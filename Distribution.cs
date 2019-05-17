using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_of_electricity_consumption
{
    abstract class Distribution
    {
        private Tarrif tarrif;
        private decimal constDistributCost;
        private decimal depedenceTarrifCost;

        public decimal totalCost { get { return constDistributCost + depedenceTarrifCost} }


    }
}
