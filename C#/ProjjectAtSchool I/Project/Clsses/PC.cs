using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clsses
{
    class PC
    {
        //Attribute
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        

        //Method
        public float CalculateTotal(float price,float dis)
        {
           
            return price - (price * dis);
        }
        public string ShowInfo(string brand, string model, float price, float dis)
        {
            return "PC Info:\n" + brand + "\n" + price + "\n" + dis;
        }

    }
}
