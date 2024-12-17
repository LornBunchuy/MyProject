using BengMealeaDB.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BengMealeaDB
{
    public partial class OrderForm : Form
    {
        public static SqlConnection sqlConn;
        public static int ordnum = 0;
        Orders orders = new Orders();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BtnAddItemOrder_Click(object sender, EventArgs e)
        {
            OrdDetailsForm detailsForm = new OrdDetailsForm(this, int.Parse(TxtOrdNo.Text));
            detailsForm.Show();
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Declare
            //Input
            orders.OrdNo = int.Parse(TxtOrdNo.Text);
            orders.OrdDate = DateTime.Parse(TxtOrdDate.Text);
            orders.EmpNo = int.Parse(TxtEmpNo.Text);
            orders.CustNo = int.Parse(TxtCustNo.Text);
            orders.Location = TxtLocation.Text;
            orders.Status = TxtStatus.Text;
            orders.GrandTotal = TxtGrandTotal.Text;

            //Process
            if (orders.InsertOrder())
            {
                //Output
                MessageBox.Show("Order is successful!");
                InsertDetailsFunc();
            }
            else
            {
                //Output
                MessageBox.Show("Insert failed....");
            }
            
            //TxtOrdNo.Clear(); TxtDate.Clear();
            TxtEmpNo.Clear(); TxtCustNo.Clear();
            TxtLocation.Clear(); TxtStatus.Clear();
            TxtGrandTotal.Clear(); dataGridView1.Rows.Clear();
        }
        private void InsertDetailsFunc()
        {
            //Declare
            Details details = new Details(orders);

            //Input
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                details.OrdNo = int.Parse(row.Cells[0].Value.ToString());
                details.ItemNo = int.Parse(row.Cells[1].Value.ToString());
                details.Description = row.Cells[2].Value.ToString();
                details.Quantity = int.Parse(row.Cells[3].Value.ToString());
                details.UnitPrice = float.Parse(row.Cells[4].Value.ToString());
                details.Amount = float.Parse(row.Cells[5].Value.ToString());
                details.InsertDetails();
            }

            MessageBox.Show("Detail inserted!");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TxtOrdDate.Text = DateTime.Now.ToString("dd-MM-yy");
            string connStr;
            connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            MessageBox.Show("DB Connection!");
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            ordnum = int.Parse(TxtOrdNo.Text);
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Show();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            orders.OrdNo = int.Parse(TxtOrdNo.Text);

            if (orders.RemoveOrder())
            {
                MessageBox.Show("Remove is successfull!");
            }
            else
            {
                MessageBox.Show("Remove failed!");
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            orders.OrdNo = int.Parse(TxtOrdNo.Text);
            orders.OrdDate = DateTime.Parse(TxtOrdDate.Text);
            orders.EmpNo = int.Parse(TxtEmpNo.Text);
            orders.CustNo = int.Parse(TxtCustNo.Text);
            orders.Location = TxtLocation.Text;
            orders.Status = TxtStatus.Text;
            orders.GrandTotal = TxtGrandTotal.Text; 

            if (orders.UpdateOrder())
            {
                MessageBox.Show("Update is successfully!");
            }
            else
            {
                MessageBox.Show("Update is failed!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            orders.OrdNo = int.Parse(TxtOrdNo.Text);

            if (orders.SearchOrder(orders.OrdNo))
            {
                TxtOrdDate.Text = orders.OrdDate.ToString();
                TxtEmpNo.Text = orders.EmpNo.ToString();
                TxtCustNo.Text = orders.CustNo.ToString();
                TxtLocation.Text = orders.Location.ToString();  
                TxtStatus.Text = orders.Status.ToString();
                TxtGrandTotal.Text = orders.GrandTotal.ToString();

                MessageBox.Show("It is found!");
            }
            else
            {
                MessageBox.Show("It is not found!");
            }
        }

        private void TxtOrdDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
