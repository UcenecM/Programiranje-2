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
                Console.Write("{0,4}", tab[k]);
            }

            Console.WriteLine();
        }
        private int Pivot(int zač, int konec)
        {
            //metoda vrne pozicijo pivotnega elementa
            int p = tab[zač];
            int m = zač;
            int n = konec + 1;
            //z m poišči prvega, ki je večji od p
            do
            {
                m = m + 1;
            } while (tab[m] <= p && m < konec);
            //z n išči prveg, ki je manjši od p
            do
            {
                n = n - 1;
            } while (tab[n] > p);
            //dokler se m in n ne prekrižata
            while (m < n)
            {
                //zamenjaj m-ti in n-ti element
                int temp = tab[m]; tab[m] = tab[n]; tab[n] = temp;
                //z m poišči prvega, ki je večji od p
                do
                {
                    m = m + 1;
                } while (tab[m] <= p && m < konec);
                //z n išči prveg, ki je manjši od p
                do
                {
                    n = n - 1;
                } while (tab[n] > p);
            }
            int temp1 = tab[zač]; tab[zač] = tab[n]; tab[n] = temp1;
            return n;
        }
        public void QuickSort(int zač, int konec)
        {
            if(zač >= konec)
            {
                return;
            }
            int delitev = Pivot(zač, konec);
            Izpiši();
            QuickSort(zač, delitev - 1);
            QuickSort(delitev + 1, konec);
        }
    }
}
