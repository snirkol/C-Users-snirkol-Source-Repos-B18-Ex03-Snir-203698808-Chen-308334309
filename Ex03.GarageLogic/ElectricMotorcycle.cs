using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricMotorcycle : ElectricVehicle
    {
        Motorcycle m_MotorCycle;

        public ElectricMotorcycle(string i_LicenseNumber, eTypeOfDriversLicense i_TypeOfLicense, int i_EngineCapacity, 
            float i_BatteryTime, float i_MaxBatteryTime) : base(i_LicenseNumber, i_BatteryTime, i_MaxBatteryTime)
        {
            m_MotorCycle = new Motorcycle(i_TypeOfLicense, i_EngineCapacity);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", base.ToString(), m_MotorCycle.ToString());
        }
    }

}
