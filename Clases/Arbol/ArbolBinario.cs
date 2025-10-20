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

        private void Insertar(ref NodoArbol nodoRaiz, int valor)
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

        // Disfraz
        public void Insertar(int valor)
        {
            Insertar(ref nodoRaiz, valor);
        }

        //Dibujar
        private void Dibujar(NodoArbol raiz, int espacios)
        {
            if (raiz != null)
            {
                Dibujar(raiz.Derecha, espacios + 1);
                for (int i = 0; i < espacios; i++)
                {
                    Console.Write("   ");
                }
                Console.WriteLine(raiz.dato); //ayuda a mostrar la raiz(imprime)
                Dibujar(raiz.Izquierda, espacios + 1);
            }
        }

        public void Dibujar()
        {
            Dibujar(nodoRaiz, 0);

        }

        //INORDEN : izquierda - raiz - derecha COMPLETAR
        public void InOrden(NodoArbol raiz)
        {
            // Izquierda-Raiz-Derecha         
            if (raiz == null)
            {
                return;
            }
            else
            {
                InOrden(raiz.Izquierda);//izquierda
                Console.Write(raiz.dato + "-");//raiz
                InOrden(raiz.Derecha);//derecha
            }
        }

        //PREORDEN : raiz - izquierda - derecha COMPLETAR
        public void PreOrden(NodoArbol raiz)
        {
            // Raiz-izquierda- Derecha         
            if (raiz == null)
            {
                return;
            }
            else
            {
                Console.Write(raiz.dato + "-");//raiz
                PreOrden(raiz.Izquierda);//izquierda              
                PreOrden(raiz.Derecha);//derecha
            }
        }
        //POSTORDEN : izquierda -derecha - raiz COMPLETAR
        public void PostOrden(NodoArbol raiz)
        {
            // Izquierda - Derecha - Raiz
            if (raiz == null)
            {
                return;
            }
            else
            {
                PostOrden(raiz.Izquierda); // izquierda
                PostOrden(raiz.Derecha);   // derecha
                Console.Write(raiz.dato + "-"); // raiz
            }
        }

        //BUSCAR
        public void Buscar(int buscado)
        {

            BuscarABB(nodoRaiz, buscado);
        }
        private void BuscarABB(NodoArbol raiz, int d)
        {
            if (raiz == null)
            {
                Console.WriteLine("Dato no encontrado");
                return;
            }
            else
            {
                if (d < raiz.dato)
                {
                    BuscarABB(raiz.Izquierda, d);
                }
                else if (d > raiz.dato)
                {
                    BuscarABB(raiz.Derecha, d);
                }
                else
                {
                    //son iguales
                    Console.WriteLine("Dato encontrado");
                }
            }
        }
        public void BuscarMenor(NodoArbol raiz)
        {
            if (raiz.Izquierda != null)
            {
                BuscarMenor(raiz.Izquierda);
            }
            else
            {
                Console.WriteLine("El nodo menor es " + raiz.dato);
                return;
            }
        }
        //completar BUSCARMAYOR
        public void BuscarMayor(NodoArbol raiz)
        {
            if (raiz.Derecha != null)
            {
                BuscarMayor(raiz.Derecha);
            }
            else
            {
                Console.WriteLine("El nodo mayor es" + raiz.dato);
                return;
            }
        }

        //completar ELiminar

    }
}
