
namespace CafeManagement.AllUserControls
{
    partial class UC_PlaceOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorycombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemlistbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityselector = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.addtocartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cartgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removebtn = new Guna.UI2.WinForms.Guna2Button();
            this.printbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grandtotallabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantityselector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartgridview)).BeginInit();
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // categorycombo
            // 
            this.categorycombo.BackColor = System.Drawing.Color.Transparent;
            this.categorycombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categorycombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorycombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorycombo.FocusedState.Parent = this.categorycombo;
            this.categorycombo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombo.ForeColor = System.Drawing.Color.Black;
            this.categorycombo.HoverState.Parent = this.categorycombo;
            this.categorycombo.ItemHeight = 30;
            this.categorycombo.ItemsAppearance.Parent = this.categorycombo;
            this.categorycombo.Location = new System.Drawing.Point(24, 93);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.ShadowDecoration.Parent = this.categorycombo;
            this.categorycombo.Size = new System.Drawing.Size(140, 36);
            this.categorycombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.categorycombo.TabIndex = 2;
            this.categorycombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categorycombo.SelectedIndexChanged += new System.EventHandler(this.categorycombo_SelectedIndexChanged);
            // 
            // searchTbox
            // 
            this.searchTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTbox.DefaultText = "";
            this.searchTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTbox.DisabledState.Parent = this.searchTbox;
            this.searchTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTbox.FocusedState.Parent = this.searchTbox;
            this.searchTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTbox.ForeColor = System.Drawing.Color.Black;
            this.searchTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTbox.HoverState.Parent = this.searchTbox;
            this.searchTbox.Location = new System.Drawing.Point(24, 136);
            this.searchTbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTbox.Name = "searchTbox";
            this.searchTbox.PasswordChar = '\0';
            this.searchTbox.PlaceholderText = "Search";
            this.searchTbox.SelectedText = "";
            this.searchTbox.ShadowDecoration.Parent = this.searchTbox;
            this.searchTbox.Size = new System.Drawing.Size(140, 36);
            this.searchTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.searchTbox.TabIndex = 3;
            this.searchTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTbox.TextChanged += new System.EventHandler(this.searchTbox_TextChanged);
            // 
            // itemlistbox
            // 
            this.itemlistbox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemlistbox.FormattingEnabled = true;
            this.itemlistbox.ItemHeight = 18;
            this.itemlistbox.Location = new System.Drawing.Point(21, 188);
            this.itemlistbox.Name = "itemlistbox";
            this.itemlistbox.Size = new System.Drawing.Size(143, 292);
            this.itemlistbox.TabIndex = 4;
            this.itemlistbox.Click += new System.EventHandler(this.itemlistbox_Click);
            this.itemlistbox.SelectedIndexChanged += new System.EventHandler(this.itemlistbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total";
            // 
            // itemTbox
            // 
            this.itemTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemTbox.DefaultText = "";
            this.itemTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemTbox.DisabledState.Parent = this.itemTbox;
            this.itemTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemTbox.FocusedState.Parent = this.itemTbox;
            this.itemTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTbox.ForeColor = System.Drawing.Color.Black;
            this.itemTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemTbox.HoverState.Parent = this.itemTbox;
            this.itemTbox.Location = new System.Drawing.Point(225, 82);
            this.itemTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemTbox.Name = "itemTbox";
            this.itemTbox.PasswordChar = '\0';
            this.itemTbox.PlaceholderText = "";
            this.itemTbox.SelectedText = "";
            this.itemTbox.ShadowDecoration.Parent = this.itemTbox;
            this.itemTbox.Size = new System.Drawing.Size(219, 36);
            this.itemTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itemTbox.TabIndex = 9;
            // 
            // priceTbox
            // 
            this.priceTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTbox.DefaultText = "";
            this.priceTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTbox.DisabledState.Parent = this.priceTbox;
            this.priceTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTbox.FocusedState.Parent = this.priceTbox;
            this.priceTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTbox.ForeColor = System.Drawing.Color.Black;
            this.priceTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTbox.HoverState.Parent = this.priceTbox;
            this.priceTbox.Location = new System.Drawing.Point(510, 82);
            this.priceTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTbox.Name = "priceTbox";
            this.priceTbox.PasswordChar = '\0';
            this.priceTbox.PlaceholderText = "";
            this.priceTbox.SelectedText = "";
            this.priceTbox.ShadowDecoration.Parent = this.priceTbox;
            this.priceTbox.Size = new System.Drawing.Size(219, 36);
            this.priceTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.priceTbox.TabIndex = 10;
            // 
            // totalTbox
            // 
            this.totalTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalTbox.DefaultText = "";
            this.totalTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalTbox.DisabledState.Parent = this.totalTbox;
            this.totalTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalTbox.FocusedState.Parent = this.totalTbox;
            this.totalTbox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTbox.ForeColor = System.Drawing.Color.Black;
            this.totalTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalTbox.HoverState.Parent = this.totalTbox;
            this.totalTbox.Location = new System.Drawing.Point(510, 153);
            this.totalTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalTbox.Name = "totalTbox";
            this.totalTbox.PasswordChar = '\0';
            this.totalTbox.PlaceholderText = "";
            this.totalTbox.SelectedText = "";
            this.totalTbox.ShadowDecoration.Parent = this.totalTbox;
            this.totalTbox.Size = new System.Drawing.Size(219, 36);
            this.totalTbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.totalTbox.TabIndex = 11;
            // 
            // quantityselector
            // 
            this.quantityselector.BackColor = System.Drawing.Color.Transparent;
            this.quantityselector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityselector.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityselector.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityselector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityselector.DisabledState.Parent = this.quantityselector;
            this.quantityselector.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.quantityselector.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.quantityselector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityselector.FocusedState.Parent = this.quantityselector;
            this.quantityselector.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityselector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quantityselector.Location = new System.Drawing.Point(225, 156);
            this.quantityselector.Name = "quantityselector";
            this.quantityselector.ShadowDecoration.Parent = this.quantityselector;
            this.quantityselector.Size = new System.Drawing.Size(219, 36);
            this.quantityselector.TabIndex = 12;
            this.quantityselector.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.quantityselector.ValueChanged += new System.EventHandler(this.quantityselector_ValueChanged);
            // 
            // addtocartBtn
            // 
            this.addtocartBtn.BorderRadius = 21;
            this.addtocartBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.addtocartBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.addtocartBtn.CheckedState.Parent = this.addtocartBtn;
            this.addtocartBtn.CustomImages.Parent = this.addtocartBtn;
            this.addtocartBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.addtocartBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartBtn.ForeColor = System.Drawing.Color.White;
            this.addtocartBtn.HoverState.Parent = this.addtocartBtn;
            this.addtocartBtn.Location = new System.Drawing.Point(530, 201);
            this.addtocartBtn.Name = "addtocartBtn";
            this.addtocartBtn.ShadowDecoration.Parent = this.addtocartBtn;
            this.addtocartBtn.Size = new System.Drawing.Size(180, 45);
            this.addtocartBtn.TabIndex = 13;
            this.addtocartBtn.Text = "Add To Cart";
            this.addtocartBtn.Click += new System.EventHandler(this.addtocartBtn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(781, 514);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 30;
            this.rectangleShape1.Location = new System.Drawing.Point(186, 32);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(581, 231);
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
            this.cartgridview.Location = new System.Drawing.Point(186, 280);
            this.cartgridview.Name = "cartgridview";
            this.cartgridview.RowHeadersVisible = false;
            this.cartgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartgridview.Size = new System.Drawing.Size(582, 150);
            this.cartgridview.TabIndex = 15;
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
            this.cartgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartgridview_CellContentClick);
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
            // removebtn
            // 
            this.removebtn.BorderRadius = 21;
            this.removebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.removebtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.removebtn.CheckedState.Parent = this.removebtn;
            this.removebtn.CustomImages.Parent = this.removebtn;
            this.removebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.removebtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.HoverState.Parent = this.removebtn;
            this.removebtn.Location = new System.Drawing.Point(185, 446);
            this.removebtn.Name = "removebtn";
            this.removebtn.ShadowDecoration.Parent = this.removebtn;
            this.removebtn.Size = new System.Drawing.Size(156, 45);
            this.removebtn.TabIndex = 16;
            this.removebtn.Text = "Remove";
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.BorderRadius = 21;
            this.printbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.printbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.printbtn.CheckedState.Parent = this.printbtn;
            this.printbtn.CustomImages.Parent = this.printbtn;
            this.printbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.printbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.HoverState.Parent = this.printbtn;
            this.printbtn.Location = new System.Drawing.Point(611, 446);
            this.printbtn.Name = "printbtn";
            this.printbtn.ShadowDecoration.Parent = this.printbtn;
            this.printbtn.Size = new System.Drawing.Size(156, 45);
            this.printbtn.TabIndex = 17;
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grand Total";
            // 
            // grandtotallabel
            // 
            this.grandtotallabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grandtotallabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotallabel.Location = new System.Drawing.Point(414, 456);
            this.grandtotallabel.Name = "grandtotallabel";
            this.grandtotallabel.Size = new System.Drawing.Size(122, 35);
            this.grandtotallabel.TabIndex = 19;
            this.grandtotallabel.Text = "Rs 00";
            this.grandtotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.grandtotallabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.cartgridview);
            this.Controls.Add(this.addtocartBtn);
            this.Controls.Add(this.quantityselector);
            this.Controls.Add(this.totalTbox);
            this.Controls.Add(this.priceTbox);
            this.Controls.Add(this.itemTbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemlistbox);
            this.Controls.Add(this.searchTbox);
            this.Controls.Add(this.categorycombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityselector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListBox itemlistbox;
        private Guna.UI2.WinForms.Guna2TextBox searchTbox;
        private Guna.UI2.WinForms.Guna2ComboBox categorycombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grandtotallabel;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button printbtn;
        private Guna.UI2.WinForms.Guna2Button removebtn;
        private Guna.UI2.WinForms.Guna2DataGridView cartgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button addtocartBtn;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantityselector;
        private Guna.UI2.WinForms.Guna2TextBox totalTbox;
        private Guna.UI2.WinForms.Guna2TextBox priceTbox;
        private Guna.UI2.WinForms.Guna2TextBox itemTbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
