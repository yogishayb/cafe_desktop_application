using System.Drawing;

namespace CafeManagement
{
    partial class LoginReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginReg));
            this.loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Regbtn = new Guna.UI2.WinForms.Guna2Button();
            this.RegPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.CPassTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTboxR = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTboxR = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminRegbtn = new Guna.UI2.WinForms.Guna2Button();
            this.LastnameTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.FirstnameTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AdminLoginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.Minimize = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.LoaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.CheckedState.Parent = this.loginbtn;
            this.loginbtn.CustomImages.Parent = this.loginbtn;
            this.loginbtn.FillColor = System.Drawing.Color.Transparent;
            this.loginbtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.Black;
            this.loginbtn.HoverState.Parent = this.loginbtn;
            this.loginbtn.Location = new System.Drawing.Point(12, 121);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.ShadowDecoration.Parent = this.loginbtn;
            this.loginbtn.Size = new System.Drawing.Size(228, 45);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Regbtn
            // 
            this.Regbtn.BackColor = System.Drawing.Color.Transparent;
            this.Regbtn.CheckedState.Parent = this.Regbtn;
            this.Regbtn.CustomImages.Parent = this.Regbtn;
            this.Regbtn.FillColor = System.Drawing.Color.Transparent;
            this.Regbtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regbtn.ForeColor = System.Drawing.Color.Black;
            this.Regbtn.HoverState.Parent = this.Regbtn;
            this.Regbtn.Location = new System.Drawing.Point(246, 121);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.ShadowDecoration.Parent = this.Regbtn;
            this.Regbtn.Size = new System.Drawing.Size(240, 45);
            this.Regbtn.TabIndex = 1;
            this.Regbtn.Text = "Register";
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // RegPanel
            // 
            this.RegPanel.BackColor = System.Drawing.Color.Transparent;
            this.RegPanel.Controls.Add(this.CPassTbox);
            this.RegPanel.Controls.Add(this.label2);
            this.RegPanel.Controls.Add(this.PasswordTboxR);
            this.RegPanel.Controls.Add(this.UsernameTboxR);
            this.RegPanel.Controls.Add(this.label3);
            this.RegPanel.Controls.Add(this.label1);
            this.RegPanel.Controls.Add(this.AdminRegbtn);
            this.RegPanel.Controls.Add(this.LastnameTbox);
            this.RegPanel.Controls.Add(this.passlabel);
            this.RegPanel.Controls.Add(this.FirstnameTbox);
            this.RegPanel.Controls.Add(this.usernamelabel);
            this.RegPanel.Location = new System.Drawing.Point(0, 0);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.ShadowDecoration.Parent = this.RegPanel;
            this.RegPanel.Size = new System.Drawing.Size(477, 334);
            this.RegPanel.TabIndex = 2;
            // 
            // CPassTbox
            // 
            this.CPassTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPassTbox.DefaultText = "";
            this.CPassTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CPassTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CPassTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CPassTbox.DisabledState.Parent = this.CPassTbox;
            this.CPassTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CPassTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CPassTbox.FocusedState.Parent = this.CPassTbox;
            this.CPassTbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPassTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CPassTbox.HoverState.Parent = this.CPassTbox;
            this.CPassTbox.Location = new System.Drawing.Point(195, 207);
            this.CPassTbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CPassTbox.Name = "CPassTbox";
            this.CPassTbox.PasswordChar = '\0';
            this.CPassTbox.PlaceholderText = "";
            this.CPassTbox.SelectedText = "";
            this.CPassTbox.ShadowDecoration.Parent = this.CPassTbox;
            this.CPassTbox.Size = new System.Drawing.Size(229, 30);
            this.CPassTbox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // PasswordTboxR
            // 
            this.PasswordTboxR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTboxR.DefaultText = "";
            this.PasswordTboxR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTboxR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTboxR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTboxR.DisabledState.Parent = this.PasswordTboxR;
            this.PasswordTboxR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTboxR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTboxR.FocusedState.Parent = this.PasswordTboxR;
            this.PasswordTboxR.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTboxR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTboxR.HoverState.Parent = this.PasswordTboxR;
            this.PasswordTboxR.Location = new System.Drawing.Point(195, 158);
            this.PasswordTboxR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordTboxR.Name = "PasswordTboxR";
            this.PasswordTboxR.PasswordChar = '\0';
            this.PasswordTboxR.PlaceholderText = "";
            this.PasswordTboxR.SelectedText = "";
            this.PasswordTboxR.ShadowDecoration.Parent = this.PasswordTboxR;
            this.PasswordTboxR.Size = new System.Drawing.Size(229, 30);
            this.PasswordTboxR.TabIndex = 9;
            // 
            // UsernameTboxR
            // 
            this.UsernameTboxR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTboxR.DefaultText = "";
            this.UsernameTboxR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTboxR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTboxR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTboxR.DisabledState.Parent = this.UsernameTboxR;
            this.UsernameTboxR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTboxR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTboxR.FocusedState.Parent = this.UsernameTboxR;
            this.UsernameTboxR.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTboxR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTboxR.HoverState.Parent = this.UsernameTboxR;
            this.UsernameTboxR.Location = new System.Drawing.Point(195, 114);
            this.UsernameTboxR.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsernameTboxR.Name = "UsernameTboxR";
            this.UsernameTboxR.PasswordChar = '\0';
            this.UsernameTboxR.PlaceholderText = "";
            this.UsernameTboxR.SelectedText = "";
            this.UsernameTboxR.ShadowDecoration.Parent = this.UsernameTboxR;
            this.UsernameTboxR.Size = new System.Drawing.Size(229, 30);
            this.UsernameTboxR.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // AdminRegbtn
            // 
            this.AdminRegbtn.BorderRadius = 20;
            this.AdminRegbtn.CheckedState.Parent = this.AdminRegbtn;
            this.AdminRegbtn.CustomImages.Parent = this.AdminRegbtn;
            this.AdminRegbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRegbtn.ForeColor = System.Drawing.Color.White;
            this.AdminRegbtn.HoverState.Parent = this.AdminRegbtn;
            this.AdminRegbtn.Location = new System.Drawing.Point(143, 274);
            this.AdminRegbtn.Name = "AdminRegbtn";
            this.AdminRegbtn.ShadowDecoration.Parent = this.AdminRegbtn;
            this.AdminRegbtn.Size = new System.Drawing.Size(180, 45);
            this.AdminRegbtn.TabIndex = 4;
            this.AdminRegbtn.Text = "Register";
            this.AdminRegbtn.Click += new System.EventHandler(this.AdminRegbtn_Click);
            // 
            // LastnameTbox
            // 
            this.LastnameTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastnameTbox.DefaultText = "";
            this.LastnameTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastnameTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastnameTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastnameTbox.DisabledState.Parent = this.LastnameTbox;
            this.LastnameTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastnameTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastnameTbox.FocusedState.Parent = this.LastnameTbox;
            this.LastnameTbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastnameTbox.HoverState.Parent = this.LastnameTbox;
            this.LastnameTbox.Location = new System.Drawing.Point(195, 69);
            this.LastnameTbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LastnameTbox.Name = "LastnameTbox";
            this.LastnameTbox.PasswordChar = '\0';
            this.LastnameTbox.PlaceholderText = "";
            this.LastnameTbox.SelectedText = "";
            this.LastnameTbox.ShadowDecoration.Parent = this.LastnameTbox;
            this.LastnameTbox.Size = new System.Drawing.Size(229, 30);
            this.LastnameTbox.TabIndex = 3;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(55, 118);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(99, 26);
            this.passlabel.TabIndex = 2;
            this.passlabel.Text = "Username";
            // 
            // FirstnameTbox
            // 
            this.FirstnameTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstnameTbox.DefaultText = "";
            this.FirstnameTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstnameTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstnameTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstnameTbox.DisabledState.Parent = this.FirstnameTbox;
            this.FirstnameTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstnameTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstnameTbox.FocusedState.Parent = this.FirstnameTbox;
            this.FirstnameTbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstnameTbox.HoverState.Parent = this.FirstnameTbox;
            this.FirstnameTbox.Location = new System.Drawing.Point(195, 23);
            this.FirstnameTbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FirstnameTbox.Name = "FirstnameTbox";
            this.FirstnameTbox.PasswordChar = '\0';
            this.FirstnameTbox.PlaceholderText = "";
            this.FirstnameTbox.SelectedText = "";
            this.FirstnameTbox.ShadowDecoration.Parent = this.FirstnameTbox;
            this.FirstnameTbox.Size = new System.Drawing.Size(229, 30);
            this.FirstnameTbox.TabIndex = 1;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(55, 73);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(105, 26);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Last Name";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.RegPanel);
            this.LoginPanel.Controls.Add(this.AdminLoginbtn);
            this.LoginPanel.Controls.Add(this.PasswordTBox);
            this.LoginPanel.Controls.Add(this.UsernameTBox);
            this.LoginPanel.Controls.Add(this.label5);
            this.LoginPanel.Controls.Add(this.label4);
            this.LoginPanel.Location = new System.Drawing.Point(12, 172);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.ShadowDecoration.Parent = this.LoginPanel;
            this.LoginPanel.Size = new System.Drawing.Size(477, 334);
            this.LoginPanel.TabIndex = 11;
            // 
            // AdminLoginbtn
            // 
            this.AdminLoginbtn.BorderRadius = 20;
            this.AdminLoginbtn.CheckedState.Parent = this.AdminLoginbtn;
            this.AdminLoginbtn.CustomImages.Parent = this.AdminLoginbtn;
            this.AdminLoginbtn.FillColor = System.Drawing.Color.Black;
            this.AdminLoginbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginbtn.ForeColor = System.Drawing.Color.White;
            this.AdminLoginbtn.HoverState.Parent = this.AdminLoginbtn;
            this.AdminLoginbtn.Location = new System.Drawing.Point(143, 234);
            this.AdminLoginbtn.Name = "AdminLoginbtn";
            this.AdminLoginbtn.ShadowDecoration.Parent = this.AdminLoginbtn;
            this.AdminLoginbtn.Size = new System.Drawing.Size(180, 45);
            this.AdminLoginbtn.TabIndex = 11;
            this.AdminLoginbtn.Text = "Login";
            this.AdminLoginbtn.Click += new System.EventHandler(this.AdminLoginbtn_Click);
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTBox.DefaultText = "";
            this.PasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTBox.DisabledState.Parent = this.PasswordTBox;
            this.PasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTBox.FocusedState.Parent = this.PasswordTBox;
            this.PasswordTBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTBox.HoverState.Parent = this.PasswordTBox;
            this.PasswordTBox.Location = new System.Drawing.Point(195, 154);
            this.PasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.PasswordChar = '*';
            this.PasswordTBox.PlaceholderText = "";
            this.PasswordTBox.SelectedText = "";
            this.PasswordTBox.ShadowDecoration.Parent = this.PasswordTBox;
            this.PasswordTBox.Size = new System.Drawing.Size(229, 30);
            this.PasswordTBox.TabIndex = 10;
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTBox.DefaultText = "";
            this.UsernameTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTBox.DisabledState.Parent = this.UsernameTBox;
            this.UsernameTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTBox.FocusedState.Parent = this.UsernameTBox;
            this.UsernameTBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTBox.HoverState.Parent = this.UsernameTBox;
            this.UsernameTBox.Location = new System.Drawing.Point(195, 64);
            this.UsernameTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.PasswordChar = '\0';
            this.UsernameTBox.PlaceholderText = "";
            this.UsernameTBox.SelectedText = "";
            this.UsernameTBox.ShadowDecoration.Parent = this.UsernameTBox;
            this.UsernameTBox.Size = new System.Drawing.Size(229, 30);
            this.UsernameTBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // LoaderPanel
            // 
            this.LoaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoaderPanel.Controls.Add(this.label6);
            this.LoaderPanel.Location = new System.Drawing.Point(0, 121);
            this.LoaderPanel.Name = "LoaderPanel";
            this.LoaderPanel.ShadowDecoration.Parent = this.LoaderPanel;
            this.LoaderPanel.Size = new System.Drawing.Size(509, 405);
            this.LoaderPanel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please Wait..........!";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.FillColor = System.Drawing.Color.Transparent;
            this.Close.FillColor2 = System.Drawing.Color.White;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(931, 22);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(43, 36);
            this.Close.TabIndex = 13;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.FillColor2 = System.Drawing.Color.White;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(879, 22);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(46, 36);
            this.Minimize.TabIndex = 14;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(35, 22);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(95, 36);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "<-- Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.LoaderPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginReg";
            this.Load += new System.EventHandler(this.LoginReg_Load);
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.LoaderPanel.ResumeLayout(false);
            this.LoaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginbtn;
        private Guna.UI2.WinForms.Guna2Button Regbtn;
        private Guna.UI2.WinForms.Guna2Panel RegPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AdminRegbtn;
        private Guna.UI2.WinForms.Guna2TextBox LastnameTbox;
        private System.Windows.Forms.Label passlabel;
        private Guna.UI2.WinForms.Guna2TextBox FirstnameTbox;
        private System.Windows.Forms.Label usernamelabel;
        private Guna.UI2.WinForms.Guna2TextBox CPassTbox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTboxR;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTboxR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2Button AdminLoginbtn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel LoaderPanel;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Close;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Minimize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}