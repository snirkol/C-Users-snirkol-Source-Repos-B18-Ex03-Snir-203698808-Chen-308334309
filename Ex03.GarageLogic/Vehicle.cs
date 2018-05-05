using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    abstract class Vehicle
    {
        string m_ModelName;
        public string m_LicenseNumber { get; }
        float m_PercentageOfEnergyRemaining;
        public List<Tire> m_Tires { get; set; }
        string m_OwnerName;
        string m_OwnerTelephone;
        public eRepairStatus m_Status { get; set; }

        public Vehicle(string i_LicencseNumber, string i_ModelName, float i_PercentageOfEnergyRemaining, 
            string i_OwnerName, string i_OwnerTelephone, int i_NumOfTires, string i_ManufacturerName, 
            float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            m_LicenseNumber = i_LicencseNumber;
            m_ModelName = i_ModelName;
            m_PercentageOfEnergyRemaining = i_PercentageOfEnergyRemaining;
            m_OwnerName = i_OwnerName;
            m_OwnerTelephone = i_OwnerTelephone;
            m_Status = eRepairStatus.InProcess;
            m_Tires = new List<Tire>(i_NumOfTires);

            for(int i=0; i < i_NumOfTires; i++)
            {
                m_Tires.Add(new Tire(i_ManufacturerName, i_CurrentAirPressure, i_MaxAirPressure));
            }
        }

        private string tireCollectionToString()
        {
            string o_Tires = "Tires: ";
            foreach (Tire currentTire in m_Tires)
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
                m_PercentageOfEnergyRemaining, m_OwnerName, m_OwnerTelephone, m_Status, tireCollectionToString());
        }
    }
}
