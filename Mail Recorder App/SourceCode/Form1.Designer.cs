namespace Mail_Recorder_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importRecordMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordMailMonthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enquiriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordMailEnquiryFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordMailsMonthlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.operatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importRecordMailToolStripMenuItem,
            this.mailRecordToolStripMenuItem,
            this.recordMailMonthlyToolStripMenuItem,
            this.toolStripSeparator1,
            this.enquiriesToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem2.Tag = "";
            this.toolStripMenuItem2.Text = "Manage Mails";
            // 
            // importRecordMailToolStripMenuItem
            // 
            this.importRecordMailToolStripMenuItem.Name = "importRecordMailToolStripMenuItem";
            this.importRecordMailToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.importRecordMailToolStripMenuItem.Tag = "ImportRecordMailForm";
            this.importRecordMailToolStripMenuItem.Text = "Import Record Mails";
            // 
            // mailRecordToolStripMenuItem
            // 
            this.mailRecordToolStripMenuItem.Name = "mailRecordToolStripMenuItem";
            this.mailRecordToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mailRecordToolStripMenuItem.Tag = "RecordMailForm";
            this.mailRecordToolStripMenuItem.Text = "Record Mails";
            // 
            // recordMailMonthlyToolStripMenuItem
            // 
            this.recordMailMonthlyToolStripMenuItem.Name = "recordMailMonthlyToolStripMenuItem";
            this.recordMailMonthlyToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recordMailMonthlyToolStripMenuItem.Tag = "RecordMailMonthlyForm";
            this.recordMailMonthlyToolStripMenuItem.Text = "Record Mails Monthly";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // enquiriesToolStripMenuItem
            // 
            this.enquiriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordMailEnquiryFormToolStripMenuItem,
            this.recordMailsMonthlyToolStripMenuItem1});
            this.enquiriesToolStripMenuItem.Name = "enquiriesToolStripMenuItem";
            this.enquiriesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.enquiriesToolStripMenuItem.Text = "Enquiries";
            // 
            // recordMailEnquiryFormToolStripMenuItem
            // 
            this.recordMailEnquiryFormToolStripMenuItem.Name = "recordMailEnquiryFormToolStripMenuItem";
            this.recordMailEnquiryFormToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.recordMailEnquiryFormToolStripMenuItem.Tag = "RecordMailEnquiryForm";
            this.recordMailEnquiryFormToolStripMenuItem.Text = "Record Mails Enquiry";
            // 
            // recordMailsMonthlyToolStripMenuItem1
            // 
            this.recordMailsMonthlyToolStripMenuItem1.Name = "recordMailsMonthlyToolStripMenuItem1";
            this.recordMailsMonthlyToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.recordMailsMonthlyToolStripMenuItem1.Tag = "RecordMailMonthlyEnquiryForm";
            this.recordMailsMonthlyToolStripMenuItem1.Text = "Record Mails Monthly Enquiry";
            // 
            // operatorToolStripMenuItem
            // 
            this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
            this.operatorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operatorToolStripMenuItem.Tag = "ManageOperatorForm";
            this.operatorToolStripMenuItem.Text = "Operator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Mail_Recorder_App.Properties.Resources.consent_under_gdpr;
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mail Recorder App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importRecordMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recordMailMonthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquiriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordMailEnquiryFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordMailsMonthlyToolStripMenuItem1;
    }
}

