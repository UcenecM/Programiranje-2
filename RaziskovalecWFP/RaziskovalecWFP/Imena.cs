using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaziskovalecWFP
{
    internal class Imena
    {
        public string ime { get; set; }
        public ObservableCollection<Imena> Elementi { get; set; }
        public Imena()
        {
            Elementi = new ObservableCollection<Imena>();
        }
    }
}
