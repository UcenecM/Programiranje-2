using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSkartami
{
    internal class Primerjava : IComparer<Karta>
    {
        public int Compare(Karta? x, Karta? y)
        {
            //kdaj je x pred y -- takrat vrni -1
            if (x.Vrednost < y.Vrednost)
                return -1;
            if (x.Vrednost >y.Vrednost)
            {
                return 1;
            }
            if(x.Barva < y.Barva)
            {
                return -1;
            }
            if (x.Barva > y.Barva)
            {
                return 1;
            }
            return 0;
        }
    }
}
