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
            custList.Items.Clear();
            List<Customer> customerList = dbw.customerSearch(custSearch.Text);
            foreach (Customer customer in customerList)
            {
                string entry = customer.name + " " + customer.address;
                custList.Items.Add(entry);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void formRefresh()
        {
            custList.Items.Clear();
            customerList = dbw.getCustomerObjects();

            foreach (Customer customer in customerList)
                custList.Items.Add(customer.name + " " + customer.address);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        #region Customers
        private void addCust_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(connection, command);
            ac.Show();
        }

        private void deleteCust_Click(object sender, EventArgs e)
        {
            dbw.deleteCustomer(selectedCustomer.id);
            selectedCustomer = null;
            editCust.Enabled = false;
            deleteCust.Enabled = false;
            addRep.Enabled = false;
            deleteRep.Enabled = false;
            RefreshRepairBtn_Click(sender, e);
            formRefresh();
        }

        private void custList_Click(object sender, EventArgs e)
        {
            carList.Items.Clear();
            string item = custList.GetItemText(custList.SelectedItem);
            carDetailsTxt.Text = "";
            repairHist.Items.Clear();
            foreach(Customer current in customerList)
            {
                string currentString = current.name + " " + current.address;
                if (currentString.Equals(item))
                {
                    selectedCustomer = current;
                    break;
                }
            }
            if(!(selectedCustomer == null))
            {
                cars = dbw.getCarObjects(selectedCustomer.id);
                foreach(Car car in cars)
                {
                    string carString = car.year + " " + car.make + " " + car.model;
                    carList.Items.Add(carString);
                }
                editCust.Enabled = true;
                deleteCust.Enabled = true;
            }
        }

        private void editCust_Click(object sender, EventArgs e)
        {
            string item = custList.GetItemText(custList.SelectedItem);
            bool customerSelected = false;
            selectedCar = null;
            foreach (Customer current in customerList)
            {
                string currentString = current.name + " " + current.address;
                if (currentString.Equals(item))
                {
                    selectedCustomer = current;
                    customerSelected = true;
                    break;
                }
            }
            if (customerSelected)
            {
                EditCustomer ec = new EditCustomer(connection, command, selectedCustomer);
                ec.Show();
            }
        }
        #endregion

        #region Repairs
        private void AddRep_Click(object sender, EventArgs e)
        {
            AddRepair ap = new AddRepair(connection, command, dbw, selectedCar);
            ap.Show();
        }

        private void RefreshRepairBtn_Click(object sender, EventArgs e)
        {
            repairs = dbw.getRepairs(selectedCar.carID);
            repairHist.Items.Clear();
            foreach (Repair repair in repairs)
            {
                repairHist.Items.Add(repair.summaryString());
            }
        }

        private void DeleteRep_Click(object sender, EventArgs e)
        {
            string repair = repairHist.GetItemText(repairHist.SelectedItem);
            foreach (Repair r in repairs)
            {
                if (r.summaryString().Equals(repair))
                {
                    dbw.deleteRepair(r.id);
                    break;
                }
            }
            RefreshRepairBtn_Click(sender, e);
            deleteRep.Enabled = false;
        }

        private void RepairHist_Click(object sender, EventArgs e)
        {
            string repair = repairHist.GetItemText(repairHist.SelectedItem);
            foreach (Repair r in repairs)
            {
                if (r.summaryString().Equals(repair))
                {
                    RepairDetailTxt.Text = r.ToString();
                    deleteRep.Enabled = true;
                    break;
                }
            }
        }
        #endregion

        private void CarList_MouseClick(object sender, MouseEventArgs e)
        {
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

            if (selectedCar != null)
            {
                carDetailsTxt.Text = selectedCar.year + " " + selectedCar.make + " " + selectedCar.model + " " + selectedCar.license;

                repairs = dbw.getRepairs(selectedCar.carID);
                repairHist.Items.Clear();
                foreach (Repair r in repairs)
                {
                    repairHist.Items.Add(r.summaryString());
                }
                addRep.Enabled = true;
            }
        }
    }
}
