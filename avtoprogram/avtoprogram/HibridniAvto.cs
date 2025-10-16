using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoprogram
{
    internal class HibridniAvto :Avto
    {
        public double ElektricniDelez { get; set; }

        public HibridniAvto(string znamka, double porabaNa100Km, double elektricniDelez): base(znamka, porabaNa100Km)
        {
            ElektricniDelez = elektricniDelez;
        }

      
        public override double IzracunajPorabo(double prevozeniKm)
        {
 
            double porabaBencina = base.IzracunajPorabo(prevozeniKm);

       
            double porabaElektricna = prevozeniKm * ElektricniDelez / 100 * 15;
            Console.WriteLine("");
            Console.WriteLine("Tu vrne Hibridni Avto: ");
            Console.WriteLine($"{Znamka} porabi {porabaBencina} litrov bencina na {prevozeniKm} km");
            Console.WriteLine($"in porabi {porabaElektricna}kwh električne energije na {prevozeniKm} km.");
            Console.WriteLine("");

            return porabaBencina;
        }
    }
}
