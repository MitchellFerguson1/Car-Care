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

            DatabaseWorker dbw = new DatabaseWorker(connection, command);
            dbw.addCustomer(name, address, make, model, year, license);

            Close();
        }
    }
}
