using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelMotorcar : Vehicle
    {
        Motorcar m_Motorcar;
        FuelVehicle m_FuelVehicle;

        public FuelMotorcar(string i_LicenseNumber, eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, 
            float i_MaxFuelQuantity, eColors i_Color, eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber)
        {
            m_Motorcar = new Motorcar(i_Color, i_NumOfDoors);
            m_FuelVehicle = new FuelVehicle(i_TypeFuel, i_CurrentFuelQuantity, i_MaxFuelQuantity);
        }
    }
}
