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
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
            this.BackColor = CreateUser.color;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Employees", "Insert", "Admin");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
                dataGridView1.Rows.Add("01-04-24", "Product", "Insert", "Cashier");
            }
        }
    }
}
