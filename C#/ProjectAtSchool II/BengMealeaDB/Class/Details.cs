using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BengMealeaDB.Class
{
    internal class Details
    {
        public int OrdNo { get; set; }
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float Amount { get; set; }
        public Details(Orders orders)
        {
            this.OrdNo = orders.OrdNo;
        }


        public bool InsertDetails()
        {
            bool check;
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(AddConnection.GetConnection()))
            {
                cmd = new SqlCommand("Insert into Details values (@OrdNo,@ItemNo,@Description,@Quantity,@UnitPrice,@Amount);", con);

                cmd.Parameters.AddWithValue("@OrdNo", OrdNo);
                cmd.Parameters.AddWithValue("@ItemNo", ItemNo);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                cmd.Parameters.AddWithValue("@Amount", Amount);
      


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
    }
}
