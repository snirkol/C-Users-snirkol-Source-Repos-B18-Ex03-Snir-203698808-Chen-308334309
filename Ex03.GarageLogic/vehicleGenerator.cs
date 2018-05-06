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

            switch (i_Type.ToLower())
            {
                case "truck":
                    {
                        vehicle = createTruck(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                            i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_OtherDetails);

                        break;
                    }

                case "fuelcar":
                    {
                        vehicle = createFuelCar(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                            i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_OtherDetails);
                        break;
                    }
                case "electriccar":
                    {
                        vehicle = createElectricCar(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                            i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_OtherDetails);
                        break;
                    }
                case "fuelmotorcycle":
                    {
                        vehicle = createFuelMotorcycle(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                            i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_OtherDetails);
                        break;
                    }
                case "electricmotorcycle":
                    {
                        vehicle = createElectricMotorcycle(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                            i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_OtherDetails);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Vehicle type not found");
                    }
            }

            return vehicle;
        }

        private static Vehicle createElectricMotorcycle(string i_LicenseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining, float i_TiresPressure, string i_OwnerName, string i_OwnerTelephone, string i_ManufacturerName, string i_OtherDetails)
        {
            string[] otherDetails = i_OtherDetails.Split(' ');

            eTypeOfDriversLicense typeOfDriversLicense = Garage.castTypeOfDriversLicense(otherDetails[0]);
            int engineCapacity;
            float batteryTime;

            if (!int.TryParse(otherDetails[1],out engineCapacity) ||
                !float.TryParse(otherDetails[2], out batteryTime))
            {
                throw new InvalidCastException();
            }

            ElectricMotorcycle electricMotorcycle = new ElectricMotorcycle(i_LicenseNumber, i_ModelName,
                i_PercentageOfEnergyRemaining , i_OwnerName, i_OwnerTelephone, i_ManufacturerName,i_TiresPressure,
                typeOfDriversLicense, engineCapacity, batteryTime);

            return electricMotorcycle;

        }

        private static Vehicle createFuelMotorcycle(string i_LicenseNumber, string i_ModelName,
            float i_PercentageOfEnergyRemaining, float i_TiresPressure, string i_OwnerName,
            string i_OwnerTelephone,string i_ManufacturerName, string i_OtherDetails)
        {
            string[] otherDetails = i_OtherDetails.Split(' ');
            eTypeOfDriversLicense typeOfLicense = Garage.castTypeOfDriversLicense(otherDetails[0]);
            int engineCapacity;
            float currentFuelQuantity;
            
            if(!int.TryParse(otherDetails[1], out engineCapacity) ||
                !float.TryParse(otherDetails[2], out currentFuelQuantity))
            {
                throw new InvalidCastException();
            }

            FuelMotorcycle fuelMotorcycle = new FuelMotorcycle(i_LicenseNumber, i_ModelName,
                i_PercentageOfEnergyRemaining,i_OwnerName, i_OwnerTelephone, i_ManufacturerName, i_TiresPressure,
                typeOfLicense, engineCapacity, currentFuelQuantity);

            return fuelMotorcycle;
        }

        private static Vehicle createElectricCar(string i_LicenseNumber, string i_ModelName,
            float i_PercentageOfEnergyRemaining, float i_TiresPressure, string i_OwnerName,
            string i_OwnerTelephone, string i_ManufacturerName, string i_OtherDetails)
        {
            string[] otherDetails = i_OtherDetails.Split(' ');
            eColors color = Garage.CastColor(otherDetails[0]);
            eNumberOfDoors numberOfDoors = Garage.castNumberOfDoor(otherDetails[1]);

            ElectricCar o_ElectriceCar = new ElectricCar(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                i_OwnerName, i_OwnerTelephone, i_PercentageOfEnergyRemaining , color, i_ManufacturerName,
                i_TiresPressure, numberOfDoors);

               return o_ElectriceCar;
        }

        private static Vehicle createFuelCar(string i_LicenseNumber, string i_ModelName,
            float i_PercentageOfEnergyRemaining, float i_TiresPressure,string i_OwnerName,
            string i_OwnerTelephone, string i_ManufacturerName, string i_OtherDetails)
        {
            string[] otherDetails = i_OtherDetails.Split(' ');
            float currentFuelQuantity;
            eColors doorsColor = Garage.CastColor(otherDetails[1]);
            eNumberOfDoors numberOfDoor= Garage.castNumberOfDoor(otherDetails[2]);

            //castColor and castNumberOfDoor method alredy throw exception.
            //no need to chek again
            if(!float.TryParse(otherDetails[0], out currentFuelQuantity))
            {
                throw new ArgumentException();
            }

            FuelCar fuelCar = new FuelCar(i_LicenseNumber, i_ModelName, i_PercentageOfEnergyRemaining,
                i_OwnerName, i_OwnerTelephone, i_ModelName, i_TiresPressure,
                currentFuelQuantity, doorsColor, numberOfDoor);

            return fuelCar;
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
                !float.TryParse(otherDetails[1], out trunckCapacity) ||
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
