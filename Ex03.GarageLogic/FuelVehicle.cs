using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelVehicle : Vehicle
    {
        eTypeFuel m_TypeFuel;
        float m_CurrentFuelQuantity;
        float m_MaxFuelQuantity;

        public FuelVehicle(string i_LicencseNumber, eTypeFuel i_TypeFuel, 
            float i_CurrentFuelQuantity, float i_MaxFuelQuantity) : base(i_LicencseNumber)
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
            else
            {
                if((m_CurrentFuelQuantity + i_LiterQuantityToAdd > m_MaxFuelQuantity))
                {
                    throw new ValueOutOfRangeException(0, m_MaxFuelQuantity - m_CurrentFuelQuantity);
                }
                else if(i_TypeFuel != m_TypeFuel)
                {
                    throw new ArgumentException("i_TypeFuel","Fuel type incorrect");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, fuel type: {1}, current fuel quantity: {2}, max fuel quantity: {3}"
                , base.ToString(), m_TypeFuel.ToString(), m_CurrentFuelQuantity, m_MaxFuelQuantity);
        }
    }
}
