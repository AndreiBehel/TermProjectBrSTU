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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void advOrdReportButton_Click(object sender, EventArgs e)
        {
            AOReportForm form = new AOReportForm();
            form.Show();
        }

        private void hallsUsageReportButton_Click(object sender, EventArgs e)
        {
            HallUsageForm form = new HallUsageForm();
            form.Show();
        }

        private void restaurantActReportButton_Click(object sender, EventArgs e)
        {
            RestActForm form = new RestActForm();
            form.Show();
        }
    }
}
