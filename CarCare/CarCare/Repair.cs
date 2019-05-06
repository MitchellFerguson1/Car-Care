using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCare
{
    public class Repair
    {
        public string id;
        public string repairDetails;
        public string repairCost;
        public Repair(string id, string repairDetails, string repairCost)
        {
            this.id = id;
            this.repairDetails = repairDetails;
            this.repairCost = repairCost;
        }

        override
        public String ToString()
        {
            return repairDetails + "\n" + repairCost;
        }

        public string summaryString()
        {
            if(repairDetails.Length >= 100)
                return id + " " + repairDetails.Substring(0, 90) + "...";
            return id + " " + repairDetails;
        }
    }
}
