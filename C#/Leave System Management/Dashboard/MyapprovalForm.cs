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
    public partial class MyapprovalForm : Form
    {
        public MyapprovalForm()
        {
            InitializeComponent();
            datagrid.CellClick += dataGridView1_CellClick;

           
        }

        private void MyapprovalForm_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            string ConectoinString = "Data Source=LORN-BUNCHUY\\SQLEXPRESS01;Initial Catalog=cshap;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConectoinString);

            con.Open();

            string Query = "select * from newrepuest";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            datagrid.DataSource = table;
            con.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row (not headers)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagrid.Rows[e.RowIndex];

                // Retrieve information from the selected row
                string RequsetNo = row.Cells["RequestNo"].Value.ToString();
                string StaffId = row.Cells["StaffID"].Value.ToString();
                string StaffName = row.Cells["StaffName"].Value.ToString();
                string RequestDate = row.Cells["RequestDate"].Value.ToString();
                string ApprovedBy = row.Cells["ApprovedBy"].Value.ToString();
                string Position = row.Cells["Position"].Value.ToString();
                string dateManage = row.Cells["DateManage"].Value.ToString();
                string TypeOfLeave = row.Cells["TypeOfLeave"].Value.ToString();
                

                // 
                // Open the CheckForm and pass the information
                CheckForm checkForm = new CheckForm(RequsetNo, StaffId, StaffName, RequestDate, ApprovedBy, dateManage,TypeOfLeave);
                if (checkForm.ShowDialog() == DialogResult.OK)
                {
                    // Update DateManage column based on approval status
                    if (checkForm.IsApproved)
                    {
                        // If approved, set DateManage to the selected date
                        datagrid.Rows[e.RowIndex].Cells["DateManage"].Value = checkForm.SelectedDate.ToShortDateString();
                    }
                    else if (checkForm.IsRejected)
                    {
                        // If rejected, show "Rejected"
                        datagrid.Rows[e.RowIndex].Cells["DateManage"].Value = "Rejected";
                    }
                }


            }
        }
    }
}
