using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarCare
{
    class DatabaseWorker
    {
        SqlConnection connection;
        SqlCommand command;
        public DatabaseWorker(SqlConnection connection, SqlCommand command)
        {
            this.connection = connection;
            this.command = command;
        }

        public List<string> customerSearch(string custName)
        {
            List<string> sameCustomers = new List<string>();
            string searchString = "SELECT custId, name, address FROM Customers WHERE name = @name";
            command = new SqlCommand(searchString, connection);
            command.Parameters.AddWithValue("@name", custName);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["custId"].ToString();
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                string entry = id + " " + name + " " + address;
                sameCustomers.Add(entry);
            }
            connection.Close();
            return sameCustomers;
        }

        public List<string> getCustomers()
        {
            List<string> customers = new List<string>();
            command = new SqlCommand("GetCustomers", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string id = reader["custId"].ToString();
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                string entry = id + " " + name + " " + address;
                customers.Add(entry);
            }
            connection.Close();
            return customers;
        }

        public List<Customer> getCustomerObjects()
        {
            List<Customer> customerObjects = new List<Customer>();
            command = new SqlCommand("GetCustomers", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["custId"].ToString();
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                customerObjects.Add(new Customer(name, address, id));
            }
            connection.Close();
            return customerObjects;
        }

        public void deleteCustomer(string customerID)
        {
            command = new SqlCommand("DeleteCustomer", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@custID", customerID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
