using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengMealeaDB.homwork
{
    public partial class TimeSubtraction : Form
    {
        public TimeSubtraction()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*   //declare
               float rate;
               float total;
               float totalHours;
               //input
               DateTime timeIn = DtpTimeIn.Value;
               DateTime timeOut = DtpTimeOut.Value;
               rate = float.Parse(txtRate.Text);
               //process
               TimeSpan duration = timeOut - timeIn;
               totalHours = duration.Hours;
               total = totalHours * rate; 
               //Output
               txtDuration.Text = totalHours.ToString();
               txtTotal.Text = total.ToString("C");*/




            // Declare variables
            float rate;
            double total;
            double totalHours;

            // Input
            DateTime timeIn = DtpTimeIn.Value;
            DateTime timeOut = DtpTimeOut.Value;
            rate = float.Parse(txtRate.Text);

            // Process
            TimeSpan duration = timeOut - timeIn;
            totalHours = duration.TotalHours;
            total = totalHours * rate;

            // Output
            string formattedDuration = string.Format("{0:hh\\:mm\\:ss}", duration);
            txtDuration.Text = formattedDuration;
            txtTotal.Text = total.ToString("C");

            




        }

        private void DtpTimeIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpTimeOut_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
