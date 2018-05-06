using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricVehicle : Vehicle
    {
        float m_BatteryTime;
        float m_MaxBatteryTime;

        public ElectricVehicle(string i_LicencseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining,
            string i_OwnerName, string i_OwnerTelephone, int i_NumOfTires, string i_ManufacturerName, 
            float i_CurrentAirPressure, float i_MaxAirPressure, float i_BatteryTime, float i_MaxBatteryTime) : 
            base(i_LicencseNumber, i_ModelName, i_PercentageOfEnergyRemaining, i_OwnerName, i_OwnerTelephone,
                i_NumOfTires, i_ManufacturerName, i_CurrentAirPressure, i_MaxAirPressure)            
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
                throw new ValueOutOfRangeException(0, m_MaxBatteryTime-m_BatteryTime);
            }

        }

        public override string ToString()
        {
            return string.Format("{0}, battety time: {1}, max batteryTime {2}"
                , base.ToString(), m_BatteryTime, m_MaxBatteryTime);
        }
    }
}
