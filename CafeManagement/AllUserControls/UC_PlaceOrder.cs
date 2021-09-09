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
using RandomSolutions;
using System.IO;
using DGVPrinterHelper;

namespace CafeManagement.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {

        List<Category> Catlist = new List<Category>();
        List<Item> selectedcategoryitemlist = new List<Item>();
        Dictionary<string, Item> StudentDict;
        int selectedcatindex;
        Item itemtoadd;
        bool isitemselected = false;
        List<Billitem> cartlist = new List<Billitem>();
        int removeitemindex;
        float grandtotal;
        int index;
        bool isempty = true;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,
   
            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;
        private void categorycombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedcatindex = categorycombo.SelectedIndex;
            loaditemlist();
           
        }
        public void loaditemlist()
        {
                FirebaseResponse result = client.Get("Items/");

                StudentDict = result.ResultAs<Dictionary<string, Item>>();


                itemlistbox.DataSource = null;
                itemlistbox.Items.Clear();
            selectedcategoryitemlist.Clear();

                string cid = Catlist[selectedcatindex].cid;
            foreach (Item s in StudentDict.Values)
            {
                if (cid == s.cid)
                {
                    selectedcategoryitemlist.Add(s);
                    itemlistbox.Items.Add(
                           s.item_name

                    );
                }

            }
        }

        public void clearlist()
        {
            itemlistbox.Items.Clear();
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
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

        public void loadcombobox()
        {
            itemlistbox.Items.Clear();

            selectedcategoryitemlist.Clear();

            categorycombo.Items.Clear();
            var result = client.Get("Categories/");
            Dictionary<string, Category> StudentDict = result.ResultAs<Dictionary<string, Category>>();


            if(StudentDict != null)
            {
                foreach (Category s in StudentDict.Values)
                {
                    categorycombo.Items.Add(s.category);
                    Catlist.Add(s);
                }
            }


        }

        private void searchTbox_TextChanged(object sender, EventArgs e)
        {
            searchloader();
        }

        public void searchloader()
        {
            var result = client.Get("Items/");
            StudentDict = result.ResultAs<Dictionary<string, Item>>();
            selectedcategoryitemlist.Clear();

            var search = searchTbox.Text.Trim();

            itemlistbox.DataSource = null;
            itemlistbox.Items.Clear();

            selectedcategoryitemlist.Clear();

            string cid = Catlist[selectedcatindex].cid;
            foreach (Item s in StudentDict.Values)
            {
               
                if (s.cid == cid)
                {
                    if (s.item_name.StartsWith(search))
                    {
                        selectedcategoryitemlist.Add(s);
                        itemlistbox.Items.Add(
                           s.item_name
                           );

                    }
                }
            }
        }

        private void itemlistbox_Click(object sender, EventArgs e)
        {
            loaddetails(itemlistbox.SelectedIndex);
        }

        public void loaddetails(int index)
        {
            isempty = false;
            if(index != -1)
            {
                isitemselected = true;

                itemtoadd = selectedcategoryitemlist[index];
                itemTbox.Text = itemtoadd.item_name;
                priceTbox.Text = itemtoadd.price;
                quantityselector.Value = 1;
                string price = (1 * float.Parse(itemtoadd.price)).ToString();
                totalTbox.Text = price;
            }


        }

        private void quantityselector_ValueChanged(object sender, EventArgs e)
        {
            

            if (!isitemselected)
            {
               
                
                    quantityselector.Value = 0;
                    ///MessageBox.Show("Please Select The Item First..!");
                    //Debug.WriteLine("ascsfsu");
                    
            }
            else
            {
                float quantity = (float)quantityselector.Value;
                string price = (quantity * float.Parse(itemtoadd.price)).ToString();
                totalTbox.Text = price;
            }
        }

        private void addtocartBtn_Click(object sender, EventArgs e)
        {
            if (!isempty)
            {
                string itemname = itemTbox.Text;
                string unitprice = priceTbox.Text;
                string quantity = quantityselector.Value.ToString();
                string totalprice = totalTbox.Text;

                Billitem billitem = new Billitem()
                {
                    itemname = itemname,
                    unitprice = unitprice,
                    quantity = quantity,
                    totalprice = totalprice

                };

                cartlist.Add(billitem);


                cartloader();

                clearbox();

                isempty = true;
            }
            else
            {
                MessageBox.Show("Please select an item.....!");
            }
        }

        public void clearbox()
        {
             itemTbox.Text = "";
             priceTbox.Text = "";
             quantityselector.Value = 0;
             totalTbox.Text = "";
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            /* byte[] pdf = cartlist.ToPdf("Bill");
             DateTime datetime = DateTime.Now;
             string timenow = datetime.ToString("MM_dd_yyyy_HH_mm_ss");

             string pdfsdownloadpath = "C:\\Users\\JAYASHREE\\Downloads\\Cafe";
             if(!Directory.Exists(pdfsdownloadpath))
             {
                 Directory.CreateDirectory(pdfsdownloadpath);
             }

             File.WriteAllBytes(pdfsdownloadpath + "\\Invoice_" + timenow + ".pdf", pdf);
             DialogResult dialogResult = MessageBox.Show("Open File", "Your Bill is Generated", MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
             {
                 Process.Start(pdfsdownloadpath);
             }
             else if (dialogResult == DialogResult.No)
             {
                 //do something else
             }

             cartgridview.Rows.Clear();
             cartlist.Clear();*/

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "F.R.I.E.N.D.S Cafe \n Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + grandtotallabel.Text + " \n\n THANK YOU! VISIT AGAIN.";
            printer.FooterAlignment = StringAlignment.Center;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(cartgridview);


            grandtotal = 0.0f;
            cartgridview.Rows.Clear();
            grandtotallabel.Text = "Rs. " + grandtotal;
        }


        private void cartgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            removeitemindex = e.RowIndex;

        }   

        private void removebtn_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Item " + cartlist[removeitemindex].itemname + " Will Be Deleted...!");
            cartlist.RemoveAt(removeitemindex);
            cartloader();

        }

        private void cartloader()
        {
            cartgridview.Rows.Clear();
            grandtotal = 0.0f;
            foreach(Billitem i in cartlist)
            {
                cartgridview.Rows.Add(
               i.itemname,
               i.unitprice,
               i.quantity,
               i.totalprice
               );

                grandtotal = grandtotal + float.Parse(i.totalprice);
            }

            grandtotallabel.Text = "Rs." + grandtotal;
        }

        private void itemlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
