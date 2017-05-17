using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasFIFO
{
    class Fifo
    {
        private Proceso actual;
        private int _ciclosVacios = 0;
        public int ciclosVacios
        { 
            get { return _ciclosVacios; }
        }

        public Proceso sacarElemento()
        {
            return actual;
        }

        public void agregar(Proceso p)
        {
            if (actual == null)
                actual = p;
            else
            {
                Proceso pr = actual;
                while (pr.siguiente != null)
                {
                    pr = pr.siguiente;
                }
                pr.siguiente = p;
            }
        }

        public void avanzar()
        {
            if (actual == null)
                _ciclosVacios++;
            else
            {
                if (actual.tiempo == 0)
                    if (actual.siguiente != null)
                    {
                        actual = actual.siguiente;
                    } 
                    else
                        actual = null;
                try
                {
                    actual.tiempo--;
                }
                catch (System.NullReferenceException) { }
            }
        }
        
    }
}
