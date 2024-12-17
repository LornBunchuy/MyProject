using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            //DECLARE
            DateTime timeIn = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute,0);
            DateTime timeOut = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0);
            TimeSpan duration = timeOut.Subtract(timeIn);
            Double s=duration.TotalHours;
            Double Amount = s * double.Parse(txtrate.Text);
            TxtDuration.Text = duration.ToString();
            MessageBox.Show(Amount.ToString());
        }
    }
}
