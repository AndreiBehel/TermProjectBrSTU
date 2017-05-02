namespace TermProject
{
    partial class AdvOrderReg
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
            this.addAdvOrdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patrTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.visDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.freeTableListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.db_restaurantDataSet = new TermProject.db_restaurantDataSet();
            this.clientTableAdapter1 = new TermProject.db_restaurantDataSetTableAdapters.ClientTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new TermProject.db_restaurantDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.updateTableListButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addAdvOrdButton
            // 
            this.addAdvOrdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(168)))), ((int)(((byte)(43)))));
            this.addAdvOrdButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addAdvOrdButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAdvOrdButton.ForeColor = System.Drawing.Color.White;
            this.addAdvOrdButton.Location = new System.Drawing.Point(97, 326);
            this.addAdvOrdButton.Name = "addAdvOrdButton";
            this.addAdvOrdButton.Size = new System.Drawing.Size(100, 40);
            this.addAdvOrdButton.TabIndex = 40;
            this.addAdvOrdButton.Text = "Register";
            this.toolTip1.SetToolTip(this.addAdvOrdButton, "Register advance order");
            this.addAdvOrdButton.UseVisualStyleBackColor = false;
            this.addAdvOrdButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patronymic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tel. number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of visit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Start time of visit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Duration of visit (hh:mm)";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(114, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(152, 29);
            this.nameTextBox.TabIndex = 10;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(114, 74);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(152, 29);
            this.surnameTextBox.TabIndex = 11;
            // 
            // patrTextBox
            // 
            this.patrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patrTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrTextBox.Location = new System.Drawing.Point(114, 106);
            this.patrTextBox.Name = "patrTextBox";
            this.patrTextBox.Size = new System.Drawing.Size(152, 29);
            this.patrTextBox.TabIndex = 12;
            // 
            // telTextBox
            // 
            this.telTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telTextBox.Location = new System.Drawing.Point(114, 138);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(152, 29);
            this.telTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(118)))));
            this.label10.Location = new System.Drawing.Point(-1, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "Client";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(118)))));
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Order";
            // 
            // visDateTimePicker
            // 
            this.visDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visDateTimePicker.Location = new System.Drawing.Point(153, 42);
            this.visDateTimePicker.Name = "visDateTimePicker";
            this.visDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.visDateTimePicker.TabIndex = 21;
            this.visDateTimePicker.Value = new System.DateTime(2017, 4, 27, 0, 0, 0, 0);
            // 
            // stDateTimePicker
            // 
            this.stDateTimePicker.CustomFormat = "H:mm";
            this.stDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stDateTimePicker.Location = new System.Drawing.Point(235, 79);
            this.stDateTimePicker.Name = "stDateTimePicker";
            this.stDateTimePicker.ShowUpDown = true;
            this.stDateTimePicker.Size = new System.Drawing.Size(118, 29);
            this.stDateTimePicker.TabIndex = 29;
            this.stDateTimePicker.Value = new System.DateTime(2017, 4, 23, 15, 0, 0, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "H:mm";
            this.endDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(235, 117);
            this.endDateTimePicker.MaxDate = new System.DateTime(2017, 4, 21, 12, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(2017, 4, 21, 0, 10, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShowUpDown = true;
            this.endDateTimePicker.Size = new System.Drawing.Size(118, 29);
            this.endDateTimePicker.TabIndex = 30;
            this.endDateTimePicker.Value = new System.DateTime(2017, 4, 21, 1, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.patrTextBox);
            this.panel1.Controls.Add(this.telTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 228);
            this.panel1.TabIndex = 31;
            this.toolTip1.SetToolTip(this.panel1, "Information about client");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.updateTableListButton);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.freeTableListView);
            this.panel2.Controls.Add(this.quantUpDown);
            this.panel2.Controls.Add(this.endDateTimePicker);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.stDateTimePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.visDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(299, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 364);
            this.panel2.TabIndex = 32;
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
            this.freeTableListView.Location = new System.Drawing.Point(8, 216);
            this.freeTableListView.MultiSelect = false;
            this.freeTableListView.Name = "freeTableListView";
            this.freeTableListView.Size = new System.Drawing.Size(245, 120);
            this.freeTableListView.TabIndex = 48;
            this.toolTip1.SetToolTip(this.freeTableListView, "List of free tables");
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
            this.quantUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantUpDown.Location = new System.Drawing.Point(275, 155);
            this.quantUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.quantUpDown.Name = "quantUpDown";
            this.quantUpDown.Size = new System.Drawing.Size(78, 29);
            this.quantUpDown.TabIndex = 49;
            this.quantUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantUpDown.ValueChanged += new System.EventHandler(this.updateTableListButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Quantity of visitors";
            // 
            // db_restaurantDataSet
            // 
            this.db_restaurantDataSet.DataSetName = "db_restaurantDataSet";
            this.db_restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdvOrderTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter1;
            this.tableAdapterManager.HallTableAdapter = null;
            this.tableAdapterManager.OperOrderTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TermProject.db_restaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitTableAdapter = null;
            // 
            // updateTableListButton
            // 
            this.updateTableListButton.BackgroundImage = global::TermProject.Properties.Resources.refresh;
            this.updateTableListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateTableListButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.updateTableListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTableListButton.Location = new System.Drawing.Point(259, 216);
            this.updateTableListButton.Name = "updateTableListButton";
            this.updateTableListButton.Size = new System.Drawing.Size(30, 30);
            this.updateTableListButton.TabIndex = 50;
            this.toolTip1.SetToolTip(this.updateTableListButton, "Refresh list of free tables");
            this.updateTableListButton.UseVisualStyleBackColor = true;
            this.updateTableListButton.Click += new System.EventHandler(this.updateTableListButton_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TermProject.Properties.Resources.flat_1298035_640;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(236, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button2, "Clear and reset all fields");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TermProject.Properties.Resources.Plus_Sign_256x256;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(183, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button1, "Choose client from the  list");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdvOrderReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addAdvOrdButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdvOrderReg";
            this.Text = "Advance Order Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAdvOrdButton;
        private db_restaurantDataSet db_restaurantDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patrTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker visDateTimePicker;
        private db_restaurantDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.DateTimePicker stDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private db_restaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updateTableListButton;
        private System.Windows.Forms.ListView freeTableListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown quantUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}