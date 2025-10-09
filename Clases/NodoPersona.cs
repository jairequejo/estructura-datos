using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoPersona<T>
    {
        public T Dato;
        public NodoPersona<T> Siguiente;
        public NodoPersona(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
