using BengMealeaDB.Class;
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

namespace BengMealeaDB
{
    public partial class ReceiptForm : Form
    {
        public int ordnum;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

            //DataSet dataSet;
            //SqlConnection conn;
            //SqlDataAdapter dataAdapter;
            //Microsoft.Reporting.WinForms.ReportDataSource rptDataSource;

            //reportViewer1.Visible = true;
            //dataSet = new DataSet();
            //conn = new SqlConnection(AddConnection.GetConnection());

            //dataAdapter = new SqlDataAdapter("Exec OrderDetails @OrdNo", conn);
            //dataAdapter.SelectCommand.Parameters.AddWithValue("@OrdNo", OrderForm.ordnum); // Pass the order number as parameter


            //conn.Close();
            //conn.Open();
            //dataAdapter.Fill(dataSet, "OrderDetails");

            //rptDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet.Tables[0]);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rptDataSource);

            //this.reportViewer1.RefreshReport();
            //conn.Close();




            DataSet orderDataSet;
            DataSet detailsDataSet;
            SqlConnection conn;
            SqlDataAdapter orderAdapter;
            SqlDataAdapter detailsAdapter;
            Microsoft.Reporting.WinForms.ReportDataSource rptOrderDataSource;
            Microsoft.Reporting.WinForms.ReportDataSource rptDetailsDataSource;

            reportViewer1.Visible = true;

            // Initialize datasets
            orderDataSet = new DataSet();
            detailsDataSet = new DataSet();

            // Create and open the connection
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();

            // Fetch "Order" data into DataSet1 (assuming Order table contains an order number column)
            orderAdapter = new SqlDataAdapter("SELECT * FROM Orders WHERE OrdNo = @OrdNo", conn);
            orderAdapter.SelectCommand.Parameters.AddWithValue("@OrdNo", OrderForm.ordnum); // Pass the order number as parameter
            orderAdapter.Fill(orderDataSet, "Orders");  // Fill the dataset with "Orders" table data

            // Fetch "Details" data into DataSet2 (assuming Details table has order-related information)
            detailsAdapter = new SqlDataAdapter("SELECT * FROM Details WHERE OrdNo = @OrdNo", conn);
            detailsAdapter.SelectCommand.Parameters.AddWithValue("@OrdNo", OrderForm.ordnum); // Pass the order number as parameter
            detailsAdapter.Fill(detailsDataSet, "Details");  // Fill the dataset with "Details" table data

            // Bind "Orders" data to the report as DataSet1
            rptOrderDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", orderDataSet.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();  // Clear previous data sources
            reportViewer1.LocalReport.DataSources.Add(rptOrderDataSource);

            // Bind "Details" data to the report as DataSet2
            rptDetailsDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", detailsDataSet.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rptDetailsDataSource);  // Add second dataset

            // Refresh the report to display the data
            this.reportViewer1.RefreshReport();

            // Close the connection
            conn.Close();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
