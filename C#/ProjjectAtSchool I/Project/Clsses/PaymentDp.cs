using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1.Clsses
{
    internal class PaymentDp
    {
        //Attribute
       
        public int PaymentNo { get; set; }
        public DateTime Date { get; set; }
        public int StudentID { get; set; }
        public string Faclty { get; set; }
        public string Major { get; set; }
        public float Fee { get; set; }
        //Method
        public PaymentDp(StudentDp student)//Constructor
        {
            this.StudentID = student.StudentID;
        }
        public float Calculate(float fee )
        {
            return fee - (fee * 0.1f);
        }
        public string ShowPaymentInfo(int paymentID,DateTime date, string fac, string major,float fee)
        {
            return "Payment Info:\n" + paymentID + "\n" + date + "\n" + this.StudentID + "\n" + fac + "\n" + major + "\n" + fee + "\n\n";
        }
    }
}

