using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CafeManagement
{
    public partial class FrontPage : Form
    {
        LoginReg form;
        EmpLoginReg form1;
        IntPtr handle;

        
        public FrontPage()
        {
            InitializeComponent();
            form = new LoginReg();
            form1 = new EmpLoginReg();
            handle = form.Handle;
            handle = form1.Handle;

            guna2HtmlLabel1.Parent = pictureBox1;
            guna2HtmlLabel1.BackColor = Color.Transparent;

            conadminbtn.Parent = pictureBox1;
            conadminbtn.BackColor = Color.Transparent;

            conEmpbtn.Parent = pictureBox1;
            conEmpbtn.BackColor = Color.Transparent;
            
            Minimize.Parent = pictureBox1;
            Minimize.BackColor = Color.Transparent;
            
            Close.Parent = pictureBox1;
            Close.BackColor = Color.Transparent;
        }

        private void conadminbtn_Click(object sender, EventArgs e)
        {
           /* LoginReg fm = new LoginReg();
            fm.Show();*/
            
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowForm1));
            t.Start();


        }

        private void ShowForm1()
        {
            if (form.InvokeRequired)
            {
                Action a = new Action(() => form.Show());
                form.Invoke(a);
            }
            else
            {
                form.Show();
                Thread.Sleep(1000);
            }
        }

        private void conEmpbtn_Click(object sender, EventArgs e)
        {
            /* EmpLoginReg emp = new EmpLoginReg();
             emp.Show();*/
             
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowForm2));
            t.Start();

            // Process.Start(@"C:\\Users\\JAYASHREE\\source\\repos\\CafeManagement\\CafeManagement");
        }

        private void ShowForm2()
        {
            if (form1.InvokeRequired)
            {
                Action a = new Action(() => form1.Show());
                form1.Invoke(a);
            }
            else
            {
                form1.Show();
                Thread.Sleep(1000);
            }
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            
        }

        

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
