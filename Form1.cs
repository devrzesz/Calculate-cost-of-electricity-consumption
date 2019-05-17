using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_of_electricity_consumption
{
    public partial class Form1 : Form
    {
        Building[] currentBuilding;
        Building[] oneFamilyBuildings;
        Building[] multiFamilyBuildings;

        decimal[] heatDemand = new decimal[2];


        public Form1()
        {
            InitializeComponent();

            CreateBuldings();

            buildingType.Items.Add(TypeOfBuilding.oneFamillyBuilding);
            buildingType.Items.Add(TypeOfBuilding.multiFamillyBuilding);

        }

        private void CreateBuldings()
        {
            oneFamilyBuildings = new Building[4];
            oneFamilyBuildings[0] = new Building(TypeOfBuilding.oneFamillyBuilding, "Stare", 150, 170);
            oneFamilyBuildings[1] = new Building(TypeOfBuilding.oneFamillyBuilding, "Stare ( z wymienionymi oknami)", 120, 150);
            oneFamilyBuildings[2] = new Building(TypeOfBuilding.oneFamillyBuilding, "Docieplone", 80, 120);
            oneFamilyBuildings[3] = new Building(TypeOfBuilding.oneFamillyBuilding, "Energooszczedne", 50, 70);

            multiFamilyBuildings = new Building[3];
            multiFamilyBuildings[0] = new Building(TypeOfBuilding.multiFamillyBuilding,"Stare", 100, 130);
            multiFamilyBuildings[1] = new Building(TypeOfBuilding.multiFamillyBuilding, "Docieplone",50,80);
            multiFamilyBuildings[2] = new Building(TypeOfBuilding.multiFamillyBuilding, "Energooszczedne",30,50);

        }

        private void CalculateEnergyConsumption_Button_Click(object sender, EventArgs e)
        {

        }

        private void BuildingType2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuildingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildingType2.Visible = true;
            buildingType2.Items.Clear();

            if (buildingType.SelectedText == TypeOfBuilding.oneFamillyBuilding)
            {
                currentBuilding = oneFamilyBuildings;

                foreach (var item in oneFamilyBuildings)
                {
                    buildingType2.Items.Add(item.Name);
                }
                
            }
            else
            {
                currentBuilding = multiFamilyBuildings;

                foreach (var item in multiFamilyBuildings)
                {
                    buildingType2.Items.Add(item.Name);
                }
            }

        }

        private void HeatDemand_Click(object sender, EventArgs e)
        {
            heatDemand[0] = currentBuilding[buildingType2.SelectedIndex].minValue * areaHome.Value;
            heatDemand[1] = currentBuilding[buildingType2.SelectedIndex].maxValue * areaHome.Value;

            string heatDemandText = "Zgodnie z obliczeniami: \r\nMinimalne zapotrzebowanie to: " + heatDemand[0] + "W/m2.\r\n A maksymalne to: " + heatDemand[1] + "W/m2";
            heatDeamndLabelResult.Visible = true;
            heatDeamndLabelResult.Text = heatDemandText;

        }
    }
}
