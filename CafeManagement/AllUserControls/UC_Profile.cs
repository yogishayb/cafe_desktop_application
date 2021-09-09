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

namespace CafeManagement.AllUserControls
{

    public partial class UC_Profile : UserControl
    {
        public string Curempusername = null;
        public UC_Profile()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;

        private void Profile_Load(object sender, EventArgs e)
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

        private void selectbtn_Click(object sender, EventArgs e)
        {
           
        }

        public void getempinfo(string Curusername)
        {
            var result = client.Get("employee/");
            Dictionary<string, EmpModel> StudentDict = result.ResultAs<Dictionary<string, EmpModel>>();
            Curempusername = Curusername;
            
            bool isuserexist = false;
            foreach (EmpModel s in StudentDict.Values)
            {


                if (Curempusername == s.Username)
                {
                    isuserexist = true;
                    fullnameTbox.Text = s.Fullname;
                    emailTbox.Text = s.Email;
                    usernameTboxR.Text = s.Username;
                    passwordTboxR.Text = s.Password;
                    genderTbox.Text = s.Gender;
                    phoneTbox.Text = s.PhoneNo;
                    addressTbox.Text = s.Address;
                }


            }
            if (!isuserexist)
            {
                MessageBox.Show("Username Does Not Exist...!");
            }
           /* else
            {
                MessageBox.Show("Data Retrived....");
            }*/
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            var result = client.Get("employee/");
            Dictionary<string, EmpModel> StudentDict = result.ResultAs<Dictionary<string, EmpModel>> ();
            
            bool isuserexist = false;
            foreach (EmpModel s in StudentDict.Values)
            {


                if (Curempusername == s.Username)
                {
                    isuserexist = true;


                    EmpModel std = new EmpModel()
                    {
                        Fullname = fullnameTbox.Text,
                        Email = emailTbox.Text,
                        Username = s.Username,
                        Password = passwordTboxR.Text,
                        Gender = genderTbox.Text,
                        PhoneNo = phoneTbox.Text,
                        Address = addressTbox.Text
                         
                    };

                    var setter = client.Update("employee/" + s.Username + "/", std);
                    
                }

            }
            if (!isuserexist)
            {
                MessageBox.Show(" Username Does Not Exist...!");
            }
            else
            {
                MessageBox.Show("Data Updated....");
            }

            

        }   
    }
}
