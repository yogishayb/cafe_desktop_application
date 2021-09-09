
namespace CafeManagement.AllUserControls
{
    partial class UC_QrGenerate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.qrpicturebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // qrpicturebox
            // 
            this.qrpicturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qrpicturebox.Location = new System.Drawing.Point(221, 107);
            this.qrpicturebox.Name = "qrpicturebox";
            this.qrpicturebox.Size = new System.Drawing.Size(300, 300);
            this.qrpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrpicturebox.TabIndex = 0;
            this.qrpicturebox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan the QR Code";
            // 
            // UC_QrGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrpicturebox);
            this.Name = "UC_QrGenerate";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_QrGenerate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox qrpicturebox;
        private System.Windows.Forms.Label label1;
    }
}
