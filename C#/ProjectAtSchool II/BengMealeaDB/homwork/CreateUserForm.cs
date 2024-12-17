using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BengMealeaDB.homwork
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userID = txtUserId.Text;
            string username = txtUserName.Text;
            string password = TxtUserPassword.Text;
            string confirmed = txtConfirmPasswod.Text;
            string role = CbUserRole.Text;

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Please enter User ID .");
                txtUserId.Focus();
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show(" Please enter Username.");
                txtUserName.Focus(); 
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Password .");
                TxtUserPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmed))
            {
                MessageBox.Show("Please enter Confirmed password .");
                txtConfirmPasswod.Focus(); 
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select Role .");
                CbUserRole.Focus(); 
                return;
            }

            // Validate the inputs
            if (password != confirmed)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            // Database connection string
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                // SQL to insert a new user
                string sql = "INSERT INTO CreateUser (UserID, UserName, Password,Confirmed, Role) VALUES (@UserID, @Username, @Password, @Confirmed, @Role)";
                using (SqlCommand cmd = new SqlCommand(sql, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Confirmed", confirmed);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error adding user.");
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string userID = txtUserId.Text.Trim();

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Please enter a UserID to remove.");
                return;
            }

            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                // First, retrieve the user's details
                string selectSql = "SELECT UserID, Username, Password, Confirmed, Role FROM CreateUser WHERE UserID = @UserID";
                using (SqlCommand selectCmd = new SqlCommand(selectSql, sqlConn))
                {
                    selectCmd.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the user's details
                            txtUserId.Text = reader["UserID"].ToString();
                            txtUserName.Text = reader["Username"].ToString();
                            TxtUserPassword.Text = reader["Password"].ToString();
                            txtConfirmPasswod.Text = reader["Confirmed"].ToString();
                            CbUserRole.Text = reader["Role"].ToString();

                            // Ask for confirmation before deletion
                            DialogResult result = MessageBox.Show($"Are you sure you want to remove the user '{txtUserName.Text}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                // Proceed to remove the user
                                reader.Close(); // Close the reader before executing another command

                                string deleteSql = "DELETE FROM CreateUser WHERE UserID = @UserID";
                                using (SqlCommand deleteCmd = new SqlCommand(deleteSql, sqlConn))
                                {
                                    deleteCmd.Parameters.AddWithValue("@UserID", userID);
                                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("User removed successfully!");
                                        // Optionally clear the input fields
                                        txtUserId.Clear();
                                        txtUserName.Clear();
                                        TxtUserPassword.Clear();
                                        txtConfirmPasswod.Clear();
                                        CbUserRole.SelectedIndex = -1; // Deselect the role
                                    }
                                    else
                                    {
                                        MessageBox.Show("User not found.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            string userID = txtUserId.Text.Trim();
            string username = txtUserName.Text.Trim();
            string password = TxtUserPassword.Text.Trim();
            string confirmed = txtConfirmPasswod.Text.Trim();
            string role = CbUserRole.Text.Trim();
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(username) ||
                  string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmed) ||
                  string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please search for a userID before modifying Or input all field.");
                return;
            }

            // Validate the inputs
            if (password != confirmed)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                string sql = "UPDATE CreateUser SET Username = @Username, Password = @Password, Confirmed = @Confirmed, Role = @Role WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(sql, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Confirmed", confirmed);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User modified successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User not found or no changes were made.");
                    }
                }
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userId =txtUserId.Text;
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter User ID .");
                txtUserId.Focus();
                return;
            }
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                string sql = "SELECT UserID, Username, Password, Confirmed, Role FROM CreateUser WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(sql, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUserId.Text = reader["UserID"].ToString();
                            txtUserName.Text = reader["Username"].ToString();
                            TxtUserPassword.Text = reader["Password"].ToString();
                            txtConfirmPasswod.Text = reader["Confirmed"].ToString();
                            CbUserRole.Text = reader["Role"].ToString();
                            MessageBox.Show("User is found!.");
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }
    }

}
