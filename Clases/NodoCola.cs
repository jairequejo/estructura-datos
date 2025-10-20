using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoCola<T>
    {
        public T Dato;
        public NodoCola<T> Siguiente;
        public NodoCola(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
