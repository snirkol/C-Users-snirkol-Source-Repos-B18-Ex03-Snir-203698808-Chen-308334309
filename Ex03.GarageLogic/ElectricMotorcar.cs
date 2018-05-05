using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricMotorcar : Vehicle
    {
        Motorcar m_Motorcar;
        ElectricVehicle m_ElectricVehicle;

        public ElectricMotorcar(string i_LicenseNumber, float i_BatteryTime, float i_MaxBatteryTime,
            eColors i_Color, eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber)
        {
            m_ElectricVehicle = new ElectricVehicle(i_BatteryTime, i_MaxBatteryTime);
            m_Motorcar = new Motorcar (i_Color, i_NumOfDoors);
        }
    }
}
