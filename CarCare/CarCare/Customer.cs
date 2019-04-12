using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCare
{
    class Customer
    {
        public string name;
        public string address;
        public string id;
        public Customer(string aName, string aAddress, string aId)
        {
            name = aName;
            address = aAddress;
            id = aId;
        }

        override
        public string ToString()
        {
            return id.ToString() + " " + name + " " + address;
        }
    }
}
