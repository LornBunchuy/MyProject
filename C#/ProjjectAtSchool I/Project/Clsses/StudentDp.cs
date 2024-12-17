using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    internal class StudentDp
    {
        //Attribute
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string ContactNo { get; set; }
        //Method
        public string ShowStudentInfo(int id,string name,string sex,string no)
        {
            return "Student Info:\n" + id + "\n" + name + "\n" + sex + "\n" + no + "\n\n";
        }
    }
}

