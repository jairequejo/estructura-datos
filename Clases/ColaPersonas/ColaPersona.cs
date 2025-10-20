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
            NodoPersona nodoNuevo = new NodoPersona(p);

            //2. encolar
            if (frente == null)
            {
                frente = nodoNuevo;
                final = nodoNuevo;
            }
            else
            {
                // Cola Preferencial
                if (p.EsPrioridad)
                {
                    if (frente.dato.EsPrioridad)
                    {
                        // Se compila despues del ultimo preferencial
                        NodoPersona aux = frente;
                        while (aux.sig != null && aux.sig.dato.EsPrioridad)
                        {
                            aux = aux.sig; 
                        }

                        // Auxiliar ya es igual al ultimo preferencial

                        nodoNuevo.sig = aux.sig;
                        aux.sig = nodoNuevo;
                    }
                    else
                    {
                        // El nuevo es preferencial y el frente no, se encola al frente
                        nodoNuevo.sig = frente;
                        frente = nodoNuevo;
                    }
                }
                else
                {
                    final.sig = nodoNuevo;
                    final = nodoNuevo;
                }
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
