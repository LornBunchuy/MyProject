using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clsses;

namespace WindowsFormsApp1.Forms
{
    public partial class AssoicationForm : Form
    {
        public AssoicationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            //Declare
            Borrowing borrowing = new Borrowing();  
            Student student = new Student();
            string str = "";

            //Input
            borrowing.BorrowingNo = int.Parse(txtBn.Text);
            borrowing.Data = dateTimePicker1.Value;
            borrowing.Return=dateTimePicker2.Value;   
            borrowing.ApprovedBy=txtAppB.Text;
            student.StudentID =int.Parse( txtSId.Text);    
            student.FullName = TxtFN.Text;
            student.Sex = txtSex.Text;
            student.Major = TxtMj.Text;
            //Process
            str =borrowing.PrintReceipt(student);
            //output
            MessageBox.Show(str, "Receipt");

        }

        private void BtnDuration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToInt32(dateTimePicker2.Value.Subtract(dateTimePicker1.Value).TotalDays).ToString());
        }
    }
}
