using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    internal class StudentCps
    {
        //Attribute
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string ContactNo { get; set; }
       
        //Method
        public string ShowStudentInfo()
        {
            return "Student Info:\n" + StudentID + "\n" + FullName + "\n" + Sex + "\n" + ContactNo + "\n\n";
        }
    }
}
