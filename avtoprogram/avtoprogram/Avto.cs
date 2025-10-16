using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoprogram
{
    internal class Avto
    {
        public string Znamka { get; set; }
        public double PorabaNa100Km { get; set; }

        public Avto(string znamka, double porabaNa100Km)
        { 
            Znamka = znamka;
            PorabaNa100Km = porabaNa100Km;
        }

        public virtual double IzracunajPorabo(double prevozeniKm)
        {
            return prevozeniKm / 100 * PorabaNa100Km;
        }

    }
}
