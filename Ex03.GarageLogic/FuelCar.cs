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
        const int k_NumOfTires = 4;
        const float k_MaxAirPressure = 32;
        const eTypeFuel k_TypeFuel = eTypeFuel.Octan98;
        const float k_MaxFuelQuantity = 45;

        public FuelCar(string i_LicenseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining ,string i_OwnerName, string i_OwnerTelephone, string i_ManufacturerName, float i_CurrentAirPressure, float i_CurrentFuelQuantity, 
            eColors i_Color, eNumberOfDoors i_NumOfDoors) : base(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining, i_OwnerName, i_OwnerTelephone, 
                k_NumOfTires, i_ManufacturerName, i_CurrentAirPressure, k_MaxAirPressure, k_TypeFuel, i_CurrentFuelQuantity, k_MaxFuelQuantity) 
        {
            m_Motorcar = new Car(i_Color, i_NumOfDoors);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", base.ToString(), m_Motorcar.ToString());
        }
    }
}
