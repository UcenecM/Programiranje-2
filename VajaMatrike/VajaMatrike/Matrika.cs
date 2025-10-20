using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaMatrike
{
    internal class Matrika
    {
        private double[,] tab = new double[3, 3];

        public double this[int x, int y]
        {
            get { return tab[x, y]; }
            set { tab[x, y] = value; }
        }

        public void Tiskaj()
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j=0; j< 3; j++)
                {
                    Console.Write(tab[i, j]+ "\t");
                }
                Console.WriteLine();
            }
        }
        public static Matrika operator +(Matrika a, Matrika b)
        {
            Matrika r = new Matrika();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r[i, j] = a[i, j] + b[i, j];
                }
            }
            return r;
        }

    }
}
