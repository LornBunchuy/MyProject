using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }

        public string UpdateAddress(string address)
        {
            string str = "#" + address + ".";
            return str;
        }
    }
}
