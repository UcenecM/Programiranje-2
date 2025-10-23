using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSkartami
{
    enum Vrednosti
    {
        As=1, Dva, Tri, Štiri, Pet, Šest, Sedem, Osem, Devet, Dest, Jazez, Dama, Kralj
    }
    enum Barve
    {
        Križ, Pik, Karo , Srce
    }
    internal class Karta
    {
        public Barve Barva { get; set; }
        public Vrednosti Vrednost { get; set; }

        public String Ime { get; set; }

        public Karta(Barve b, Vrednosti v)
        {
            Barva = b;
            Vrednost = v;
            Ime = Vrednost + " " + Barva;
        }
    }
}
