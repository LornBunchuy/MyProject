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
using System.Data.SqlClient;

namespace BengMealeaDB
{
    public partial class CreateUser : Form
    {
        public static SqlConnection sqlConn;
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            SqlDataReader dataReader;

            sql = "Select * from [user] where userId = '" + txtUserId.Text + "';";
            cmd = new SqlCommand(sql, Form1.sqlConn);

            Form1.sqlConn.Close();
            Form1.sqlConn.Open();   

            dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    txtUserId.Text = dataReader.GetValue(0).ToString();
                    txtUserName.Text = dataReader.GetValue(1).ToString();
                    TxtUserPassword.Text = dataReader.GetValue(2).ToString();
                    txtConfirmed.Text = dataReader.GetValue(3).ToString();
                    CbUserRole.Text = dataReader.GetValue(4).ToString();
                }
                MessageBox.Show("User  is found !");
                Form1.sqlConn.Close();

            }
            else
            {
                MessageBox.Show("User is not found !");
                Form1.sqlConn.Close();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* string connStr;
            connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Year 2, Semester 2\\IT 207 .Net C# Programming II\\repos\\BengMealeaDB\\BengMealeaDB\\Database1.mdf\";Integrated Security=True";
            sqlConn = new SqlConnection(connStr);
            sqlConn.Open();
            MessageBox.Show("DB Connection!");*/
           txtUserId.Clear();
            txtUserName.Clear();    
            txtConfirmed.Clear();   
             TxtUserPassword.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            SqlDataAdapter dataAdapter;

            //Open Db
            Form1.sqlConn.Close();
            Form1.sqlConn.Open();

            sql = "insert into [user] values ('" + txtUserId.Text + "','"+txtUserName.Text+"','"+TxtUserPassword.Text+"','"+txtConfirmed.Text+"','"+CbUserRole.Text+"');";

            dataAdapter = new SqlDataAdapter();
            cmd = new SqlCommand(sql, Form1.sqlConn);

            dataAdapter.InsertCommand = new SqlCommand(sql, Form1.sqlConn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("user instead");

            cmd.Dispose();
            Form1.sqlConn.Close();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            SqlDataAdapter dataAdapter;

            //Open Db
            Form1.sqlConn.Close();
            Form1.sqlConn.Open();

            sql = "update [user] set username = '" + txtUserName.Text + "', [password] = '" + TxtUserPassword.Text + "', confirmed='" + txtConfirmed.Text + "', [role]='" + CbUserRole.Text + "' where userId='"+txtUserId.Text +"';";

            dataAdapter = new SqlDataAdapter();
            cmd = new SqlCommand(sql, Form1.sqlConn);

            dataAdapter.InsertCommand = new SqlCommand(sql, Form1.sqlConn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("user Update !");

            cmd.Dispose();
            Form1.sqlConn.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd;
            SqlDataAdapter dataAdapter;

            //Open Db
            Form1.sqlConn.Close();
            Form1.sqlConn.Open();

            sql = "delete from [user] where userId = '" + txtUserId.Text + "';";

            dataAdapter = new SqlDataAdapter();
            cmd = new SqlCommand(sql, Form1.sqlConn);

            dataAdapter.InsertCommand = new SqlCommand(sql, Form1.sqlConn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("user deleted !");

            cmd.Dispose();
            Form1.sqlConn.Close();
        }
    }
}
