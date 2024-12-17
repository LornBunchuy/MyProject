using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1.Clsses
{
    internal class StudentAgg
    {
        //Attribute
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string ContactNo { get; set; }
        public string Faclty { get; set; }
        public string Major { get; set; }
        public string Email { get; set; }
        public string TimeShifg { get; set; }
        public ContactAddressAgg address;

        //Method
        public StudentAgg(ContactAddressAgg address)
        {
            this.address = address;
        }
        public string SaveData()
        {
            return "Student Info:\n" + StudentID + "\n" + FullName + "\n" + Sex + "\n" + ContactNo + "\n" + Faclty + "\n" + Major + "\n" + Email + "\n" + TimeShifg + "\n\n"+
                   "Address:\n" + address.HomeNo + "\n" + address.StreetNo + "\n" + address.Commune + "\n" + address.District + "\n" + address.City + address.Country+ "\n\n" ;
        }
    }
}
