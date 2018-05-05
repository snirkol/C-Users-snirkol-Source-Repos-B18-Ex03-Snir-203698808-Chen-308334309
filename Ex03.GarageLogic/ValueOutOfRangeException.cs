using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ValueOutOfRangeException : Exception
    {
        float m_minValue;
        float m_maxValue;

        public ValueOutOfRangeException(float i_MinValue, float i_MaxValue)
        {
            m_minValue = i_MinValue;
            m_maxValue = i_MaxValue;
        }
    }
}
