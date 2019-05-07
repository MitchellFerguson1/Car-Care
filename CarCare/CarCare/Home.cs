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
    public partial class Home : Form
    {
        //NOTE: These methods do not have summaries since they should only be called from the home screen

        private SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarCare;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlCommand command = new SqlCommand();
        private List<Customer> customerList = new List<Customer>();
        private List<Car> cars = new List<Car>();
        private List<Repair> repairs = new List<Repair>();
        private Car selectedCar;
        private Customer selectedCustomer = null;
        DatabaseWorker dbw;

        public Home()
        {
            dbw = new DatabaseWorker(connection, command);
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Clear the customer list
            custList.Items.Clear();

            //Get a new list of customers from databaseWorker and add them to the list
            List<Customer> customerList = dbw.customerSearch(custSearch.Text);
            foreach (Customer customer in customerList)
            {
                string entry = customer.name + " " + customer.address;
                custList.Items.Add(entry);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerRefresh(); //Load in the customers on refresh
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            customerRefresh();
        }

        #region Customers
        private void customerRefresh()
        {
            //Clear the list of customers and get a new list of all customers
            custList.Items.Clear();
            customerList = dbw.getAllCustomers();

            //Add each customer to the list
            foreach (Customer customer in customerList)
                custList.Items.Add(customer.name + " " + customer.address);
        }

        private void addCust_Click(object sender, EventArgs e)
        {
            //Go to the addCustomer screen
            AddCustomer ac = new AddCustomer(connection, command);
            ac.Show();
        }

        private void deleteCust_Click(object sender, EventArgs e)
        {
            //Delete the customer from the database
            dbw.deleteCustomer(selectedCustomer.id);

            //Make sure there is no selected customer
            selectedCustomer = null;

            //Disable some buttons
            editCust.Enabled = false;
            deleteCust.Enabled = false;
            addRep.Enabled = false;
            deleteRep.Enabled = false;

            //Refresh the form
            RefreshRepairBtn_Click(sender, e);
            customerRefresh();
        }

        private void custList_Click(object sender, EventArgs e)
        {
            //Clear the customer list
            carList.Items.Clear();

            //Get the string of the selected customer
            string item = custList.GetItemText(custList.SelectedItem);

            //Since a new customer is selected we don't want the previous cars info to be displayed
            carDetailsTxt.Text = "";
            repairHist.Items.Clear();

            //Loop through the customer list until we find one that has the same toString as the item string
            foreach(Customer current in customerList)
            {
                string currentString = current.name + " " + current.address;
                if (currentString.Equals(item))
                {
                    //Make the current customer in the loop the selected customer and break the loop
                    selectedCustomer = current;
                    break;
                }
            }

            //As long as there is a selected customer we can look for their cars
            if(!(selectedCustomer == null))
            {
                //Get a list of all the cars the customers own and add them to the list
                cars = dbw.getCarObjects(selectedCustomer.id);
                foreach(Car car in cars)
                {
                    string carString = car.year + " " + car.make + " " + car.model;
                    carList.Items.Add(carString);
                }

                //Enable relevant buttons
                editCust.Enabled = true;
                deleteCust.Enabled = true;
            }
        }

        private void editCust_Click(object sender, EventArgs e)
        {
            //As long as a customer is selected we can go to the edit screen
            if (selectedCustomer != null)
            {
                EditCustomer ec = new EditCustomer(connection, command, selectedCustomer);
                ec.Show();
            }
        }
        #endregion

        #region Repairs
        private void AddRep_Click(object sender, EventArgs e)
        {
            //Go the the add repair screen
            AddRepair ap = new AddRepair(connection, command, dbw, selectedCar);
            ap.Show();
        }

        private void RefreshRepairBtn_Click(object sender, EventArgs e)
        {
            //Get all the repairs from the database matched to the car
            repairs = dbw.getRepairs(selectedCar.carID);

            //Clear the current repair list
            repairHist.Items.Clear();

            //Add each repair from the database to the list
            foreach (Repair repair in repairs)
            {
                repairHist.Items.Add(repair.summaryString());
            }
        }

        private void DeleteRep_Click(object sender, EventArgs e)
        {
            //Get the string of the selected repair
            string repair = repairHist.GetItemText(repairHist.SelectedItem);

            //Search through the repair list until we find the matching repair. This is why Repair has ID in it, so it is distinguishable from other oil changes
            foreach (Repair r in repairs)
            {
                if (r.summaryString().Equals(repair))
                {
                    //Delete the repair and break the loop
                    dbw.deleteRepair(r.id);
                    break;
                }
            }

            //Refresh the repair list and disable proper buttons
            RefreshRepairBtn_Click(sender, e);
            deleteRep.Enabled = false;
        }

        private void RepairHist_Click(object sender, EventArgs e)
        {
            //Find the selected repair based off its string
            string repair = repairHist.GetItemText(repairHist.SelectedItem);
            foreach (Repair r in repairs)
            {
                if (r.summaryString().Equals(repair))
                {
                    //Detail the proper areas and enable proper buttons
                    RepairDetailTxt.Text = r.ToString();
                    deleteRep.Enabled = true;
                    break;
                }
            }
        }
        #endregion

        private void CarList_MouseClick(object sender, MouseEventArgs e)
        {
            //Find the car just like with customer
            string currentCar = carList.GetItemText(carList.SelectedItem);
            foreach(Car car in cars)
            {
                string carString = car.year + " " + car.make + " " + car.model;
                if (carString.Equals(currentCar))
                {
                    selectedCar = car;
                    break;
                }
            }

            //As long as we have a selected car we can expand its details
            if (selectedCar != null)
            {
                carDetailsTxt.Text = selectedCar.year + " " + selectedCar.make + " " + selectedCar.model + " " + selectedCar.license;

                //Get its repairs
                repairs = dbw.getRepairs(selectedCar.carID);
                repairHist.Items.Clear();
                foreach (Repair r in repairs)
                {
                    repairHist.Items.Add(r.summaryString());
                }

                //Enable the proper buttons
                addRep.Enabled = true;
            }
        }
    }
}
