using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Tire
    {
        readonly string m_ManufacturerName;
        public float m_CurrentAirPressure{ get; set; }
        public float m_MaxAirPressure{ get;}

        public Tire(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            if(i_CurrentAirPressure > i_MaxAirPressure)
            {
                throw new ValueOutOfRangeException(0, i_MaxAirPressure);
            }

            m_ManufacturerName = i_ManufacturerName;
            m_CurrentAirPressure = i_CurrentAirPressure;
            m_MaxAirPressure = i_MaxAirPressure;
        }

        public void Inflate(float i_QuantityOfAir)
        {
            if(m_CurrentAirPressure + i_QuantityOfAir <= m_MaxAirPressure)
            {
                m_CurrentAirPressure += i_QuantityOfAir;
            }
            else
            {
                throw new ValueOutOfRangeException(0, m_CurrentAirPressure - m_CurrentAirPressure);
            }
        }

        public override string ToString()
        {
            return string.Format("Pressure {0}, Manufacturer Name: {1}"
                , m_CurrentAirPressure, m_ManufacturerName);
        }
    }
}
