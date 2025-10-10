namespace KliciMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec Janez = new Kupec();
            Janez.Ime = "Janez";
            //Janez.BeležiKlic(10, 1);
            Console.WriteLine(Janez.Ime+" dolguuje " + Janez.Stanje + " EUR");

            Kupec60 alenka = new Kupec60();
            alenka.Ime = "Alenka";
            alenka.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(alenka.Ime + " dolguuje " + alenka.Stanje + " EUR");

            Kupec[] vsiKupci = new Kupec[2];
            vsiKupci[0] = new Kupec();
            vsiKupci[0].Ime = "Janez";
            vsiKupci[0].BeležiKlic(10, TipKlica.Stacionarno);
            vsiKupci[1] = new Kupec60();
            vsiKupci[1].Ime = "Alenka";
            vsiKupci[1].BeležiKlic(10, TipKlica.Mobilno);


        }
    }
}
