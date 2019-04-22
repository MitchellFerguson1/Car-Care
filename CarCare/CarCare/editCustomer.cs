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
            nameChangeTxt.Text = customer.name;
            addressChangeTxt.Text = customer.address;
            cars = dbw.getCarObjects(customer.id);
            foreach(Car car in cars)
            {
                carList.Items.Add(car);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string newName = nameChangeTxt.Text;
            string newAddress = addressChangeTxt.Text;
            dbw.updateCustomer(newName, newAddress, customer.id);
            Close();
        }
    }
}