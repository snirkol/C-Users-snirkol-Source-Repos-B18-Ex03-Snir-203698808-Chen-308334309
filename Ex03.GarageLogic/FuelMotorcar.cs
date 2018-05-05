using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelMotorcar : Vehicle
    {
        eTypeFuel m_TypeFuel;
        float m_CurrentFuelQuantity;
        float m_MaxFuelQuantity;
        Motorcar m_Motorcar;

        public FuelMotorcar(string i_LicenseNumber, eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, 
            float i_MaxFuelQuantity, eColors i_Color, eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber)
        {
            m_TypeFuel = i_TypeFuel;
            m_CurrentFuelQuantity = i_CurrentFuelQuantity;
            m_MaxFuelQuantity = i_MaxFuelQuantity;
            m_Motorcar = new Motorcar(i_Color, i_NumOfDoors);
        }

        public void Refuel (float i_LiterQuantityToAdd, eTypeFuel i_TypeFuel)
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
