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
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                txtPath.Text = selectedImagePath;

                // Display the selected image in the PictureBox
                pictureBox1.Image = new System.Drawing.Bitmap(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            /*  string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

              SqlConnection con = new SqlConnection(ConectoinString);

              con.Open();

              string Query = "INSERT INTO staff_information (StaffID, StaffName, Position, Unit, Department, Sex, PhoneNumber, Address, DateOfBirth, Email, Path) VALUES('" + txtstaffid.Text + "','"+ txtstaffname.Text +"','"+ comboBoxposition.SelectedItem + "','"+ comboBoxunit.SelectedItem+ "','"+ comboBoxdepartment.SelectedItem +"','"+comboBoxsex.SelectedItem+"','"+ txtphone.Text + "','"+ txtaddress.Text + "','"+ dateTimePicker1.Value + "','"+ textBoxemail.Text + "','"+ txtPath.Text + "') ";
              SqlCommand cmd = new SqlCommand(Query, con);
              cmd.ExecuteNonQuery();

              con.Close();

              MessageBox.Show("Data has been saved");
  */

            string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(ConectoinString))
                {
                    con.Open();

                    string Query = "INSERT INTO staff_information (StaffID, StaffName, Position, Unit, Department, Sex, PhoneNumber, Address, DateOfBirth, Email, Path) VALUES(@StaffID, @StaffName, @Position, @Unit, @Department, @Sex, @PhoneNumber, @Address, @DateOfBirth, @Email, @Path)";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    // Set parameters to avoid SQL injection and improve performance
                    cmd.Parameters.AddWithValue("@StaffID", txtstaffid.Text);
                    cmd.Parameters.AddWithValue("@StaffName", txtstaffname.Text);
                    cmd.Parameters.AddWithValue("@Position", comboBoxposition.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Unit", comboBoxunit.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Department", comboBoxdepartment.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Sex", comboBoxsex.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Email", textBoxemail.Text);
                    cmd.Parameters.AddWithValue("@Path", txtPath.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Data has been saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            pictureBox1.Image = null;
            txtstaffid.Text = "";
            txtstaffname.Text = "";
            comboBoxposition.SelectedIndex = -1; // Assuming you want to deselect any selected item
            comboBoxunit.SelectedIndex = -1;
            comboBoxdepartment.SelectedIndex = -1;
            comboBoxsex.SelectedIndex = -1;
            txtphone.Text = "";
            txtaddress.Text = "";
            dateTimePicker1.Value = DateTime.Now; // Set DateTimePicker to current date
            textBoxemail.Text = "";
            txtPath.Text = "";

            // Optionally, focus on the first textbox after reset
            txtstaffid.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConectoinString))
            {
                con.Open();

                string Query = "DELETE FROM staff_information WHERE StaffID = @StaffID";

                SqlCommand cmd = new SqlCommand(Query, con);

                // Set parameter to avoid SQL injection and improve performance
                cmd.Parameters.AddWithValue("@StaffID", txtsearch.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully");
                }
                else
                {
                    MessageBox.Show("No record found with the provided StaffID");
                }

                con.Close();
            }


            pictureBox1.Image = null;
            txtstaffid.Text = "";
            txtstaffname.Text = "";
            comboBoxposition.SelectedIndex = -1; // Assuming you want to deselect any selected item
            comboBoxunit.SelectedIndex = -1;
            comboBoxdepartment.SelectedIndex = -1;
            comboBoxsex.SelectedIndex = -1;
            txtphone.Text = "";
            txtaddress.Text = "";
            dateTimePicker1.Value = DateTime.Now; // Set DateTimePicker to current date
            textBoxemail.Text = "";
            txtPath.Text = "";
            txtsearch.Clear();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConectoinString))
            {
                con.Open();

                string Query = "UPDATE staff_information SET StaffName = @StaffName, Position = @Position, Unit = @Unit, Department = @Department, Sex = @Sex, PhoneNumber = @PhoneNumber, Address = @Address, DateOfBirth = @DateOfBirth, Email = @Email, Path = @Path WHERE StaffID = @StaffID";

                SqlCommand cmd = new SqlCommand(Query, con);

                // Set parameters to avoid SQL injection and improve performance
                cmd.Parameters.AddWithValue("@StaffID", txtstaffid.Text);
                cmd.Parameters.AddWithValue("@StaffName", txtstaffname.Text);
                cmd.Parameters.AddWithValue("@Position", comboBoxposition.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Unit", comboBoxunit.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Department", comboBoxdepartment.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Sex", comboBoxsex.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PhoneNumber", txtphone.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Email", textBoxemail.Text);
                cmd.Parameters.AddWithValue("@Path", txtPath.Text);

                cmd.ExecuteNonQuery();

                con.Close();
            }

            MessageBox.Show("Data has been updated");

            pictureBox1.Image = null;
            txtstaffid.Text = "";
            txtstaffname.Text = "";
            comboBoxposition.SelectedIndex = -1; // Assuming you want to deselect any selected item
            comboBoxunit.SelectedIndex = -1;
            comboBoxdepartment.SelectedIndex = -1;
            comboBoxsex.SelectedIndex = -1;
            txtphone.Text = "";
            txtaddress.Text = "";
            dateTimePicker1.Value = DateTime.Now; // Set DateTimePicker to current date
            textBoxemail.Text = "";
            txtPath.Text = "";
            txtsearch.Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConectoinString))
            {
                con.Open();

                string Query = "SELECT * FROM staff_information WHERE StaffID = @StaffID";

                SqlCommand cmd = new SqlCommand(Query, con);

                // Set parameter to avoid SQL injection and improve performance
                cmd.Parameters.AddWithValue("@StaffID", txtsearch.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtstaffid.Text = reader["StaffID"].ToString();
                    txtstaffname.Text = reader["StaffName"].ToString();
                    comboBoxposition.SelectedItem = reader["Position"].ToString();
                    comboBoxunit.SelectedItem = reader["Unit"].ToString();
                    comboBoxdepartment.SelectedItem = reader["Department"].ToString();
                    comboBoxsex.SelectedItem = reader["Sex"].ToString();
                    txtphone.Text = reader["PhoneNumber"].ToString();
                    txtaddress.Text = reader["Address"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    textBoxemail.Text = reader["Email"].ToString();
                    txtPath.Text = reader["Path"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

                reader.Close();
                con.Close();
            }


        }
    }
}
