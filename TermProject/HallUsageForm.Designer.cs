namespace TermProject
{
    partial class HallUsageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallUsageForm));
            this.getHallUsageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_restaurantDataSet = new TermProject.db_restaurantDataSet();
            this.getHallUsageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getHallUsageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getActivityStatForHallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getActivityStatForHallsTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getActivityStatForHallsTableAdapter();
            this.getHallUsageTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.getHallUsageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getHallUsageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHallUsageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHallUsageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getActivityStatForHallsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getHallUsageBindingSource1
            // 
            this.getHallUsageBindingSource1.DataMember = "getHallUsage";
            this.getHallUsageBindingSource1.DataSource = this.db_restaurantDataSet;
            // 
            // db_restaurantDataSet
            // 
            this.db_restaurantDataSet.DataSetName = "db_restaurantDataSet";
            this.db_restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getHallUsageBindingSource2
            // 
            this.getHallUsageBindingSource2.DataMember = "getHallUsage";
            this.getHallUsageBindingSource2.DataSource = this.db_restaurantDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getHallUsageBindingSource1;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.getHallUsageBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TermProject.HallUsageReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(684, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // getHallUsageBindingSource
            // 
            this.getHallUsageBindingSource.DataMember = "getHallUsage";
            this.getHallUsageBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // getActivityStatForHallsBindingSource
            // 
            this.getActivityStatForHallsBindingSource.DataMember = "getActivityStatForHalls";
            this.getActivityStatForHallsBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // getActivityStatForHallsTableAdapter
            // 
            this.getActivityStatForHallsTableAdapter.ClearBeforeFill = true;
            // 
            // getHallUsageTableAdapter
            // 
            this.getHallUsageTableAdapter.ClearBeforeFill = true;
            // 
            // HallUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HallUsageForm";
            this.Text = "Hall\'s Usage Report";
            this.Load += new System.EventHandler(this.HallUsageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getHallUsageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHallUsageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHallUsageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getActivityStatForHallsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getActivityStatForHallsBindingSource;
        private db_restaurantDataSet db_restaurantDataSet;
        private db_restaurantDataSetTableAdapters.getActivityStatForHallsTableAdapter getActivityStatForHallsTableAdapter;
        private System.Windows.Forms.BindingSource getHallUsageBindingSource;
        private db_restaurantDataSetTableAdapters.getHallUsageTableAdapter getHallUsageTableAdapter;
        private System.Windows.Forms.BindingSource getHallUsageBindingSource1;
        private System.Windows.Forms.BindingSource getHallUsageBindingSource2;
    }
}