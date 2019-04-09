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
    public partial class AddCustomer : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public AddCustomer(SqlConnection connection, SqlCommand command)
        {
            this.connection = connection;
            this.command = command;
            InitializeComponent();
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            //Get data from form into variables
            string name = nameTxt.Text;
            string address = addressTxt.Text;
            string make = makeTxt.Text;
            string model = modelTxt.Text;
            int year = Convert.ToInt32(yearInt.Value);
            string license = licenseTxt.Text;

            command = new SqlCommand("AddNewCust", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command = new SqlCommand("AddNewCar", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("make", make);
            command.Parameters.AddWithValue("model", model);
            command.Parameters.AddWithValue("year", year);
            command.Parameters.AddWithValue("license", license);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Close();
        }
    }
}
