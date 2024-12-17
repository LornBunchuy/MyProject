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
    public partial class DateSubtraction : Form
    {
        public DateSubtraction()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            int totalDays;
            DateTime startDay = DtpStart.Value;
            DateTime endDay = DtpEnd.Value;
            TimeSpan duration;
            duration = endDay - startDay;
            totalDays = duration.Days + 1;
            txtDuration.Text = $"{totalDays} day(s)";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            TimeSpan duration;
            int totalDays;
            float totalAmount;
            float dailyFee;

            DateTime startDay = DtpStart.Value;
            DateTime endDay = DtpEnd.Value;
            dailyFee = float.Parse(txtDaily.Text);


            duration = endDay - startDay;
            totalDays = duration.Days;

            // Calculate the total amount
            totalAmount = totalDays * dailyFee;

            int years = endDay.Year - startDay.Year;
            int months = endDay.Month - startDay.Month;
            int days = endDay.Day - startDay.Day;

            // Adjust the years and months if necessary
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(endDay.AddMonths(-1).Year, endDay.AddMonths(-1).Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }

            // Display the formatted duration
            txtDuration.Text = $"{years} year(s), {months} month(s), {days} day(s)";

            txtTotal.Text = totalAmount.ToString("C");
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DateTime startDay = DtpStart.Value;
            DateTime endDay = DtpEnd.Value;
            int months = endDay.Month - startDay.Month;
            int days = endDay.Day - startDay.Day;
            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(endDay.AddMonths(-1).Year, endDay.AddMonths(-1).Month);
            }
            txtDuration.Text = $" {months} month(s), {days} day(s)";

        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            DateTime startDay = DtpStart.Value;
            DateTime endDay = DtpEnd.Value;
            int years = endDay.Year - startDay.Year;
            int months = endDay.Month - startDay.Month;
            if (months < 0)
            {
                years--;
                months += 12;
            }
            txtDuration.Text = $"{years} year(s), {months} month(s)";
        }
    }
}
