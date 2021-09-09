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
using DGVPrinterHelper;


namespace CafeManagement
{
    public partial class pendingOrders : Form
    {
        List<string> pendingOrderids = new List<string>();
        Dictionary<string, Dictionary<string, OrderModel>> orderdict;
        int grandtotal = 0 ;
        string oid = "0";
        public static bool isadmin = true;
        public pendingOrders()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;


        private void pendingOrders_Load(object sender, EventArgs e)
        {

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }
            loadOrderids();
        }

        public void loadOrderids()
        {
            FirebaseResponse result = client.Get("orders/pendingorders/");
            orderdict = result.ResultAs<Dictionary<string, Dictionary<string, OrderModel>>>();

            int count=1;
            pendingOrderIDSlistbox.Items.Clear();
            pendingOrderids.Clear();

            if(orderdict != null)
            {
                foreach (KeyValuePair<string, Dictionary<string, OrderModel>> kvp in orderdict)
                {
                    Debug.WriteLine(" order id    " + kvp.Key);
                    pendingOrderIDSlistbox.Items.Add("Order " + count);
                    count++;

                    pendingOrderids.Add(kvp.Key);


                }
            }
            else
            {
                MessageBox.Show("Pending Order list is empty....!");
            }
        }


        public void loaditems(int index)
        {
            grandtotal = 0;
            cartgridview.Rows.Clear();
            oid = pendingOrderids[index];

            foreach (KeyValuePair<string, OrderModel> pp in orderdict[oid])
            {
                Debug.WriteLine(" ------ item id  " + pp.Key);
                Debug.WriteLine("----------- name  " + pp.Value.name);
                Debug.WriteLine("----------- price  " + pp.Value.price);
                Debug.WriteLine("----------- quantity  " + pp.Value.quantity);

                cartgridview.Rows.Add(
                    pp.Value.name,
                    pp.Value.price,
                    pp.Value.quantity,
                    pp.Value.price * pp.Value.quantity
                    );
                int eachtotal = pp.Value.price * pp.Value.quantity;
                grandtotal += eachtotal;
                eachtotal = 0;
               
            }
            grandtotallabel.Text = grandtotal.ToString();
        }

        private void pendingOrderIDSlistbox_Click(object sender, EventArgs e)
        {
            loaditems(pendingOrderIDSlistbox.SelectedIndex);
        }

        private void placeOrderbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "F.R.I.E.N.D.S Cafe \n Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + grandtotal + " \n\n THANK YOU! VISIT AGAIN.";
            printer.FooterAlignment = StringAlignment.Center;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(cartgridview);



            foreach (KeyValuePair<string, OrderModel> pp in orderdict[oid])
            {
                Debug.WriteLine(" ------ item id  " + pp.Key);
                Debug.WriteLine("----------- name  " + pp.Value.name);
                Debug.WriteLine("----------- price  " + pp.Value.price);
                Debug.WriteLine("----------- quantity  " + pp.Value.quantity);

                string name = pp.Value.name;
                int price = pp.Value.price;
                int quantity = pp.Value.quantity;
                OrderModel orderModel = new OrderModel()
                { 
                   name =  name,
                   price =  price,
                   quantity =  quantity,
                };
                client.Set("orders/acceptedorders/" + oid + "/" + pp.Key , orderModel);

            }

            client.Delete("orders/pendingorders/" + oid);
            loadOrderids();

            cartgridview.Rows.Clear();
            grandtotal = 0;
            grandtotallabel.Text = "0";
        }

   

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Dashboard.username != null)
            {
                Dashboard fs = new Dashboard(Dashboard.username);
                fs.Show();
                this.Hide();
            }
            else
            {
                Dashboard fs = new Dashboard();
                fs.Show();
                this.Hide();
            }
        }

        private void acceptedordersbtn_Click(object sender, EventArgs e)
        {
            acceptedOrders ao = new acceptedOrders();
            ao.Show();
            this.Hide();

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loadOrderids();
        }
    }
    
}
