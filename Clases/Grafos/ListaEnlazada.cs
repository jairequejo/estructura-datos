using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Grafos
{
    public  class ListaEnlazada
    {
        public NodoLista PrimerNodo;
        public void Insertar(int dato)
        {
            if (PrimerNodo == null)
            {
                NodoLista nuevoNodo = new NodoLista(dato);
                if (PrimerNodo == null)
                {
                    PrimerNodo = nuevoNodo;
                }
                else
                {
                    NodoLista nodoTemporal = PrimerNodo;
                    while (nodoTemporal.siguiente != null)
                    {
                        nodoTemporal = nodoTemporal.siguiente;
                    }
                    nodoTemporal.siguiente = nuevoNodo;
                }
            }

        }
        public void Mostrar()
        {
            if (PrimerNodo == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            else
            {
                NodoLista nodoTemporal = PrimerNodo;
                while (nodoTemporal != null)
                {
                    Console.Write($"{nodoTemporal.dato} ->");
                    nodoTemporal = nodoTemporal.siguiente;
                }
            }
            Console.WriteLine(" ");
        }
    }
}
