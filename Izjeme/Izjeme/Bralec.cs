using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    internal class Bralec
    {
        FileStream fs;
        StreamReader sr;
        uint Število;
        public void Odpri(string imeD)
        {
            fs = new FileStream(imeD, FileMode.Open);
            sr = new StreamReader(fs);
            try
            {
                string prvaVrstica = sr.ReadLine();
                Število = uint.Parse(prvaVrstica);
            }
            catch(FormatException x)
            {
                throw new VročiKliciException("Prvo stevilo no poz")  
                    
            }

        }
        public uint NOseb
        {
            get { return Število; }
        }
        public void ObravnajNasedjega()
        {
            try
            {
                string ime = sr.ReadLine();
                if(ime == null)
                {
                    throw new VročiKliciException("Ni dovolj imen");
                }
                if (ime[0] == 'Z')
                    throw new TajniAgentException(ime);
            }
            catch(TajniAgentException x)
            {
                Console.Write
            }
        }
    }
}
