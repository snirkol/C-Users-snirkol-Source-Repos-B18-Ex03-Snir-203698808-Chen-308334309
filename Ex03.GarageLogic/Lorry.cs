using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Lorry : Vehicle
    {
        bool m_IsTrunkCooled;
        float m_TrunckCapacity;

        public Lorry(string i_LicencseNumber, bool i_IsTrunkCooled, float i_TrunckCapacity) : base(i_LicencseNumber)
        {
            m_IsTrunkCooled = i_IsTrunkCooled;
            m_TrunckCapacity = i_TrunckCapacity;
        }
    }
}
