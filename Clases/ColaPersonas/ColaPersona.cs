using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ColaPersonas
{
    public class ColaPersona
    {
        public NodoPersona frente = null;
        public NodoPersona final = null;

        public void Encolar(Persona p)
        {
            //1. Crear nuevo Nodo
            NodoPersona nuevo = new NodoPersona();
            nuevo.dato = p;

            //2. encolar
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {



                final.sig = nuevo;
                final = nuevo;
            }

        }

        public Persona Desencolar()
        {
            if (frente != null)
            {
                Persona p = frente.dato;

                frente = frente.sig;

                return p;
            }
            return null;
        }

        public bool EsVacio()
        {
            if (frente == null)
            {
                return true;
            }
            return false;
        }
        public Persona MostrarCola()
        {
            if (frente != null)
            {
                return frente.dato;
            }
            return null;
        }
    }
}
