using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preobteževanje_operatorjev
{
    internal class Pravokotnik
    {
        public double širina;
        public double višina;

        public Pravokotnik()
        {
            širina = 0;
            višina = 0;
        }

        public Pravokotnik(double širina, double višina)
        {
            this.širina = širina;
            this.višina = višina;
        }

        public double Širina
        {
            get { return širina; }
            set { širina = value; }
        }

        public double Višina
        {
            get { return višina; }
            set { višina = value; }
        }

        public double Ploščina
        {
            get { return širina * višina; }
        }

        //operator ==
        public static bool operator ==(Pravokotnik p1, Pravokotnik p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
                return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;

            return p1.Ploščina == p2.Ploščina;
        }

  
        //Operator !=
        public static bool operator !=(Pravokotnik p1, Pravokotnik p2)
        {
            return !(p1 == p2);
        }


        //Operator >
        public static bool operator >(Pravokotnik p1, Pravokotnik p2)
        {
            if (ReferenceEquals(p1, null))
                return false;  
            if (ReferenceEquals(p2, null))
                return true;  

            return p1.Ploščina > p2.Ploščina;
        }

        //Operator <
        public static bool operator <(Pravokotnik p1, Pravokotnik p2)
        {
            if (ReferenceEquals(p1, null))
                return !ReferenceEquals(p2, null);
            if (ReferenceEquals(p2, null))
                return false;

            return p1.Ploščina < p2.Ploščina;
        }
        //Operator >=
        public static bool operator >=(Pravokotnik p1, Pravokotnik p2)
        {
            return (p1 > p2) || (p1 == p2);
        }

        //Operator <=
        public static bool operator <=(Pravokotnik p1, Pravokotnik p2)
        {
            return (p1 < p2) || (p1 == p2);
        }
        public override string ToString()
        {
            return $"Višina = {višina}, Širina = {širina}";
        }

    }

}
