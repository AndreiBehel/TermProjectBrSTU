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
    public partial class HallUsageForm : Form
    {
        public HallUsageForm()
        {
            InitializeComponent();
        }

        private void HallUsageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getHallUsage' table. You can move, or remove it, as needed.
            this.getHallUsageTableAdapter.Fill(this.db_restaurantDataSet.getHallUsage);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getActivityStatForHalls' table. You can move, or remove it, as needed.
            this.getActivityStatForHallsTableAdapter.Fill(this.db_restaurantDataSet.getActivityStatForHalls);

            this.reportViewer1.RefreshReport();
        }
    }
}
