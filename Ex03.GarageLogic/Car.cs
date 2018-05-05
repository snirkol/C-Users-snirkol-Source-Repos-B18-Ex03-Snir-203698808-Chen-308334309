using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Car
    {
        eColors m_Color;
        eNumberOfDoors m_NumOfDoors;

        public Car(eColors i_Color, eNumberOfDoors i_NumOfDoors)
        {
            m_Color = i_Color;
            m_NumOfDoors = i_NumOfDoors;
        }
    }
}
