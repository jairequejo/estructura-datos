using Clases.Arbol.ColaParaArbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        // Disfraz (Sobrecarga del metodo Insertar)
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

        ////INORDEN : izquierda - raiz - derecha COMPLETAR
        //// Ascendente
        //public void InOrden(NodoArbol raiz)
        //{
        //    // Izquierda-Raiz-Derecha         
        //    if (raiz == null)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        InOrden(raiz.Izquierda);//izquierda
        //        Console.Write(raiz.dato + "-");//raiz
        //        InOrden(raiz.Derecha);//derecha 
        //    }
        //}

        ////PREORDEN : raiz - izquierda - derecha COMPLETAR
        //public void PreOrden(NodoArbol raiz)
        //{
        //    // Raiz-izquierda- Derecha         
        //    if (raiz == null)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        Console.Write(raiz.dato + "-");//raiz
        //        PreOrden(raiz.Izquierda);//izquierda              
        //        PreOrden(raiz.Derecha);//derecha
        //    }
        //}
        ////POSTORDEN : izquierda -derecha - raiz COMPLETAR
        //public void PostOrden(NodoArbol raiz)
        //{
        //    // Izquierda - Derecha - Raiz
        //    if (raiz == null)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        PostOrden(raiz.Izquierda); // izquierda
        //        PostOrden(raiz.Derecha);   // derecha
        //        Console.Write(raiz.dato + "-"); // raiz
        //    }
        //}

        // ---- RECORRIDOS ----

        // 🔹 Preorden (Raíz → Izquierda → Derecha)
        private void Preorden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                Console.Write(raiz.dato + " ");
                Preorden(raiz.Izquierda);
                Preorden(raiz.Derecha);
            }
        }

        public void MostrarPreorden()
        {
            Console.WriteLine("\n--- RECORRIDO PREORDEN ---");
            Preorden(nodoRaiz);
            Console.WriteLine();
        }

        // 🔹 Inorden (Izquierda → Raíz → Derecha)
        private void Inorden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.Izquierda);
                Console.Write(raiz.dato + " ");
                Inorden(raiz.Derecha);
            }
        }

        public void MostrarInorden()
        {
            Console.WriteLine("\n--- RECORRIDO INORDEN ---");
            Inorden(nodoRaiz);
            Console.WriteLine();
        }

        // 🔹 Postorden (Izquierda → Derecha → Raíz)
        private void Postorden(NodoArbol raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.Izquierda);
                Postorden(raiz.Derecha);
                Console.Write(raiz.dato + " ");
            }
        }

        public void MostrarPostorden()
        {
            Console.WriteLine("\n--- RECORRIDO POSTORDEN ---");
            Postorden(nodoRaiz);
            Console.WriteLine();
        }

        //BUSCAR

        //Busqueda Binaria
        public void Buscar(int buscado)
        {

            Buscar(nodoRaiz, buscado);
        }
        private void Buscar(NodoArbol raiz, int d)
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
                    Buscar(raiz.Izquierda, d);
                }
                else if (d > raiz.dato)
                {
                    Buscar(raiz.Derecha, d);
                }
                else
                {
                    //son iguales
                    Console.WriteLine("Dato encontrado");
                }
            }
        }
        //Busqueda Lineal
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

        //completar ELiminar GENERAL
        public void Eliminar(int valor)
        {
            nodoRaiz = EliminarNodo(nodoRaiz, valor);
        }

        private NodoArbol EliminarNodo(NodoArbol raiz, int valor)
        {
            if(raiz == null)
            {
                Console.WriteLine("Dato no encontrado");
                return raiz;
            }

            if (valor < raiz.dato)
            {
                raiz.Izquierda = EliminarNodo(raiz.Izquierda, valor);
            }
            else if (valor > raiz.dato)
            {
                raiz.Derecha = EliminarNodo(raiz.Derecha, valor);
            }
            else
            {
                // Caso 1: Nodo sin hijos
                if (raiz.Izquierda == null && raiz.Derecha == null)
                {
                    Console.WriteLine($"Eliminando hoja {raiz.dato}");
                    return null;
                }

                // Caso 2: Nodo con un solo hijo
                if (raiz.Izquierda == null)
                {
                    Console.WriteLine($"Eliminando nodo {raiz.dato}, reemplazado por {raiz.Derecha.dato}");
                    return raiz.Derecha;
                }
                else if (raiz.Derecha == null)
                {
                    Console.WriteLine($"Eliminando nodo {raiz.dato}, reemplazado por {raiz.Izquierda.dato}");
                    return raiz.Izquierda;
                }

                // Caso 3: Nodo con dos hijos
                NodoArbol sucesor = EncontrarMinimo(raiz.Derecha);
                Console.WriteLine($"Eliminando nodo {raiz.dato}, reemplazado por su sucesor {sucesor.dato}");
                raiz.dato = sucesor.dato;
                raiz.Derecha = EliminarNodo(raiz.Derecha, sucesor.dato);
            }

            return raiz;
        }
        private NodoArbol EncontrarMinimo(NodoArbol nodo)
        {
            while (nodo.Izquierda != null)
                nodo = nodo.Izquierda;
            return nodo;
        }

        //public void MostrarPorNiveles()
        //{
        //    if (nodoRaiz == null)
        //    {
        //        Console.WriteLine("El árbol está vacío");
        //        return;
        //    }

        //    Queue<NodoArbol> cola = new Queue<NodoArbol>();
        //    cola.Enqueue(nodoRaiz);

        //    while (cola.Count > 0)
        //    {
        //        int nivelCount = cola.Count;

        //        // Mostrar todos los nodos del mismo nivel
        //        while (nivelCount > 0)
        //        {
        //            NodoArbol actual = cola.Dequeue();
        //            Console.Write(actual.dato + " ");

        //            if (actual.Izquierda != null)
        //                cola.Enqueue(actual.Izquierda);
        //            if (actual.Derecha != null)
        //                cola.Enqueue(actual.Derecha);

        //            nivelCount--;
        //        }

        //        Console.WriteLine(); // salto de línea entre niveles
        //    }
        //}

        // Mostrar niveles usando tu clase ColaSimple
        public void MostrarPorNiveles()
        {
            if (nodoRaiz == null)
            {
                Console.WriteLine("El árbol está vacío");
                return;
            }
            ColaABB cola = new ColaABB();
            cola.Encolar(nodoRaiz);

            while (cola.Frente != null)
            {
                int nivelCount = ContarElementos(cola); // contamos los elementos del nivel actual

                for (int i = 0; i < nivelCount; i++)
                {
                    NodoArbol actual = cola.Desencolar();
                    Console.Write(actual.dato + " ");

                    if (actual.Izquierda != null)
                        cola.Encolar(actual.Izquierda);

                    if (actual.Derecha != null)
                        cola.Encolar(actual.Derecha);
                }

                Console.WriteLine(); // salto de línea por nivel
            }
        }

        // Método auxiliar para contar los elementos actuales de la cola
        private int ContarElementos(ColaABB cola)
        {
            int contador = 0;
            NodoColaABB aux = cola.Frente;
            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }
            return contador;
        }

        public void EliminarConDescendencia(int valor)
        {
            nodoRaiz = EliminarSubarbol(nodoRaiz, valor);
        }

        private NodoArbol EliminarSubarbol(NodoArbol raiz, int valor)
        {
            if (raiz == null)
            {
                Console.WriteLine("Dato no encontrado");
                return null;
            }

            if (valor < raiz.dato)
            {
                raiz.Izquierda = EliminarSubarbol(raiz.Izquierda, valor);
            }
            else if (valor > raiz.dato)
            {
                raiz.Derecha = EliminarSubarbol(raiz.Derecha, valor);
            }
            else
            {
                // Caso encontrado: eliminar nodo y todo su subárbol
                Console.WriteLine($"Eliminando nodo {raiz.dato} y toda su descendencia...");
                return null; // Aquí se rompe el enlace: el recolector eliminará todo el subárbol
            }

            return raiz;
        }

    }
}
