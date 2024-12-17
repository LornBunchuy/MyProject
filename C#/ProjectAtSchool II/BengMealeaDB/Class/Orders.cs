using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BengMealeaDB.Class
{
    internal class Orders
    {
        public int OrdNo { get; set; }
        public DateTime OrdDate { get; set; }
        public int EmpNo { get; set; }
        public int CustNo { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string GrandTotal { get; set; }

        public bool InsertOrder()
        {
            bool check;
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Insert into Orders values(@OrdNo,@OrderDate,@EmpNo,@CustNo,@Location,@Status,@GrandTotal);", con);

                cmd.Parameters.AddWithValue("@OrdNo", OrdNo);
                cmd.Parameters.AddWithValue("@OrderDate", OrdDate);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@CustNo", CustNo);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@GrandTotal", GrandTotal);

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }
                return check;
            }
           
            
        }
        public bool RemoveOrder()
        {
            string sql; bool check;
            SqlConnection conn; SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Close();
                sql = "Delete from Orders where OrdNo = @OrdNo;";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrdNo", OrdNo);
                dataAdapter.DeleteCommand = cmd;
                try
                {
                    dataAdapter.DeleteCommand.ExecuteNonQuery();
                    check = true;
                    cmd.Dispose();
                    conn.Close();

                }
                catch (Exception)
                {
                    check = false;
                }
            }
            return check;
        }

        public bool UpdateOrder()
        {
            //Declare
            string sql; bool check;
            SqlConnection conn; SqlCommand cmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //Input
            using (conn = new SqlConnection(AddConnection.GetConnection()))
            {
                //Process
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                sql = "Update Orders set OrderDate=@OrderDate, EmpNo=@EmpNo, CustNo=@CustNo, [Location]=@Location" +
                      ", [Status]=@Status, [GrandTotal]= GrandTotal where OrdNo=@OrdNo;";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrdNo", OrdNo);
                cmd.Parameters.AddWithValue("@OrderDate", OrdDate);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@CustNo", CustNo);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                dataAdapter.UpdateCommand = cmd;
                try
                {
                    dataAdapter.UpdateCommand.ExecuteNonQuery(); //Run
                    check = true;
                    cmd.Dispose(); conn.Close();
                }
                catch (Exception)
                {
                    check = false;
                }
            }
            return check;
        }
        public bool SearchOrder(int orderNo)
        {
            this.OrdNo = orderNo;
            bool check = false;
            using (SqlConnection conn = new SqlConnection(AddConnection.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand("Select * from Orders where OrdNo=@OrdNo;", conn);
                cmd.Parameters.AddWithValue("@OrdNo", OrdNo);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //OrdNo = int.Parse(dataReader.GetValue(0).ToString());
                        OrdDate = DateTime.Parse(dataReader.GetValue(1).ToString());
                        EmpNo = int.Parse(dataReader.GetValue(2).ToString());
                        CustNo = int.Parse(dataReader.GetValue(3).ToString());
                        Location = dataReader.GetValue(4).ToString();
                        Status = dataReader.GetValue(5).ToString();
                        GrandTotal = dataReader.GetValue(6).ToString();
                        check = true;
                    }
                }
                else
                    check = false;
                dataReader.Close();
                conn.Close();
            }
            return check;
        }

    }



}

