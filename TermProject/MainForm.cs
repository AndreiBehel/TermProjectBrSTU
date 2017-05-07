using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class MainForm : Form
    {
        private string connstr = TermProject.Utility.GetConnectionString();
        private DataTable dt = new DataTable();
        private DataTable dtUsedSeats = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void advOrdButton_Click(object sender, EventArgs e)
        {
            AdvOrderReg aor = new AdvOrderReg();
            aor.ShowDialog();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            ReportsForm r = new ReportsForm();
            r.ShowDialog();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
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
                            cmd.Parameters.Add("@Visitors", SqlDbType.Int).Value = quantUpDown.Value;

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

        private void button1_Click(object sender, EventArgs e)
        {
            CancelAdvOrdForm caof = new CancelAdvOrdForm();
            caof.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkCorrectness()) 
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connstr))
                    {
                        using (SqlCommand cmd = new SqlCommand("addOperOrd", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = getTableId();
                            cmd.Parameters.Add("@Quant", SqlDbType.Int).Value = quantUpDown.Text;

                            cmd.Parameters.Add("@VisDate", SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
                            cmd.Parameters.Add("@VisStTime", SqlDbType.Time).Value = DateTime.Now.ToShortTimeString();
                            cmd.Parameters.Add("@VisEndTime", SqlDbType.Time).Value = DateTime.Now.Add(endDateTimePicker.Value.TimeOfDay).ToShortTimeString();

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                freeTableListView.Items.Clear();
            }
        }
        private bool checkCorrectness()
        {
            StringBuilder message = new StringBuilder("");
            bool flag = true;
            if (freeTableListView.SelectedItems.Count < 1)
            {
                message.Append("Table is not choosen. Choose a table from the list.\n");
                flag = false;
            }
            else
            {
                if (dt.Rows[freeTableListView.SelectedItems[0].Index][3] != DBNull.Value &&
                    (TimeSpan)dt.Rows[freeTableListView.SelectedItems[0].Index][3] < DateTime.Now.Add(endDateTimePicker.Value.TimeOfDay).TimeOfDay)
                {
                    message.Append("The choosen table will be not free.\nChoose another table or reduce duration of visit\n");
                    flag = false;
                }
            }
            
            if (!flag)
            {
                MessageBox.Show(message.ToString(), "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return flag;
        }
        private string getTableId()
        {
            ListViewItem selectedItem = freeTableListView.SelectedItems[0];
            return dt.Select("TableNum=" + selectedItem.SubItems[1].Text + " AND HallNum=" + selectedItem.SubItems[0].Text)[0]["TableId"].ToString();
        }

        private void complHallComboBox_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connstr))
                {
                    using (SqlCommand cmd = new SqlCommand("getUncompletedOrd", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        con.Open();
                        cmd.ExecuteNonQuery();

                        SqlDataReader sqlReader = cmd.ExecuteReader();

                        //tableComboBox.Items.Clear();

                        dtUsedSeats.Clear();
                        dtUsedSeats.Load(sqlReader);

                        foreach (DataRow dr in dtUsedSeats.Rows)
                        {
                            if (!complHallComboBox.Items.Contains(dr["HallNum"].ToString()))
                                complHallComboBox.Items.Add(dr["HallNum"].ToString());
                        }
                        sqlReader.Close();
                    }
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void complTableComboBox_DropDown(object sender, EventArgs e)
        {
            string selectedHall = complHallComboBox.GetItemText(complHallComboBox.SelectedItem);
            complTableComboBox.Items.Clear();
            foreach (DataRow dr in dtUsedSeats.Rows)
            {
                if (selectedHall == dr["HallNum"].ToString())
                    complTableComboBox.Items.Add(dr["TableNum"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(complHallComboBox.Text) && !String.IsNullOrEmpty(complTableComboBox.Text))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connstr))
                    {
                        using (SqlCommand cmd = new SqlCommand("complVisit", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@VisNum", SqlDbType.Int).Value =
                                dtUsedSeats.Select("TableNum=" + complTableComboBox.Text
                                + " AND HallNum=" + complHallComboBox.Text)[0]["VisNum"].ToString();

                            cmd.Parameters.Add("@VisEndTime", SqlDbType.Time).Value = DateTime.Now.ToShortTimeString();

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                complHallComboBox.Items.Clear();
                complTableComboBox.Items.Clear();
            }
            else
            {
                MessageBox.Show("The information for the order was not filles in.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private DataTable sendQuery()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connstr))
                {
                    using (SqlCommand cmd = new SqlCommand("complVisit", con))
                    {
                        
                    }
                }
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + "Help.chm");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be careful!\nEditing of reference data can lead to corruption of data.",
                "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefDocForm rdf = new RefDocForm();
            rdf.ShowDialog();
        }
    }
}
