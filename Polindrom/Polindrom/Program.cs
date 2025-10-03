namespace Polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi besedo: ");
            string beseda = Console.ReadLine();
            if(Polindrom(beseda) == true)
            {
                Console.WriteLine("BESEDA JE POLINDROM");
            }
            else
            {
                Console.WriteLine("NI POLINDROPM");
            }
        }
        static bool Polindrom(String s)
        {
            if (s.Length <= 1)
                return true;
    
            if (s[0] != s[s.Length - 1])
                return false;

            return Polindrom(s.Substring(1, s.Length - 2));
        }
    }
}
