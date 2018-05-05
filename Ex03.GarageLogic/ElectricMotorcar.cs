using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricMotorcar : Vehicle
    {
        float m_BatteryTime;
        float m_MaxBatteryTime;
        Motorcar m_Motorcar;

        public ElectricMotorcar(string i_LicenseNumber, float i_BatteryTime, float i_MaxBatteryTime, eColors i_Color, eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber)
        {
            m_BatteryTime = i_BatteryTime;
            m_MaxBatteryTime = i_MaxBatteryTime;
            m_Motorcar = new Motorcar (i_Color, i_NumOfDoors);
        }

        public void ChargingBattery(float i_TimeToCharge)
        {
            if (m_BatteryTime + i_TimeToCharge <= m_MaxBatteryTime)
            {
                m_BatteryTime += i_TimeToCharge;
            }

            //TODO: if is grater from max time -> throw exception
        }
    }
}
