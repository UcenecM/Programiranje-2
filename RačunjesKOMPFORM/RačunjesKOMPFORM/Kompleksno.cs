using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RačunjesKOMPFORM
{
    internal class Kompleksno
    {
        public double Realna { get; set; }
        public double Imagiarna { get; set; }

        public Kompleksno(double x, double y)
        {
            Realna = x; Imagiarna = y;
        }
        //izpis
        public override string ToString()
        {
            return Realna + " +i* " + Imagiarna;
        }
        public static Kompleksno operator +(Kompleksno z, Kompleksno w)
        {
            Kompleksno r = new Kompleksno(0, 0);
            r.Realna = z.Realna + w.Realna;
            r.Imagiarna = z.Imagiarna + w.Imagiarna;
            return r;
        }
        public static Kompleksno operator -(Kompleksno z, Kompleksno w)
        {
            Kompleksno r = new Kompleksno(0, 0);
            r.Realna = z.Realna - w.Realna;
            r.Imagiarna = z.Imagiarna - w.Imagiarna;
            return r;
        }
        public static Kompleksno operator *(Kompleksno a, Kompleksno b)
        {
            Kompleksno r = new Kompleksno(0, 0);

            r.Imagiarna = a.Realna * b.Imagiarna + a.Imagiarna * b.Realna;
            r.Realna = a.Realna * b.Realna - a.Imagiarna * b.Imagiarna;
            return r;
        }
    }
}
