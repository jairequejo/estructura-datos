using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Grafos
{
    public  class NodoLista
    {
        public int dato;
        public NodoLista siguiente = null;
        public NodoLista(int dato)
        {
            this.dato = dato;
        }
    }
}
