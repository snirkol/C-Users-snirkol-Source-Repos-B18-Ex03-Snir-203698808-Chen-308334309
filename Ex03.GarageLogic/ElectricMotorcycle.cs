using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricMotorcycle : Vehicle
    {
        Motorcycle m_MotorCycle;
        ElectricVehicle m_ElectricVehicle;

        public ElectricMotorcycle(string i_LicenseNumber, eTypeOfDriversLicense i_TypeOfLicense, 
            int i_EngineCapacity, float i_BatteryTime, float i_MaxBatteryTime) : base(i_LicenseNumber)
        {
            m_MotorCycle = new Motorcycle(i_TypeOfLicense, i_EngineCapacity);
            m_ElectricVehicle = new ElectricVehicle(i_BatteryTime, i_MaxBatteryTime);
        }
    }

}
