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
        

        public void Inflate(float i_QuantityOfAir) { }

        public override string ToString()
        {
            return string.Format("Pressure {0}, Manufacturer Name: {1}"
                , m_CurrentAirPressure, m_ManufacturerName);
        }
    }
}
