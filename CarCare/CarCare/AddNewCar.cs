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
    public partial class AddNewCar : Form
    {
        SqlConnection connection;
        SqlCommand command;
        Customer owner;

        public AddNewCar(SqlConnection connection, SqlCommand command, Customer owner)
        {
            this.connection = connection;
            this.command = command;
            this.owner = owner;
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //Get all the data needed
            string name = owner.name;
            string address = owner.address;
            string make = MakeTxt.Text;
            string model = ModelTxt.Text;
            int year = Convert.ToInt32(YearTxt.Text);
            string license = LicenseTxt.Text;
            bool allEntered = false;

            //Ensure all data has data
            if (!(make.Equals("") || model.Equals("") || year.Equals("") || license.Equals("")))
                allEntered = true;

            if (allEntered)
            {
                //As long as everything is entered properly add it to the database
                DatabaseWorker dbw = new DatabaseWorker(connection, command);
                dbw.addNewCar(name, address, make, model, year, license);

                Close();
            }
            else //Otherwise show an error
                MessageBox.Show("Not all items have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
