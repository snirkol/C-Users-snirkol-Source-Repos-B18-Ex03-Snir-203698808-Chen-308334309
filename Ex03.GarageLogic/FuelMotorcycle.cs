using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelMotorcycle : Vehicle
    {
        Motorcycle m_MotorCycle;
        FuelVehicle m_FuelVehicle;

        public FuelMotorcycle(string i_LicenseNumber, eTypeOfDriversLicense i_TypeOfLicense, int i_EngineCapacity, 
            eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, float i_MaxFuelQuantity) : base(i_LicenseNumber)
        {
            m_MotorCycle = new Motorcycle(i_TypeOfLicense, i_EngineCapacity);
            m_FuelVehicle = new FuelVehicle(i_TypeFuel, i_CurrentFuelQuantity, i_MaxFuelQuantity);
        }
    }
}
