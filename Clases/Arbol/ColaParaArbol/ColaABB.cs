using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Arbol.ColaParaArbol
{
    public class ColaABB
    {
        public NodoColaABB Frente;
        public NodoColaABB Final;

        public void Encolar(NodoArbol dato)
        {
            NodoColaABB nuevoNodo = new NodoColaABB(dato);
            if (Final == null)
            {
                Frente = nuevoNodo;
                Final = nuevoNodo;
                //Console.WriteLine($"Se encoló el primer nodo: {dato.dato}");
            }
            else
            {
                Final.Siguiente = nuevoNodo;
                Final = nuevoNodo;
                //Console.WriteLine($"Se encoló un nodo más: {dato.dato}");
            }
        }

        public NodoArbol Desencolar()
        {
            if (Frente == null)
            {
                Console.WriteLine("No se pudo desencolar, la cola está vacía");
                return null;
            }

            NodoColaABB nodoAuxiliar = Frente;
            Frente = Frente.Siguiente;

            if (Frente == null)
                Final = null;

            return nodoAuxiliar.Dato;
        }

        public bool EstaVacia()
        {
            return Frente == null;
        }
    }
}
