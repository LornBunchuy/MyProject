using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public static Form sForm = null;
        bool btnState = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        public void OpenForm(Form childForm)//order
        {
            if (sForm != null)
                sForm.Close();
            sForm = childForm;  //sForm = order
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new OrdersForm());
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm());
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new Employee());
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
             OpenForm(new ReportForm());
            if (btnState == false)
            {
                OpenForm(new ReportForm());
                BtnReceipt.Height = 50;
                BtnMonthly.Height = 50;
                button1.Height = 50;
                btnState = true;
            }
            else
            {
                OpenForm(new blankForm());
                BtnReceipt.Height = 0;
                BtnMonthly.Height = 0;
                button1.Height = 0;
                btnState = false;
            }
        }

        private void BtnDashboad_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboadForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.username == "bunchuy")
            {
                BtnLog.Height = 0;
                BtnReport.Height = 0;
                BtnDashboad.Height = 0;
                BtnCreateUser.Height = 0;
            }
            else
            {
                BtnProduct.Height = 0;
                BtnCustomer.Height = 0;
                BtnOrders.Height = 0;
                BtnEmployee.Height = 0;
            }
            label1.Text = "Welcome, " + LoginForm.username;
            BtnReceipt.Height = 0;
            BtnMonthly.Height = 0;
            button1.Height = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           this.Close();
           LoginForm.ActiveForm.WindowState = FormWindowState.Normal;
           LoginForm.ActiveForm.TopMost = true;
        }

        private void BtnDaily_Click(object sender, EventArgs e)
        {
            OpenForm(new DailyReport());
        }

        private void BtnMonthly_Click(object sender, EventArgs e)
        {
            OpenForm(new MonthlyReport());
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            OpenForm(new TransactionForm());
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            OpenForm(new CreateUser(this));
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            OpenForm(new ReceiptForm());
        }

        private void button1_Click(object sender, EventArgs e)//BtnDialy
        {
            OpenForm(new DailyReport());
        }

        private void BtnMonthly_Click_1(object sender, EventArgs e)
        {
            OpenForm(new MonthlyReport());
        }
    }
}
