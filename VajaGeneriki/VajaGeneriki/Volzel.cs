using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class Volzel<K, T>
    {
        public K Key { get; set; }
        public T Item { get; set; }

        public Volzel<K, T> Naslednji { get; set; }
        public Vozel(){
            Key = default(K);
            Item = default(T);
            Naslednji = null;
        }
        public Volzel(K kljuc, 
    }
}
