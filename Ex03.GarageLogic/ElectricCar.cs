using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricCar : ElectricVehicle
    {
        Car m_Car;
        const int k_NumOfTires = 4;
        const float k_MaxBatteryTime = (float)3.2;
        const float k_MaxAirPressure = 32;

        public ElectricCar(string i_LicenseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining, string i_OwnerName, string i_OwnerTelephone, 
            int i_NumOfTires, float i_BatteryTime, eColors i_Color, string i_ManufacturerName, float i_CurrentAirPressure, eNumberOfDoors i_NumOfDoors) : 
            base(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining, i_OwnerName, i_OwnerTelephone, k_NumOfTires, i_ManufacturerName, i_CurrentAirPressure, k_MaxAirPressure, i_BatteryTime, k_MaxBatteryTime)            
        {
            m_Car = new Car (i_Color, i_NumOfDoors);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} ", base.ToString(), m_Car.ToString());
        }
    }
}
