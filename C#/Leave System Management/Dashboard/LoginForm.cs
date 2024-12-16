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
    public partial class Form1 : Form
    {
        public static string username = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin form
            Admin adminForm = new Admin();

            // Show the Admin form
            adminForm.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" || txtUsername.Text == "S1Phanith" || txtUsername.Text == "User1")
            {
                if (txtPassword.Text == "123")
                {
                    LoginForm.ActiveForm.TopMost = false;
                    username = txtUsername.Text;
                    MessageBox.Show("Successful!");
                    LoginForm main = new LoginForm();//MainForm
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Password is invalid!");
                }
            }
            else
            {
                MessageBox.Show("Username is invalid!");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Link Register
        {
            RegisterForm Form = new RegisterForm();
            Form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
