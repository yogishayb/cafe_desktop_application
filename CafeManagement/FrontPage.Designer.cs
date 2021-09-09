
namespace CafeManagement
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conadminbtn = new Guna.UI2.WinForms.Guna2Button();
            this.conEmpbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Close = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.Minimize = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(341, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(558, 114);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "F.R.I.E.N.D.S Cafe";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // conadminbtn
            // 
            this.conadminbtn.BackColor = System.Drawing.Color.Transparent;
            this.conadminbtn.BorderRadius = 20;
            this.conadminbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.conadminbtn.CheckedState.Parent = this.conadminbtn;
            this.conadminbtn.CustomImages.Parent = this.conadminbtn;
            this.conadminbtn.FillColor = System.Drawing.Color.Transparent;
            this.conadminbtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conadminbtn.ForeColor = System.Drawing.Color.White;
            this.conadminbtn.HoverState.Parent = this.conadminbtn;
            this.conadminbtn.Location = new System.Drawing.Point(473, 290);
            this.conadminbtn.Name = "conadminbtn";
            this.conadminbtn.ShadowDecoration.Parent = this.conadminbtn;
            this.conadminbtn.Size = new System.Drawing.Size(242, 45);
            this.conadminbtn.TabIndex = 1;
            this.conadminbtn.Text = "Continue As Admin";
            this.conadminbtn.Click += new System.EventHandler(this.conadminbtn_Click);
            // 
            // conEmpbtn
            // 
            this.conEmpbtn.BackColor = System.Drawing.Color.Transparent;
            this.conEmpbtn.BorderRadius = 20;
            this.conEmpbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.conEmpbtn.CheckedState.Parent = this.conEmpbtn;
            this.conEmpbtn.CustomImages.Parent = this.conEmpbtn;
            this.conEmpbtn.FillColor = System.Drawing.Color.Transparent;
            this.conEmpbtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conEmpbtn.ForeColor = System.Drawing.Color.White;
            this.conEmpbtn.HoverState.Parent = this.conEmpbtn;
            this.conEmpbtn.Location = new System.Drawing.Point(473, 382);
            this.conEmpbtn.Name = "conEmpbtn";
            this.conEmpbtn.ShadowDecoration.Parent = this.conEmpbtn;
            this.conEmpbtn.Size = new System.Drawing.Size(242, 45);
            this.conEmpbtn.TabIndex = 2;
            this.conEmpbtn.Text = "Continue As Employee";
            this.conEmpbtn.Click += new System.EventHandler(this.conEmpbtn_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.FillColor = System.Drawing.Color.White;
            this.Close.FillColor2 = System.Drawing.Color.Transparent;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(931, 12);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(43, 31);
            this.Close.TabIndex = 4;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.White;
            this.Minimize.FillColor2 = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(879, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(46, 31);
            this.Minimize.TabIndex = 5;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.conEmpbtn);
            this.Controls.Add(this.conadminbtn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontPage";
            this.Load += new System.EventHandler(this.FrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button conadminbtn;
        private Guna.UI2.WinForms.Guna2Button conEmpbtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Close;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Minimize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}