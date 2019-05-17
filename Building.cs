using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_of_electricity_consumption
{
    class Building
    {
        public Building(string typeOfBuilding,string name, int min, int max)
        {
            this.typeOfBuildings = typeOfBuilding;
            Name = name;
            minValue = min;
            maxValue = max;
        }

        public string typeOfBuildings { get; private set; }
        public string Name { get; private set; }
        public int minValue { get; private set; }
        public int maxValue { get; private set; }
    }
}
