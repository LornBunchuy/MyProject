using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public static string username = " ";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Form1.close()
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "admin")
            {
                if (TxtPassword.Text == "123")
                {
                    MessageBox.Show("Successful!");
                    MainForm main = new MainForm();
                    main.Show();
                }
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           //Form1.close();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "admin" || TxtUserName.Text=="bunchuy")
            {
                if (TxtPassword.Text == "123")
                {
                    LoginForm.ActiveForm.TopMost = false;
                    username = TxtUserName.Text;
                    MessageBox.Show("Successful!");
                    MainForm main = new MainForm();
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

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
