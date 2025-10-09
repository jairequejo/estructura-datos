using Clases;
using Clases.Arbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecucionConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario miArbol = new ArbolBinario();

            int[] valores = { 5, 3, 7, 2, 4, 6, 8, 1 };

            Console.WriteLine("--- INSERCIÓN DE NODOS ---");
            foreach (int valor in valores)
            {
                // La llamada inicial debe usar miArbol.nodoRaiz
                // ya que el método Insertar recibe la referencia al nodo actual.
                miArbol.Insertar(ref miArbol.nodoRaiz, valor);
            }
            miArbol.MostrarArbol(miArbol.nodoRaiz, 0);

        }
    }
}
