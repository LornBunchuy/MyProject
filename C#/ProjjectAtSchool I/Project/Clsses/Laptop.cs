using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    class Laptop: PC
    {
        //Attribute
        public string ScreenSize { get; set; }
        public string Color { get; set; }
        public string HDD { get; set; }
        public string RAM { get; set; }

        //Method
        public string PrintReceipt(string size,string color, string hdd,string ram)
        {
            return "\nLaptop Info:\n" + size +"\n" + color + "\n" + hdd + "\n" + ram;
        }
    }
}
