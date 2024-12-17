using WindowsFormsApp1.Clsses;
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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            //Declare
            Laptop laptop = new Laptop();
            float total = 0.0f;

            //INPUT

            laptop.Price = float.Parse(txtPrice.Text);
            laptop.Discount = float.Parse(txtMadeIn.Text);


            //Process
            total = laptop.CalculateTotal(laptop.Price, laptop.Discount);

            MessageBox.Show(total.ToString("C"), "Total Price");
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            //Declare
            Laptop lap = new Laptop();
            float total = 0.0f;
            string str1 = "", str2 = "";

            lap.Brand = txtBrand.Text;
            lap.Model = txtModel.Text;
            lap.Price = float.Parse(txtPrice.Text);
            lap.Discount = float.Parse(txtMadeIn.Text);
            lap.ScreenSize = txtScreenSize.Text;
            lap.Color = txtColor.Text;
            lap.HDD = txtHDD.Text;
            lap.RAM = txtRAM.Text;

            //
            //Process

            total = lap.CalculateTotal(lap.Price, lap.Discount);
            str1 = lap.ShowInfo(lap.Brand, lap.Model,lap.Price,lap.Discount);
            str2 = lap.PrintReceipt(lap.ScreenSize, lap.Color,lap.HDD,lap.RAM);

            MessageBox.Show(str1 + str2, "Receipt");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtRAM.Clear(); 
            txtColor.Clear();
            txtHDD.Clear();
            txtMadeIn.Clear();
            txtScreenSize.Clear();
            
        }
    }
}
