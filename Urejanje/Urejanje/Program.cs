namespace Urejanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabela a = new Tabela(10);
            //a.Dodaj(6); a.Dodaj(24); a.Dodaj(80);
            //a.Dodaj(4); a.Dodaj(19); a.Dodaj(84);
            //a.Dodaj(1); a.Dodaj(10); a.Dodaj(13); a.Dodaj(7);


            Random r = new Random();
            Tabela a = new Tabela(11);
            for(int k=0; k<100; k++)
            {

            }

            Console.WriteLine("NEurejena tabela");
            a.Izpiši();
            a.QuickSort(0, 9);
            Console.WriteLine("URejenja tablea");
            a.Izpiši();
        }
    }
}
