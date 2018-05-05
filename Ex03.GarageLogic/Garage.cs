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

        public bool AddNewVehicle(string i_licenseNumber)
        {
            bool isSuccess = false;
            Vehicle vehicle = null;

            m_vehicleDictionary.TryGetValue(i_licenseNumber, out vehicle);

            if(vehicle == null)
            {
                m_vehicleDictionary.Add(
                    i_licenseNumber, VehicleGenerator.CreateNewVehicle(i_licenseNumber));
                isSuccess = true;
            }

            return isSuccess;
        }
    }
}
