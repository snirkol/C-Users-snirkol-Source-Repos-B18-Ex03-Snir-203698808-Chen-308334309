using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Vehicle
    {
        string m_ModelName;
        string m_LicenseNumber;
        float m_PercentageOfEnergyRemaining;
        public ICollection<Tire> m_tires { get; set; }
        string m_OwnerName;
        string m_ownerTelephone;
        public eRepairStatus m_Status { get; set; }
        public Vehicle(string i_LicencseNumber)
        {
            this.m_LicenseNumber = i_LicencseNumber;
        }
    }
}
