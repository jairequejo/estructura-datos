using Clases;
using Clases.Arbol;
using Clases.ColaPersonas;
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
            ArbolBinario abb = new ArbolBinario();

            int[] valores = { 6, 4, 1, 5, 8, 9};

            Console.WriteLine("--- INSERCIÓN DE NODOS ---");

            foreach (int valor in valores)
            {
                abb.Insertar(valor);
            }

            abb.Dibujar();

            abb.MostrarInorden();

            abb.MostrarPostorden();

            abb.MostrarPreorden();


            Console.WriteLine("Ingrese el valor a buscar: ");
            int buscado = int.Parse(Console.ReadLine());
            abb.Buscar(buscado);

            abb.EliminarConDescendencia(buscado);
            abb.Dibujar();







            //abb.BuscarMenor(abb.nodoRaiz);

            //Persona p1 = new Persona(12345678, "Juan Perez", false);
            //Persona p2 = new Persona(87654321, "Maria Gomez", true);
            //Persona p3 = new Persona(11223344, "Carlos Ruiz", false);
            //Persona p4 = new Persona(44332211, "Anaaa Torres", true);

            //ColaPersona cola = new ColaPersona();
            //cola.Encolar(p1);
            //cola.Encolar(p2);
            //cola.Encolar(p3);
            //cola.Encolar(p4);

            //Console.WriteLine("Mostrando personas en la cola:");
            //while (!cola.EsVacio())
            //{
            //    Persona personaAtendida = cola.Desencolar();
            //    Console.WriteLine(personaAtendida);
            //    Console.WriteLine("---------------------");
            //}

        }
    }
}
