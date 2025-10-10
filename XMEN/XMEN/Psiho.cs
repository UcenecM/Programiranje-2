using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMEN
{
    internal class Psiho:Mutant
    {
        public int IQ { get; set; }
        public int ŠteviloUporabeMoči { get; set; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * IQ * ŠteviloUporabeMoči;
        }
    }
}
