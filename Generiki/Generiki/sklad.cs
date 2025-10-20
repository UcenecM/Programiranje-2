using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class sklad
    {
        int m_size;
        int m_Items;
        public sklad(int velikost)
        {
            m_size = velikost;
            m_Items = new object[m_size];
        }

    }
}
