using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelCar : FuelVehicle
    {
        Car m_Motorcar;

        public FuelCar(string i_LicenseNumber, eTypeFuel i_TypeFuel, float i_CurrentFuelQuantity, float i_MaxFuelQuantity, 
            eColors i_Color, eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber, i_TypeFuel, i_CurrentFuelQuantity, i_MaxFuelQuantity)
        {
            m_Motorcar = new Car(i_Color, i_NumOfDoors);
        }
    }
}
