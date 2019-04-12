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
        DatabaseWorker dbw;

        public Home()
        {
            dbw = new DatabaseWorker(connection, command);
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            custList.Items.Clear();
            List<string> customerList = dbw.customerSearch(custSearch.Text);
            foreach (string customer in customerList)
                custList.Items.Add(customer);
            formRefresh();
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
            custList.Items.Clear();
            customerList = dbw.getCustomerObjects();

            foreach (Customer customer in customerList)
                custList.Items.Add(customer.ToString());
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void deleteCust_Click(object sender, EventArgs e)
        {
            string item = custList.GetItemText(custList.SelectedItem);
            if (item != null)
            {
                Customer toDelete = new Customer("null", "null", "-1");
                foreach (Customer current in customerList)
                    if (current.ToString().Equals(item))
                    {
                        toDelete = current;
                        break;
                    }
                dbw.deleteCustomer(toDelete.id);
                formRefresh();
            }
        }

        private void custList_Click(object sender, EventArgs e)
        {
            string item = custList.GetItemText(custList.SelectedItem);
            Customer getCarCustomer = new Customer("null", "null", "null");
            foreach(Customer current in customerList)
            {
                if(current.ToString().Equals(item))
                {
                    getCarCustomer = current;
                    break;
                }
            }
            if(!getCarCustomer.ToString().Equals("null null null"))
            {

            }
        }
    }
}
