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


namespace CafeManagement
{
    public partial class LoginReg : Form
    {
        public LoginReg()
        {
            InitializeComponent();

            guna2Button1.Parent = pictureBox1;
            guna2Button1.BackColor = Color.Transparent;

            // var pos = this.PointToScreen(LoaderPanel.Location);
            // pos = RegPanel.PointToClient(pos);
            // LoaderPanel.Location = pos;
            LoaderPanel.Parent = pictureBox1;
            LoaderPanel.BackColor = Color.Transparent;

            //var pos3 =  this.PointToScreen(RegPanel.Location);
            // pos = LoginPanel.PointToClient(pos3);
            // RegPanel.Location = pos3;
            RegPanel.Parent = LoginPanel;
            RegPanel.BackColor = Color.Transparent;

            /* var pos6 = this.PointToScreen(loginbtn.Location);
            pos = pictureBox1.PointToClient(pos6);
            loginbtn.Location = pos6;*/
            loginbtn.Parent = pictureBox1;
            loginbtn.BackColor = Color.Transparent;

           /* var pos7 = this.PointToScreen(Regbtn.Location);
            pos = pictureBox1.PointToClient(pos7);
            Regbtn.Location = pos7;*/
            Regbtn.Parent = pictureBox1;
            Regbtn.BackColor = Color.Transparent;

            // var pos1 = this.PointToScreen(LoginPanel.Location);
            // pos = pictureBox1.PointToClient(pos1);
            LoginPanel.Parent = pictureBox1;
           // LoginPanel.Location = pos1;
            LoginPanel.BackColor = Color.Transparent;

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


        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginPanel.BringToFront();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            RegPanel.BringToFront();
        }

        private void LoginReg_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }

            admincheck();
        }

        private async void admincheck()
        {
            FirebaseResponse getter = await client.GetAsync("admin/isadminexist");
            string isexist = getter.ResultAs<string>();
            if (isexist != null)
            {
                RegPanel.Hide();
                Regbtn.Hide();
            }

            LoaderPanel.Hide();
        }

        private void AdminLoginbtn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTBox.Text) &&
                string.IsNullOrWhiteSpace(PasswordTBox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            #endregion

            FirebaseResponse res = client.Get("admin/admininfo/" + UsernameTBox.Text);
            AdminModel ResUser = res.ResultAs<AdminModel>(); // DB Result


            AdminModel CurUser = new AdminModel() // user given info
            {
                Username = UsernameTBox.Text,
                Password = PasswordTBox.Text,
            };

            if (AdminModel.IsEqual(ResUser, CurUser))
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }

            else
            {
                AdminModel.ShowError();
            }
        }

        private void AdminRegbtn_Click(object sender, EventArgs e)
        {
            string ps = PasswordTboxR.Text;

            #region Condition
            if (
                string.IsNullOrWhiteSpace(FirstnameTbox.Text) &&
                string.IsNullOrWhiteSpace(LastnameTbox.Text) &&
                string.IsNullOrWhiteSpace(UsernameTboxR.Text) &&
                string.IsNullOrWhiteSpace(PasswordTboxR.Text) &&
                string.IsNullOrWhiteSpace(CPassTbox.Text)
                )
            {
                MessageBox.Show("Please Fill All The Fields");
                //return;
            }

            #endregion
            else if (UsernameTboxR.Text.Length < 8)
            {
                MessageBox.Show("Username must contain minimum 8 charaters....!");
            }

            else if (ps.Length < 5)
            {
                MessageBox.Show("Password must contain minimum 5 charaters....!");
            }

            else if(PasswordTboxR.Text != CPassTbox.Text )
            {
                MessageBox.Show("Password Doesnt Match!");
            }

            else
            {
                AdminModel am = new AdminModel()
                {
                    Firstname = FirstnameTbox.Text,
                    Lastname = LastnameTbox.Text,
                    Username = UsernameTboxR.Text,
                    Password = PasswordTboxR.Text,
                };

                var push = client.Set("admin/admininfo/" + UsernameTboxR.Text + "/", am);
                var isadminexist = client.Set("admin/isadminexist", "YES");
                RegPanel.Hide();
                Regbtn.Hide();
                MessageBox.Show("Thank You, " + FirstnameTbox.Text + " " + LastnameTbox.Text + "\nYour Registration is Successfull! \nYou can login now....");

      
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrontPage fs = new FrontPage();
            fs.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
