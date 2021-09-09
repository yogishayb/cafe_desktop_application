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
using FireSharp.Response;
using FireSharp.Interfaces;
using CafeManagement.Models;
using System.Diagnostics;
using System.Threading;

namespace CafeManagement
{
    public partial class LoginRegisterEmp : Form
    {

        public LoginRegisterEmp()
        {
            InitializeComponent();



            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;

            label1.Parent = panel1;
            label1.BackColor = Color.Transparent;

            guna2Button1.Parent = pictureBox1;
            guna2Button1.BackColor = Color.Transparent;

            label11.Parent = panel1;
            label11.BackColor = Color.Transparent;

            Minimize.Parent = pictureBox1;
            Minimize.BackColor = Color.Transparent;

            Close.Parent = pictureBox1;
            Close.BackColor = Color.Transparent;
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void LoginRegisterEmp_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrontPage fs = new FrontPage();
            fs.Show();
            this.Hide();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginEmpbtn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
                string.IsNullOrWhiteSpace(PasswordTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            #endregion

            FirebaseResponse res = client.Get("employee/" + UsernameTbox.Text);
            AdminModel ResUser = res.ResultAs<AdminModel>(); // DB Result


            AdminModel CurUser = new AdminModel() // user given info
            {
                Username = UsernameTbox.Text,
                Password = PasswordTbox.Text,
            };

            if (AdminModel.IsEqual(ResUser, CurUser))
            {
                Dashboard ds = new Dashboard(ResUser.Username);
                ds.Show();
                this.Hide();
            }

            else
            {
                AdminModel.ShowError();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
             EmpLoginReg em = new EmpLoginReg();
             em.Show();
             this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                PasswordTbox.PasswordChar = '\0';
            }
            else
            {
                PasswordTbox.PasswordChar = '*';
            }
        }
    }
}
