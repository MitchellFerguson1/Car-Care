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
    public partial class addCust : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public addCust(SqlConnection connection, SqlCommand command)
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

            int count;
            int ID;
            int carID;
            do
            {
                ID = new Random().Next();

                command.CommandText = "Select COUNT(CustID) From [dbo].[Vehicle] Where CustID = " + ID;

                connection.Open();
                count = command.ExecuteNonQuery();
                connection.Close();
            } while (count > 0);

            do
            {
                carID = new Random().Next();

                command.CommandText = "SELECT COUNT(VehicleID) FROM Vehicle WHERE VehicleID = " + carID;

                connection.Open();

                count = command.ExecuteNonQuery();
                connection.Close();
            } while (count > 0);

            //command.CommandText = "INSERT INTO Vehicle (Make, Model, Year, CustomerName, CustID, VehicleID) VALUES (@Make" +
            //    ", @model," + year + ", @custName," + ID + "," + carID + ");";
            //command.Parameters.AddWithValue("@Make", make);
            ////Parameters["@Make"].Value = make;
            //command.Parameters.AddWithValue("@model", model);
            //command.Parameters.AddWithValue("@year", year);
            //command.Parameters.AddWithValue("@custName", name);
            //command.Parameters.AddWithValue("@custID", ID);
            //command.Parameters.AddWithValue("@vehicleID", carID);
            command.CommandText = "INSERT INTO Vehicle (Make, Model, Year, CustomerName, CustID, VehicleID) VALUES " +
                "('" + make + "','" + model + "'," + year + ",'" + name + "'," + ID + "," + carID + ");";

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
    }
}
