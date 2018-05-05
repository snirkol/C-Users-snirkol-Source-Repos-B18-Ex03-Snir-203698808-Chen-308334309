﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelMotorcycle : FuelVehicle
    {
        Motorcycle m_MotorCycle;
        const int k_NumOfTires = 2;
        const float k_MaxAirPressure = 30;
        const eTypeFuel k_TypeFuel = eTypeFuel.Octan96;
        const float k_MaxFuelQuantity = 6;


        public FuelMotorcycle(string i_LicenseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining, string i_OwnerName, string i_OwnerTelephone, 
            string i_ManufacturerName, float i_CurrentAirPressure,  eTypeOfDriversLicense i_TypeOfLicense, int i_EngineCapacity, eTypeFuel i_TypeFuel, 
            float i_CurrentFuelQuantity) : base(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining, i_OwnerName, i_OwnerTelephone, k_NumOfTires, 
                i_ManufacturerName, i_CurrentAirPressure, k_MaxAirPressure, k_TypeFuel, i_CurrentFuelQuantity, k_MaxFuelQuantity)
        {
            m_MotorCycle = new Motorcycle(i_TypeOfLicense, i_EngineCapacity);
        }

        public override string ToString()
        {
            return string.Format ("{0}, {1}",base.ToString(), m_MotorCycle.ToString());
        }
    }
}
