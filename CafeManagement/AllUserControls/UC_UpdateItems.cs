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
    public partial class UC_UpdateItems : UserControl
    {
        List<Item> itemlist = new List<Item>();
        Item selecteditem;
        Dictionary<string, Item> StudentDict;

        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;

        private void UC_UpdateItems_Load(object sender, EventArgs e)
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
            

            updategridview.DataSource = null;
            updategridview.Rows.Clear();
            int count = 1;

            if(StudentDict != null)
            {
                foreach (Item s in StudentDict.Values)
                {
                    itemlist.Add(s);
                    updategridview.Rows.Add(

                           count.ToString(),
                           s.item_name,
                           s.category_name,
                           s.price
                    );
                    count++;
                }
            }

            
        }

        private void updategridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             /*if (updategridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            
                 updategridview.CurrentRow.Selected = true;
                 CategoryTbox.Text = updategridview.SelectedRows[0].Cells[2].Value.ToString();
                 nameTbox.Text = updategridview.SelectedRows[0].Cells[1].Value.ToString();
                 PriceTbox.Text = updategridview.SelectedRows[0].Cells[3].Value.ToString();*/

            int index = e.RowIndex;
            selecteditem = itemlist[index];

           
            nameTbox.Text = selecteditem.item_name;
            PriceTbox.Text = selecteditem.price;
        }

        private void SearchItemTbox_TextChanged(object sender, EventArgs e)
        {
            searchloader();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Item itemtoupdate = new Item()
            {
                iid = selecteditem.iid,
                cid = selecteditem.cid,
                category_name = selecteditem.category_name,
                item_name = nameTbox.Text,
                price = PriceTbox.Text
            };

            var setter = client.Set("Items/" + selecteditem.iid, itemtoupdate);
            MessageBox.Show("Updated");

            
            nameTbox.Text = "";
            PriceTbox.Text = "";

            searchloader();


        }

        public void searchloader()
        {
            var result = client.Get("Items/");
            StudentDict = result.ResultAs<Dictionary<string, Item>>();
            itemlist.Clear();

            var search = SearchItemTbox.Text.Trim();

            updategridview.DataSource = null;
            updategridview.Rows.Clear();
            int count = 1;
            foreach (Item s in StudentDict.Values)
            {
                if (s.item_name.StartsWith(search))
                {
                    itemlist.Add(s);
                    updategridview.Rows.Add(

                       count.ToString(),
                       s.item_name,
                       s.category_name,
                       s.price

                       );
                    count++;
                }
            }
        }
    }
}
