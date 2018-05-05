using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelMotorcycle : FuelVehicle
    {
        Motorcycle m_MotorCycle;

        public FuelMotorcycle(string i_LicenseNumber, eTypeOfDriversLicense i_TypeOfLicense, int i_EngineCapacity, 
            eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, float i_MaxFuelQuantity) : base(i_LicenseNumber, i_TypeFuel, i_CurrentFuelQuantity, i_MaxFuelQuantity)
        {
            m_MotorCycle = new Motorcycle(i_TypeOfLicense, i_EngineCapacity);
        }

        public override string ToString()
        {
            return string.Format ("{0}, {1}",base.ToString(), m_MotorCycle.ToString());
        }
    }
}
