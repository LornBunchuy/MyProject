using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clsses;

namespace WindowsFormsApp1.Forms
{
    public partial class Aggregation : Form
    {
        public Aggregation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //DEclare
            ContactAddressAgg address = new ContactAddressAgg();
            StudentAgg student = new StudentAgg(address);
            string str = "";
            //Input
            student.address.HomeNo = int.Parse(txtHome.Text);
            student.address.StreetNo = txtStreet.Text;
            student.address.Commune = cbbCommune.Text;
            student.address.District = cbbDistrict.Text;
            student.address.City = cbbCity.Text;
            student.address.Country = cbbCountry.Text;
            student.StudentID= int.Parse(txtSD.Text);   
            student.FullName = txtFn.Text;  
            student.Sex = CbbSex.Text;
            student.ContactNo=txtContact.Text;   
            student.Faclty = cbbFaculty.Text;   
            student.Major = cbbMajor.Text;
            student.Email = txtEmail.Text;  
            student.TimeShifg = cbbTimeshift.Text;  

            //Process
            str = student.SaveData();

            //OUTPUT
            MessageBox.Show(str);

        }
    }
}
