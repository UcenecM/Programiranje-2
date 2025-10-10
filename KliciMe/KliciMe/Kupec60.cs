using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KliciMe
{
    internal class Kupec60:Kupec
    {
        //60 minut v mobilno po 0.05€, ostale minute pa 0.01€
        private int višjaTarifaPorabljeno;

        public int VišjaTarifaPorabljeno { get => višjaTarifaPorabljeno; set => višjaTarifaPorabljeno = value; }

        public new void BeležiKlic(int minute, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    Stanje += minute * 0.2m;
                    break;
                case TipKlica.Mobilno:
                    int vMinute, nMinute;
                    int šeVMinute = (višjaTarifaPorabljeno < 60) ?
                        60 - višjaTarifaPorabljeno : 0;
                    if(minute > šeVMinute)
                    {
                        vMinute = šeVMinute;
                        nMinute = minute - šeVMinute;
                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    VišjaTarifaPorabljeno += vMinute;
                    Stanje += 0.05m * vMinute + 0.01m * nMinute;
                    break;
            }
        }
    }
}
