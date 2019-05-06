using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarCare
{
    public class DatabaseWorker
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
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
        }

        private SqlDataReader executeCommandWithReader()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            connection.Open();
            SqlDataReader toBeReturned = command.ExecuteReader();
            return toBeReturned;
        }

        #region Customer Stuff
        public void addCustomer(string name, string address, string make, string model, int year, string license)
        {
            command = new SqlCommand("AddNewCust", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            executeCommand();
            connection.Close();

            addNewCar(name, address, make, model, year, license);
        }

        public List<Customer> customerSearch(string custName)
        {
            string searchString = "SELECT custId, name, address FROM Customers WHERE name LIKE '%' + @name + '%'";
            command = new SqlCommand(searchString, connection);
            command.Parameters.AddWithValue("@name", custName);
            SqlDataReader reader = executeCommandWithReader();
            List<Customer> customers = new List<Customer>();
            while(reader.Read())
            {
                customers.Add(new Customer(reader["name"].ToString(),
                                           reader["address"].ToString(),
                                           reader["custId"].ToString()));
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
            connection.Close();
        }

        public void updateCustomer(string newName, string newAddress, string id)
        {
            command = new SqlCommand("updateCustomer", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@custId", Convert.ToInt32(id));
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newAddress", newAddress);
            executeCommand();
            connection.Close();
        }
#endregion
        public void addNewCar(string name, string address, string make, string model, int year, string license)
        {
            command = new SqlCommand("AddNewCar", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("make", make);
            command.Parameters.AddWithValue("model", model);
            command.Parameters.AddWithValue("year", year);
            command.Parameters.AddWithValue("license", license);
            executeCommand();
            connection.Close();
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

        public void deleteCar(string carID)
        {
            command = new SqlCommand("DeleteCar", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@carID", Convert.ToInt32(carID));
            executeCommand();
            connection.Close();
        }

        public List<Repair> getRepairs(string carID)
        {
            List<Repair> repairs = new List<Repair>();
            string getRepairsQuery = "SELECT repairId, repairCost, repairDetails FROM Repairs WHERE carId = @carID";
            command = new SqlCommand(getRepairsQuery, connection);
            command.Parameters.AddWithValue("@carID", carID);
            SqlDataReader reader = executeCommandWithReader();
            while(reader.Read())
            {
                repairs.Add(new Repair(reader["repairId"].ToString(),
                                       reader["repairDetails"].ToString(),
                                       reader["repairCost"].ToString()));
            }
            connection.Close();
            return repairs;
        }

        public void addRepair(string repairDetails, float repairCost, string carID)
        {
            string addRepairQuery = "INSERT INTO Repairs (carId, repairDetails, repairCost) VALUES (@carId, @repairDetails, @repairCost)";
            command = new SqlCommand(addRepairQuery, connection);
            command.Parameters.AddWithValue("@carId", carID);
            command.Parameters.AddWithValue("@repairDetails", repairDetails);
            command.Parameters.AddWithValue("@repairCost", repairCost);
            executeCommand();
            connection.Close();
        }

        public void deleteRepair(string repairID)
        {
            string deleteQuery = "DELETE FROM Repairs WHERE repairId = @repairId";
            command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@repairId", repairID);
            executeCommand();
            connection.Close();
        }
    }
}
