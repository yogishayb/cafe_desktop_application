
namespace CafeManagement.AllUserControls
{
    partial class UC_Notifications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.notifygridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnplaceorder = new Guna.UI2.WinForms.Guna2Button();
            this.grandtotallabel = new System.Windows.Forms.Label();
            this.grandtotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notifygridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // notifygridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.notifygridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.notifygridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notifygridview.BackgroundColor = System.Drawing.Color.White;
            this.notifygridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notifygridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.notifygridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notifygridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.notifygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifygridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notifygridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.notifygridview.EnableHeadersVisualStyles = false;
            this.notifygridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.notifygridview.Location = new System.Drawing.Point(32, 40);
            this.notifygridview.Name = "notifygridview";
            this.notifygridview.RowHeadersVisible = false;
            this.notifygridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notifygridview.Size = new System.Drawing.Size(709, 259);
            this.notifygridview.TabIndex = 1;
            this.notifygridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.notifygridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.notifygridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.notifygridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.notifygridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.notifygridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.notifygridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.notifygridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.notifygridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.notifygridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.notifygridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.notifygridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.notifygridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifygridview.ThemeStyle.HeaderStyle.Height = 21;
            this.notifygridview.ThemeStyle.ReadOnly = false;
            this.notifygridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.notifygridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.notifygridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.notifygridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.notifygridview.ThemeStyle.RowsStyle.Height = 22;
            this.notifygridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.notifygridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.CheckedState.Parent = this.btnplaceorder;
            this.btnplaceorder.CustomImages.Parent = this.btnplaceorder;
            this.btnplaceorder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnplaceorder.ForeColor = System.Drawing.Color.White;
            this.btnplaceorder.HoverState.Parent = this.btnplaceorder;
            this.btnplaceorder.Location = new System.Drawing.Point(266, 421);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.ShadowDecoration.Parent = this.btnplaceorder;
            this.btnplaceorder.Size = new System.Drawing.Size(180, 45);
            this.btnplaceorder.TabIndex = 3;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // grandtotallabel
            // 
            this.grandtotallabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grandtotallabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotallabel.Location = new System.Drawing.Point(297, 352);
            this.grandtotallabel.Name = "grandtotallabel";
            this.grandtotallabel.Size = new System.Drawing.Size(122, 35);
            this.grandtotallabel.TabIndex = 21;
            this.grandtotallabel.Text = "Rs 00";
            this.grandtotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grandtotal
            // 
            this.grandtotal.AutoSize = true;
            this.grandtotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotal.Location = new System.Drawing.Point(309, 329);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(98, 23);
            this.grandtotal.TabIndex = 20;
            this.grandtotal.Text = "Grand Total";
            // 
            // UC_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.grandtotallabel);
            this.Controls.Add(this.grandtotal);
            this.Controls.Add(this.btnplaceorder);
            this.Controls.Add(this.notifygridview);
            this.Name = "UC_Notifications";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_Notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifygridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnplaceorder;
        private Guna.UI2.WinForms.Guna2DataGridView notifygridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label grandtotallabel;
        private System.Windows.Forms.Label grandtotal;
    }
}
