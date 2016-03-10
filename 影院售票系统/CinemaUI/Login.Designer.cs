namespace 影院售票系统.CinemaUI
{
    partial class Login
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
            this.BLogin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LName = new System.Windows.Forms.Label();
            this.LPassport = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPassport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(48, 137);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.TabIndex = 0;
            this.BLogin.Text = "登录";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(194, 137);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(73, 39);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(41, 12);
            this.LName.TabIndex = 2;
            this.LName.Text = "帐号：";
            // 
            // LPassport
            // 
            this.LPassport.AutoSize = true;
            this.LPassport.Location = new System.Drawing.Point(73, 87);
            this.LPassport.Name = "LPassport";
            this.LPassport.Size = new System.Drawing.Size(41, 12);
            this.LPassport.TabIndex = 3;
            this.LPassport.Text = "密码：";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(120, 36);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(126, 21);
            this.TBName.TabIndex = 4;
            // 
            // TBPassport
            // 
            this.TBPassport.Location = new System.Drawing.Point(120, 84);
            this.TBPassport.Name = "TBPassport";
            this.TBPassport.Size = new System.Drawing.Size(126, 21);
            this.TBPassport.TabIndex = 5;
            this.TBPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPassport_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::影院售票系统.Properties.Resources.登录;
            this.ClientSize = new System.Drawing.Size(336, 200);
            this.Controls.Add(this.TBPassport);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LPassport);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LPassport;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBPassport;

    }
}