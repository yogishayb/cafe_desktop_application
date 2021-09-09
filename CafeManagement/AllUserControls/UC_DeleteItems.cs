using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Models;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace CafeManagement.AllUserControls
{
    public partial class UC_DeleteItems : UserControl
    {
        List<Item> itemlist = new List<Item>();
        Item selecteditem;
        Dictionary<string, Item> StudentDict;
        public UC_DeleteItems()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;
        private void UC_DeleteItems_Load(object sender, EventArgs e)
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
            FirebaseResponse result = client.Get("Items/");

            StudentDict = result.ResultAs<Dictionary<string, Item>>();


            deletegridview.DataSource = null;
            deletegridview.Rows.Clear();
            int count = 1;

            if(StudentDict != null)
            {
                foreach (Item s in StudentDict.Values)
                {
                    itemlist.Add(s);
                    deletegridview.Rows.Add(

                           count.ToString(),
                           s.item_name,
                           s.category_name,
                           s.price
                    );
                    count++;
                }
            }


        }

        private void DelLabel_Click(object sender, EventArgs e)
        {

        }

        private void deletegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selecteditem = itemlist[index];

            deletelabel.Text = "Are you sure To delete, " + selecteditem.item_name + " ?";
        }

        private void SearchItemTbox_TextChanged(object sender, EventArgs e)
        {
            searchloader();
        }

        public void searchloader()
        {
            var result = client.Get("Items/");
            StudentDict = result.ResultAs<Dictionary<string, Item>>();
            itemlist.Clear();

            var search = SearchItemTbox.Text.Trim();

            deletegridview.DataSource = null;
            deletegridview.Rows.Clear();
            int count = 1;
            foreach (Item s in StudentDict.Values)
            {
                if (s.item_name.StartsWith(search))
                {
                    itemlist.Add(s);
                    deletegridview.Rows.Add(

                       count.ToString(),
                       s.item_name,
                       s.category_name,
                       s.price

                       );
                    count++;
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string iidtodelete = selecteditem.iid;
            var deletor = client.Delete("Items/" + iidtodelete);
            MessageBox.Show("deleted");

            searchloader();

            deletelabel.Text = "Select  the item to delete ";
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
