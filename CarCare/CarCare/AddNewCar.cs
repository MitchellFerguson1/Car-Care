﻿using System;
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
            string name = owner.name;
            string address = owner.address;
            string make = MakeTxt.Text;
            string model = ModelTxt.Text;
            int year = Convert.ToInt32(YearTxt.Text);
            string license = LicenseTxt.Text;

            command = new SqlCommand("AddNewCar", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("address", address);
            command.Parameters.AddWithValue("make", make);
            command.Parameters.AddWithValue("model", model);
            command.Parameters.AddWithValue("year", year);
            command.Parameters.AddWithValue("license", license);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            Close();
        }
    }
}
