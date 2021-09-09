
namespace CafeManagement.AllUserControls
{
    partial class UC_DeleteItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchItemTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.deletegridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.deletelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deletegridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Item";
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
            this.SearchItemTbox.Location = new System.Drawing.Point(453, 105);
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
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.Black;
            this.namelabel.Location = new System.Drawing.Point(448, 73);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(112, 27);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Item Name";
            // 
            // deletegridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.deletegridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deletegridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletegridview.BackgroundColor = System.Drawing.Color.White;
            this.deletegridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deletegridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deletegridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deletegridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.deletegridview.ColumnHeadersHeight = 20;
            this.deletegridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.deletegridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.deletegridview.EnableHeadersVisualStyles = false;
            this.deletegridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deletegridview.Location = new System.Drawing.Point(29, 161);
            this.deletegridview.Name = "deletegridview";
            this.deletegridview.RowHeadersVisible = false;
            this.deletegridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletegridview.Size = new System.Drawing.Size(719, 258);
            this.deletegridview.TabIndex = 5;
            this.deletegridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.deletegridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.deletegridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.deletegridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.deletegridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.deletegridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.deletegridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.deletegridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deletegridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.deletegridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.deletegridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.deletegridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.deletegridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.deletegridview.ThemeStyle.HeaderStyle.Height = 20;
            this.deletegridview.ThemeStyle.ReadOnly = false;
            this.deletegridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.deletegridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deletegridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.deletegridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.deletegridview.ThemeStyle.RowsStyle.Height = 22;
            this.deletegridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deletegridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.deletegridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletegridview_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item_Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(781, 514);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gray;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 21;
            this.rectangleShape1.Location = new System.Drawing.Point(11, 14);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(752, 485);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // deletebtn
            // 
            this.deletebtn.BorderRadius = 20;
            this.deletebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.deletebtn.CheckedState.Parent = this.deletebtn;
            this.deletebtn.CustomImages.Parent = this.deletebtn;
            this.deletebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.HoverState.Parent = this.deletebtn;
            this.deletebtn.Location = new System.Drawing.Point(462, 431);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ShadowDecoration.Parent = this.deletebtn;
            this.deletebtn.Size = new System.Drawing.Size(180, 45);
            this.deletebtn.TabIndex = 8;
            this.deletebtn.Text = "Delete";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // deletelabel
            // 
            this.deletelabel.AutoSize = true;
            this.deletelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletelabel.Location = new System.Drawing.Point(111, 450);
            this.deletelabel.Name = "deletelabel";
            this.deletelabel.Size = new System.Drawing.Size(228, 20);
            this.deletelabel.TabIndex = 9;
            this.deletelabel.Text = "Select the above item to delete";
            // 
            // UC_DeleteItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.deletelabel);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.deletegridview);
            this.Controls.Add(this.SearchItemTbox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UC_DeleteItems";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_DeleteItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletegridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SearchItemTbox;
        private System.Windows.Forms.Label namelabel;
        private Guna.UI2.WinForms.Guna2DataGridView deletegridview;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button deletebtn;
        private System.Windows.Forms.Label deletelabel;
    }
}
