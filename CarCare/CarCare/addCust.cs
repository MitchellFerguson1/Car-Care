using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare
{
    public partial class addCust : Form
    {
        public addCust()
        {
            InitializeComponent();
        }
        //Access the dataWorker class so everything gets added to the database
        private DataWorker dw = new DataWorker();

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            //Get data from form into variables
            string name = nameTxt.Text;
            string address = addressTxt.Text;
            string make = makeTxt.Text;
            string model = modelTxt.Text;
            int year = Convert.ToInt32(yearInt.Value);
            string repairType = repairTxt.Text;
            string repairSum = repairDetailsTxt.Text;
            double price = Convert.ToDouble(cost.Value);

        }
    }
}
