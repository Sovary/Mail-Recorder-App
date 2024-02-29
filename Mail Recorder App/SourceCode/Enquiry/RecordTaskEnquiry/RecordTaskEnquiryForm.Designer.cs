namespace Mail_Recorder_App
{
    partial class RecordTaskEnquiryForm
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonDone = new System.Windows.Forms.RadioButton();
            this.radioButtonUndone = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGroupby = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFrom = new DMC.Operator.Factory.DateTimePickerDmc();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new DMC.Operator.Factory.DateTimePickerDmc();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonRun.Location = new System.Drawing.Point(213, 202);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(89, 28);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-5, -1);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(320, 51);
            this.gradientControl1.TabIndex = 22;
            this.gradientControl1.Title = "Record Task Enquiry";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(-28, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 2);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(20, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Operator:";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(90, 66);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(201, 24);
            this.comboBoxOperator.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(32, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Status:";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioButtonAll.Location = new System.Drawing.Point(90, 156);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(38, 21);
            this.radioButtonAll.TabIndex = 31;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonDone
            // 
            this.radioButtonDone.AutoSize = true;
            this.radioButtonDone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioButtonDone.Location = new System.Drawing.Point(134, 156);
            this.radioButtonDone.Name = "radioButtonDone";
            this.radioButtonDone.Size = new System.Drawing.Size(59, 21);
            this.radioButtonDone.TabIndex = 32;
            this.radioButtonDone.Text = "Done";
            this.radioButtonDone.UseVisualStyleBackColor = true;
            // 
            // radioButtonUndone
            // 
            this.radioButtonUndone.AutoSize = true;
            this.radioButtonUndone.Checked = true;
            this.radioButtonUndone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioButtonUndone.Location = new System.Drawing.Point(199, 156);
            this.radioButtonUndone.Name = "radioButtonUndone";
            this.radioButtonUndone.Size = new System.Drawing.Size(74, 21);
            this.radioButtonUndone.TabIndex = 33;
            this.radioButtonUndone.TabStop = true;
            this.radioButtonUndone.Text = "Undone";
            this.radioButtonUndone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Group by:";
            // 
            // comboBoxGroupby
            // 
            this.comboBoxGroupby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupby.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxGroupby.FormattingEnabled = true;
            this.comboBoxGroupby.Location = new System.Drawing.Point(90, 96);
            this.comboBoxGroupby.Name = "comboBoxGroupby";
            this.comboBoxGroupby.Size = new System.Drawing.Size(201, 24);
            this.comboBoxGroupby.TabIndex = 34;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = " ";
            this.dateTimePickerFrom.CustomFormatX = "dd-MMM-yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.IsNullDate = true;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(90, 126);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(94, 24);
            this.dateTimePickerFrom.TabIndex = 37;
            this.dateTimePickerFrom.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(3, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Date Range:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = " ";
            this.dateTimePickerTo.CustomFormatX = "dd-MMM-yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.IsNullDate = true;
            this.dateTimePickerTo.Location = new System.Drawing.Point(197, 126);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(94, 24);
            this.dateTimePickerTo.TabIndex = 38;
            this.dateTimePickerTo.Value = null;
            // 
            // RecordTaskEnquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 242);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGroupby);
            this.Controls.Add(this.radioButtonUndone);
            this.Controls.Add(this.radioButtonDone);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradientControl1);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 296);
            this.Name = "RecordTaskEnquiryForm";
            this.Text = "Record Task Enquiry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private DMC.Operator.Factory.GradientControl gradientControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonDone;
        private System.Windows.Forms.RadioButton radioButtonUndone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGroupby;
        private DMC.Operator.Factory.DateTimePickerDmc dateTimePickerFrom;
        private System.Windows.Forms.Label label7;
        private DMC.Operator.Factory.DateTimePickerDmc dateTimePickerTo;
    }
}