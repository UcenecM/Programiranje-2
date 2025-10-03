namespace REKURZIJE_DALJE
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine(naloga5(5));
            Console.WriteLine(naloga6(5));
            Console.WriteLine(naloga7(5));
            Console.WriteLine(naloga10(10,5));
        }

        internal static int naloga5(int n)
        {
            //        5. Podano je zaporedje:: 1, 2, 5, 12, 29, …
            //a.Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
            //Upoštevajte, da je zaporedje definirano:
            //a1 = 1
            //a2 = 2
            //a(n) = a(n-1)*2 + a(n-2)
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            return naloga5(n - 1) * 2 + naloga5(n - 2);
        }

        internal static int naloga6(int n)
        {
            //6.Podano je zaporedje: 1, 4, 6, 8, 10, 12, 14, 16, …
            //a.Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
            //Upoštevajte, da je zaporedje definirano:
            //a1 = 1
            //a2 = 4
            //a(n)= a(n-1)+2
            if (n == 1)
                return 1;
            else if (n == 2)
                return 4;
            else
                return naloga6(n - 1) + 2;
        }

        internal static int naloga7(int n)
        {
            //7. Podano je zaporedje: 1, 3, 8, 18, 38, 78, ...
            //a.Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
            //Upoštevajte, da je zaporedje definirano:
            //a1 = 1
            //a2 = 3
            //a(n) = 2*a(n-1)+2
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 3;
            }
            else
            {
                return 2 * naloga7(n - 1) + 2;
            }
        }
        static int naloga10(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return a * naloga10(a, n - 1);
        }

    }
}
