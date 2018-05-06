using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, Vehicle> m_vehicleDictionary;
        public Garage()
        {
            m_vehicleDictionary = new Dictionary<string, Vehicle>();
        }

        public bool IsVehicleExist(string i_licenseNumber)
        {
            bool isExist;
            Vehicle vehicle;
            m_vehicleDictionary.TryGetValue(i_licenseNumber, out vehicle);

            if(vehicle == null)
            {
                isExist = false;
            }
            else
            {
                isExist = true;
            }

            return isExist;
        }

        public void ChangeVehicleRepairStatus(string i_licenseNumber, eRepairStatus i_NewSatus)
        {
            Vehicle vehicle = m_vehicleDictionary[i_licenseNumber];
            vehicle.m_Status = i_NewSatus;
        }

        public void AddNewVehicle(string i_Type, string i_LicenseNumber, string i_ModelName,
            float i_PercentageOfEnergyRemaining, float i_TiresPressure, string i_OwnerName, string i_OwnerTelephone,
            string i_ManufacturerName, string i_OtherDetails)
        {
            Vehicle vehicle = VehicleGenerator.CreateNewVehicle(i_Type, i_LicenseNumber, i_ModelName,
            i_PercentageOfEnergyRemaining, i_TiresPressure, i_OwnerName, i_OwnerTelephone, i_ManufacturerName,
            i_OtherDetails);

            m_vehicleDictionary.Add(i_LicenseNumber, vehicle);
        }

        public List<string> GetAllVehiclesLisenceNumber()
        {
            List<string> o_VehiclesDetailList = new List<string>();

            foreach (Vehicle currentVehicle in m_vehicleDictionary.Values)
            {
                o_VehiclesDetailList.Add(currentVehicle.m_LicenseNumber);
            }

            return o_VehiclesDetailList;
        }

        public List<string> GetAllVehiclesLisenceNumber(eRepairStatus i_Status)
        {
            List<string> o_VehiclesDetailList = new List<string>();

            foreach (Vehicle currentVehicle in m_vehicleDictionary.Values)
            {
                if(i_Status == currentVehicle.m_Status)
                {
                    o_VehiclesDetailList.Add(currentVehicle.m_LicenseNumber);
                }
            }

            return o_VehiclesDetailList;
        }

        public string GetVehicleDetail(string i_licenseNumber)
        {
            return m_vehicleDictionary[i_licenseNumber].ToString();
        }

        public void BlowUpAllTireToMax(string i_licenseNumber)
        {
            var Tires = m_vehicleDictionary[i_licenseNumber].m_Tires;

            foreach (Tire currentTire in Tires)
            {
                currentTire.m_CurrentAirPressure = currentTire.m_MaxAirPressure;
            }
        }

        public void RefuleVehicle(string i_licenseNumber, eTypeFuel i_fuelType, float i_LiterQuantity)
        {
            FuelVehicle fuelVehicle = ((FuelVehicle)m_vehicleDictionary[i_licenseNumber]);
            fuelVehicle.Refuel(i_LiterQuantity, i_fuelType);
        }

        public void ChargeVehicle(string i_licenseNumber, float i_TimeToCharge)
        {
            ElectricVehicle electricVehicle = ((ElectricVehicle)m_vehicleDictionary[i_licenseNumber]);
            electricVehicle.ChargeBattery(i_TimeToCharge);
        }

        public static eColors CastColor(string i_DoorColor)
        {
            eColors o_Color;

            switch (i_DoorColor.ToLower())
            {
                case "gray":
                    {
                        o_Color = eColors.Gray;
                        break;
                    }
                case "blue":
                    {
                        o_Color = eColors.Blue;
                        break;
                    }

                case "black":
                    {
                        o_Color = eColors.Black;
                        break;
                    }
                case "white":
                    {
                        o_Color = eColors.White;
                        break;
                    }
                default:
                    {
                        throw new InvalidCastException();
                    }
            }

            return o_Color;
        }

        public static eNumberOfDoors castNumberOfDoor(string i_NumberOfDoors)
        {
            eNumberOfDoors o_NumberOfDoors;
            
            switch (i_NumberOfDoors.ToLower())
            {
                case "2":
                    {
                        o_NumberOfDoors = eNumberOfDoors.Two;
                        break;
                    }
                case "3":
                    {
                        o_NumberOfDoors = eNumberOfDoors.Three;
                        break;
                    }

                case "4":
                    {
                        o_NumberOfDoors = eNumberOfDoors.Four;
                        break;
                    }
                case "5":
                    {
                        o_NumberOfDoors = eNumberOfDoors.Five;
                        break;
                    }
                default:
                    {
                        throw new InvalidCastException();
                    }
            }

            return o_NumberOfDoors;
        }

        public static eTypeOfDriversLicense castTypeOfDriversLicense(string i_TypeOfDriversLicense)
        {
            eTypeOfDriversLicense o_TypeOfDriversLicense;
            
            switch (i_TypeOfDriversLicense.ToLower())
            {
                case "a":
                    {
                        o_TypeOfDriversLicense  = eTypeOfDriversLicense.A;
                        break;
                    }
                case "a1":
                    {
                        o_TypeOfDriversLicense = eTypeOfDriversLicense.A1;
                        break;
                    }

                case "b1":
                    {
                        o_TypeOfDriversLicense = eTypeOfDriversLicense.B1;
                        break;
                    }
                case "b2":
                    {
                        o_TypeOfDriversLicense = eTypeOfDriversLicense.B2;
                        break;
                    }
                default:
                    {
                        throw new InvalidCastException();
                    }
            }

            return o_TypeOfDriversLicense;
        }
    }
}
