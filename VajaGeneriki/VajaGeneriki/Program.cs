namespace VajaGeneriki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PovezanaLista<int, string> p1 = new PovezanaLista<int, string>();
            p1.DodajGlavo(1, "AAAAAAA");
            p1.DodajGlavo(2, "BBBBBBBB");

        }
    }
}
