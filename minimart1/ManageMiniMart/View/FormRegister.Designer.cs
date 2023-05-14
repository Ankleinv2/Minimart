namespace ManageMiniMart.View
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.pnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cbbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl.Controls.Add(this.pictureBox1);
            this.pnl.Controls.Add(this.panel3);
            this.pnl.Controls.Add(this.panel1);
            this.pnl.ForeColor = System.Drawing.Color.White;
            this.pnl.Location = new System.Drawing.Point(4, 3);
            this.pnl.Margin = new System.Windows.Forms.Padding(0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(338, 566);
            this.pnl.TabIndex = 2;
            this.pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(330, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 440);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(330, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 440);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 440);
            this.panel1.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.pnlLogin.Controls.Add(this.lblConfirmPassword);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.cbbRole);
            this.pnlLogin.Controls.Add(this.lblRole);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.lblRegister);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.pnlPassword);
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.pnlUserName);
            this.pnlLogin.Controls.Add(this.lblUserID);
            this.pnlLogin.ForeColor = System.Drawing.Color.Magenta;
            this.pnlLogin.Location = new System.Drawing.Point(345, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(335, 569);
            this.pnlLogin.TabIndex = 16;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(5, 278);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(207, 25);
            this.lblConfirmPassword.TabIndex = 18;
            this.lblConfirmPassword.Text = "Confirm password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Location = new System.Drawing.Point(8, 322);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel2.Size = new System.Drawing.Size(300, 30);
            this.panel2.TabIndex = 17;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 0);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 27);
            this.txtConfirmPassword.TabIndex = 0;
            // 
            // cbbRole
            // 
            this.cbbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbbRole.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbRole.BorderRadius = 5;
            this.cbbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.ForeColor = System.Drawing.Color.DarkViolet;
            this.cbbRole.ItemHeight = 30;
            this.cbbRole.Location = new System.Drawing.Point(10, 414);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(298, 36);
            this.cbbRole.TabIndex = 16;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.lblRole.Location = new System.Drawing.Point(5, 380);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 25);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // btnRegister
            // 
            this.btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.BorderThickness = 1;
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.FillColor = System.Drawing.Color.Transparent;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.btnRegister.Location = new System.Drawing.Point(20, 489);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(285, 37);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.lblRegister.Location = new System.Drawing.Point(3, 21);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(132, 37);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Register";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.lblPassword.Location = new System.Drawing.Point(2, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 25);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.pnlPassword.Location = new System.Drawing.Point(5, 216);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlPassword.Size = new System.Drawing.Size(300, 30);
            this.pnlPassword.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(288, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlUserName
            // 
            this.pnlUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlUserName.Controls.Add(this.txtUserId);
            this.pnlUserName.ForeColor = System.Drawing.Color.Magenta;
            this.pnlUserName.Location = new System.Drawing.Point(7, 119);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlUserName.Size = new System.Drawing.Size(300, 30);
            this.pnlUserName.TabIndex = 6;
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtUserId.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtUserId.Location = new System.Drawing.Point(0, 0);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(300, 27);
            this.txtUserId.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.lblUserID.Location = new System.Drawing.Point(5, 78);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(85, 25);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "User ID";
            // 
            // FormRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 570);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRole;
    }
}