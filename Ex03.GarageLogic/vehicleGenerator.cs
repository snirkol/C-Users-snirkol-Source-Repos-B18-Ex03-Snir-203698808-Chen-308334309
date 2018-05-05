using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    static class VehicleGenerator
    {
        public static Vehicle CreateNewVehicle(string i_Type, string i_LicenseNumber, string i_ModelName,
            float i_PercentageOfEnergyRemaining, float i_TiresPressure, string i_OwnerName , string i_OwnerTelephone,
            string i_ManufacturerName, string i_OtherDetails)
        {
            Vehicle vehicle = null;

            switch (i_Type)
            {
                case "truck":
                    {
                        vehicle = createTruck(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                            i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_OtherDetails);

                        break;
                    }
            }
            //Vehicle newVehicle = new Vehicle(i_LicenseNumber);
            //return newVehicle; 

            return vehicle;
        }

        private static Vehicle createTruck(string i_LicenseNumber, string i_ModelName,
            float i_PercentageOfEnergyRemaining, float i_TiresPressure,string i_ManufacturerName, string i_OwnerName,
            string i_OwnerTelephone, string i_OtherDetails)
        {
            string[] otherDetails = i_OtherDetails.Split(' ');
            bool isCooled;
            float trunckCapacity;
            float fuelQuantity;

            if (!bool.TryParse(otherDetails[0], out isCooled) ||
                !float.TryParse(otherDetails[1], out trunckCapacity)||
                !float.TryParse(otherDetails[2], out fuelQuantity))
            {
                throw new ArgumentException();
            }


            Truck truck = new Truck(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining, i_OwnerName,
                i_OwnerTelephone, i_ManufacturerName, i_TiresPressure, isCooled, trunckCapacity, fuelQuantity);

            return truck;
        }
    }
}
