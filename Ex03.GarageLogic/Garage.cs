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

        public void enterVehicleToGarage(string i_licenseNumber)
        {
            Vehicle vehicle = m_vehicleDictionary[i_licenseNumber];
            vehicle.m_Status = eRepairStatus.InProcess;
        }

        public void AddNewVehicle(string i_licenseNumber)
        {
            Vehicle vehicle = VehicleGenerator.CreateNewVehicle(i_licenseNumber);

            m_vehicleDictionary.Add(i_licenseNumber, vehicle);
        }
    }
}
