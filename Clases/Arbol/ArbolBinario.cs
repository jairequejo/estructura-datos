using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Arbol
{
    public class ArbolBinario
    {
        public NodoArbol nodoRaiz = null;

        public void Insertar(ref NodoArbol nodoRaiz, int valor)
        {
            if (nodoRaiz == null)
            {
                NodoArbol nodoNuevo = new NodoArbol();
                nodoNuevo.dato = valor;
                nodoRaiz = nodoNuevo;
                Console.WriteLine($"Elemento agregado");
            }
            else
            {
                if (valor < nodoRaiz.dato)
                {
                    Insertar(ref nodoRaiz.Izquierda, valor);
                }
                else if (valor > nodoRaiz.dato)
                {
                    Insertar(ref nodoRaiz.Derecha, valor);
                }
                else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }
        public void MostrarArbol(NodoArbol raiz, int espacios)
        {
            if (raiz == null)
            {
                return;
            }
            else
            {
                MostrarArbol(raiz.Derecha, espacios + 1);
                for (int i = 0; i < espacios; i++)
                {
                    Console.Write("   ");
                }
                Console.WriteLine(raiz.dato);
                MostrarArbol(raiz.Izquierda, espacios + 1);
            }
        }
    }
}
