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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connectionString="Data Source=MSSQL;Initial Catalog=Northwind;Integrated Security"
            //using (SqlConnection connection = new SqlConnection(""))
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
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;

                command.CommandText = "SELECT ProductName FROM Products" /* +
                                      "WHERE[CategoryID] LIKE @CategoryID"*/;
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


}
}
