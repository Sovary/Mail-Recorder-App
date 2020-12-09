namespace Mail_Recorder_App
{
    partial class RecordMailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAttachment = new System.Windows.Forms.Button();
            this.transactionControl1 = new DMC.Operator.Factory.TransactionControl();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.lookupControl1 = new DMC.Operator.Factory.LookupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDmcDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerMonth = new DMC.Operator.Factory.DateTimePickerDmc();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(329, 487);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 29);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnDetail});
            this.grid.Location = new System.Drawing.Point(91, 321);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(455, 143);
            this.grid.TabIndex = 1;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // ColumnDate
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnDetail
            // 
            this.ColumnDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnDetail.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnDetail.DividerWidth = 2;
            this.ColumnDetail.HeaderText = "Detail";
            this.ColumnDetail.Name = "ColumnDetail";
            this.ColumnDetail.ReadOnly = true;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxDetail.Location = new System.Drawing.Point(91, 183);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDetail.Size = new System.Drawing.Size(455, 99);
            this.textBoxDetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(43, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detail:";
            // 
            // comboBoxSender
            // 
            this.comboBoxSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSender.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxSender.FormattingEnabled = true;
            this.comboBoxSender.Location = new System.Drawing.Point(91, 123);
            this.comboBoxSender.Name = "comboBoxSender";
            this.comboBoxSender.Size = new System.Drawing.Size(201, 24);
            this.comboBoxSender.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(302, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Operator:";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonClear.Location = new System.Drawing.Point(443, 487);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 29);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAttachment
            // 
            this.buttonAttachment.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAttachment.Location = new System.Drawing.Point(345, 119);
            this.buttonAttachment.Name = "buttonAttachment";
            this.buttonAttachment.Size = new System.Drawing.Size(103, 30);
            this.buttonAttachment.TabIndex = 20;
            this.buttonAttachment.Text = "Attachment";
            this.buttonAttachment.UseVisualStyleBackColor = true;
            this.buttonAttachment.Click += new System.EventHandler(this.buttonAttachment_Click);
            // 
            // transactionControl1
            // 
            this.transactionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionControl1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.transactionControl1.Location = new System.Drawing.Point(-1, 47);
            this.transactionControl1.Name = "transactionControl1";
            this.transactionControl1.Size = new System.Drawing.Size(558, 31);
            this.transactionControl1.TabIndex = 22;
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-1, -1);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(567, 51);
            this.gradientControl1.TabIndex = 21;
            this.gradientControl1.Title = "Record Mail";
            // 
            // lookupControl1
            // 
            this.lookupControl1.Location = new System.Drawing.Point(91, 90);
            this.lookupControl1.Name = "lookupControl1";
            this.lookupControl1.Size = new System.Drawing.Size(201, 27);
            this.lookupControl1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(-4, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 2);
            this.label5.TabIndex = 25;
            // 
            // dateTimePickerDmcDate
            // 
            this.dateTimePickerDmcDate.CustomFormat = "dd-MMM-yyyy hh:mm tt";
            this.dateTimePickerDmcDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerDmcDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDmcDate.Location = new System.Drawing.Point(345, 90);
            this.dateTimePickerDmcDate.Name = "dateTimePickerDmcDate";
            this.dateTimePickerDmcDate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerDmcDate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(39, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Memo:";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxMemo.Location = new System.Drawing.Point(90, 288);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMemo.Size = new System.Drawing.Size(455, 24);
            this.textBoxMemo.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(37, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Month:";
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.CustomFormat = " ";
            this.dateTimePickerMonth.CustomFormatX = "MMM-yyyy";
            this.dateTimePickerMonth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonth.IsNullDate = true;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(91, 153);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(201, 24);
            this.dateTimePickerMonth.TabIndex = 31;
            this.dateTimePickerMonth.Value = null;
            // 
            // RecordMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 525);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDmcDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lookupControl1);
            this.Controls.Add(this.transactionControl1);
            this.Controls.Add(this.gradientControl1);
            this.Controls.Add(this.buttonAttachment);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 564);
            this.Name = "RecordMailForm";
            this.Text = "Record Mail Form";
            this.Load += new System.EventHandler(this.RecordMailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAttachment;
        private DMC.Operator.Factory.TransactionControl transactionControl1;
        private DMC.Operator.Factory.GradientControl gradientControl1;
        private DMC.Operator.Factory.LookupControl lookupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDmcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Label label7;
        private DMC.Operator.Factory.DateTimePickerDmc dateTimePickerMonth;
    }
}