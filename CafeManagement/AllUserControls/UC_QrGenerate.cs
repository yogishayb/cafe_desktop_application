using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class UC_QrGenerate : UserControl
    {
        public UC_QrGenerate()
        {
            InitializeComponent();
        }

        private void UC_QrGenerate_Load(object sender, EventArgs e)
        {
            pictureloader();
        }

        private void pictureloader()
        {
            string qrinfo = "https://acafe24.herokuapp.com/";
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(qrinfo, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            qrpicturebox.Image = code.GetGraphic(50);
        }
    }
}
