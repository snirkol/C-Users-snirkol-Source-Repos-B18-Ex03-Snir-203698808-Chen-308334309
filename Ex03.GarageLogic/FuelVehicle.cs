using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelVehicle
    {
        eTypeFuel m_TypeFuel;
        float m_CurrentFuelQuantity;
        float m_MaxFuelQuantity;

        public FuelVehicle(eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, float i_MaxFuelQuantity)
        {
            m_TypeFuel = i_TypeFuel;
            m_CurrentFuelQuantity = i_CurrentFuelQuantity;
            m_MaxFuelQuantity = i_MaxFuelQuantity;
        }

        public void Refuel(float i_LiterQuantityToAdd, eTypeFuel i_TypeFuel)
        {
            if ((m_CurrentFuelQuantity + i_LiterQuantityToAdd <= m_MaxFuelQuantity) &&
                (i_TypeFuel == m_TypeFuel))
            {
                m_CurrentFuelQuantity += i_LiterQuantityToAdd;
            }

            //TODO: else -> throw exception
        }
    }
}
