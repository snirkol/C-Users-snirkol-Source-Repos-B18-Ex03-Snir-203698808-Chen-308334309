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
        public string m_LicenseNumber { get; }
        float m_PercentageOfEnergyRemaining;
        public ICollection<Tire> m_tires { get; set; }
        string m_OwnerName;
        string m_OwnerTelephone;
        public eRepairStatus m_Status { get; set; }
        public Vehicle(string i_LicencseNumber)
        {
            this.m_LicenseNumber = i_LicencseNumber;
        }

        private string tireCollectionToString()
        {
            string o_Tires = "Tires: ";
            foreach (Tire currentTire in m_tires)
            {
                o_Tires += string.Format( currentTire.ToString(), " ");
            }
            return o_Tires;
        }

        public override string ToString()
        {
            return string.Format("Model Name: {0}, License number: {1}," +
                " percentage of entergy remaining: {2}, owner name: {3}, owner telephone: {4}," +
                "repair status: {5}, tire: {6} ",m_ModelName, m_LicenseNumber,
                m_PercentageOfEnergyRemaining, m_OwnerName, m_OwnerTelephone, m_Status, m_tires.ToString());
        }
    }
}
