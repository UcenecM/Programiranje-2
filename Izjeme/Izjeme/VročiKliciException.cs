using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    internal class VročiKliciException: ApplicationException
    {
        public VročiKliciException(string sp):
            base("Vroči klici: " + sp)
        {
        }
        public VročiKliciException(String sp):
             base("Vroči klici: " + sp)
        {
        }
}
}
