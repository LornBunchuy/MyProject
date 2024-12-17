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
using System.Windows.Forms.DataVisualization.Charting;

namespace BengMealeaDB
{
    
    public partial class DashboardForm : Form
    {
        SqlConnection conn;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(AddConnection.GetConnection());
            CountCustomer();
            CountOrder();
            ProductSold();
            IncomeShow();
            ColumnChart();
            AreaChart();
            PieChart();
            BarChart();

        }
        private void CountCustomer()
        {
            // Declare
            SqlDataReader dataReader;
            SqlCommand cmd;
            int countAll = 0;
            int countToday = 0;

            // Input
            cmd = new SqlCommand("Select count(CustNo) from Customers;", conn);

            // Process
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    countAll = int.Parse(dataReader.GetValue(0).ToString());
                }
            }
            else
            {
                countAll = 0;
            }

            lblCustomer.Text = countAll.ToString();

            dataReader.Close();

            // Count orders today
            cmd = new SqlCommand("SELECT COUNT(CustNo) FROM Customers WHERE CAST(CustDate AS DATE) = CAST(GETDATE() AS DATE);", conn);

            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    countToday = int.Parse(dataReader.GetValue(0).ToString());
                }
            }

            // Display the count of orders today
            LblCustomerToday.Text = "+" + countToday.ToString();
            conn.Close();
        }
        private void CountOrder()
        {
            // Declare
            SqlDataReader dataReader;
            SqlCommand cmd;
            int countall = 0;
            int countday = 0;

            // Input
            cmd = new SqlCommand("Select count(OrdNo) from Orders;", conn);

            // Process
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    countall = int.Parse(dataReader.GetValue(0).ToString());
                }
            }
            else
            {
                countall = 0;
            }

            lblOrder.Text = countall.ToString();

            dataReader.Close();

            // Count orders today
            cmd = new SqlCommand("SELECT COUNT(OrdNo) FROM Orders WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE);", conn);

            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    countday = int.Parse(dataReader.GetValue(0).ToString());
                }
            }

            // Display the count of orders today
            LblOrderToday.Text = "+" + countday.ToString();
            conn.Close();
        }
        private void ProductSold()
        {
            // Declare
            SqlDataReader dataReader;
            SqlCommand cmd;
            int countAll = 0;
            int countToday = 0;

            // Input
            cmd = new SqlCommand("SELECT COUNT(DISTINCT ItemNo) AS TotalUniqueItemNo\r\nFROM Details;\r\n;", conn);

            // Process
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            dataReader = cmd.ExecuteReader(); // Run

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    countAll = int.Parse(dataReader.GetValue(0).ToString());
                }
            }
            else
            {
                countAll = 0;
            }

            lblProductSold.Text = countAll.ToString();
            dataReader.Close();

            cmd = new SqlCommand(@"
            SELECT COUNT(D.ItemNo) AS TotalItems
            FROM Details D
            INNER JOIN Orders O ON D.OrdNo = O.OrdNo
            WHERE CAST(O.OrderDate AS DATE) = CAST(GETDATE() AS DATE);", conn);


            dataReader = cmd.ExecuteReader(); // Run

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    countToday = int.Parse(dataReader.GetValue(0).ToString());
                }
            }
            else
            {
                countToday = 0;
            }

            LblProductToday.Text = "+" + countToday.ToString();
            // Output
            conn.Close();
        }
        private void IncomeShow()
        {
            //Declare
            SqlDataReader dataReader;
            SqlCommand cmd;
            float count = 0;
            float todayIncome = 0;

            //Input
            cmd = new SqlCommand("Select sum(Quantity * UnitPrice) as Total from Details;", conn);

            //Process
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            dataReader = cmd.ExecuteReader(); //Run
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    count = float.Parse(dataReader.GetValue(0).ToString());
                }
            }
            else
            {
                count = 0;
            }

            lblIncome.Text = count.ToString("C2"); //Output

            dataReader.Close();

            // Input: Calculate today's income
            cmd = new SqlCommand(@"
            SELECT SUM(D.Quantity * D.UnitPrice) AS TotalToday
            FROM Details D
            INNER JOIN Orders O ON D.OrdNo = O.OrdNo
            WHERE CAST(O.OrderDate AS DATE) = CAST(GETDATE() AS DATE);", conn);

            dataReader = cmd.ExecuteReader(); // Run for today's income

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    todayIncome = float.Parse(dataReader.GetValue(0).ToString());
                }
            }
            else
            {
                todayIncome = 0; // No income today
            }

            LblIncomeToday.Text = todayIncome.ToString("C2");
            conn.Close();
        }
        private void ColumnChart()
        {
            //Declare
            SqlConnection conn;          //Connect Database
            SqlCommand cmd;              //For SQL language code
            SqlDataAdapter da;           //Transmit data from database
            DataSet ds;                  //Store data table in memory
            Title title;

            //Input
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();

            cmd = new SqlCommand("SELECT DATENAME(month, Orders.OrderDate) as Months, " +
                                 "SUM(Details.Quantity * Details.UnitPrice) as Total FROM Orders " +
                                 "INNER JOIN Details ON Orders.OrdNo = Details.OrdNo " +
                                 "GROUP BY DATENAME(month, Orders.OrderDate) Order By Months;", conn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            chartColumn.DataSource = ds.Tables[0]; //Datasource = ds.Table

            chartColumn.Series[0].XValueMember = "Months";  //Set title to Axis X
            chartColumn.Series[0].YValueMembers = "Total";  //Set title to Coordinate Y

            //Chart Title
            title = new Title();
            title.Text = "Income Profit By Months";
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Gray;
            this.chartColumn.Titles.Add(title);

            chartColumn.Series[0].ChartType = SeriesChartType.Column; //Chart Type
            chartColumn.Series[0].IsValueShownAsLabel = true;      //Show value
            chartColumn.Series[0].LabelFormat = "C";               //Label Format
            chartColumn.Legends[0].Docking = Docking.Bottom;

            conn.Close();
        }
        private void AreaChart()
        {
            //Declare
            SqlConnection conn;  //Connect Database
            SqlCommand cmd;     //For sql language code
            SqlDataAdapter da;  //Transmit data from database
            DataSet ds;         //Store data table in memory
            Title title;

            //Input
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();
            cmd = new SqlCommand("SELECT DATENAME(month,Orders.OrderDate)" +
                " as Months, Sum(Details.Quantity)as Total FROM Orders " +
                "INNER JOIN Details ON Orders.OrdNo = Details.OrdNo " +
                " Group By DATENAME(month, Orders.OrderDate) Order By DATENAME(month,Orders.OrderDate) asc; ", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            //Process
            da.Fill(ds);
            chartArea.DataSource = ds.Tables[0]; // Datasource = ds.Table
            //Output
            chartArea.Series[0].XValueMember = "Months";       //Set title to Axis X
            chartArea.Series[0].YValueMembers = "Total";      //Set title to Coordinate Y
            //Chart Title
            title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.Text = "Sold Items By Month";
            title.ForeColor = Color.Gray;
            this.ChartPie.Titles.Add(title);

            chartArea.Series[0].ChartType = SeriesChartType.StackedArea;//Chart Type
            chartArea.Series[0].IsValueShownAsLabel = true;    //Show value
            chartArea.Legends[0].Docking = Docking.Bottom;

            conn.Close();
        }
        private void PieChart()
        {
            //Declare
            SqlConnection conn;  //Connect Database
            SqlCommand cmd;     //For sql language code
            SqlDataAdapter da;  //Transmit data from database
            DataSet ds;         //Store data table in memory
            Title title;

            //Input
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();
            cmd = new SqlCommand("Select Status As Categories, count(Status)" +
                " As NumOfStatus From [Orders] Group by [Status];", conn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            //Process
            da.Fill(ds);
            ChartPie.DataSource = ds.Tables[0]; // Datasource = ds.Table


            //Output
            ChartPie.Series[0].XValueMember = "Categories";       //Set title to Axis X
            ChartPie.Series[0].YValueMembers = "NumOfStatus";      //Set title to Coordinate Y
            //Chart Title
            title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.Text = "Order Status";
            title.ForeColor = Color.Gray;
            this.ChartPie.Titles.Add(title);

            ChartPie.Series[0].ChartType = SeriesChartType.Pie;//Chart Type
            ChartPie.Series[0].IsValueShownAsLabel = true;    //Show value
            ChartPie.Legends[0].Docking = Docking.Bottom;

            conn.Close();
        }
        private void BarChart()
        {
            //Declare
            SqlConnection conn;  //Connect Database
            SqlCommand cmd;     //For sql language code
            SqlDataAdapter da;  //Transmit data from database
            DataSet ds;         //Store data table in memory
            Title title;

            //Input
            conn = new SqlConnection(AddConnection.GetConnection());
            conn.Open();
            cmd = new SqlCommand(@"SELECT Description AS ItemName, SUM(Quantity) AS NumOfItem 
                FROM Details 
                GROUP BY Description;;", conn);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();

            //Process
            da.Fill(ds);
            ChartBar.DataSource = ds.Tables[0]; // Datasource = ds.Table

            //Output
            ChartBar.Series[0].XValueMember = "ItemName";       //Set title to Axis X
            ChartBar.Series[0].YValueMembers = "NumOfItem";      //Set title to Coordinate Y

            //Chart Title
            title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.Text = "Sold Number of Items";
            title.ForeColor = Color.Gray;
            this.ChartBar.Titles.Add(title);

            //Bar Chart Color
            
            ChartBar.Series[0].ChartType = SeriesChartType.Bar;//Chart Type
            ChartBar.Series[0].IsValueShownAsLabel = true;    //Show value
            ChartBar.Legends[0].Docking = Docking.Bottom;



            conn.Close();


        }

    }
}
