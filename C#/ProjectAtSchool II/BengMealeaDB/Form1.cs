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
using System.Data.Common;

namespace BengMealeaDB
{
    public partial class Form1 : Form
    {
        public static string username;
        public static SqlConnection sqlConn;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //declare 
            string connStr= "", sql = "", output = "";
            SqlConnection sqlConn;
            SqlDataReader dataRander;
            SqlCommand cmd;

            connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
             sqlConn = new SqlConnection(connStr);
            //input
            sqlConn.Open();
           
            //Process

            sql = "select username, [password] from [user] where username = '" +
                TxtUserName.Text + "' and [password] = '" + TxtPassword.Text + "';";
            cmd = new SqlCommand(sql, sqlConn);
            dataRander = cmd.ExecuteReader();
            if (dataRander.HasRows)
            {
                while (dataRander.Read())
                {
                    output += dataRander.GetString(0) + " , " + dataRander.GetValue(1);
                }
                //Output
                MessageBox.Show("Successfu1... !\n" + output);
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password...!");
            }
            sqlConn.Close();
        }

        private void LbCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser userForm = new CreateUser(); 
            userForm.Show();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr;
            connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\M\\source\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf;Integrated Security=True";
            sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            MessageBox.Show("DB Connection!");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
