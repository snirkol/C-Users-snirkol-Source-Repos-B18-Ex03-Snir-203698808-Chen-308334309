using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricVehicle
    {
        float m_BatteryTime;
        float m_MaxBatteryTime;

        public ElectricVehicle(float i_BatteryTime, float i_MaxBatteryTime)
        {
            m_BatteryTime = i_BatteryTime;
            m_MaxBatteryTime = i_MaxBatteryTime;
        }

        public void ChargeBattery(float i_TimeToCharge)
        {
            if (m_BatteryTime + i_TimeToCharge <= m_MaxBatteryTime)
            {
                m_BatteryTime += i_TimeToCharge;
            }
            else
            {
                throw new ValueOutOfRangeException(0, m_MaxBatteryTime);
            }
        }
    }
}
