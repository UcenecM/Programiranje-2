using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraSkartami
{
    internal class Kup
    {
        List<Karta> karte;
        Random r = new Random();
        //ctor brez parametrov napolni kup z vsemi kartami
        public Kup(){
            for(int b = 0; b <4; b++)
            {
                karte = new List<Karta>();
                for (int v = 1; v <=13;v++)
                {
                    karte.Add(new Karta((Barve)b, (Vrednosti)v));

                }
            }
       }
        public Kup(IEnumerable<Karta> začetek)
        {
            karte = new List<Karta>(začetek);
        }
        public void Add(Karta nova)
        {
            karte.Add(nova);
        }
        public int Count
        {
            get { return karte.Count; }
        }
        public void Sort()
        {
            karte.Sort(new Primerjava());
        }
        public Karta Deli(int indeks)
        {
            Karta zaDelitev = karte[indeks];
            karte.Remove(zaDelitev);
            return zaDelitev;
        }
        public void Mešaj()
        {
            List<Karta> noveKarte = new List<Karta>();
            while(karte.Count > 0)
            {
                int zaPremik = r.Next(karte.Count);
                noveKarte.Add(karte[zaPremik]);
                karte.RemoveAt(zaPremik);
            }
            karte = noveKarte;
        }
        public string[] ImenaKart()
        {
            string[] imena = new string[karte.Count];
            for(int k= 0; k < imena.Length; k++)
            {
                imena[k] = karte[k].Ime;
            }
            return imena;
        }
    }
}
