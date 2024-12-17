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
    public partial class OrdersForm : Form
    {
        
        public OrdersForm()
        {
            InitializeComponent();
            this.BackColor = CreateUser.color;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            TxtOrdDate.Text = DateTime.Now.ToString("dd-MM-yy hh:mm:ss");
        }

        private void BtnAddItemOrder_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm(this,int.Parse(TxtOrdNo.Text));
            detailsForm.Show();
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            string str = " ", str1 = "";
            str += "\t\t\tRECEIPT\t\t\n";
            str += TxtOrdNo.Text + "\t\t\t\t" + TxtOrdDate.Text + "\n";
            str += "No.\tItemName\tQty\tUP\tAmount\n";
            str += "------------------------------------------------------------------------\n";
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                str1 += row.Cells[1].Value + "\t";
                str1 += row.Cells[2].Value + "\t\t";
                str1 += row.Cells[3].Value + "\t";
                str1 += row.Cells[4].Value + "\t";
                str1 += row.Cells[5].Value + "\t\n";
            }
            str += str1+"\n";
            str += "------------------------------------------------------------------------\n";
            str += "\t\t\t\tGrand Total: " + TxtGrandTotal.Text;
            MessageBox.Show(str);
        }
    }
}
