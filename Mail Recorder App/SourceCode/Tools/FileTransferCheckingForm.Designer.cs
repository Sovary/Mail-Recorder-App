namespace Mail_Recorder_App
{
    partial class FileTransferCheckingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUpstream = new System.Windows.Forms.RadioButton();
            this.radioButtonCust_Info = new System.Windows.Forms.RadioButton();
            this.textBoxUpstream = new System.Windows.Forms.TextBox();
            this.textBoxCustomerInfo = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gradientControl1.Location = new System.Drawing.Point(-4, -1);
            this.gradientControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(1011, 63);
            this.gradientControl1.TabIndex = 28;
            this.gradientControl1.Title = "File Transfer Check";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonBrowse.Location = new System.Drawing.Point(552, 67);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 27);
            this.buttonBrowse.TabIndex = 30;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxLocation.Location = new System.Drawing.Point(12, 69);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(534, 24);
            this.textBoxLocation.TabIndex = 29;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonCheck.Location = new System.Drawing.Point(552, 117);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 93);
            this.buttonCheck.TabIndex = 32;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUpstream);
            this.groupBox1.Controls.Add(this.radioButtonCust_Info);
            this.groupBox1.Controls.Add(this.textBoxUpstream);
            this.groupBox1.Controls.Add(this.textBoxCustomerInfo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 101);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Name";
            // 
            // radioButtonUpstream
            // 
            this.radioButtonUpstream.AutoSize = true;
            this.radioButtonUpstream.Location = new System.Drawing.Point(228, 62);
            this.radioButtonUpstream.Name = "radioButtonUpstream";
            this.radioButtonUpstream.Size = new System.Drawing.Size(273, 21);
            this.radioButtonUpstream.TabIndex = 4;
            this.radioButtonUpstream.TabStop = true;
            this.radioButtonUpstream.Text = "Up Down/Stream (Possible Folder Name)";
            this.radioButtonUpstream.UseVisualStyleBackColor = true;
            // 
            // radioButtonCust_Info
            // 
            this.radioButtonCust_Info.AutoSize = true;
            this.radioButtonCust_Info.Checked = true;
            this.radioButtonCust_Info.Location = new System.Drawing.Point(228, 24);
            this.radioButtonCust_Info.Name = "radioButtonCust_Info";
            this.radioButtonCust_Info.Size = new System.Drawing.Size(255, 21);
            this.radioButtonCust_Info.TabIndex = 3;
            this.radioButtonCust_Info.TabStop = true;
            this.radioButtonCust_Info.Text = "Customer Info (Possible Folder Name)";
            this.radioButtonCust_Info.UseVisualStyleBackColor = true;
            // 
            // textBoxUpstream
            // 
            this.textBoxUpstream.Location = new System.Drawing.Point(12, 61);
            this.textBoxUpstream.Name = "textBoxUpstream";
            this.textBoxUpstream.Size = new System.Drawing.Size(210, 24);
            this.textBoxUpstream.TabIndex = 0;
            this.textBoxUpstream.Text = "upstream_bw";
            // 
            // textBoxCustomerInfo
            // 
            this.textBoxCustomerInfo.Location = new System.Drawing.Point(12, 23);
            this.textBoxCustomerInfo.Name = "textBoxCustomerInfo";
            this.textBoxCustomerInfo.Size = new System.Drawing.Size(210, 24);
            this.textBoxCustomerInfo.TabIndex = 0;
            this.textBoxCustomerInfo.Text = "cust_info, customer";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnOperator,
            this.ColumnFilename,
            this.ColumnMonth,
            this.ColumnDate,
            this.ColumnSize});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid.Location = new System.Drawing.Point(12, 216);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(848, 328);
            this.grid.TabIndex = 47;
            // 
            // ColumnNo
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnNo.Frozen = true;
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Width = 50;
            // 
            // ColumnOperator
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnOperator.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnOperator.Frozen = true;
            this.ColumnOperator.HeaderText = "Operator";
            this.ColumnOperator.Name = "ColumnOperator";
            this.ColumnOperator.ReadOnly = true;
            // 
            // ColumnFilename
            // 
            this.ColumnFilename.Frozen = true;
            this.ColumnFilename.HeaderText = "Filename";
            this.ColumnFilename.Name = "ColumnFilename";
            this.ColumnFilename.ReadOnly = true;
            this.ColumnFilename.Width = 150;
            // 
            // ColumnMonth
            // 
            this.ColumnMonth.Frozen = true;
            this.ColumnMonth.HeaderText = "Month (MMM-YYYY)";
            this.ColumnMonth.Name = "ColumnMonth";
            this.ColumnMonth.ReadOnly = true;
            this.ColumnMonth.Width = 150;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Frozen = true;
            this.ColumnDate.HeaderText = "Date Modified";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 200;
            // 
            // ColumnSize
            // 
            this.ColumnSize.Frozen = true;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonExport.Location = new System.Drawing.Point(750, 568);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(108, 29);
            this.buttonExport.TabIndex = 48;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(-7, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(942, 2);
            this.label5.TabIndex = 49;
            // 
            // FileTransferCheckingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 607);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.gradientControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FileTransferCheckingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Transfer Checking Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMC.Operator.Factory.GradientControl gradientControl1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUpstream;
        private System.Windows.Forms.RadioButton radioButtonCust_Info;
        private System.Windows.Forms.TextBox textBoxUpstream;
        private System.Windows.Forms.TextBox textBoxCustomerInfo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label5;
    }
}