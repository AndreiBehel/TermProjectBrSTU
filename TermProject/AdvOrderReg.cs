using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public struct ClInfo
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public string TelNumber;
        public string id;
    }
    public partial class AdvOrderReg : Form
    {
        private AddClientForm acf = null;
        private string connstr = TermProject.Utility.GetConnectionString();
        private DataTable dt = new DataTable();
        private ClInfo clientInfo = new ClInfo();
        public AdvOrderReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkCorrectness())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connstr))
                    {
                        using (SqlCommand cmd = new SqlCommand("addAdvOrd", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            //check if we choosed existing record about client
                            if (clientInfo.id == null)
                            {
                                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = nameTextBox.Text;
                                cmd.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = surnameTextBox.Text;
                                cmd.Parameters.Add("@Patr", SqlDbType.NVarChar).Value = patrTextBox.Text;
                                cmd.Parameters.Add("@TelNum", SqlDbType.VarChar).Value = telTextBox.Text;
                            }
                            else
                            {
                                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = clientInfo.id;
                            }
                            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = getTableId();
                            cmd.Parameters.Add("@Quant", SqlDbType.Int).Value = quantUpDown.Text;

                            cmd.Parameters.Add("@OrdDate", SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
                            cmd.Parameters.Add("@VisDate", SqlDbType.Date).Value = visDateTimePicker.Value.ToShortDateString();
                            cmd.Parameters.Add("@VisStTime", SqlDbType.Time).Value = stDateTimePicker.Value.ToShortTimeString();
                            cmd.Parameters.Add("@VisEndTime", SqlDbType.Time).Value = stDateTimePicker.Value.Add(endDateTimePicker.Value.TimeOfDay).ToShortTimeString();

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearElenents();
            }
        }
        private string getTableId()
        {
            ListViewItem selectedItem = freeTableListView.SelectedItems[0];
            return dt.Select("TableNum=" + selectedItem.SubItems[1].Text + " AND HallNum=" + selectedItem.SubItems[0].Text)[0]["TableId"].ToString();   
        }
        private bool checkCorrectness()
        {
            bool flag = true;
            string message = "";
            if (freeTableListView.SelectedItems.Count < 1)
            {
                message += "Table is not choosen. Choose a table from the list.\n";
                flag = false;
            }
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        message += "Client information is not inputed.\n";
                        flag = false;
                        break;
                    }
                }
            }
            if(!flag)
            {
                MessageBox.Show(message, "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return flag;
        }
        private void clearElenents()
        {
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            patrTextBox.Text = "";
            telTextBox.Text = "";
            freeTableListView.Items.Clear();
            quantUpDown.Value = 1;
        }

        private void updateTableListButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(quantUpDown.Text) && quantUpDown.Text != "0")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connstr))
                    {
                        using (SqlCommand cmd = new SqlCommand("getListOfFreeTablesAndTime", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@Visitors", SqlDbType.Int).Value = quantUpDown.Text;
                            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = visDateTimePicker.Value.ToShortDateString();
                            cmd.Parameters.Add("@StartTime", SqlDbType.Time).Value = stDateTimePicker.Value.ToShortTimeString();

                            con.Open();
                            cmd.ExecuteNonQuery();

                            SqlDataReader sqlReader = cmd.ExecuteReader();

                            dt.Clear();
                            dt.Load(sqlReader);

                            freeTableListView.Items.Clear();
                            foreach (DataRow dr in dt.Rows)
                            {
                                ListViewItem listitem = new ListViewItem(dr["HallNum"].ToString());

                                listitem.SubItems.Add(dr["TableNum"].ToString());
                                listitem.SubItems.Add(dr["Time"].ToString());
                                freeTableListView.Items.Add(listitem);
                            }
                            freeTableListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                            sqlReader.Close();
                        }
                    }

                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please, fill in the number of visitor", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            acf = new AddClientForm(clientInfo);
            acf.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            acf.ShowDialog();
        }
        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            clientInfo = acf.Info;
            nameTextBox.Text = clientInfo.Name;
            surnameTextBox.Text = clientInfo.Surname;
            patrTextBox.Text = clientInfo.Patronymic;
            telTextBox.Text = clientInfo.TelNumber;
            nameTextBox.Enabled = false;
            surnameTextBox.Enabled = false;
            patrTextBox.Enabled = false;
            telTextBox.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
            surnameTextBox.Enabled = true;
            patrTextBox.Enabled = true;
            telTextBox.Enabled = true;
            clearElenents();
            clientInfo = new ClInfo();
        }
    }
}
