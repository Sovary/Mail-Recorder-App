namespace Mail_Recorder_App
{
    partial class SettingForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerMonth = new DMC.Operator.Factory.DateTimePickerDmc();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBoxDayAlert = new DMC.Operator.Factory.NumberTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 2);
            this.label5.TabIndex = 28;
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-1, -1);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(309, 51);
            this.gradientControl1.TabIndex = 27;
            this.gradientControl1.Title = "Setting";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(175, 214);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 29);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "OK";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.CustomFormat = " ";
            this.dateTimePickerMonth.CustomFormatX = "MMM-yyyy";
            this.dateTimePickerMonth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonth.IsNullDate = true;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(78, 71);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(201, 24);
            this.dateTimePickerMonth.TabIndex = 33;
            this.dateTimePickerMonth.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(24, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Day alert:";
            // 
            // numberTextBoxDayAlert
            // 
            this.numberTextBoxDayAlert.DecimalValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberTextBoxDayAlert.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numberTextBoxDayAlert.IsAllowNumber = true;
            this.numberTextBoxDayAlert.Location = new System.Drawing.Point(78, 113);
            this.numberTextBoxDayAlert.Name = "numberTextBoxDayAlert";
            this.numberTextBoxDayAlert.Size = new System.Drawing.Size(44, 24);
            this.numberTextBoxDayAlert.TabIndex = 46;
            this.numberTextBoxDayAlert.Text = "4";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 246);
            this.Controls.Add(this.numberTextBoxDayAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gradientControl1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private DMC.Operator.Factory.GradientControl gradientControl1;
        private System.Windows.Forms.Button buttonAdd;
        private DMC.Operator.Factory.DateTimePickerDmc dateTimePickerMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DMC.Operator.Factory.NumberTextBox numberTextBoxDayAlert;
    }
}