using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ColaPersonas
{
    public class NodoPersona
    {
        public Persona dato;
        public NodoPersona sig = null;

        public NodoPersona(Persona dato)
        {
            this.dato = dato;
        }
    }
}
