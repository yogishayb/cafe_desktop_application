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


namespace CafeManagement.AllUserControls
{
    public partial class UC_Notifications : UserControl
    {
        int totalsum = 0;
        public UC_Notifications()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = Databaseconfig.Authsecret,

            BasePath = Databaseconfig.BasePath
        };

        IFirebaseClient client;

        private void UC_Notifications_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet Or Connection Problem");
            }
            getdata();
        }

        public async void getdata()
        {
            notifygridview.Rows.Clear();
            totalsum = 0;
            FirebaseResponse result = await client.GetAsync("orders/pendingorders/");
            Dictionary<string, OrderModel> lowerdict = result.ResultAs<Dictionary<string, OrderModel>>();
            Dictionary<string, Dictionary<string, OrderModel>> StudentDict = new Dictionary<string, Dictionary<string, OrderModel>>();
            Dictionary<string, Dictionary<string, OrderModel>> orderdict = result.ResultAs<Dictionary<string, Dictionary<string, OrderModel>>>();

            Debug.WriteLine("sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss");
            /*foreach(string i in orderdict.Keys)
            {
                Debug.WriteLine("oid = " + i );
            }*/
            if (orderdict != null)
            {
                foreach (KeyValuePair<string, Dictionary<string, OrderModel>> kvp in orderdict)
                {
                    Debug.WriteLine(" order id    " + kvp.Key);
                    foreach (KeyValuePair<string, OrderModel> pp in kvp.Value)
                    {
                        Debug.WriteLine(" ------ item id  " + pp.Key);
                        Debug.WriteLine("----------- name  " + pp.Value.name);
                        Debug.WriteLine("----------- price  " + pp.Value.price);
                        Debug.WriteLine("----------- quantity  " + pp.Value.quantity);

                    }
                    Debug.WriteLine(" ##############################################");
                }

                Debug.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            }

            /*if (StudentDict != null)
            {
                
                foreach (OrderModel s in StudentDict.Values)
                {
                    int eachtotal = s.price * s.quantity;
                    notifygridview.Rows.Add(
                       s.name,
                       s.price,
                       s.quantity,
                       eachtotal.ToString()
                    );
            
                    Debug.WriteLine("name " + s.name + " price " + s.price + " quantity " + s.quantity + "total  " +  eachtotal  );
                    totalsum += eachtotal;
                    eachtotal = 0;

                }
                Debug.WriteLine("total sum =  " + totalsum);
                grandtotallabel.Text = totalsum.ToString();
            }
            else
            {
                MessageBox.Show("No Orders");
            }*/
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "F.R.I.E.N.D.S Cafe \n Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + totalsum + " \n\n THANK YOU! VISIT AGAIN.";
            printer.FooterAlignment = StringAlignment.Center;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(notifygridview);

            client.Delete("orders/");
            getdata();

            totalsum = 0;
            grandtotallabel.Text = "0";

        }
    }
}
