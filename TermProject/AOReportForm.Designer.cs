namespace TermProject
{
    partial class AOReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AOReportForm));
            this.getAdvOrdHallsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_restaurantDataSet = new TermProject.db_restaurantDataSet();
            this.getAdvOrdReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getAdvOrdHallsReportTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getAdvOrdHallsReportTableAdapter();
            this.getAdvOrdReportTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getAdvOrdReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdHallsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getAdvOrdHallsReportBindingSource
            // 
            this.getAdvOrdHallsReportBindingSource.DataMember = "getAdvOrdHallsReport";
            this.getAdvOrdHallsReportBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // db_restaurantDataSet
            // 
            this.db_restaurantDataSet.DataSetName = "db_restaurantDataSet";
            this.db_restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getAdvOrdReportBindingSource
            // 
            this.getAdvOrdReportBindingSource.DataMember = "getAdvOrdReport";
            this.getAdvOrdReportBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getAdvOrdHallsReportBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.getAdvOrdReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TermProject.AOReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(684, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // getAdvOrdHallsReportTableAdapter
            // 
            this.getAdvOrdHallsReportTableAdapter.ClearBeforeFill = true;
            // 
            // getAdvOrdReportTableAdapter
            // 
            this.getAdvOrdReportTableAdapter.ClearBeforeFill = true;
            // 
            // AOReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AOReportForm";
            this.Text = "Advance Order Report";
            this.Load += new System.EventHandler(this.AOReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdHallsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAdvOrdReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getAdvOrdHallsReportBindingSource;
        private db_restaurantDataSet db_restaurantDataSet;
        private db_restaurantDataSetTableAdapters.getAdvOrdHallsReportTableAdapter getAdvOrdHallsReportTableAdapter;
        private System.Windows.Forms.BindingSource getAdvOrdReportBindingSource;
        private db_restaurantDataSetTableAdapters.getAdvOrdReportTableAdapter getAdvOrdReportTableAdapter;
    }
}