using System;

namespace Urejanje
{
    internal class Tabela
    {
        string[] tab;
        int štElementov;

        public Tabela(int velikost)
        {
            tab = new string[velikost];
            štElementov = 0;
        }

        public void Dodaj(string k)
        {
            tab[štElementov++] = k;
        }

        public void Izpiši()
        {
            for (int k = 0; k < tab.Length; k++)
            {
                Console.Write(tab[k] + " ");  
            }

            Console.WriteLine();
        }

        private int Pivot(int zač, int konec)
        {
            string p = tab[zač];
            int m = zač;
            int n = konec + 1;

            do
            {
                m = m + 1;
            } while (string.Compare(tab[m], p) <= 0 && m < konec);

            do
            {
                n = n - 1;
            } while (string.Compare(tab[n], p) > 0);

            while (m < n)
            {
                string temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;

                do
                {
                    m = m + 1;
                } while (string.Compare(tab[m], p) <= 0 && m < konec);

                do
                {
                    n = n - 1;
                } while (string.Compare(tab[n], p) > 0);
            }

            string temp1 = tab[zač];
            tab[zač] = tab[n];
            tab[n] = temp1;
            return n;
        }

        public void QuickSort(int zač, int konec)
        {
            if (zač >= konec)
            {
                return;
            }
            int delitev = Pivot(zač, konec);
            QuickSort(zač, delitev - 1);
            QuickSort(delitev + 1, konec);
        }
    }
}
