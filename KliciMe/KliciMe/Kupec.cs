using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KliciMe
{
    internal class Kupec
    {
        //enkapsulacija neki neki
        private string ime;
        private decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; set => stanje = value; }

        public void BeležiStanje(decimal plačilo)
        {
            stanje -= plačilo;
        }
        public void BeležiKlic(int minute, TipKlica tipKlica)
        {
            //1-stacionarno=minute*0.2,2- mobilno=minute*0.03
            switch(tipKlica){
                case TipKlica.Stacionarno:
                    stanje += minute * 0.2m;
                    break;
                case TipKlica.Mobilno:
                    stanje += minute * 0.3m;
                    break;
            }
        }
        public override string ToString()
        {
            return ime + " dolguje " + stanje + " EUR";
        }
    }
}
