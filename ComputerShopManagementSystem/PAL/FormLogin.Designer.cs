﻿namespace ComputerShopManagementSystem.PAL
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Shop Management System | Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(212, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(218, 506);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(547, 39);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(218, 598);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(506, 39);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(212, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password  :";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(386, 695);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(205, 32);
            this.lblForgotPassword.TabIndex = 0;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(218, 779);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(547, 65);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnLogin;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Image = global::ComputerShopManagementSystem.Properties.Resources.icons8_eye_30;
            this.picShow.Location = new System.Drawing.Point(723, 598);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(42, 42);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 9;
            this.picShow.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picShow, "Show Password");
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // picHide
            // 
            this.picHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHide.Image = global::ComputerShopManagementSystem.Properties.Resources.icons8_hide_50;
            this.picHide.Location = new System.Drawing.Point(723, 598);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(42, 42);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 8;
            this.picHide.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picHide, "Hide Password");
            this.picHide.Visible = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::ComputerShopManagementSystem.Properties.Resources.icons8_multiply_50;
            this.picClose.Location = new System.Drawing.Point(943, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(45, 45);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.picClose, "Close");
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ComputerShopManagementSystem.Properties.Resources.Tech_Haven_ico;
            this.pictureBox3.Location = new System.Drawing.Point(323, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 327);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComputerShopManagementSystem.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 970);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop Management System | Log In";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
    }
}