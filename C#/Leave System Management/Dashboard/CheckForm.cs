using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class CheckForm : Form
    {
        public bool IsApproved { get; private set; }
        public DateTime SelectedDate { get { return dateTimePicker2.Value; } }
        public bool IsRejected { get; private set; }

        public CheckForm(string requestNo, string staffNo, string staffName, string requestDate, string approvedBy, string dateManage, string leaveType)
        {
            InitializeComponent();

            txtREQNO.Text = requestNo;
            txtSTAFFID.Text = staffNo;
            txtSTAFFNAME.Text = staffName;
            dateTimePicker1.Text = requestDate;
            txtAPPBY.Text = approvedBy;
            dateTimePicker2.Text = dateManage;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxREJECT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxREJECT.Checked)
            {
                IsRejected = true;
                IsApproved = false;
                checkBoxACCEPT.Checked = false;
            }
        }

        private void checkBoxACCEPT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxACCEPT.Checked)
            {
                IsRejected = false;
                IsApproved = true;
                checkBoxREJECT.Checked = false;
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSUBMIT_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
