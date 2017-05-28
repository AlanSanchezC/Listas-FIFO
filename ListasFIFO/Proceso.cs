using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasFIFO
{
    class Proceso
    {
        public int tiempo { get; set; }
        public Proceso siguiente { get; set; }

        public Proceso(int time)
        {
            tiempo = time;
        }
    }
}
