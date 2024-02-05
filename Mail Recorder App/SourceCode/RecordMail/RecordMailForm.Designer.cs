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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.checkBoxCQ = new System.Windows.Forms.CheckBox();
            this.textBoxClose = new System.Windows.Forms.TextBox();
            this.textBoxPending = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAnalyze = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(391, 522);
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnDetail});
            this.grid.Location = new System.Drawing.Point(91, 352);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(511, 143);
            this.grid.TabIndex = 1;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // ColumnDate
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnDetail
            // 
            this.ColumnDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnDetail.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnDetail.DividerWidth = 2;
            this.ColumnDetail.HeaderText = "Detail";
            this.ColumnDetail.Name = "ColumnDetail";
            this.ColumnDetail.ReadOnly = true;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxDetail.Location = new System.Drawing.Point(91, 214);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDetail.Size = new System.Drawing.Size(201, 99);
            this.textBoxDetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(43, 214);
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
            this.label3.Location = new System.Drawing.Point(49, 187);
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
            this.buttonClear.Location = new System.Drawing.Point(505, 522);
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
            this.buttonAttachment.Location = new System.Drawing.Point(499, 316);
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
            this.transactionControl1.Size = new System.Drawing.Size(620, 31);
            this.transactionControl1.TabIndex = 22;
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-1, -1);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(629, 51);
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
            this.label5.Location = new System.Drawing.Point(-4, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(632, 2);
            this.label5.TabIndex = 25;
            // 
            // dateTimePickerDmcDate
            // 
            this.dateTimePickerDmcDate.CustomFormat = "dd-MMM-yyyy hh:mm tt";
            this.dateTimePickerDmcDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerDmcDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDmcDate.Location = new System.Drawing.Point(92, 183);
            this.dateTimePickerDmcDate.Name = "dateTimePickerDmcDate";
            this.dateTimePickerDmcDate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerDmcDate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(41, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Memo:";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxMemo.Location = new System.Drawing.Point(92, 319);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMemo.Size = new System.Drawing.Size(401, 24);
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
            // checkBoxCQ
            // 
            this.checkBoxCQ.AutoSize = true;
            this.checkBoxCQ.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkBoxCQ.Location = new System.Drawing.Point(67, 12);
            this.checkBoxCQ.Name = "checkBoxCQ";
            this.checkBoxCQ.Size = new System.Drawing.Size(46, 21);
            this.checkBoxCQ.TabIndex = 32;
            this.checkBoxCQ.Text = "CQ";
            this.checkBoxCQ.UseVisualStyleBackColor = true;
            this.checkBoxCQ.CheckedChanged += new System.EventHandler(this.checkBoxCQ_CheckedChanged);
            // 
            // textBoxClose
            // 
            this.textBoxClose.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxClose.Location = new System.Drawing.Point(67, 130);
            this.textBoxClose.Name = "textBoxClose";
            this.textBoxClose.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxClose.Size = new System.Drawing.Size(201, 24);
            this.textBoxClose.TabIndex = 48;
            // 
            // textBoxPending
            // 
            this.textBoxPending.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxPending.Location = new System.Drawing.Point(67, 100);
            this.textBoxPending.Name = "textBoxPending";
            this.textBoxPending.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPending.Size = new System.Drawing.Size(201, 24);
            this.textBoxPending.TabIndex = 49;
            // 
            // textBoxNew
            // 
            this.textBoxNew.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxNew.Location = new System.Drawing.Point(67, 40);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNew.Size = new System.Drawing.Size(201, 24);
            this.textBoxNew.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(20, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Close:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(3, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Pending:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(26, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "New:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAnalyze);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxNew);
            this.groupBox1.Controls.Add(this.checkBoxCQ);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxClose);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxPending);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(314, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 229);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // textBoxAnalyze
            // 
            this.textBoxAnalyze.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxAnalyze.Location = new System.Drawing.Point(67, 70);
            this.textBoxAnalyze.Name = "textBoxAnalyze";
            this.textBoxAnalyze.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAnalyze.Size = new System.Drawing.Size(201, 24);
            this.textBoxAnalyze.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Analyze:";
            // 
            // RecordMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 560);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "RecordMailForm";
            this.Text = "Record Mail Form";
            this.Load += new System.EventHandler(this.RecordMailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxCQ;
        private System.Windows.Forms.TextBox textBoxClose;
        private System.Windows.Forms.TextBox textBoxPending;
        private System.Windows.Forms.TextBox textBoxNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAnalyze;
        private System.Windows.Forms.Label label12;
    }
}