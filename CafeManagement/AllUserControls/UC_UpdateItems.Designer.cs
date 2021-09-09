
namespace CafeManagement.AllUserControls
{
    partial class UC_UpdateItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchItemTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.updategridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.updategridview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(515, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
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
            this.SearchItemTbox.Location = new System.Drawing.Point(519, 79);
            this.SearchItemTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchItemTbox.Name = "SearchItemTbox";
            this.SearchItemTbox.PasswordChar = '\0';
            this.SearchItemTbox.PlaceholderText = "Start Typing";
            this.SearchItemTbox.SelectedText = "";
            this.SearchItemTbox.ShadowDecoration.Parent = this.SearchItemTbox;
            this.SearchItemTbox.Size = new System.Drawing.Size(228, 36);
            this.SearchItemTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SearchItemTbox.TabIndex = 2;
            this.SearchItemTbox.TextChanged += new System.EventHandler(this.SearchItemTbox_TextChanged);
            // 
            // updategridview
            // 
            this.updategridview.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.updategridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.updategridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updategridview.BackgroundColor = System.Drawing.Color.White;
            this.updategridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updategridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.updategridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.updategridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.updategridview.ColumnHeadersHeight = 25;
            this.updategridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.updategridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.updategridview.EnableHeadersVisualStyles = false;
            this.updategridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.updategridview.Location = new System.Drawing.Point(33, 123);
            this.updategridview.Name = "updategridview";
            this.updategridview.RowHeadersVisible = false;
            this.updategridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updategridview.Size = new System.Drawing.Size(727, 203);
            this.updategridview.TabIndex = 3;
            this.updategridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.updategridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.updategridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.updategridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.updategridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.updategridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.updategridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.updategridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.updategridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updategridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.updategridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.updategridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.updategridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.updategridview.ThemeStyle.HeaderStyle.Height = 25;
            this.updategridview.ThemeStyle.ReadOnly = false;
            this.updategridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.updategridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.updategridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.updategridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.updategridview.ThemeStyle.RowsStyle.Height = 22;
            this.updategridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.updategridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.updategridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updategridview_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "I.No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item_name";
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
            // nameTbox
            // 
            this.nameTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTbox.DefaultText = "";
            this.nameTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTbox.DisabledState.Parent = this.nameTbox;
            this.nameTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTbox.FocusedState.Parent = this.nameTbox;
            this.nameTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.nameTbox.ForeColor = System.Drawing.Color.Black;
            this.nameTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTbox.HoverState.Parent = this.nameTbox;
            this.nameTbox.Location = new System.Drawing.Point(98, 372);
            this.nameTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.PasswordChar = '\0';
            this.nameTbox.PlaceholderText = "Item Name";
            this.nameTbox.SelectedText = "";
            this.nameTbox.ShadowDecoration.Parent = this.nameTbox;
            this.nameTbox.Size = new System.Drawing.Size(241, 36);
            this.nameTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nameTbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(94, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Name";
            // 
            // PriceTbox
            // 
            this.PriceTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTbox.DefaultText = "";
            this.PriceTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTbox.DisabledState.Parent = this.PriceTbox;
            this.PriceTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTbox.FocusedState.Parent = this.PriceTbox;
            this.PriceTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.PriceTbox.ForeColor = System.Drawing.Color.Black;
            this.PriceTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTbox.HoverState.Parent = this.PriceTbox;
            this.PriceTbox.Location = new System.Drawing.Point(520, 372);
            this.PriceTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceTbox.Name = "PriceTbox";
            this.PriceTbox.PasswordChar = '\0';
            this.PriceTbox.PlaceholderText = "Price";
            this.PriceTbox.SelectedText = "";
            this.PriceTbox.ShadowDecoration.Parent = this.PriceTbox;
            this.PriceTbox.Size = new System.Drawing.Size(241, 36);
            this.PriceTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceTbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(516, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BorderRadius = 21;
            this.Updatebtn.CheckedState.Parent = this.Updatebtn;
            this.Updatebtn.CustomImages.Parent = this.Updatebtn;
            this.Updatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.Updatebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.HoverState.Parent = this.Updatebtn;
            this.Updatebtn.Location = new System.Drawing.Point(315, 435);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.ShadowDecoration.Parent = this.Updatebtn;
            this.Updatebtn.Size = new System.Drawing.Size(180, 45);
            this.Updatebtn.TabIndex = 10;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(794, 514);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleShape2.CornerRadius = 21;
            this.rectangleShape2.Location = new System.Drawing.Point(45, 36);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(203, 47);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gray;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 21;
            this.rectangleShape1.Location = new System.Drawing.Point(17, 16);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(757, 485);
            // 
            // UC_UpdateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.PriceTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updategridview);
            this.Controls.Add(this.SearchItemTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UC_UpdateItems";
            this.Size = new System.Drawing.Size(794, 514);
            this.Load += new System.EventHandler(this.UC_UpdateItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updategridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2TextBox PriceTbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox nameTbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView updategridview;
        private Guna.UI2.WinForms.Guna2TextBox SearchItemTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
