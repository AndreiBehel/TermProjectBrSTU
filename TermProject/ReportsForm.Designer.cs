namespace TermProject
{
    partial class ReportsForm
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
            this.advOrdReportButton = new System.Windows.Forms.Button();
            this.hallsUsageReportButton = new System.Windows.Forms.Button();
            this.restaurantActReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // advOrdReportButton
            // 
            this.advOrdReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.advOrdReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advOrdReportButton.Location = new System.Drawing.Point(65, 12);
            this.advOrdReportButton.Name = "advOrdReportButton";
            this.advOrdReportButton.Size = new System.Drawing.Size(153, 39);
            this.advOrdReportButton.TabIndex = 0;
            this.advOrdReportButton.Text = "Advance orders";
            this.advOrdReportButton.UseVisualStyleBackColor = true;
            this.advOrdReportButton.Click += new System.EventHandler(this.advOrdReportButton_Click);
            // 
            // hallsUsageReportButton
            // 
            this.hallsUsageReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hallsUsageReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hallsUsageReportButton.Location = new System.Drawing.Point(65, 57);
            this.hallsUsageReportButton.Name = "hallsUsageReportButton";
            this.hallsUsageReportButton.Size = new System.Drawing.Size(153, 39);
            this.hallsUsageReportButton.TabIndex = 1;
            this.hallsUsageReportButton.Text = "Halls usage";
            this.hallsUsageReportButton.UseVisualStyleBackColor = true;
            this.hallsUsageReportButton.Click += new System.EventHandler(this.hallsUsageReportButton_Click);
            // 
            // restaurantActReportButton
            // 
            this.restaurantActReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restaurantActReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restaurantActReportButton.Location = new System.Drawing.Point(65, 102);
            this.restaurantActReportButton.Name = "restaurantActReportButton";
            this.restaurantActReportButton.Size = new System.Drawing.Size(153, 39);
            this.restaurantActReportButton.TabIndex = 2;
            this.restaurantActReportButton.Text = "Restaurant activity";
            this.restaurantActReportButton.UseVisualStyleBackColor = true;
            this.restaurantActReportButton.Click += new System.EventHandler(this.restaurantActReportButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.restaurantActReportButton);
            this.Controls.Add(this.hallsUsageReportButton);
            this.Controls.Add(this.advOrdReportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button advOrdReportButton;
        private System.Windows.Forms.Button hallsUsageReportButton;
        private System.Windows.Forms.Button restaurantActReportButton;
    }
}