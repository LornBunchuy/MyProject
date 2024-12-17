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
    public partial class DetailsForm : Form
    {
         public static float GrandTotal = 0.0f;
         private OrdersForm newOrder = new OrdersForm();
        public DetailsForm(OrdersForm OldForm,int OrdNo)
        {
            InitializeComponent();
            newOrder = OldForm;
            this.TxtOrdNo.Text = OrdNo.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            newOrder.dataGridView1.Rows.Add(TxtOrdNo.Text, TxtItemNo.Text, TxtItemName.Text, TxtQuantity.Text, TxtUnitPrice.Text, TxtAmount.Text); 
            //add in newOrder 
            newOrder.TxtGrandTotal.Text = GrandTotal.ToString("C"); 
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtAmount_DoubleClick(object sender, EventArgs e)
        {
            //TxtAmount.Text = (int.Parse(TxtQuantity.Text) * float.Parse(TxtUnitPrice.Text)).ToString("C");
            //DECLARE
            float quantity = 0.0f, unitprice = 0.0f, Total = 0.0f;
            //INTPUT
            quantity = float.Parse(TxtQuantity.Text);
            unitprice = float.Parse(TxtUnitPrice.Text);
            //PROCESS
            Total = quantity * unitprice;
            GrandTotal += Total;
            //OUTPUT
            TxtAmount.Text = Total.ToString();
        }

        private void TxtOrdNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
