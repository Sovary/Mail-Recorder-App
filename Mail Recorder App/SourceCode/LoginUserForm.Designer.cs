namespace Mail_Recorder_App
{
    partial class LoginUserForm
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
            this.gradientControl1 = new DMC.Operator.Factory.GradientControl();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradientControl1
            // 
            this.gradientControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientControl1.Location = new System.Drawing.Point(-1, -2);
            this.gradientControl1.Name = "gradientControl1";
            this.gradientControl1.Size = new System.Drawing.Size(316, 51);
            this.gradientControl1.TabIndex = 22;
            this.gradientControl1.Title = "Login";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxUser.Location = new System.Drawing.Point(77, 55);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUser.Size = new System.Drawing.Size(225, 24);
            this.textBoxUser.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(36, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "User:";
            // 
            // textBoxPw
            // 
            this.textBoxPw.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxPw.Location = new System.Drawing.Point(77, 85);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPw.Size = new System.Drawing.Size(225, 24);
            this.textBoxPw.TabIndex = 32;
            this.textBoxPw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonLogin.Location = new System.Drawing.Point(194, 125);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 29);
            this.buttonLogin.TabIndex = 33;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 166);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gradientControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMC.Operator.Factory.GradientControl gradientControl1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
    }
}