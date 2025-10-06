namespace Urejanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabela a = new Tabela(10);
            a.Dodaj("Miha"); a.Dodaj("Ana"); a.Dodaj("Barbara");
            a.Dodaj("Vid"); a.Dodaj("Jan"); a.Dodaj("Žan");
            a.Dodaj("Lia"); a.Dodaj("Žiga"); a.Dodaj("Liam"); a.Dodaj("Tone");

            Console.WriteLine("NEurejena tabela");
            a.Izpiši();
            a.QuickSort(0, 9);
            Console.WriteLine("URejenja tablea");
            a.Izpiši();
        }
    }
}
