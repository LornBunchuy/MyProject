using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    internal class Course
    {
        //Attribute
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public float Fee { get; set; }
        public TimeSpan Duratin { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public StudentCps student = new StudentCps();
        //Method
        public string PrintReceipt(int id, string name, string sex, string no)
        {
            return "Receipt:\n" + CourseID + "\n" + CourseName + "\n" + Fee + "\n" + Start + "\n" + End + "\n"+ Duratin + "\n\n" +
                   "Student Info:\n" + id + "\n" + name + "\n" + sex + "\n" + no + "\n\n"; ;
        }
    }
}
