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

        public ElectricCar(string i_LicenseNumber, float i_BatteryTime, float i_MaxBatteryTime, eColors i_Color, 
            eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber, i_BatteryTime, i_MaxBatteryTime)
        {
            m_Car = new Car (i_Color, i_NumOfDoors);
        }

    }
}
