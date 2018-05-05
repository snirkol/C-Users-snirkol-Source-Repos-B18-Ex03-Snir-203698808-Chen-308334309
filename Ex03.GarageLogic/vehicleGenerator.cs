using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    static class VehicleGenerator
    {
        public static Vehicle CreateNewVehicle(string i_Type, string i_LicenseNumber, string i_ModelName,float i_PercentageOfEnergyRemaining,
            float i_TiresPressure, string i_OwnerName , string i_OwnerTelephone, string i_OtherDetails)
        {
            Vehicle vehicle = null;

            switch (i_Type)
            {
                case "truck":
                    break;
            }
            //Vehicle newVehicle = new Vehicle(i_LicenseNumber);
            //return newVehicle; 

            return vehicle;
        }
    }
}
