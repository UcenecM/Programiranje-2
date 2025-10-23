using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class PovezanaLista<K, T>
    {
        Volzel<K, T> glava;
        public PovezanaLista()
        {
            glava = new Volzel<K, T>();
        }
        public void DodajGlavo(K key, T item)
        {
            Volzel<K, T> nov = new Volzel<K, T>(key, item, glava.Naslednji);
            glava.Naslednji = nov;
        }
        public T Najdi(K ključ)
        {
            Volzel<K, T> trenutni = glava;
            while(trenutni.Naslednji != null)
            {
                if(trenutni.Key == ključ)
                {
                    break;
                }
                else
                {
                    trenutni = trenutni.Naslednji;
                }
                return trenutni.Item;
            }
        }
    }
}
