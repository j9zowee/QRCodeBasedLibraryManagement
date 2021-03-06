﻿namespace QRCodeBasedLMS
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_UserIDNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Lastname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ConfirmPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cmb_SecretQuestion = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_SecretAnswer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.link_GoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Firstname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lastname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Username :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Confirm Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Secret Question :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Secret Answer :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "User ID Number :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_UserIDNum
            // 
            this.txt_UserIDNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNum.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_UserIDNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_UserIDNum.BorderThickness = 1;
            this.txt_UserIDNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_UserIDNum.Enabled = false;
            this.txt_UserIDNum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_UserIDNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_UserIDNum.isPassword = false;
            this.txt_UserIDNum.Location = new System.Drawing.Point(156, 56);
            this.txt_UserIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserIDNum.Name = "txt_UserIDNum";
            this.txt_UserIDNum.Size = new System.Drawing.Size(218, 22);
            this.txt_UserIDNum.TabIndex = 1;
            this.txt_UserIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Firstname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Firstname.BorderThickness = 1;
            this.txt_Firstname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Firstname.isPassword = false;
            this.txt_Firstname.Location = new System.Drawing.Point(156, 88);
            this.txt_Firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(218, 22);
            this.txt_Firstname.TabIndex = 2;
            this.txt_Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Lastname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Lastname.BorderThickness = 1;
            this.txt_Lastname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Lastname.isPassword = false;
            this.txt_Lastname.Location = new System.Drawing.Point(156, 120);
            this.txt_Lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(218, 22);
            this.txt_Lastname.TabIndex = 3;
            this.txt_Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Username.BorderThickness = 1;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Username.isPassword = false;
            this.txt_Username.Location = new System.Drawing.Point(156, 152);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(218, 22);
            this.txt_Username.TabIndex = 4;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_Password.BorderThickness = 1;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_Password.isPassword = true;
            this.txt_Password.Location = new System.Drawing.Point(156, 184);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(218, 22);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ConfirmPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_ConfirmPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_ConfirmPassword.BorderThickness = 1;
            this.txt_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_ConfirmPassword.isPassword = true;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(156, 216);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(218, 22);
            this.txt_ConfirmPassword.TabIndex = 6;
            this.txt_ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ConfirmPassword.Leave += new System.EventHandler(this.txt_ConfirmPassword_Leave);
            // 
            // cmb_SecretQuestion
            // 
            this.cmb_SecretQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cmb_SecretQuestion.BorderRadius = 3;
            this.cmb_SecretQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmb_SecretQuestion.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_SecretQuestion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmb_SecretQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.cmb_SecretQuestion.Items = new string[] {
        "What was your favorite food as a child?",
        "What is your favorite color?",
        "What is the title of your favorite movie?",
        "What is your mother\'s maiden name?",
        "In what city or town did your mother and father meet?",
        "In what town was your first job?",
        "What school did you attend for sixth grade?"};
            this.cmb_SecretQuestion.Location = new System.Drawing.Point(156, 247);
            this.cmb_SecretQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_SecretQuestion.Name = "cmb_SecretQuestion";
            this.cmb_SecretQuestion.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.cmb_SecretQuestion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.cmb_SecretQuestion.selectedIndex = 0;
            this.cmb_SecretQuestion.Size = new System.Drawing.Size(218, 45);
            this.cmb_SecretQuestion.TabIndex = 7;
            // 
            // txt_SecretAnswer
            // 
            this.txt_SecretAnswer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SecretAnswer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.txt_SecretAnswer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txt_SecretAnswer.BorderThickness = 1;
            this.txt_SecretAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_SecretAnswer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SecretAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txt_SecretAnswer.isPassword = false;
            this.txt_SecretAnswer.Location = new System.Drawing.Point(156, 301);
            this.txt_SecretAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SecretAnswer.Name = "txt_SecretAnswer";
            this.txt_SecretAnswer.Size = new System.Drawing.Size(218, 22);
            this.txt_SecretAnswer.TabIndex = 8;
            this.txt_SecretAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.BorderRadius = 7;
            this.btnRegister.ButtonText = "REGISTER";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegister.Iconimage")));
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = false;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = true;
            this.btnRegister.IconZoom = 80D;
            this.btnRegister.IsTab = false;
            this.btnRegister.Location = new System.Drawing.Point(241, 345);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(133, 41);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // link_GoBack
            // 
            this.link_GoBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.BackColor = System.Drawing.Color.Transparent;
            this.link_GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.link_GoBack.BorderRadius = 7;
            this.link_GoBack.ButtonText = "Go Back";
            this.link_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_GoBack.DisabledColor = System.Drawing.Color.Gray;
            this.link_GoBack.Iconcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("link_GoBack.Iconimage")));
            this.link_GoBack.Iconimage_right = null;
            this.link_GoBack.Iconimage_right_Selected = null;
            this.link_GoBack.Iconimage_Selected = null;
            this.link_GoBack.IconMarginLeft = 0;
            this.link_GoBack.IconMarginRight = 0;
            this.link_GoBack.IconRightVisible = false;
            this.link_GoBack.IconRightZoom = 0D;
            this.link_GoBack.IconVisible = false;
            this.link_GoBack.IconZoom = 110D;
            this.link_GoBack.IsTab = false;
            this.link_GoBack.Location = new System.Drawing.Point(337, 12);
            this.link_GoBack.Name = "link_GoBack";
            this.link_GoBack.Normalcolor = System.Drawing.Color.Transparent;
            this.link_GoBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.link_GoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.link_GoBack.selected = false;
            this.link_GoBack.Size = new System.Drawing.Size(72, 22);
            this.link_GoBack.TabIndex = 31;
            this.link_GoBack.Text = "Go Back";
            this.link_GoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_GoBack.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.link_GoBack.TextFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_GoBack.Click += new System.EventHandler(this.link_GoBack_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(421, 398);
            this.Controls.Add(this.link_GoBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txt_SecretAnswer);
            this.Controls.Add(this.cmb_SecretQuestion);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.txt_UserIDNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_UserIDNum;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Firstname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Lastname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Username;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ConfirmPassword;
        private Bunifu.Framework.UI.BunifuDropdown cmb_SecretQuestion;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_SecretAnswer;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegister;
        private Bunifu.Framework.UI.BunifuFlatButton link_GoBack;
    }
}