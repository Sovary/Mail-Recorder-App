namespace Mail_Recorder_App
{
    partial class RecordMailMonthlyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClear = new System.Windows.Forms.Button();
            this.transactionControl1 = new DMC.Operator.Factory.TransactionControl();
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(716, 493);
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
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.ColumnOperator,
            this.ColumnSender,
            this.ColumnDate,
            this.ColumnDetail});
            this.grid.Location = new System.Drawing.Point(-1, 177);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(945, 302);
            this.grid.TabIndex = 1;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // ColumnNo
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnNo.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnNo.HeaderText = "No";
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.ReadOnly = true;
            this.ColumnNo.Width = 50;
            // 
            // ColumnOperator
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnOperator.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnOperator.HeaderText = "Operator";
            this.ColumnOperator.Name = "ColumnOperator";
            this.ColumnOperator.ReadOnly = true;
            // 
            // ColumnSender
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnSender.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnSender.HeaderText = "Sender";
            this.ColumnSender.Name = "ColumnSender";
            this.ColumnSender.ReadOnly = true;
            // 
            // ColumnDate
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnDetail
            // 
            this.ColumnDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ColumnDetail.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColumnDetail.DividerWidth = 2;
            this.ColumnDetail.HeaderText = "Detail";
            this.ColumnDetail.Name = "ColumnDetail";
            this.ColumnDetail.ReadOnly = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonClear.Location = new System.Drawing.Point(830, 493);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 29);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // transactionControl1
            // 
            this.transactionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionControl1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.transactionControl1.Location = new System.Drawing.Point(-1, 47);
            this.transactionControl1.Name = "transactionControl1";
            this.transactionControl1.Size = new System.Drawing.Size(945, 31);
            this.transactionControl1.TabIndex = 22;
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-1, -1);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(954, 51);
            this.gradientControl1.TabIndex = 21;
            this.gradientControl1.Title = "Record Mail Monthly";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(-4, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(957, 2);
            this.label5.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(46, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Memo:";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxMemo.Location = new System.Drawing.Point(98, 130);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMemo.Size = new System.Drawing.Size(260, 41);
            this.textBoxMemo.TabIndex = 28;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(98, 100);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(260, 24);
            this.dateTimePickerDate.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Date:";
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.CustomFormat = "MMM-yyyy";
            this.dateTimePickerMonth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(72, 25);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(105, 24);
            this.dateTimePickerMonth.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Monthly:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerMonth);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(364, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 71);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelDateRange.Location = new System.Drawing.Point(603, 153);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(64, 17);
            this.labelDateRange.TabIndex = 35;
            this.labelDateRange.Text = "_______";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.BackgroundImage = global::Mail_Recorder_App.Properties.Resources.refresh_double_rounded_flat;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(183, 25);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(27, 24);
            this.buttonRefresh.TabIndex = 29;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // RecordMailMonthlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 531);
            this.Controls.Add(this.labelDateRange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMemo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionControl1);
            this.Controls.Add(this.gradientControl1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "RecordMailMonthlyForm";
            this.Text = "Record Mail Monthly Form";
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
        private System.Windows.Forms.Button buttonClear;
        private DMC.Operator.Factory.TransactionControl transactionControl1;
        private DMC.Operator.Factory.GradientControl gradientControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetail;
        private System.Windows.Forms.Label labelDateRange;
    }
}