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
    public partial class EmpLoginReg : Form
    {
        public EmpLoginReg()
        {
            InitializeComponent();

            EmpRegPanel.Parent = pictureBox1;
            EmpRegPanel.BackColor = Color.Transparent;

            guna2Button1.Parent = pictureBox1;
            guna2Button1.BackColor = Color.Transparent;

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

        private void EmpLoginReg_Load(object sender, EventArgs e)
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

        private void passwordTboxR_Leave(object sender, EventArgs e)
        {
            string ps = passwordTboxR.Text;
            if(ps.Length < 5)
            {
                MessageBox.Show("Password must contain minimum 5 charaters....!" );
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


        private void label13_Click_1(object sender, EventArgs e)
        {
            
            LoginRegisterEmp lg = new LoginRegisterEmp();
            lg.Show();
            this.Hide();
        }

        private void RegEmpbtn_Click_1(object sender, EventArgs e)
        {
            string ps = passwordTboxR.Text;

            #region Condition
            if (
                string.IsNullOrWhiteSpace(fullnameTbox.Text) &&
                string.IsNullOrWhiteSpace(emailTbox.Text) &&
                string.IsNullOrWhiteSpace(usernameTboxR.Text) &&
                string.IsNullOrWhiteSpace(passwordTboxR.Text) &&
                string.IsNullOrWhiteSpace(confirmpasswordTboxR.Text)&&
                string.IsNullOrWhiteSpace(genderCbox.Text) &&
                string.IsNullOrWhiteSpace(phoneTbox.Text) &&
                string.IsNullOrWhiteSpace(addressTbox.Text)
                )
            {
                MessageBox.Show("Please Fill All The Fields");
                //return;
            }

            #endregion

            else if (!Validationfunctions.isemail(emailTbox.Text))
            {
                MessageBox.Show("Enter the email in correct pattern...!");
            }

            else if (isuserexist(usernameTboxR.Text))
            {
                MessageBox.Show("Username already taken..!");
            }

            else if (usernameTboxR.Text.Length < 8)
            {
                MessageBox.Show("Username must contain minimum 8 charaters....!");
            }

            else if (ps.Length < 5)
            {
                MessageBox.Show("Password must contain minimum 5 charaters....!");
            }

            else if (passwordTboxR.Text != confirmpasswordTboxR.Text)
            {
                MessageBox.Show("Password Doesnt Match!");
            }

            else
            {
                EmpModel emp = new EmpModel()
                {
                    Fullname = fullnameTbox.Text,
                    Email = emailTbox.Text,
                    Username = usernameTboxR.Text,
                    Password = passwordTboxR.Text,
                    Gender = genderCbox.Text,
                    PhoneNo = phoneTbox.Text,
                    Address = addressTbox.Text,
                };

                var setter = client.Set("employee/" + usernameTboxR.Text + "/", emp);
                MessageBox.Show("Thank You, " + fullnameTbox.Text + "\nYour Registration Is Successfull,\nYou Can Login Now...!");
                EmpRegPanel.BringToFront();

                fullnameTbox.Text = "";
                emailTbox.Text = "";
                usernameTboxR.Text = "";
                passwordTboxR.Text = "";
                confirmpasswordTboxR.Text = "";
                genderCbox.SelectedIndex = -1;
                phoneTbox.Text = "";
                addressTbox.Text = "";
            }
        }

        public bool isuserexist(string user)
        {
            var getter = client.Get("employee/" + user);
            EmpModel emp = getter.ResultAs<EmpModel>();

            if (emp != null)
            {
                return true;
            }
            return false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                confirmpasswordTboxR.PasswordChar = '\0';
            }
            else
            {
                confirmpasswordTboxR.PasswordChar = '*';
            }
        }

        private void phoneTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
