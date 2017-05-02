namespace TermProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.advOrdButton = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.complHallComboBox = new System.Windows.Forms.ComboBox();
            this.complTableComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.freeTableListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(118)))));
            this.timeLabel.Location = new System.Drawing.Point(4, -1);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(51, 25);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // advOrdButton
            // 
            this.advOrdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(102)))), ((int)(((byte)(109)))));
            this.advOrdButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.advOrdButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.advOrdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.advOrdButton.ForeColor = System.Drawing.Color.White;
            this.advOrdButton.Location = new System.Drawing.Point(12, 373);
            this.advOrdButton.Name = "advOrdButton";
            this.advOrdButton.Size = new System.Drawing.Size(130, 50);
            this.advOrdButton.TabIndex = 1;
            this.advOrdButton.Text = "Add adv order";
            this.toolTip1.SetToolTip(this.advOrdButton, "Register advance order");
            this.advOrdButton.UseVisualStyleBackColor = false;
            this.advOrdButton.Click += new System.EventHandler(this.advOrdButton_Click);
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(102)))), ((int)(((byte)(109)))));
            this.Reports.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Reports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reports.ForeColor = System.Drawing.Color.White;
            this.Reports.Location = new System.Drawing.Point(358, 374);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(130, 50);
            this.Reports.TabIndex = 2;
            this.Reports.Text = "Reports";
            this.toolTip1.SetToolTip(this.Reports, "Show the list of reports");
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(118)))));
            this.dateLabel.Location = new System.Drawing.Point(16, 23);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(25, 15);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity of visitors";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(168)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(89, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Place order";
            this.toolTip1.SetToolTip(this.button2, "Place operative order");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(102)))), ((int)(((byte)(109)))));
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(200, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel advence order";
            this.toolTip1.SetToolTip(this.button1, "Cancel previously registered advanced order");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "H:mm";
            this.endDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(226, 40);
            this.endDateTimePicker.MaxDate = new System.DateTime(2017, 4, 20, 12, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(2017, 4, 20, 0, 10, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShowUpDown = true;
            this.endDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.endDateTimePicker.TabIndex = 34;
            this.endDateTimePicker.Value = new System.DateTime(2017, 4, 20, 0, 10, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Duration of visit (hh:mm)";
            // 
            // complHallComboBox
            // 
            this.complHallComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.complHallComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.complHallComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.complHallComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complHallComboBox.FormattingEnabled = true;
            this.complHallComboBox.Location = new System.Drawing.Point(65, 54);
            this.complHallComboBox.Name = "complHallComboBox";
            this.complHallComboBox.Size = new System.Drawing.Size(81, 29);
            this.complHallComboBox.TabIndex = 35;
            this.complHallComboBox.DropDown += new System.EventHandler(this.complHallComboBox_DropDown);
            // 
            // complTableComboBox
            // 
            this.complTableComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.complTableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.complTableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.complTableComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complTableComboBox.FormattingEnabled = true;
            this.complTableComboBox.Location = new System.Drawing.Point(65, 88);
            this.complTableComboBox.Name = "complTableComboBox";
            this.complTableComboBox.Size = new System.Drawing.Size(81, 29);
            this.complTableComboBox.TabIndex = 36;
            this.complTableComboBox.DropDown += new System.EventHandler(this.complTableComboBox_DropDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(168)))), ((int)(((byte)(43)))));
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 37;
            this.button3.Text = "Complete visit";
            this.toolTip1.SetToolTip(this.button3, "Complete the order");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Order information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.complHallComboBox);
            this.panel1.Controls.Add(this.complTableComboBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(336, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 302);
            this.panel1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Table #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Hall #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(-1, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Complete order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.freeTableListView);
            this.panel2.Controls.Add(this.quantUpDown);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.endDateTimePicker);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 302);
            this.panel2.TabIndex = 41;
            // 
            // freeTableListView
            // 
            this.freeTableListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.freeTableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.freeTableListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeTableListView.FullRowSelect = true;
            this.freeTableListView.GridLines = true;
            this.freeTableListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.freeTableListView.Location = new System.Drawing.Point(8, 121);
            this.freeTableListView.MultiSelect = false;
            this.freeTableListView.Name = "freeTableListView";
            this.freeTableListView.Size = new System.Drawing.Size(245, 120);
            this.freeTableListView.TabIndex = 43;
            this.freeTableListView.UseCompatibleStateImageBehavior = false;
            this.freeTableListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "2";
            this.columnHeader1.Text = "Hall #";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "2";
            this.columnHeader2.Text = "Table #";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "2";
            this.columnHeader3.Text = "Free until";
            this.columnHeader3.Width = 80;
            // 
            // quantUpDown
            // 
            this.quantUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantUpDown.Location = new System.Drawing.Point(224, 76);
            this.quantUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.quantUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantUpDown.Name = "quantUpDown";
            this.quantUpDown.Size = new System.Drawing.Size(78, 29);
            this.quantUpDown.TabIndex = 43;
            this.quantUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantUpDown.ValueChanged += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.about);
            this.panel3.Controls.Add(this.timeLabel);
            this.panel3.Controls.Add(this.dateLabel);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 41);
            this.panel3.TabIndex = 42;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::TermProject.Properties.Resources.notepad_icon;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(389, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button6, "Edit reference data");
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TermProject.Properties.Resources.help;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(432, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.BackgroundImage = global::TermProject.Properties.Resources.inf;
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.about.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(463, 6);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(25, 25);
            this.about.TabIndex = 5;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::TermProject.Properties.Resources.refresh;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(272, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 46;
            this.toolTip1.SetToolTip(this.button4, "Update the list of free tables");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(519, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.advOrdButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Administrator\'s Workplace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button advOrdButton;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox complHallComboBox;
        private System.Windows.Forms.ComboBox complTableComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView freeTableListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown quantUpDown;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

