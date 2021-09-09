using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using CafeManagement.Models;

namespace CafeManagement
{
    public partial class Dashboard : Form
    {
        public bool isemp = false;
        public static string username = null;
        bool isadmin = false;
        public Dashboard()
        {
            InitializeComponent();
            btnAddItems.Show();
            btnUpdate.Show();
            btnRemove.Show();
            yourprofilebtn.Hide();
            btnNotification.Show();
        }

        public Dashboard(string username1)
        {
            InitializeComponent();
            username = username1;
            btnAddItems.Hide();
            btnUpdate.Hide();
            btnRemove.Hide();
            deleteAdminbtn.Hide();
            QRbtn.Hide();
            empdetailsbtn.Hide();
            btnNotification.Show();
            
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrontPage fm = new FrontPage();
            username = null;
            this.Hide();
            fm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }

            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_DeleteItems1.Visible = false;
            uC_QrGenerate1.Visible = false;
            uC_EmpDetails1.Visible = false;
            uC_Profile1.Visible = false;
            

        }

        private void deleteAdminbtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are You Sure TO Delete Your Account ...? ", "Delete Admin Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var del = client.Delete("admin/");
                this.Close();

                FrontPage fe = new FrontPage();
                fe.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();

            uC_AddItems1.clearcomboindex();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            

            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();

            uC_PlaceOrder1.clearlist();
            uC_PlaceOrder1.loadcombobox();
            
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();

            uC_UpdateItems1.loadgridview();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_DeleteItems1.Visible = true;
            uC_DeleteItems1.BringToFront();

            uC_DeleteItems1.loadgridview();
        }

        private void QRbtn_Click(object sender, EventArgs e)
        {
            uC_QrGenerate1.Visible = true;
            uC_QrGenerate1.BringToFront();
        }

        private void empdetailsbtn_Click_1(object sender, EventArgs e)
        {
            uC_EmpDetails1.Visible = true;
            uC_EmpDetails1.BringToFront();

            uC_EmpDetails1.loadgridview();
        }

        private void yourprofilebtn_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();

            uC_Profile1.getempinfo(username);
        }

        private void uC_Profile1_Load(object sender, EventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            
            pendingOrders po = new pendingOrders();
            po.Show();
            this.Hide();
            
        }
    }
}
