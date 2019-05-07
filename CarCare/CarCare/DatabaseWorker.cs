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

        /// <summary>
        /// Execute a command
        /// </summary>
        private void executeCommand()
        {
            if (connection.State == System.Data.ConnectionState.Open) //Make sure the connection is closed
                connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Execute a command and return a data reader
        /// </summary>
        /// <returns>Data reader for specified command</returns>
        private SqlDataReader executeCommandWithReader()
        {
            if (connection.State == System.Data.ConnectionState.Open) //Make sure the connection is closed
                connection.Close();
            connection.Open();
            SqlDataReader toBeReturned = command.ExecuteReader(); //Return the reader
            return toBeReturned;
        }

        #region Customer Stuff
        /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="name">Customer name</param>
        /// <param name="address">Customer address</param>
        /// <param name="make">Car make</param>
        /// <param name="model">Car model</param>
        /// <param name="year">Car year</param>
        /// <param name="license">Car license plate</param>
        public void addCustomer(string name, string address, string make, string model, int year, string license)
        {
            //SQL stuff for adding a customer using a stored procedure
            command = new SqlCommand("AddNewCust", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);

            //Executing the command
            executeCommand();
            connection.Close();

            //Adding a new car since a customer must always have a car
            addNewCar(name, address, make, model, year, license);
        }

        /// <summary>
        /// Search for a customer
        /// </summary>
        /// <param name="custName">Customer name being searched</param>
        /// <returns>A list of all customers with that name</returns>
        public List<Customer> customerSearch(string custName)
        {
            //Using a simple query like this since I feel a stored procedure is too much for this
            string searchString = "SELECT custId, name, address FROM Customers WHERE name LIKE '%' + @name + '%'";
            command = new SqlCommand(searchString, connection);
            command.Parameters.AddWithValue("@name", custName);

            //Executing the command with a reader and getting it sent back
            SqlDataReader reader = executeCommandWithReader();

            //Creating a new list of customers
            List<Customer> customers = new List<Customer>();

            //While the reader still has data, add to the new list of customers
            while(reader.Read())
            {
                customers.Add(new Customer(reader["name"].ToString(),
                                           reader["address"].ToString(),
                                           reader["custId"].ToString()));
            }

            //Close the connection and send back the list of customers
            connection.Close();
            return customers;
        }

        /// <summary>
        /// Get all the customers from the database
        /// </summary>
        /// <returns></returns>
        public List<Customer> getAllCustomers()
        {
            //Create a new list of customers to be returned
            List<Customer> customerObjects = new List<Customer>();

            //Execute the stored procedure for getting all the customers and getting the reader
            command = new SqlCommand("GetCustomers", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = executeCommandWithReader();

            //While the reader still has data, create a new customer and add it to the list
            while (reader.Read())
            {
                string id = reader["custId"].ToString();
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                customerObjects.Add(new Customer(name, address, id));
            }

            //Close the connection and return the customer list
            connection.Close();
            return customerObjects;
        }

        /// <summary>
        /// Delete the selected customer
        /// </summary>
        /// <param name="customerID">ID of the customer to be removed</param>
        public void deleteCustomer(string customerID)
        {
            //Execute the stored procedure for deleting a customer
            command = new SqlCommand("DeleteCustomer", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@custID", customerID);
            executeCommand();
            connection.Close();
        }

        /// <summary>
        /// Update a customer
        /// </summary>
        /// <param name="newName">New name of the customer</param>
        /// <param name="newAddress">New address of the customer</param>
        /// <param name="id">ID of the customer</param>
        public void updateCustomer(string newName, string newAddress, string id)
        {
            //Update the customer using a stored procedure
            command = new SqlCommand("updateCustomer", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@custId", Convert.ToInt32(id));
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newAddress", newAddress);
            executeCommand();
            connection.Close();
        }
        #endregion

        #region Car stuff
        /// <summary>
        /// Add a new car to the database
        /// </summary>
        /// <param name="name">Owner name</param>
        /// <param name="address">Owner address</param>
        /// <param name="make">Make of the car</param>
        /// <param name="model">Model of the car</param>
        /// <param name="year">Year of the car</param>
        /// <param name="license">License of the car</param>
        public void addNewCar(string name, string address, string make, string model, int year, string license)
        {
            //Add a new car using the stored procedure
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

        /// <summary>
        /// Get all the cars for a customer
        /// </summary>
        /// <param name="customerID">ID of the customer</param>
        /// <returns>List of owned cars</returns>
        public List<Car> getCarObjects(string customerID)
        {
            //Create a new list of cars
            List<Car> cars = new List<Car>();

            //Use a string query for simplicity and use a reader
            string getObjectsQuery = "SELECT carId, year, make, model, license FROM Cars WHERE custId = @custId";
            command = new SqlCommand(getObjectsQuery, connection);
            command.Parameters.AddWithValue("@custId", customerID);
            SqlDataReader reader = executeCommandWithReader();

            //While the reader has data add a new car to the list
            while(reader.Read())
            {
                cars.Add(new Car(reader["carId"].ToString(),
                                    reader["make"].ToString(),
                                    reader["model"].ToString(),
                                    reader["year"].ToString(),
                                    reader["license"].ToString()));
            }

            //Close the connection and return the list
            connection.Close();
            return cars;
        }

        /// <summary>
        /// Delete the selected car from the database
        /// </summary>
        /// <param name="carID">The carID</param>
        public void deleteCar(string carID)
        {
            //Delete the car using a stored procedure
            command = new SqlCommand("DeleteCar", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@carID", Convert.ToInt32(carID));
            executeCommand();
            connection.Close();
        }
        #endregion

        #region Repair stuff
        /// <summary>
        /// Get all the repairs for a car
        /// </summary>
        /// <param name="carID">The car ID</param>
        /// <returns>A list of all the repairs</returns>
        public List<Repair> getRepairs(string carID)
        {
            //Create a new list of repairs
            List<Repair> repairs = new List<Repair>();

            //Use a string query and execute with reader
            string getRepairsQuery = "SELECT repairId, repairCost, repairDetails FROM Repairs WHERE carId = @carID";
            command = new SqlCommand(getRepairsQuery, connection);
            command.Parameters.AddWithValue("@carID", carID);
            SqlDataReader reader = executeCommandWithReader();

            //While the reader has data add the repair to the list
            while(reader.Read())
            {
                repairs.Add(new Repair(reader["repairId"].ToString(),
                                       reader["repairDetails"].ToString(),
                                       reader["repairCost"].ToString()));
            }

            //Close the connection and add the repair
            connection.Close();
            return repairs;
        }

        /// <summary>
        /// Add a new repair for a car
        /// </summary>
        /// <param name="repairDetails">The repair details</param>
        /// <param name="repairCost">The repair cost</param>
        /// <param name="carID">The car ID</param>
        public void addRepair(string repairDetails, float repairCost, string carID)
        {
            //Insert the repair using a string query
            string addRepairQuery = "INSERT INTO Repairs (carId, repairDetails, repairCost) VALUES (@carId, @repairDetails, @repairCost)";
            command = new SqlCommand(addRepairQuery, connection);
            command.Parameters.AddWithValue("@carId", carID);
            command.Parameters.AddWithValue("@repairDetails", repairDetails);
            command.Parameters.AddWithValue("@repairCost", repairCost);
            executeCommand();
            connection.Close();
        }

        /// <summary>
        /// Delete a repair from the database
        /// </summary>
        /// <param name="repairID">The ID of the repair</param>
        public void deleteRepair(string repairID)
        {
            //Use a string query to delete the repair
            string deleteQuery = "DELETE FROM Repairs WHERE repairId = @repairId";
            command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@repairId", repairID);
            executeCommand();
            connection.Close();
        }
        #endregion
    }
}
