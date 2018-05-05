﻿using System;
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
        ICollection<Tire> m_tires;
        string m_OwnerName;
        string m_ownerTelephone;
        eRepairStatus m_Status;

        public Vehicle(string i_LicencseNumber)
        {
            this.m_LicenseNumber = i_LicencseNumber;
        }
    }
}
