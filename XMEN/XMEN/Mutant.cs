using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMEN
{
    internal abstract class Mutant
    {
        public String Ime { get; set; }
        public int Stopnja { get; set; }
        public abstract int KvocientNevarnosti();


        public void PrikažiInformacije()
        {
            Console.WriteLine("Sem " + Ime + " moj koficient nevarnosi je " + KvocientNevarnosti());
        }
    }
}
