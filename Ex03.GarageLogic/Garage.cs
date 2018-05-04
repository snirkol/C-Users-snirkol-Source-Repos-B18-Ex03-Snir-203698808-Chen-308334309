using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private List<Vehicle> m_vehicleList;
        public Garage()
        {
            m_vehicleList = new List<Vehicle>();
        }

        public void AddNewVehicle(string i_licenseNumber)
        {
            m_vehicleList.Add(
                vehicleGenerator.CreateNewVehicle(i_licenseNumber));
        }
    }
}
