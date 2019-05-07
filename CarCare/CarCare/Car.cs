using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCare
{
    public class Car
    {
        //These are all public so I don't have a ton of getters and setters
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

        /// <summary>
        /// Get the string of the car
        /// </summary>
        /// <returns>The car details</returns>
        override
        public string ToString()
        {
            return carID + " " + make + " " + model + " " + year + " " + year + " " + license;
        }
    }
}
