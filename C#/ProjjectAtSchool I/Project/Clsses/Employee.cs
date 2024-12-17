using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    class Employee : Person
    {
       
        
            public string Position { get; set; }
            public string Department { get; set; }
            public double SalaryRate { get; set; }

            public string Promotion(string position)
            {
                return "Mr./Mrs." + position;
            }
        
    }
}
