using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Motorcycle
    {
        eTypeOfDriversLicense m_TypeOfLicense;
        int m_EngineCapacity;

        public Motorcycle(eTypeOfDriversLicense i_TypeOfLicense, int i_EngineCapacity)
        {
            m_TypeOfLicense = i_TypeOfLicense;
            m_EngineCapacity = i_EngineCapacity;
        }

        public override string ToString()
        {
            return string.Format("Driver licencnce type: {0}, EngineCapacity: {1}"
                ,m_TypeOfLicense.ToString(), m_EngineCapacity );
        }
    }
}
