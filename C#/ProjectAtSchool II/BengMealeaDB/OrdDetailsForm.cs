using BengMealeaDB.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengMealeaDB
{
    public partial class OrdDetailsForm : Form
    {


        public double GrandTotal = 0.0d;
        public float amount = 0.0f;
        
        private OrderForm newOrder = new OrderForm();
        public OrdDetailsForm(OrderForm OldForm,int ordNo)
        {
            InitializeComponent();
            this.newOrder = OldForm;
            TxtOrdNo.Text = ordNo.ToString();
            TxtAmount.ReadOnly = true;

        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
           
            float amount = 0.0f;
            // Create a new row in DataGridView for the entered details
            int ordNo = int.Parse(TxtOrdNo.Text);
            int itemNo = int.Parse(TxtItemNo.Text);
            string description = TxtItemName.Text;
            float quantity = float.Parse(TxtQuantity.Text);
            float unitPrice = float.Parse(TxtUnitPrice.Text);
            amount = quantity * unitPrice;
            //GrandTotal = string.IsNullOrEmpty(newOrder.TxtGrandTotal.Text) ? 0 : float.Parse(newOrder.TxtGrandTotal.Text, NumberStyles.Currency);
            GrandTotal += amount;
            newOrder.TxtGrandTotal.Text = GrandTotal.ToString("C");
            // Add the item details to the DataGridView
            newOrder.dataGridView1.Rows.Add(ordNo, itemNo, description, quantity, unitPrice, amount);

            // Clear the input fields after adding the item to DataGridView
            ClearFields();

            MessageBox.Show("Item added to the order.");
        }


        private void ClearFields()
        {
            TxtItemNo.Clear();
            TxtItemName.Clear();
            TxtQuantity.Clear();
            TxtUnitPrice.Clear();
            TxtAmount.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtAmount_Click(object sender, EventArgs e)
        {
            float quantity = float.Parse(TxtQuantity.Text);
            float unitPrice = float.Parse(TxtUnitPrice.Text);
            amount = quantity * unitPrice;
            TxtAmount.Text = amount.ToString("C");
        }
    }
}
