﻿namespace Cost_of_electricity_consumption
{
    abstract class Distribution
    {
        private Tarrif tarrif;
        private decimal constDistributCost;
        private decimal depedenceTarrifCost;

        public decimal totalCost { get { return constDistributCost + depedenceTarrifCost; } }


    }
}
