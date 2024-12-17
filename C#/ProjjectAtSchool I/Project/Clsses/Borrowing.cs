using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    internal class Borrowing
    {
        //Attribute
        public int  BorrowingNo {get; set; }
        public DateTime Data { get; set; }
        public DateTime Return { get; set; }
        public string ApprovedBy { get; set; }

        //Method
       public string PrintReceipt(Student st )
        {
            string str = "";
            str += this.BorrowingNo + "\n";
            str += this.Data + "\n";
            str += this.Return + "\n";
            str += this.ApprovedBy + "\n";
            str += this.BorrowingNo + "\n";
            str += st.StudentID + "\n";
            str += st.FullName + "\n";
            str += st.Sex + "\n";
            str += st.Major + "\n";
            return str;
       }
    }
}
