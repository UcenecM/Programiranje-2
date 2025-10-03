using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urejanje
{
    internal class Tabela
    {
        int[] tab;
        int štElementov;

        public Tabela(int velikost)
        {
            tab = new int[velikost];
            štElementov = 0;
        }
        public void Dodaj(int k)
        {
            tab[štElementov++] = k;
        }
        public void Izpiši()
        {
            for (int k = 0; k<tab.Length; k++)
            {
                Console.WriteLine("{0,4", tab[k]);
            }
            Console.WriteLine();
        }
    }
}
