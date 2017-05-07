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
    public partial class CancelAdvOrdForm : Form
    {
        string connstr = TermProject.Utility.GetConnectionString();
        public CancelAdvOrdForm()
        {
            InitializeComponent();
        }

        private void CancelAdvOrdForm_Load(object sender, EventArgs e)
        {
            this.advOrdViewTableAdapter.Fill(this.db_restaurantDataSet.AdvOrdView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (advOrdViewDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Choose only one client", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (advOrdViewDataGridView.SelectedRows.Count == 0)
             {
                 MessageBox.Show("The client is not choosen. Please, choose the client from the list", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
             else
             {
                 string id = advOrdViewDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                 try
                 {
                     using (SqlConnection con = new SqlConnection(connstr))
                     {
                         using (SqlCommand cmd = new SqlCommand("cancelAdvOrd", con))
                         {
                             cmd.CommandType = CommandType.StoredProcedure;
                             cmd.Parameters.Add("@OrdNum", SqlDbType.Int).Value = id;

                             con.Open();
                             cmd.ExecuteNonQuery();
                         }
                     }
                 }
                 catch (SqlException er)
                 {
                     MessageBox.Show(er.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 advOrdViewDataGridView.Rows.RemoveAt(advOrdViewDataGridView.SelectedRows[0].Index);
             }
        }


        private void clearElenents()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    textBox.Text = "";
                }
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.advOrdViewTableAdapter.Fill(this.db_restaurantDataSet.AdvOrdView);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
