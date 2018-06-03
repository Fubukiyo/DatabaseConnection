using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.Product";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showAddress_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.Address";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showCustomer_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.Customer";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.CustomerAddress";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showPCategory_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.ProductCategory";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showPDescription_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.ProductDescription";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showPModel_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.ProductModel";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showPModelPDesc_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.ProductModelProductDescription";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showSalesOrderDetail_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.SalesOrderDetail";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void showSalesOrderHeader_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SalesLT.SalesOrderHeader";
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void customQuery_Click(object sender, EventArgs e)
        {
            var select = textBox1.Text;
            var c = new SqlConnection("Data Source = thisthing.database.windows.net; Initial Catalog = myDatabase; Persist Security Info = True; User ID = red; Password = Passw0rd");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}

