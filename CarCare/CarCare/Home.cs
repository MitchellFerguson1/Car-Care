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

namespace CarCare
{
    //This is to test commits from github profile
    public partial class Home : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlCommand command = new SqlCommand();

        public Home()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void addCust_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(connection, command);
            ac.Show();
        }

        private void formRefresh()
        {
            List<string> customerData = new List<string>();
            custList.Items.Clear();
            command = new SqlCommand("GetCustomers", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            string entry = null;

            while (reader.Read())
            {
                entry = reader["custId"].ToString() + " ";
                entry += reader["name"].ToString();
                custList.Items.Add(entry);
            }
            connection.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            formRefresh();
        }
    }
}
