namespace KliciMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec Janez = new Kupec();
            Janez.Ime = "Janez";
            Janez.BeležiKlic(10, 1);
            Console.WriteLine(Janez.Ime+" dolguuje " + Janez.Stanje + " EUR");
        }
    }
}
