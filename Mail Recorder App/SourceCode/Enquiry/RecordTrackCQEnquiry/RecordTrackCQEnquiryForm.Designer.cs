namespace Mail_Recorder_App
{
    partial class RecordTrackCQEnquiryForm
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
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonRun.Location = new System.Drawing.Point(213, 136);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(89, 28);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.CustomFormat = "MMM-yyyy";
            this.dateTimePickerMonth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(85, 70);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(201, 24);
            this.dateTimePickerMonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month:";
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-5, -1);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(320, 51);
            this.gradientControl1.TabIndex = 22;
            this.gradientControl1.Title = "Record Track CQ Enquiry";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(-28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 2);
            this.label4.TabIndex = 26;
            // 
            // RecordTrackCQEnquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 176);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradientControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 296);
            this.Name = "RecordTrackCQEnquiryForm";
            this.Text = "Record Track CQ Enquiry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.Label label1;
        private DMC.Operator.Factory.GradientControl gradientControl1;
        private System.Windows.Forms.Label label4;
    }
}