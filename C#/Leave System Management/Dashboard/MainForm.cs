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
    public partial class LoginForm : Form
    {
        
        public static Form sForm = null;
        bool btnState = false;
        public LoginForm()
        {
            InitializeComponent();
            OpenForm(new Admin());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            if (Form1.username == "S1Phanith")
            {
                BtnApproval.Height = 0;
                BtnUserManagement.Height = 0;
                BtnSystemLog.Height = 0;
            }
            else if(Form1.username == "User1")
            {
                BtnApproval.Height = 0;
                BtnUserManagement.Height = 0;
                BtnRequest.Height = 0;
                BtnSystemLog.Height = 0;
            }
            LbWelcom.Text = "Welcome, " + Form1.username;

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        public void OpenForm(Form childForm)//order
        {
            if (sForm != null)
                sForm.Close();
            sForm = childForm;  //sForm = order
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            PanelShow.Controls.Add(childForm);
            PanelShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new Admin());
        }

        private void BtnRequest_Click(object sender, EventArgs e)
        {
            OpenForm(new Request());
        }

        private void BtnApproval_Click(object sender, EventArgs e)
        {
            OpenForm(new MyapprovalForm());
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            OpenForm(new UserManagementForm());
        }

        private void BtnSystemLog_Click(object sender, EventArgs e)
        {
            OpenForm(new SystemLogForm());
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            OpenForm(new AboutForm());
        }

        private void LbLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
