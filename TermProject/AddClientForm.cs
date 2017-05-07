using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class AddClientForm : Form
    {
        private ClInfo clientInfo;
        public ClInfo Info
        {
            get { return clientInfo; }
        }
        public AddClientForm(ClInfo c)
        {
            InitializeComponent();
            clientInfo = c;
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_restaurantDataSet);

        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_restaurantDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.db_restaurantDataSet.Client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientDataGridView.ClearSelection();
            for (int i = 0; i < clientDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < clientDataGridView.RowCount-1; j++)
                {
                    clientDataGridView[i, j].Style.BackColor = Color.White;
                    clientDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < clientDataGridView.ColumnCount - 1; i++)
                for (int j = 0; j < clientDataGridView.RowCount - 1; j++)
                    if (3 > DamerauLevenshteinDistance(clientDataGridView[i, j].Value.ToString().ToLower(), findTextBox.Text.ToLower()))
                    {
                        //clientDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        //clientDataGridView[i, j].Style.ForeColor = Color.Blue;
                        clientDataGridView.Rows[j].Selected = true;
                    }
        }
        private static int DamerauLevenshteinDistance(string string1, string string2)
        {
            if (String.IsNullOrEmpty(string1))
            {
                if (!String.IsNullOrEmpty(string2))
                    return string2.Length;

                return 0;
            }

            if (String.IsNullOrEmpty(string2))
            {
                if (!String.IsNullOrEmpty(string1))
                    return string1.Length;

                return 0;
            }

            int length1 = string1.Length;
            int length2 = string2.Length;

            int[,] d = new int[length1 + 1, length2 + 1];

            int cost, del, ins, sub;

            for (int i = 0; i <= d.GetUpperBound(0); i++)
                d[i, 0] = i;

            for (int i = 0; i <= d.GetUpperBound(1); i++)
                d[0, i] = i;

            for (int i = 1; i <= d.GetUpperBound(0); i++)
            {
                for (int j = 1; j <= d.GetUpperBound(1); j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                        cost = 0;
                    else
                        cost = 1;

                    del = d[i - 1, j] + 1;
                    ins = d[i, j - 1] + 1;
                    sub = d[i - 1, j - 1] + cost;

                    d[i, j] = Math.Min(del, Math.Min(ins, sub));

                    if (i > 1 && j > 1 && string1[i - 1] == string2[j - 2] && string1[i - 2] == string2[j - 1])
                        d[i, j] = Math.Min(d[i, j], d[i - 2, j - 2] + cost);
                }
            }

            return d[d.GetUpperBound(0), d.GetUpperBound(1)];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Choose only one client", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (clientDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("The client is not choosen. Please, choose the client from the list", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {  
                clientInfo.id = clientDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                clientInfo.Name = clientDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                clientInfo.Surname = clientDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                clientInfo.Patronymic = clientDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                clientInfo.TelNumber = clientDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                this.DialogResult = DialogResult.Cancel; 
            }
        }
    }
}
