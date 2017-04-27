namespace TermProject
{
    partial class CancelAdvOrdForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label telNumLabel;
            this.db_restaurantDataSet = new TermProject.db_restaurantDataSet();
            this.advOrdViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advOrdViewTableAdapter = new TermProject.db_restaurantDataSetTableAdapters.AdvOrdViewTableAdapter();
            this.tableAdapterManager = new TermProject.db_restaurantDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.telNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            telNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advOrdViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(27, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(27, 126);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(78, 20);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Surname:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            patronymicLabel.Location = new System.Drawing.Point(27, 165);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(91, 20);
            patronymicLabel.TabIndex = 5;
            patronymicLabel.Text = "Patronymic:";
            // 
            // telNumLabel
            // 
            telNumLabel.AutoSize = true;
            telNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            telNumLabel.Location = new System.Drawing.Point(27, 206);
            telNumLabel.Name = "telNumLabel";
            telNumLabel.Size = new System.Drawing.Size(71, 20);
            telNumLabel.TabIndex = 7;
            telNumLabel.Text = "Tel Num:";
            // 
            // db_restaurantDataSet
            // 
            this.db_restaurantDataSet.DataSetName = "db_restaurantDataSet";
            this.db_restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advOrdViewBindingSource
            // 
            this.advOrdViewBindingSource.DataMember = "AdvOrdView";
            this.advOrdViewBindingSource.DataSource = this.db_restaurantDataSet;
            // 
            // advOrdViewTableAdapter
            // 
            this.advOrdViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdvOrderTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.HallTableAdapter = null;
            this.tableAdapterManager.OperOrderTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TermProject.db_restaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advOrdViewBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(131, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advOrdViewBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(131, 124);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(144, 26);
            this.surnameTextBox.TabIndex = 4;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advOrdViewBindingSource, "Patronymic", true));
            this.patronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextBox.Location = new System.Drawing.Point(131, 163);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(144, 26);
            this.patronymicTextBox.TabIndex = 6;
            // 
            // telNumTextBox
            // 
            this.telNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advOrdViewBindingSource, "TelNum", true));
            this.telNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telNumTextBox.Location = new System.Drawing.Point(131, 204);
            this.telNumTextBox.Name = "telNumTextBox";
            this.telNumTextBox.Size = new System.Drawing.Size(144, 26);
            this.telNumTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(100, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(85, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "◄";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(172, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "►";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(26, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Advance orders information";
            // 
            // CancelAdvOrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(telNumLabel);
            this.Controls.Add(this.telNumTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CancelAdvOrdForm";
            this.Text = "Cancel advance order";
            this.Load += new System.EventHandler(this.CancelAdvOrdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advOrdViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_restaurantDataSet db_restaurantDataSet;
        private System.Windows.Forms.BindingSource advOrdViewBindingSource;
        private db_restaurantDataSetTableAdapters.AdvOrdViewTableAdapter advOrdViewTableAdapter;
        private db_restaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox telNumTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;









    }
}