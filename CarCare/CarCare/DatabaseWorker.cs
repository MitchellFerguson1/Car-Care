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

        private void executeCommand()
        {
            connection.Open();
            command.ExecuteNonQuery();
        }

        private SqlDataReader executeCommandWithReader()
        {
            connection.Open();
            SqlDataReader toBeReturned = command.ExecuteReader();
            return toBeReturned;
        }

        public List<string> customerSearch(string custName)
        {
            List<string> sameCustomers = new List<string>();
            string searchString = "SELECT custId, name, address FROM Customers WHERE name = @name";
            command = new SqlCommand(searchString, connection);
            command.Parameters.AddWithValue("@name", custName);
            SqlDataReader reader = executeCommandWithReader();
            while (reader.Read())
            {
                string id = reader["custId"].ToString();
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                string entry = id + "" + name + " " + address;
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
            SqlDataReader reader = executeCommandWithReader();

            while (reader.Read())
            {
                string id = reader["custId"].ToString();
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                string entry = id + "" + name + " " + address;
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
            SqlDataReader reader = executeCommandWithReader();
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
            executeCommand();
        }

        public List<string> getCars(string customerID)
        {
            List<string> cars = new List<string>();
            string getCarQuery = "SELECT carId, year, make, model FROM Cars WHERE custId = @custId";
            command = new SqlCommand(getCarQuery, connection);
            command.Parameters.AddWithValue("@custId", customerID);
            SqlDataReader reader = executeCommandWithReader();
            while(reader.Read())
            {
                string entry = reader["carId"].ToString() + " ";
                entry += reader["year"].ToString() + " ";
                entry += reader["make"].ToString() + " ";
                entry += reader["model"].ToString() + " ";
                cars.Add(entry);
            }
            connection.Close();
            return cars;
        }

        public List<Car> getCarObjects(string customerID)
        {
            List<Car> cars = new List<Car>();
            string getObjectsQuery = "SELECT carId, year, make, model, license FROM Cars WHERE custId = @custId";
            command = new SqlCommand(getObjectsQuery, connection);
            command.Parameters.AddWithValue("@custId", customerID);
            SqlDataReader reader = executeCommandWithReader();
            while(reader.Read())
            {
                cars.Add(new Car(reader["carId"].ToString(),
                                    reader["make"].ToString(),
                                    reader["model"].ToString(),
                                    reader["year"].ToString(),
                                    reader["license"].ToString()));
            }
            connection.Close();
            return cars;
        }

        public void updateCustomer(string newName, string newAddress, string id)
        {
            command = new SqlCommand("updateCustomer", connection);
            command.Parameters.AddWithValue("@custId", id);
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newAddress", newAddress);
            executeCommand();
        }
    }
}
