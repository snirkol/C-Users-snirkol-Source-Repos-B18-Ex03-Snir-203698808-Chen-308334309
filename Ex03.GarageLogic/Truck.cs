using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : FuelVehicle
    {
        bool m_IsTrunkCooled;
        float m_TrunckCapacity;
        const int k_NumOfTires = 12;
        const float k_MaxAirPressure = 28;
        const eTypeFuel k_TypeFuel = eTypeFuel.Soler;
        const float k_MaxFuelQuantity = 115;

        public Truck(string i_LicencseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining, string i_OwnerName, string i_OwnerTelephone, 
            string i_ManufacturerName, float i_CurrentAirPressure,   bool i_IsTrunkCooled, float i_TrunckCapacity, float i_CurrentFuelQuantity) : 
            base(i_LicencseNumber, i_ModelName, i_PercentageOfEnergyRemaining, i_OwnerName, i_OwnerTelephone, k_NumOfTires, i_ManufacturerName, 
                i_CurrentAirPressure, k_MaxAirPressure, k_TypeFuel, i_CurrentFuelQuantity, k_MaxFuelQuantity)
        {
            m_IsTrunkCooled = i_IsTrunkCooled;
            m_TrunckCapacity = i_TrunckCapacity;
        }

        public override string ToString()
        {
            return String.Format("{0} , IsTrunkCooled = {1}, m_TrunckCapacity = {2} "
                ,base.ToString(), m_IsTrunkCooled ,m_TrunckCapacity);
        }
    }
}
