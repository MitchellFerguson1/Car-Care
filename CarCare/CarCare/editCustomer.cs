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
    public partial class EditCustomer : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private Customer customer;
        private DatabaseWorker dbw;
        private List<Car> cars;

        public EditCustomer(SqlConnection connection, SqlCommand command, Customer customer)
        {
            this.connection = connection;
            this.command = command;
            this.customer = customer;
            dbw = new DatabaseWorker(connection, command);
            InitializeComponent();
            load();
        }

        private void load()
        {
            //Set the text to the name and address
            nameChangeTxt.Text = customer.name;
            addressChangeTxt.Text = customer.address;

            //Get all the cars
            cars = dbw.getCarObjects(customer.id);
            foreach(Car car in cars)
            {
                carList.Items.Add(car);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Find the car using methods used in home.cs and delete it from the database
            string selectedCar = carList.GetItemText(carList.SelectedItem);
            foreach(Car car in cars)
            {
                if(car.ToString().Equals(selectedCar))
                {
                    dbw.deleteCar(car.carID);
                    break;
                }
            }
            RefreshBtn_Click(sender, e);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //Get all the text fields into a string and add them to the database
            string newName = nameChangeTxt.Text;
            string newAddress = addressChangeTxt.Text;
            dbw.updateCustomer(newName, newAddress, customer.id);
            Close();
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            //Bring up the add new car form
            AddNewCar anc = new AddNewCar(connection, command, customer);
            anc.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            //Clear the list
            carList.Items.Clear();

            //Get all the cars and add them to the list
            cars = dbw.getCarObjects(customer.id);
            foreach (Car car in cars)
            {
                carList.Items.Add(car);
            }
        }
    }
}
