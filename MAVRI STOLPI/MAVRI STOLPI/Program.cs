namespace MAVRI_STOLPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hanoi(2000, "a", "b", "c");
        }

        static void Hanoi(int n,  string zac, string koncni, string pomoc)
        {
            if (n == 1)
            {
                Console.WriteLine("premakni obroc iz "+zac+" na "+koncni);
                return;
            }
            Hanoi(n - 1, zac, pomoc, koncni);
            Console.WriteLine("premakni obroc iz " + zac + " na " + koncni);
            Hanoi(n - 1, pomoc, koncni, zac);

        }
    }
}
