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
    public partial class SystemLogForm : Form
    {
        public SystemLogForm()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGrid()
        {
            dataGridView1.Rows.Add(1, 109, "01/04/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(2, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(3, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(4, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(5, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(6, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(7, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(8, 112, "01/04/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(9, 113, "01/04/2024 17:03:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(10, 110, "01/04/2024 17:05:00 pm", "Request leave", "request");

            dataGridView1.Rows.Add(11, 114, "01/05/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(12, 114, "01/05/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(13, 115, "01/05/2024 17:30:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(14, 116, "01/06/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(15, 116, "01/06/2024 12:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(16, 117, "01/06/2024 14:30:00 pm", "Log in", "staff");
            dataGridView1.Rows.Add(17, 117, "01/06/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(18, 118, "01/07/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(19, 118, "01/07/2024 12:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(20, 119, "01/08/2024 07:30:00 am", "Log in", "staff");

            dataGridView1.Rows.Add(21, 119, "01/08/2024 12:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(22, 119, "01/08/2024 15:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(23, 120, "01/09/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(24, 120, "01/09/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(25, 121, "01/10/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(26, 121, "01/10/2024 17:30:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(27, 122, "01/11/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(28, 122, "01/11/2024 17:00:00 pm", "Log out", "staff");
            dataGridView1.Rows.Add(29, 123, "01/12/2024 07:30:00 am", "Log in", "staff");
            dataGridView1.Rows.Add(30, 123, "01/12/2024 17:30:00 pm", "Log out", "staff");


            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 12.0f);
        }

        private void btnSeachUser_Click(object sender, EventArgs e)
        {
            string userID = txtSearch.Text;

            // Loop through rows and select the row with matching User ID
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["UserID"].Value != null && row.Cells["UserID"].Value.ToString() == userID)
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    return; // Exit the loop after finding the first match
                }
            }
            MessageBox.Show("No logs found for the specified User ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
