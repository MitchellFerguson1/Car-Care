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
            string repairDetail = RepairDetailsTxt.Text;
            float repairCost = (float)(Cost.Value);
            bool allEntered = false;

            if (!repairDetail.Equals(""))
                allEntered = true;

            if (allEntered)
            {
                dbw.addRepair(repairDetail, repairCost, currentCar.carID);
                Close();
            }
            else
                MessageBox.Show("Not all items have a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RepairDetailsTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if(RepairDetailsTxt.Text == "Repair Details:")
                RepairDetailsTxt.Text = "";
            ConfirmBtn.Enabled = true;
        }
    }
}
