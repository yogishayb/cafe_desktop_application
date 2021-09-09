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


namespace CafeManagement.AllUserControls
{
    public partial class UC_EmpDetails : UserControl
    {
        List<EmpModel> emplist = new List<EmpModel>();
        EmpModel selecteddetails;
        Dictionary<string, EmpModel> StudentDict;

        public UC_EmpDetails()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;

        private void UC_EmpDetails_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }
            loadgridview();
        }

        public void loadgridview()
        {
            FirebaseResponse result = client.Get("employee/");

            StudentDict = result.ResultAs<Dictionary<string, EmpModel>>();


            empdetailsgridview.DataSource = null;
            empdetailsgridview.Rows.Clear();
            int count = 1;

            if (StudentDict != null)
            {
                foreach (EmpModel s in StudentDict.Values)
                {
                    emplist.Add(s);
                    empdetailsgridview.Rows.Add(

                           count.ToString(),
                           s.Fullname,
                           s.Email,
                           s.Gender,
                           s.PhoneNo,
                           s.Address
                    );
                    count++;
                }
            }


        }

        private void empdetailsgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchItemTbox_TextChanged(object sender, EventArgs e)
        {
            searchloader();
        }

        public void searchloader()
        {
            var result = client.Get("employee/");
            StudentDict = result.ResultAs<Dictionary<string, EmpModel>>();
            emplist.Clear();

            var search = SearchItemTbox.Text.Trim();

            empdetailsgridview.DataSource = null;
            empdetailsgridview.Rows.Clear();
            int count = 1;
            foreach (EmpModel s in StudentDict.Values)
            {
                if (s.Username.StartsWith(search))
                {
                    emplist.Add(s);
                    empdetailsgridview.Rows.Add(

                       
                           count.ToString(),
                           s.Fullname,
                           s.Email,
                           s.Gender,
                           s.PhoneNo,
                           s.Address

                       );
                    count++;
                }
            }
        }
    }
}
