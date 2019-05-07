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
    public partial class AddRepair : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DatabaseWorker dbw;
        Car currentCar;

        public AddRepair(SqlConnection connection, SqlCommand command, DatabaseWorker dbw, Car currentCar)
        {
            this.connection = connection;
            this.command = command;
            this.dbw = dbw;
            this.currentCar = currentCar;
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //Get all the values from the text boxes
            string repairDetail = RepairDetailsTxt.Text;
            float repairCost = (float)(Cost.Value);
            bool allEntered = false;

            //Ensure everything that needs data has data
            if (!repairDetail.Equals(""))
                allEntered = true;

            if (allEntered)
            {
                //If there is data add it to the database
                dbw.addRepair(repairDetail, repairCost, currentCar.carID);
                Close();
            }
            else //Otherwise show an error and not do anything
                MessageBox.Show("Not all items have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //Self explanatory
            Close();
        }

        private void RepairDetailsTxt_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear the repair details thing so I don't have another label
            if(RepairDetailsTxt.Text == "Repair Details:")
                RepairDetailsTxt.Text = "";
            //Enable proper buttons
            ConfirmBtn.Enabled = true;
        }
    }
}
