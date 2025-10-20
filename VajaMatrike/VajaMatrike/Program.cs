namespace VajaMatrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrika m1 = new Matrika();
            Matrika m2 = new Matrika();
            Random r = new Random();
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    m1[x, y] = r.NextDouble();
                    m2[x, y] = r.NextDouble();
                }
            Console.WriteLine("Matrika 1");
            m1.Tiskaj();
            Console.WriteLine("Matrika 2");
            m2.Tiskaj();
            Console.WriteLine("Matrika 3");
            Matrika m3 = m1 + m2; m3.Tiskaj();
            Console.ReadLine();
        }
    }
}
