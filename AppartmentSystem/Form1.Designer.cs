﻿namespace AppartmentSystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.lbl_logo_admin_Signup = new System.Windows.Forms.Label();
            this.lbl_motto = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(163, 498);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(196, 62);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "    Log in";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SignUp.AutoSize = true;
            this.btn_SignUp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_SignUp.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.Black;
            this.btn_SignUp.Image = ((System.Drawing.Image)(resources.GetObject("btn_SignUp.Image")));
            this.btn_SignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SignUp.Location = new System.Drawing.Point(163, 396);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(196, 63);
            this.btn_SignUp.TabIndex = 1;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Visible = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(51, 187);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 32);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(55, 278);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(116, 32);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Username.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Location = new System.Drawing.Point(60, 219);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(371, 22);
            this.txt_Username.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Location = new System.Drawing.Point(60, 310);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(371, 22);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Login.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Login.Location = new System.Drawing.Point(0, -2);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(1348, 91);
            this.lbl_Login.TabIndex = 6;
            this.lbl_Login.Text = "Apartment Management System";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.AutoSize = true;
            this.panel_login.BackColor = System.Drawing.Color.Silver;
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.cb_showPassword);
            this.panel_login.Controls.Add(this.lbl_logo_admin_Signup);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.lbl_password);
            this.panel_login.Controls.Add(this.txt_Password);
            this.panel_login.Controls.Add(this.btn_Login);
            this.panel_login.Controls.Add(this.txt_Username);
            this.panel_login.Controls.Add(this.btn_SignUp);
            this.panel_login.Location = new System.Drawing.Point(715, 156);
            this.panel_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(515, 633);
            this.panel_login.TabIndex = 7;
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.ForeColor = System.Drawing.Color.White;
            this.cb_showPassword.Location = new System.Drawing.Point(60, 342);
            this.cb_showPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(125, 20);
            this.cb_showPassword.TabIndex = 7;
            this.cb_showPassword.Text = "Show Password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            // 
            // lbl_logo_admin_Signup
            // 
            this.lbl_logo_admin_Signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_logo_admin_Signup.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo_admin_Signup.Image = ((System.Drawing.Image)(resources.GetObject("lbl_logo_admin_Signup.Image")));
            this.lbl_logo_admin_Signup.Location = new System.Drawing.Point(185, 34);
            this.lbl_logo_admin_Signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_logo_admin_Signup.Name = "lbl_logo_admin_Signup";
            this.lbl_logo_admin_Signup.Size = new System.Drawing.Size(140, 114);
            this.lbl_logo_admin_Signup.TabIndex = 6;
            // 
            // lbl_motto
            // 
            this.lbl_motto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_motto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_motto.Font = new System.Drawing.Font("Calisto MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motto.ForeColor = System.Drawing.Color.White;
            this.lbl_motto.Location = new System.Drawing.Point(85, 377);
            this.lbl_motto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_motto.Name = "lbl_motto";
            this.lbl_motto.Size = new System.Drawing.Size(515, 208);
            this.lbl_motto.TabIndex = 8;
            this.lbl_motto.Text = "You Live, We Provide";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.lbl_motto);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.panel_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.Text = " LoginFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lbl_logo_admin_Signup;
        private System.Windows.Forms.Label lbl_motto;
        private System.Windows.Forms.CheckBox cb_showPassword;
    }
}

