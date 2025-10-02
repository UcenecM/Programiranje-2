using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napišite program, s katerim preberete nenegativno celo število in izpišite njegovo fakulteto.
            //Fakulteta števila n je definirana n!= n.(n - 1).(n - 2)….3.2.1.Primer 5 != 5.4.3.2.1 = 120.

            Console.WriteLine("5! = " + fakulteta(5));
            Console.WriteLine("5! = " + fr(5));
        }
        static int fakulteta(int n)
        {
            int produkt = 1;
            for (int k = n; k >= 1; k--)
            {
                produkt *= k;
            }
            return produkt;

        }
        //rekurzivan n!
        static int fr(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * fr(n - 1);
        }
        static int Fibonachi(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }


    }
}
