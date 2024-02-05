namespace Mail_Recorder_App
{
    partial class OperatorLookupForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(1, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(479, 232);
            this.grid.TabIndex = 0;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_KeyPress);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 150;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(381, 238);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(99, 32);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(12, 238);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(99, 32);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // OperatorLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 273);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OperatorLookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator Lookup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperatorLookupForm_FormClosing);
            this.Load += new System.EventHandler(this.OperatorLookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.Button buttonOpen;
    }
}