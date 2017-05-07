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
    public partial class RefDocForm : Form
    {
        public RefDocForm()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_restaurantDataSet);

        }

        private void RefDocForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_restaurantDataSet.Hall' table. You can move, or remove it, as needed.
            this.hallTableAdapter.Fill(this.db_restaurantDataSet.Hall);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.db_restaurantDataSet.Table);

        }
    }
}
