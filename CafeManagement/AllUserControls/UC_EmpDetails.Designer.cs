
namespace CafeManagement.AllUserControls
{
    partial class UC_EmpDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.emplabel = new System.Windows.Forms.Label();
            this.SearchItemTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.empdetailsgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // emplabel
            // 
            this.emplabel.AutoSize = true;
            this.emplabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.emplabel.Location = new System.Drawing.Point(59, 43);
            this.emplabel.Name = "emplabel";
            this.emplabel.Size = new System.Drawing.Size(207, 34);
            this.emplabel.TabIndex = 1;
            this.emplabel.Text = "Employee Details";
            // 
            // SearchItemTbox
            // 
            this.SearchItemTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchItemTbox.DefaultText = "";
            this.SearchItemTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchItemTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchItemTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchItemTbox.DisabledState.Parent = this.SearchItemTbox;
            this.SearchItemTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchItemTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchItemTbox.FocusedState.Parent = this.SearchItemTbox;
            this.SearchItemTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.SearchItemTbox.ForeColor = System.Drawing.Color.Black;
            this.SearchItemTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchItemTbox.HoverState.Parent = this.SearchItemTbox;
            this.SearchItemTbox.Location = new System.Drawing.Point(481, 98);
            this.SearchItemTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchItemTbox.Name = "SearchItemTbox";
            this.SearchItemTbox.PasswordChar = '\0';
            this.SearchItemTbox.PlaceholderText = "Start Typing";
            this.SearchItemTbox.SelectedText = "";
            this.SearchItemTbox.ShadowDecoration.Parent = this.SearchItemTbox;
            this.SearchItemTbox.Size = new System.Drawing.Size(228, 36);
            this.SearchItemTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchItemTbox.TabIndex = 4;
            this.SearchItemTbox.TextChanged += new System.EventHandler(this.SearchItemTbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(477, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(781, 514);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gray;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 21;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectangleShape1.Location = new System.Drawing.Point(17, 20);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(745, 474);
            // 
            // empdetailsgridview
            // 
            this.empdetailsgridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.empdetailsgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.empdetailsgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empdetailsgridview.BackgroundColor = System.Drawing.Color.White;
            this.empdetailsgridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empdetailsgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empdetailsgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empdetailsgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.empdetailsgridview.ColumnHeadersHeight = 25;
            this.empdetailsgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empdetailsgridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.empdetailsgridview.EnableHeadersVisualStyles = false;
            this.empdetailsgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empdetailsgridview.Location = new System.Drawing.Point(27, 156);
            this.empdetailsgridview.Name = "empdetailsgridview";
            this.empdetailsgridview.RowHeadersVisible = false;
            this.empdetailsgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empdetailsgridview.Size = new System.Drawing.Size(727, 308);
            this.empdetailsgridview.TabIndex = 6;
            this.empdetailsgridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.empdetailsgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empdetailsgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empdetailsgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empdetailsgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empdetailsgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empdetailsgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empdetailsgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empdetailsgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empdetailsgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empdetailsgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empdetailsgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empdetailsgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empdetailsgridview.ThemeStyle.HeaderStyle.Height = 25;
            this.empdetailsgridview.ThemeStyle.ReadOnly = false;
            this.empdetailsgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empdetailsgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empdetailsgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.empdetailsgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empdetailsgridview.ThemeStyle.RowsStyle.Height = 22;
            this.empdetailsgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empdetailsgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone_No";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            // 
            // UC_EmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.empdetailsgridview);
            this.Controls.Add(this.SearchItemTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emplabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UC_EmpDetails";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_EmpDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label emplabel;
        private Guna.UI2.WinForms.Guna2TextBox SearchItemTbox;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Guna.UI2.WinForms.Guna2DataGridView empdetailsgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
