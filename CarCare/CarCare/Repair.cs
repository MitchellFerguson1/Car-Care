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

        /// <summary>
        /// Get the repair details and the cost. All the information of the repair excluding the ID
        /// </summary>
        /// <returns>Repair details</returns>
        override
        public String ToString()
        {
            return repairDetails + "\n$" + repairCost;
        }

        /// <summary>
        /// Get a short summary of the repair
        /// </summary>
        /// <returns>Repair summary</returns>
        public string summaryString()
        {
            if(repairDetails.Length >= 100) //Make sure the box doesn't have long summaries
                return id + " " + repairDetails.Substring(0, 90) + "...";
            return id + " " + repairDetails;
        }
    }
}
