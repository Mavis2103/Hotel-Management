﻿namespace HotelManagement.GUI
{
    partial class FormQuenMatKhauNhapOTP
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
            this.ButtonContinue = new HotelManagement.CTControls.CTButton();
            this.textBoxOTP = new HotelManagement.CTControls.CTTextBox();
            this.LabelForgotPassword = new System.Windows.Forms.Label();
            this.ButtonResend = new HotelManagement.CTControls.CTButton();
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonContinue.BorderColor = System.Drawing.Color.White;
            this.ButtonContinue.BorderRadius = 20;
            this.ButtonContinue.BorderSize = 0;
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.FlatAppearance.BorderSize = 0;
            this.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonContinue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonContinue.ForeColor = System.Drawing.Color.White;
            this.ButtonContinue.Location = new System.Drawing.Point(179, 302);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(130, 47);
            this.ButtonContinue.TabIndex = 10;
            this.ButtonContinue.Text = "CONTINUE";
            this.ButtonContinue.TextColor = System.Drawing.Color.White;
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxOTP.BorderRadius = 20;
            this.textBoxOTP.BorderSize = 1;
            this.textBoxOTP.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBoxOTP.IsFocused = false;
            this.textBoxOTP.Location = new System.Drawing.Point(24, 203);
            this.textBoxOTP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTP.Multiline = false;
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxOTP.PasswordChar = false;
            this.textBoxOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOTP.PlaceholderText = "Enter your OTP";
            this.textBoxOTP.ReadOnly = false;
            this.textBoxOTP.Size = new System.Drawing.Size(286, 45);
            this.textBoxOTP.TabIndex = 8;
            this.textBoxOTP.Texts = "";
            this.textBoxOTP.UnderlineedStyle = false;
            // 
            // LabelForgotPassword
            // 
            this.LabelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelForgotPassword.AutoSize = true;
            this.LabelForgotPassword.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.LabelForgotPassword.Location = new System.Drawing.Point(13, 69);
            this.LabelForgotPassword.Name = "LabelForgotPassword";
            this.LabelForgotPassword.Size = new System.Drawing.Size(295, 59);
            this.LabelForgotPassword.TabIndex = 7;
            this.LabelForgotPassword.Text = "Forgot password";
            // 
            // ButtonResend
            // 
            this.ButtonResend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonResend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonResend.BorderColor = System.Drawing.Color.White;
            this.ButtonResend.BorderRadius = 20;
            this.ButtonResend.BorderSize = 0;
            this.ButtonResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonResend.FlatAppearance.BorderSize = 0;
            this.ButtonResend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResend.ForeColor = System.Drawing.Color.White;
            this.ButtonResend.Location = new System.Drawing.Point(24, 302);
            this.ButtonResend.Name = "ButtonResend";
            this.ButtonResend.Size = new System.Drawing.Size(130, 47);
            this.ButtonResend.TabIndex = 10;
            this.ButtonResend.Text = "RESEND";
            this.ButtonResend.TextColor = System.Drawing.Color.White;
            this.ButtonResend.UseVisualStyleBackColor = false;
            this.ButtonResend.Click += new System.EventHandler(this.ButtonResend_Click);
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Image = global::HotelManagement.Properties.Resources.back;
            this.PictureBoxBack.Location = new System.Drawing.Point(12, 24);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 11;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormQuenMatKhauNhapOTP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonResend);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.textBoxOTP);
            this.Controls.Add(this.LabelForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhauNhapOTP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormQuenMatKhauNhapOTP";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTButton ButtonContinue;
        private CTControls.CTTextBox textBoxOTP;
        private System.Windows.Forms.Label LabelForgotPassword;
        private CTControls.CTButton ButtonResend;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.Timer timer1;
    }
}