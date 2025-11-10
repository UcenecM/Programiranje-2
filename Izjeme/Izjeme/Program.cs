namespace Izjeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String imeD;
            Console.WriteLine("Vnesi ime dadoteke: ");
            imeD = Console.ReadLine();
            Bralec osebe = new Bralec();
            try
            {
                osebe.Odpri(imeD);
                for(int k=0; k< osebe.NOseb; k++)
                {
                    osebe.ObravnajNasedjega();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Exceprion ne obstajaq");
            }
            catch(VročiKliciException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
