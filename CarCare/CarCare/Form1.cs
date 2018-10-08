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
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=carCareDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlCommand command = new SqlCommand();

        public Form1()
        {
            command.CommandType = CommandType.Text;
            command.Connection = connection;
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
            addCust ac = new addCust(connection, command);
            ac.Show();
            formRefresh();
        }

        private void formRefresh()
        {

        }
    }
}
