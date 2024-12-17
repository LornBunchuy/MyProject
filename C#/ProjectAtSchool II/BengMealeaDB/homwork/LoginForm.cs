using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BengMealeaDB.homwork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            string password = TxtPassword.Text;
            string confirmPassword = TxtConfirmPassword.Text;

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            // Database connection string
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                MessageBox.Show("DB Connection Established!");

                // Example of how you might validate the user credentials
                string sql = "SELECT COUNT(1) FROM CreateUser WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(sql, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = (int)cmd.ExecuteScalar();
                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!");
                        MainForm mainForm = new MainForm(); 
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                }
            }
        }

        private void LbCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUserForm createForm = new CreateUserForm();
            createForm.Show();
        }
    }
}


