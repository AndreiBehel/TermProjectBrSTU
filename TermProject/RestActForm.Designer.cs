namespace TermProject
{
    partial class RestActForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestActForm));
            this.getActivityStatForHallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_restaurantDataSet = new TermProject.db_restaurantDataSet();
            this.getActivityStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getQuantOfHallsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getQuantOfHallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getActivityStatForHallsTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getActivityStatForHallsTableAdapter();
            this.getActivityStatTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getActivityStatTableAdapter();
            this.getAdvOrdHallsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAdvOrdHallsReportTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getAdvOrdHallsReportTableAdapter();
            this.getAdvOrdReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getAdvOrdReportTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getAdvOrdReportTableAdapter();
            this.getQuantOfHallsTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getQuantOfHallsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getActivityStatForHallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getActivityStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQuantOfHallsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQuantOfHallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdHallsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getActivityStatForHallsBindingSource
            // 
            this.getActivityStatForHallsBindingSource.DataMember = "getActivityStatForHalls";
            this.getActivityStatForHallsBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // db_restaurantDataSet
            // 
            this.db_restaurantDataSet.DataSetName = "db_restaurantDataSet";
            this.db_restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getActivityStatBindingSource
            // 
            this.getActivityStatBindingSource.DataMember = "getActivityStat";
            this.getActivityStatBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // getQuantOfHallsBindingSource1
            // 
            this.getQuantOfHallsBindingSource1.DataMember = "getQuantOfHalls";
            this.getQuantOfHallsBindingSource1.DataSource = this.db_restaurantDataSet;
            // 
            // getQuantOfHallsBindingSource
            // 
            this.getQuantOfHallsBindingSource.DataMember = "getQuantOfHalls";
            this.getQuantOfHallsBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.getActivityStatForHallsBindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.getActivityStatBindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.getQuantOfHallsBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TermProject.RestActReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(684, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // getActivityStatForHallsTableAdapter
            // 
            this.getActivityStatForHallsTableAdapter.ClearBeforeFill = true;
            // 
            // getActivityStatTableAdapter
            // 
            this.getActivityStatTableAdapter.ClearBeforeFill = true;
            // 
            // getAdvOrdHallsReportBindingSource
            // 
            this.getAdvOrdHallsReportBindingSource.DataMember = "getAdvOrdHallsReport";
            this.getAdvOrdHallsReportBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // getAdvOrdHallsReportTableAdapter
            // 
            this.getAdvOrdHallsReportTableAdapter.ClearBeforeFill = true;
            // 
            // getAdvOrdReportBindingSource
            // 
            this.getAdvOrdReportBindingSource.DataMember = "getAdvOrdReport";
            this.getAdvOrdReportBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // getAdvOrdReportTableAdapter
            // 
            this.getAdvOrdReportTableAdapter.ClearBeforeFill = true;
            // 
            // getQuantOfHallsTableAdapter
            // 
            this.getQuantOfHallsTableAdapter.ClearBeforeFill = true;
            // 
            // RestActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestActForm";
            this.Text = "Restaurant Activity Report";
            this.Load += new System.EventHandler(this.RestActForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getActivityStatForHallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getActivityStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQuantOfHallsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getQuantOfHallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdHallsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_restaurantDataSet db_restaurantDataSet;
        private System.Windows.Forms.BindingSource getActivityStatForHallsBindingSource;
        private db_restaurantDataSetTableAdapters.getActivityStatForHallsTableAdapter getActivityStatForHallsTableAdapter;
        private System.Windows.Forms.BindingSource getActivityStatBindingSource;
        private db_restaurantDataSetTableAdapters.getActivityStatTableAdapter getActivityStatTableAdapter;
        private System.Windows.Forms.BindingSource getQuantOfHallsBindingSource;
        private System.Windows.Forms.BindingSource getAdvOrdHallsReportBindingSource;
        private System.Windows.Forms.BindingSource getAdvOrdReportBindingSource;
        private db_restaurantDataSetTableAdapters.getAdvOrdHallsReportTableAdapter getAdvOrdHallsReportTableAdapter;
        private db_restaurantDataSetTableAdapters.getAdvOrdReportTableAdapter getAdvOrdReportTableAdapter;
        private db_restaurantDataSetTableAdapters.getQuantOfHallsTableAdapter getQuantOfHallsTableAdapter;
        private System.Windows.Forms.BindingSource getQuantOfHallsBindingSource1;
    }
}