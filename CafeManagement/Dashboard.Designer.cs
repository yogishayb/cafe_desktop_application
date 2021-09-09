
namespace CafeManagement
{
    partial class Dashboard
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotification = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.yourprofilebtn = new Guna.UI2.WinForms.Guna2Button();
            this.empdetailsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteAdminbtn = new Guna.UI2.WinForms.Guna2Button();
            this.QRbtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse10 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse11 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            //this.guna2Elipse12 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Profile1 = new CafeManagement.AllUserControls.UC_Profile();
            this.uC_EmpDetails1 = new CafeManagement.AllUserControls.UC_EmpDetails();
            this.uC_QrGenerate1 = new CafeManagement.AllUserControls.UC_QrGenerate();
            this.uC_DeleteItems1 = new CafeManagement.AllUserControls.UC_DeleteItems();
            this.uC_UpdateItems1 = new CafeManagement.AllUserControls.UC_UpdateItems();
            this.uC_PlaceOrder1 = new CafeManagement.AllUserControls.UC_PlaceOrder();
            this.uC_AddItems1 = new CafeManagement.AllUserControls.UC_AddItems();
            this.uC_Welcome1 = new CafeManagement.AllUserControls.UC_Welcome();
            //this.uC_Notifications1 = new CafeManagement.AllUserControls.UC_Notifications();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnNotification);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.yourprofilebtn);
            this.panel1.Controls.Add(this.empdetailsbtn);
            this.panel1.Controls.Add(this.deleteAdminbtn);
            this.panel1.Controls.Add(this.QRbtn);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            // 
            // btnNotification
            // 
            this.btnNotification.BorderRadius = 15;
            this.btnNotification.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNotification.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNotification.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnNotification.CheckedState.Parent = this.btnNotification;
            this.btnNotification.CustomImages.Parent = this.btnNotification;
            this.guna2Transition1.SetDecoration(this.btnNotification, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNotification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.HoverState.Parent = this.btnNotification;
            this.btnNotification.Location = new System.Drawing.Point(25, 140);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.ShadowDecoration.Parent = this.btnNotification;
            this.btnNotification.Size = new System.Drawing.Size(202, 41);
            this.btnNotification.TabIndex = 8;
            this.btnNotification.Text = "Notification";
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // Minimize
            // 
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.guna2Transition1.SetDecoration(this.Minimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(44, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(38, 35);
            this.Minimize.TabIndex = 6;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // yourprofilebtn
            // 
            this.yourprofilebtn.BorderRadius = 15;
            this.yourprofilebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.yourprofilebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.yourprofilebtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.yourprofilebtn.CheckedState.Parent = this.yourprofilebtn;
            this.yourprofilebtn.CustomImages.Parent = this.yourprofilebtn;
            this.guna2Transition1.SetDecoration(this.yourprofilebtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.yourprofilebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.yourprofilebtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourprofilebtn.ForeColor = System.Drawing.Color.White;
            this.yourprofilebtn.HoverState.Parent = this.yourprofilebtn;
            this.yourprofilebtn.Location = new System.Drawing.Point(25, 41);
            this.yourprofilebtn.Name = "yourprofilebtn";
            this.yourprofilebtn.ShadowDecoration.Parent = this.yourprofilebtn;
            this.yourprofilebtn.Size = new System.Drawing.Size(202, 41);
            this.yourprofilebtn.TabIndex = 9;
            this.yourprofilebtn.Text = "Profile";
            this.yourprofilebtn.Click += new System.EventHandler(this.yourprofilebtn_Click);
            // 
            // empdetailsbtn
            // 
            this.empdetailsbtn.BorderRadius = 15;
            this.empdetailsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.empdetailsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.empdetailsbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.empdetailsbtn.CheckedState.Parent = this.empdetailsbtn;
            this.empdetailsbtn.CustomImages.Parent = this.empdetailsbtn;
            this.guna2Transition1.SetDecoration(this.empdetailsbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.empdetailsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.empdetailsbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdetailsbtn.ForeColor = System.Drawing.Color.White;
            this.empdetailsbtn.HoverState.Parent = this.empdetailsbtn;
            this.empdetailsbtn.Location = new System.Drawing.Point(25, 328);
            this.empdetailsbtn.Name = "empdetailsbtn";
            this.empdetailsbtn.ShadowDecoration.Parent = this.empdetailsbtn;
            this.empdetailsbtn.Size = new System.Drawing.Size(202, 41);
            this.empdetailsbtn.TabIndex = 8;
            this.empdetailsbtn.Text = "Employee Details";
            this.empdetailsbtn.Click += new System.EventHandler(this.empdetailsbtn_Click_1);
            // 
            // deleteAdminbtn
            // 
            this.deleteAdminbtn.BorderRadius = 15;
            this.deleteAdminbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.deleteAdminbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.deleteAdminbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.deleteAdminbtn.CheckedState.Parent = this.deleteAdminbtn;
            this.deleteAdminbtn.CustomImages.Parent = this.deleteAdminbtn;
            this.guna2Transition1.SetDecoration(this.deleteAdminbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.deleteAdminbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.deleteAdminbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdminbtn.ForeColor = System.Drawing.Color.White;
            this.deleteAdminbtn.HoverState.Parent = this.deleteAdminbtn;
            this.deleteAdminbtn.Location = new System.Drawing.Point(25, 426);
            this.deleteAdminbtn.Name = "deleteAdminbtn";
            this.deleteAdminbtn.ShadowDecoration.Parent = this.deleteAdminbtn;
            this.deleteAdminbtn.Size = new System.Drawing.Size(202, 41);
            this.deleteAdminbtn.TabIndex = 7;
            this.deleteAdminbtn.Text = "Delete Admin";
            this.deleteAdminbtn.Click += new System.EventHandler(this.deleteAdminbtn_Click);
            // 
            // QRbtn
            // 
            this.QRbtn.BorderRadius = 15;
            this.QRbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.QRbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.QRbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.QRbtn.CheckedState.Parent = this.QRbtn;
            this.QRbtn.CustomImages.Parent = this.QRbtn;
            this.guna2Transition1.SetDecoration(this.QRbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.QRbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.QRbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRbtn.ForeColor = System.Drawing.Color.White;
            this.QRbtn.HoverState.Parent = this.QRbtn;
            this.QRbtn.Location = new System.Drawing.Point(25, 379);
            this.QRbtn.Name = "QRbtn";
            this.QRbtn.ShadowDecoration.Parent = this.QRbtn;
            this.QRbtn.Size = new System.Drawing.Size(202, 41);
            this.QRbtn.TabIndex = 6;
            this.QRbtn.Text = "QR Generate";
            this.QRbtn.Click += new System.EventHandler(this.QRbtn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.LinkColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(21, 482);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(62, 20);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(38, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.guna2Transition1.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(25, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(202, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Items";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 15;
            this.btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.guna2Transition1.SetDecoration(this.btnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(25, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(202, 41);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Items";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BorderRadius = 15;
            this.btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItems.CheckedState.Parent = this.btnAddItems;
            this.btnAddItems.CustomImages.Parent = this.btnAddItems;
            this.guna2Transition1.SetDecoration(this.btnAddItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.HoverState.Parent = this.btnAddItems;
            this.btnAddItems.Location = new System.Drawing.Point(25, 187);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.ShadowDecoration.Parent = this.btnAddItems;
            this.btnAddItems.Size = new System.Drawing.Size(202, 41);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 15;
            this.btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaceOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlaceOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlaceOrder.CheckedState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.CustomImages.Parent = this.btnPlaceOrder;
            this.guna2Transition1.SetDecoration(this.btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.HoverState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(25, 88);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.ShadowDecoration.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Size = new System.Drawing.Size(202, 41);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            //this.panel2.Controls.Add(this.uC_Notifications1);
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_EmpDetails1);
            this.panel2.Controls.Add(this.uC_QrGenerate1);
            this.panel2.Controls.Add(this.uC_DeleteItems1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItems1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(211, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 30;
            this.guna2Elipse8.TargetControl = this.panel2;
            // 
            // guna2Elipse9
            // 
            this.guna2Elipse9.BorderRadius = 30;
            this.guna2Elipse9.TargetControl = this.panel2;
            // 
            // guna2Elipse11
            // 
            this.guna2Elipse11.BorderRadius = 30;
            this.guna2Elipse11.TargetControl = this.panel2;
            // 
            // guna2Elipse12
            // 
            /*this.guna2Elipse12.BorderRadius = 30;
            this.guna2Elipse12.TargetControl = this.panel2;*/
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_Profile1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(781, 514);
            this.uC_Profile1.TabIndex = 7;
            this.uC_Profile1.Load += new System.EventHandler(this.uC_Profile1_Load);
            // 
            // uC_EmpDetails1
            // 
            this.uC_EmpDetails1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_EmpDetails1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_EmpDetails1.Location = new System.Drawing.Point(0, 0);
            this.uC_EmpDetails1.Name = "uC_EmpDetails1";
            this.uC_EmpDetails1.Size = new System.Drawing.Size(781, 514);
            this.uC_EmpDetails1.TabIndex = 6;
            // 
            // uC_QrGenerate1
            // 
            this.uC_QrGenerate1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_QrGenerate1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_QrGenerate1.Location = new System.Drawing.Point(0, 0);
            this.uC_QrGenerate1.Name = "uC_QrGenerate1";
            this.uC_QrGenerate1.Size = new System.Drawing.Size(781, 514);
            this.uC_QrGenerate1.TabIndex = 5;
            // 
            // uC_DeleteItems1
            // 
            this.uC_DeleteItems1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_DeleteItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_DeleteItems1.Location = new System.Drawing.Point(-3, 0);
            this.uC_DeleteItems1.Name = "uC_DeleteItems1";
            this.uC_DeleteItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_DeleteItems1.TabIndex = 4;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(781, 514);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.White;
            this.uC_AddItems1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.uC_AddItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddItems1.Location = new System.Drawing.Point(0, -3);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(0, -3);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // uC_Notifications1
            // 
            /*this.uC_Notifications1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Transition1.SetDecoration(this.uC_Notifications1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Notifications1.Location = new System.Drawing.Point(0, 0);
            this.uC_Notifications1.Name = "uC_Notifications1";
            this.uC_Notifications1.Size = new System.Drawing.Size(781, 514);
            this.uC_Notifications1.TabIndex = 8;*/
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Button deleteAdminbtn;
        private Guna.UI2.WinForms.Guna2Button QRbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Button empdetailsbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControls.UC_DeleteItems uC_DeleteItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private AllUserControls.UC_QrGenerate uC_QrGenerate1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse9;
        private AllUserControls.UC_EmpDetails uC_EmpDetails1;
        private Guna.UI2.WinForms.Guna2Button yourprofilebtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse11;
        private AllUserControls.UC_Profile uC_Profile1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton Minimize;
        private Guna.UI2.WinForms.Guna2Button btnNotification;
        //private Guna.UI2.WinForms.Guna2Elipse guna2Elipse12;
        //private AllUserControls.UC_Notifications uC_Notifications1;
    }
}