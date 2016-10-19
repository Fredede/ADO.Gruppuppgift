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


namespace ADO_Gruppuppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lboCategories.MouseDoubleClick += new MouseEventHandler(lboCategories_DoubleClick);
            lboShow.MouseDoubleClick += new MouseEventHandler(lboShow_DoubleClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lboCategories.Items.Clear();

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "SELECT CategoryName FROM Categories";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lboCategories.Items.Add(reader["CategoryName"].ToString());
                    }
                }
            }
            connection.Close();
        }

        private void lboCategories_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lboCategories.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                    DisplayProducts();
            }
        }

        public void DisplayProducts()
        {
            lboShow.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            connection.Open();

            var cat = connection.CreateCommand();
            cat.CommandText = "SELECT CategoryID FROM Categories WHERE CategoryName=@CategoryName";
            cat.Parameters.AddWithValue("@CategoryName", lboCategories.SelectedItem);
            int catID = (int)cat.ExecuteScalar();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "SELECT ProductName FROM Products " +
                                      "WHERE [CategoryID] LIKE @CategoryID";
                command.Parameters.AddWithValue("@CategoryID", catID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lboShow.Items.Add(reader["ProductName"].ToString());
                    }
                }
            }
            connection.Close();
        }

        public void UpdateProducts()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string newProductName = tbxProduct.Text;
            string newUnitPrice = tbxPrice.Text;

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Products SET ProductName = @nm, UnitPrice = @pr " + 
                                                      "WHERE ProductName = @pn";

                command.Parameters.AddWithValue("@pn", lboShow.SelectedItem);
                command.Parameters.AddWithValue("@nm", newProductName);
                command.Parameters.AddWithValue("@pr", newUnitPrice);

                connection.Open();

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }

        private void lboShow_DoubleClick(object sender, MouseEventArgs e)
        {
            var productName = lboShow.SelectedItem;
            int index = this.lboShow.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                tbxProduct.Text = productName.ToString();    
                FindNameAndPrice();
            }
        }
        public void FindNameAndPrice()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "SELECT UnitPrice FROM Products " +
                                                      "WHERE ProductName = @pn";

                command.Parameters.AddWithValue("@pn", lboShow.SelectedItem);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tbxPrice.Text = (reader["UnitPrice"].ToString());
                    }
                }
                command.ExecuteNonQuery();
            }
            connection.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //using (SqlCommand command = connection.CreateCommand()) {

            string query = "INSERT INTO Products (ProductName, UnitPrice, CategoryID)";
            query += " VALUES (@ProductName, @UnitPrice, @CategoryID)";
            connection.Open();

            SqlCommand myCommand = new SqlCommand(query, connection);

            myCommand.Parameters.AddWithValue("@ProductName", tbxNewProductName.Text);
            myCommand.Parameters.AddWithValue("@UnitPrice", tbxNewPrice.Text);
            myCommand.Parameters.AddWithValue("@CategoryID", tbxNewCategoryID.Text);


            myCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
