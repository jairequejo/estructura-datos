using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Arbol.ColaParaArbol
{
    public class NodoColaABB
    {
        public NodoArbol Dato;
        public NodoColaABB Siguiente;

        public NodoColaABB(NodoArbol dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
