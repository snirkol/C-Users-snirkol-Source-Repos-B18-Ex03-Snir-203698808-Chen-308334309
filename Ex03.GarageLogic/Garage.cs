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

        public void AddNewVehicle(string i_licenseNumber)
        {
            Vehicle vehicle = VehicleGenerator.CreateNewVehicle(i_licenseNumber);

            m_vehicleDictionary.Add(i_licenseNumber, vehicle);
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
    }
}
