using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoprogram
{
    internal class ElektricniAvto: Avto
    {
        public double PorabaNa100KmKWh { get; set; }

        public ElektricniAvto(string znamka, double porabaNa100KmKWh)
            : base(znamka, 0) 
        {
            PorabaNa100KmKWh = porabaNa100KmKWh;
        }

        public override double IzracunajPorabo(double prevozeniKm)
        {
            return prevozeniKm / 100 * PorabaNa100KmKWh;
        }
    }
}
