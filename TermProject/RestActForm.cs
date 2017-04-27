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
    public partial class RestActForm : Form
    {
        public RestActForm()
        {
            InitializeComponent();
        }

        private void RestActForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getQuantOfHalls' table. You can move, or remove it, as needed.
            this.getQuantOfHallsTableAdapter.Fill(this.db_restaurantDataSet.getQuantOfHalls);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getAdvOrdHallsReport' table. You can move, or remove it, as needed.
            this.getAdvOrdHallsReportTableAdapter.Fill(this.db_restaurantDataSet.getAdvOrdHallsReport);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getAdvOrdReport' table. You can move, or remove it, as needed.
            this.getAdvOrdReportTableAdapter.Fill(this.db_restaurantDataSet.getAdvOrdReport);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getActivityStat' table. You can move, or remove it, as needed.
            this.getActivityStatTableAdapter.Fill(this.db_restaurantDataSet.getActivityStat);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getActivityStatForHalls' table. You can move, or remove it, as needed.
            this.getActivityStatForHallsTableAdapter.Fill(this.db_restaurantDataSet.getActivityStatForHalls);

            this.reportViewer1.RefreshReport();
        }
    }
}
