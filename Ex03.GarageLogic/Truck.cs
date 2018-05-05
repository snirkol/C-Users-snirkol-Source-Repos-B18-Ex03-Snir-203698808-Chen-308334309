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

        public Truck(string i_LicencseNumber, bool i_IsTrunkCooled, float i_TrunckCapacity, eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, 
            float i_MaxFuelQuantity) : base(i_LicencseNumber, i_TypeFuel, i_CurrentFuelQuantity, i_MaxFuelQuantity)
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
