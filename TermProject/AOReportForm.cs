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
    public partial class AOReportForm : Form
    {
        public AOReportForm()
        {
            InitializeComponent();
        }

        private void AOReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getAdvOrdReport' table. You can move, or remove it, as needed.
            this.getAdvOrdReportTableAdapter.Fill(this.db_restaurantDataSet.getAdvOrdReport);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getAdvOrdReport' table. You can move, or remove it, as needed.
            this.getAdvOrdReportTableAdapter.Fill(this.db_restaurantDataSet.getAdvOrdReport);
            // TODO: This line of code loads data into the 'db_restaurantDataSet.getAdvOrdHallsReport' table. You can move, or remove it, as needed.
            this.getAdvOrdHallsReportTableAdapter.Fill(this.db_restaurantDataSet.getAdvOrdHallsReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
