using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class NewRequestForm : Form
    {
        //private MyapprovalForm newOrder = new MyapprovalForm();
        public NewRequestForm()
        {
            InitializeComponent();
          
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttSubmit_Click(object sender, EventArgs e)
        {

        }

        private void NewRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void bttCancel_Click(object sender, EventArgs e)
        {


            /*  textBox1.Clear();
              textBox2.Clear();
              comboTypeOfLeave;
              dateTimeRequestD;
              dateTimeFromeDay;
              dateTimePicker1;
              timeIn;
              timeOut;
              comboCertifiedBy;
              comboAuthorizedBy;
              comboBox7;*/

        }

        private void bttSubmit_Click_1(object sender, EventArgs e)
        {

            string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConectoinString);

            con.Open();

            string Query = "INSERT INTO newrepuest (StaffId, StaffName, RequestDate, ApprovedBy, Position, TypeOfLeave, FromDate, TimeIn, TimeOut) VALUES ('" + textBox2.Text + "','" + textName.Text + "','" + dateTimeRequestD.Value + "','" + ApprovedBy.Text + "','" + comboBox7.SelectedItem + "' , '" + comboTypeOfLeave.SelectedItem + "',  '" + dateTimeFromeDay.Value + "', '" + timeIn.Value + "', '" + timeOut.Value + "' )";
            //NSERT INTO newrepuest (IDCard, Name, TypeOfLeave, RequestDate, FromDate, ToDate, TimeIn, TimeOut, Duration, CertifiedBy,  Position, AuthorizedBy) VALUES(,'" + textName.Text+"', '"+comboTypeOfLeave.SelectedItem+"', ,, , '"+timeIn.Value+"', '"+timeOut.Value+"' , '"+textBox1.Text+"',,  '"+comboBox7.SelectedItem+"', '"+comboAuthorizedBy.SelectedItem+"')
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data has been saved");

           

            textName.Clear();
            textBox2.Clear();
            comboTypeOfLeave.SelectedIndex = -1; // Reset combo box selection
            dateTimeRequestD.Value = DateTime.Today; // Reset date to today
            dateTimeFromeDay.Value = DateTime.Today; // Reset date to today
            dateTimePicker1.Value = DateTime.Today; // Reset date to today
            timeIn.Value = new DateTime(2000, 1, 1, 0, 0, 0); // Reset time to midnight
            timeOut.Value = new DateTime(2000, 1, 1, 0, 0, 0); // Reset time to midnight
            comboBox7.SelectedIndex = -1; // Reset combo box selection*/
        }

        private void ApprovedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttCancel_Click_1(object sender, EventArgs e)
        {
            textName.Clear();
            textBox2.Clear();
            comboTypeOfLeave.SelectedIndex = -1; // Reset combo box selection
            dateTimeRequestD.Value = DateTime.Today; // Reset date to today
            dateTimeFromeDay.Value = DateTime.Today; // Reset date to today
            dateTimePicker1.Value = DateTime.Today; // Reset date to today
            timeIn.Value = new DateTime(2000, 1, 1, 0, 0, 0); // Reset time to midnight
            timeOut.Value = new DateTime(2000, 1, 1, 0, 0, 0); // Reset time to midnight
            comboBox7.SelectedIndex = -1; // Reset combo box selection*/
            FromTime.Clear();
            TotalTime.Clear();
            TotalTime.Clear();
            txttotaldate.Clear();
        }

        private void TotalTime_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

            DateTime fromtime = DateTime.Parse(FromTime.Text);
            DateTime totime = DateTime.Parse(ToTime.Text);
            TimeSpan workHours = totime - fromtime ;

            TotalTime.Text = string.Format("{0} hours, {1} minutes", workHours.Hours, workHours.Minutes);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            // Get the selected dates from the DateTimePickers
            DateTime fromDate = dateTimeFromeDay.Value;
            DateTime toDate = dateTimePicker1.Value;

            // Calculate the difference in days
            TimeSpan difference = toDate - fromDate;
            int daysDifference = difference.Days;

            // Display the result
            txttotaldate.Text = $"days to leave: {daysDifference}";
        }
    }
}
