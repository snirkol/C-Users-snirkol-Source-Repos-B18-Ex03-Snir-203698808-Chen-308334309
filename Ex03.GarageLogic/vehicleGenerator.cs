using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    static class vehicleGenerator
    {
        public static Vehicle CreateNewVehicle(string i_LicenseNumber)
        {
            if(i_LicenseNumber.Length < 7)
            {
                throw new Exception();
            }

            Vehicle newVehicle = new Vehicle(i_LicenseNumber);
            return newVehicle; 
            
        }
    }
}
