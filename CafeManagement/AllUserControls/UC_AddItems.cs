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
using System.Diagnostics;


namespace CafeManagement.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        List<Category> Catlist = new List<Category>();
        int index;
        Dictionary<string, Category> StudentDict;

        public UC_AddItems()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;

        private void UC_AddItems_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }
            loadcombobox();
        }

        private void addcategbtn_Click(object sender, EventArgs e)
        {

            Category category = new Category()
            {
                category = categoryTbox.Text,
                cid = "0"
            };
            PushResponse catpush = client.Push("Categories/", category);
            string cid = catpush.Result.name;
            client.Set("Categories/" + cid + "/cid/", cid);
            loadcombobox();
            MessageBox.Show("Category " + categoryTbox.Text + " is Successfully Added...!");
            categoryTbox.Text = "";
            SelCategCbox.SelectedIndex = -1;
        }

        public void loadcombobox()
        {
            SelCategCbox.Items.Clear();
            Catlist.Clear();
            var result = client.Get("Categories/");
             StudentDict = result.ResultAs<Dictionary<string, Category>>();
            

            if(StudentDict != null)
            {
                foreach (Category s in StudentDict.Values)
                {
                    SelCategCbox.Items.Add(s.category);

                    Catlist.Add(s);
                }
            }

            foreach(Category s in Catlist)
            {
                Debug.WriteLine(s.category);
            }
           

        }

        private void addItembtn_Click(object sender, EventArgs e)
        {
             
            Item std = new Item()
            {
                item_name = itemTbox.Text,
                cid = Catlist[index].cid,
                category_name = Catlist[index].category,
                price = priceTbox.Text,
                iid = "0"
            };
            PushResponse setter = client.Push("Items/" ,std);
            string iid = setter.Result.name;
            client.Set("Items/" + iid + "/iid/", iid);
            MessageBox.Show( " Data Inserted Successfully");


            itemTbox.Text = string.Empty;
            priceTbox.Text = string.Empty;
            
        }

        public void clearcomboindex()
        {
            SelCategCbox.SelectedIndex = -1;
        }

        private void SelCategCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = SelCategCbox.SelectedIndex;
        }
    }
}
