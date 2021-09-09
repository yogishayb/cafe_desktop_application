
namespace CafeManagement
{
    partial class pendingOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pendingOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.pendingOrderIDSlistbox = new System.Windows.Forms.ListBox();
            this.cartgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandtotallabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.placeOrderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.acceptedordersbtn = new Guna.UI2.WinForms.Guna2Button();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(412, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending Orders";
            // 
            // pendingOrderIDSlistbox
            // 
            this.pendingOrderIDSlistbox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingOrderIDSlistbox.FormattingEnabled = true;
            this.pendingOrderIDSlistbox.ItemHeight = 18;
            this.pendingOrderIDSlistbox.Location = new System.Drawing.Point(64, 143);
            this.pendingOrderIDSlistbox.Name = "pendingOrderIDSlistbox";
            this.pendingOrderIDSlistbox.Size = new System.Drawing.Size(193, 364);
            this.pendingOrderIDSlistbox.TabIndex = 5;
            this.pendingOrderIDSlistbox.Click += new System.EventHandler(this.pendingOrderIDSlistbox_Click);
            // 
            // cartgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.cartgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cartgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartgridview.BackgroundColor = System.Drawing.Color.White;
            this.cartgridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cartgridview.ColumnHeadersHeight = 21;
            this.cartgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.cartgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.cartgridview.EnableHeadersVisualStyles = false;
            this.cartgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartgridview.Location = new System.Drawing.Point(274, 95);
            this.cartgridview.Name = "cartgridview";
            this.cartgridview.RowHeadersVisible = false;
            this.cartgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartgridview.Size = new System.Drawing.Size(673, 351);
            this.cartgridview.TabIndex = 16;
            this.cartgridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.cartgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.cartgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cartgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cartgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cartgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cartgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cartgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cartgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cartgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cartgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cartgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartgridview.ThemeStyle.HeaderStyle.Height = 21;
            this.cartgridview.ThemeStyle.ReadOnly = false;
            this.cartgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.cartgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cartgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.cartgridview.ThemeStyle.RowsStyle.Height = 22;
            this.cartgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // grandtotallabel
            // 
            this.grandtotallabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grandtotallabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotallabel.Location = new System.Drawing.Point(552, 472);
            this.grandtotallabel.Name = "grandtotallabel";
            this.grandtotallabel.Size = new System.Drawing.Size(122, 35);
            this.grandtotallabel.TabIndex = 21;
            this.grandtotallabel.Text = "Rs 00";
            this.grandtotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Grand Total";
            // 
            // placeOrderbtn
            // 
            this.placeOrderbtn.BorderRadius = 21;
            this.placeOrderbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.placeOrderbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.placeOrderbtn.CheckedState.Parent = this.placeOrderbtn;
            this.placeOrderbtn.CustomImages.Parent = this.placeOrderbtn;
            this.placeOrderbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.placeOrderbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderbtn.ForeColor = System.Drawing.Color.White;
            this.placeOrderbtn.HoverState.Parent = this.placeOrderbtn;
            this.placeOrderbtn.Location = new System.Drawing.Point(274, 460);
            this.placeOrderbtn.Name = "placeOrderbtn";
            this.placeOrderbtn.ShadowDecoration.Parent = this.placeOrderbtn;
            this.placeOrderbtn.Size = new System.Drawing.Size(156, 45);
            this.placeOrderbtn.TabIndex = 22;
            this.placeOrderbtn.Text = "Place Order";
            this.placeOrderbtn.Click += new System.EventHandler(this.placeOrderbtn_Click);
            // 
            // acceptedordersbtn
            // 
            this.acceptedordersbtn.BorderRadius = 21;
            this.acceptedordersbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.acceptedordersbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.acceptedordersbtn.CheckedState.Parent = this.acceptedordersbtn;
            this.acceptedordersbtn.CustomImages.Parent = this.acceptedordersbtn;
            this.acceptedordersbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.acceptedordersbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedordersbtn.ForeColor = System.Drawing.Color.White;
            this.acceptedordersbtn.HoverState.Parent = this.acceptedordersbtn;
            this.acceptedordersbtn.Location = new System.Drawing.Point(791, 460);
            this.acceptedordersbtn.Name = "acceptedordersbtn";
            this.acceptedordersbtn.ShadowDecoration.Parent = this.acceptedordersbtn;
            this.acceptedordersbtn.Size = new System.Drawing.Size(156, 45);
            this.acceptedordersbtn.TabIndex = 23;
            this.acceptedordersbtn.Text = "Accepted Orders";
            this.acceptedordersbtn.Click += new System.EventHandler(this.acceptedordersbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BorderRadius = 21;
            this.refreshbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.refreshbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.refreshbtn.CheckedState.Parent = this.refreshbtn;
            this.refreshbtn.CustomImages.Parent = this.refreshbtn;
            this.refreshbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.refreshbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.HoverState.Parent = this.refreshbtn;
            this.refreshbtn.Location = new System.Drawing.Point(64, 95);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.ShadowDecoration.Parent = this.refreshbtn;
            this.refreshbtn.Size = new System.Drawing.Size(193, 36);
            this.refreshbtn.TabIndex = 24;
            this.refreshbtn.Text = "refresh";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // Minimize
            // 
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(909, 38);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(38, 35);
            this.Minimize.TabIndex = 26;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(865, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(38, 35);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(64, 38);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(78, 36);
            this.guna2Button3.TabIndex = 27;
            this.guna2Button3.Text = "<-- Back";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // pendingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.acceptedordersbtn);
            this.Controls.Add(this.placeOrderbtn);
            this.Controls.Add(this.grandtotallabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cartgridview);
            this.Controls.Add(this.pendingOrderIDSlistbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pendingOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pendingOrders";
            this.Load += new System.EventHandler(this.pendingOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox pendingOrderIDSlistbox;
        private Guna.UI2.WinForms.Guna2DataGridView cartgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label grandtotallabel;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button placeOrderbtn;
        private Guna.UI2.WinForms.Guna2Button acceptedordersbtn;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Minimize;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}