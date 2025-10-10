using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMEN
{
    internal class Elementalec:Mutant
    {
        public int Področje { get; set; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * Področje;
        }
    }
}
