namespace Rekurzija3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Podano je zaporedje: 2, 2, 3, 5, 14, 69, 965, ...
a. Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
b. Napišite sled izvajanja programa za klic test.clen(2) in test.clen(5)!
Upoštevajte, da je zaporedje definirano:
a1 = 2
a2 = 2
a(n) = a(n-2)*a(n-1) – 1*/
            Console.WriteLine(zaporedje(5));
            Console.WriteLine(zaporedje(2));
        }
        static int zaporedje(int n)
        {
               if(n== 1 || n== 2)
            {
                return 2;
            }
            return zaporedje(n - 2) * zaporedje(n - 1) - 1;
        }
    }
}
