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
    public partial class Dependancy : Form
    {
        public Dependancy()
        {
            InitializeComponent();
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        { 
            //DECLARE
            StudentDp student = new StudentDp();
            PaymentDp payment = new PaymentDp(student);
            string str = "";
            string str1 = "";
            string str2 = "";

            //INPUT
            student.StudentID = int.Parse(txtSD.Text);
            student.FullName = txtFn.Text;
            student.Sex = CbbSex.Text;
            student.ContactNo = txtContact.Text;

            payment.PaymentNo = int.Parse(txtPaymentNo.Text);
            payment.Date = dateTimePicker1.Value;
            payment.StudentID = student.StudentID;
            payment.Faclty = CbbF.Text;
            payment.Major = comboBox3.Text;
            payment.Fee = float.Parse(txtFee.Text);
            //PROCESS
            str = student.ShowStudentInfo(student.StudentID, student.FullName, student.Sex, student.ContactNo);
            str1 = payment.ShowPaymentInfo(payment.PaymentNo, payment.Date, payment.Faclty, payment.Major, payment.Fee);
            str2 = "Total: " + payment.Calculate(payment.Fee).ToString("C");

            //OUTPUT
            MessageBox.Show(str + str1 + str2, "Dependancy Class");
        }

        private void txtSD_MouseLeave(object sender, EventArgs e)
        {
            //txtSDP.Text = txtSD.Text;   
        }

        private void txtSD_MouseEnter(object sender, EventArgs e)
        {
            //txtSDP.Text = txtSD.Text;
        }

        private void txtSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtSDP.Text = txtSD.Text;
        }

        private void txtSD_KeyUp(object sender, KeyEventArgs e)
        {
            txtSDP.Text = txtSD.Text;
        }
    }
}
