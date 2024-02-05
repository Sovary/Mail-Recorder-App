namespace Mail_Recorder_App
{
    partial class ManageOperatorForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.lookupControl1 = new DMC.Operator.Factory.LookupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDmcConnected = new DMC.Operator.Factory.DateTimePickerDmc();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDmcTransfer = new DMC.Operator.Factory.DateTimePickerDmc();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(200, 310);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 28);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonRemove.Location = new System.Drawing.Point(311, 310);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(72, 28);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonClear.Location = new System.Drawing.Point(391, 310);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(58, 28);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-1, -2);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(458, 51);
            this.gradientControl1.TabIndex = 22;
            this.gradientControl1.Title = "Manage Operator";
            // 
            // lookupControl1
            // 
            this.lookupControl1.Location = new System.Drawing.Point(145, 65);
            this.lookupControl1.Name = "lookupControl1";
            this.lookupControl1.Size = new System.Drawing.Size(201, 27);
            this.lookupControl1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(75, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Operator:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(145, 98);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(201, 24);
            this.comboBoxType.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(99, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Type:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(-4, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(522, 2);
            this.label5.TabIndex = 28;
            // 
            // dateTimePickerDmcConnected
            // 
            this.dateTimePickerDmcConnected.CustomFormat = " ";
            this.dateTimePickerDmcConnected.CustomFormatX = "dd-MMM-yyyy";
            this.dateTimePickerDmcConnected.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerDmcConnected.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDmcConnected.IsNullDate = true;
            this.dateTimePickerDmcConnected.Location = new System.Drawing.Point(145, 128);
            this.dateTimePickerDmcConnected.Name = "dateTimePickerDmcConnected";
            this.dateTimePickerDmcConnected.Size = new System.Drawing.Size(201, 24);
            this.dateTimePickerDmcConnected.TabIndex = 55;
            this.dateTimePickerDmcConnected.Value = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(32, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Connected date:";
            // 
            // dateTimePickerDmcTransfer
            // 
            this.dateTimePickerDmcTransfer.CustomFormat = " ";
            this.dateTimePickerDmcTransfer.CustomFormatX = "dd-MMM-yyyy";
            this.dateTimePickerDmcTransfer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerDmcTransfer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDmcTransfer.IsNullDate = true;
            this.dateTimePickerDmcTransfer.Location = new System.Drawing.Point(145, 158);
            this.dateTimePickerDmcTransfer.Name = "dateTimePickerDmcTransfer";
            this.dateTimePickerDmcTransfer.Size = new System.Drawing.Size(201, 24);
            this.dateTimePickerDmcTransfer.TabIndex = 57;
            this.dateTimePickerDmcTransfer.Value = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(3, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Transfered data date:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxDescription.Location = new System.Drawing.Point(145, 188);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(201, 100);
            this.textBoxDescription.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(62, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Description:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(352, 67);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(66, 24);
            this.comboBoxStatus.TabIndex = 61;
            // 
            // ManageOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 348);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDmcTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDmcConnected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.lookupControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradientControl1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManageOperatorForm";
            this.Text = "Manage Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private DMC.Operator.Factory.GradientControl gradientControl1;
        private DMC.Operator.Factory.LookupControl lookupControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DMC.Operator.Factory.DateTimePickerDmc dateTimePickerDmcConnected;
        private System.Windows.Forms.Label label8;
        private DMC.Operator.Factory.DateTimePickerDmc dateTimePickerDmcTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}