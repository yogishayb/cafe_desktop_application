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
    public partial class acceptedOrders : Form
    {

        List<string> pendingOrderids = new List<string>();
        Dictionary<string, Dictionary<string, OrderModel>> orderdict;
        int grandtotal = 0;
        string oid = "0";
        public acceptedOrders()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;


        private void acceptedOrders_Load(object sender, EventArgs e)
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
            FirebaseResponse result = client.Get("orders/acceptedorders/");
            orderdict = result.ResultAs<Dictionary<string, Dictionary<string, OrderModel>>>();

            int count = 1;
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
                MessageBox.Show(" Accepted Order list is empty, Place the orders....!");
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
            pendingOrders ds = new pendingOrders();
            ds.Show();
            this.Hide();
        }
    }
}
