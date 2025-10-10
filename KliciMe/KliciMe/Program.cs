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

            Kupec60 alenka = new Kupec60();
            alenka.Ime = "Alenka";
            alenka.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(alenka.Ime + " dolguuje " + alenka.Stanje + " EUR");
        }
    }
}
