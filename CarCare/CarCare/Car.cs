using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCare
{
    public class Car
    {
        public string carID;
        public string make;
        public string model;
        public string year;
        public string license;

        public Car(string carID, string make, string model, string year, string license)
        {
            this.carID = carID;
            this.make = make;
            this.model = model;
            this.year = year;
            this.license = license;
        }

        override
        public string ToString()
        {
            return carID + " " + make + " " + model + " " + year + " " + year + " " + license;
        }
    }
}
