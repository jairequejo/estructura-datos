using Clases;
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
            //ColaSimple<int> colaDeElJean = new ColaSimple<int>();
            //colaDeElJean.Desencolar();

            //colaDeElJean.Encolar(5);
            //colaDeElJean.Encolar(10);
            //colaDeElJean.Encolar(15);

            //Console.WriteLine(colaDeElJean.Desencolar());


            //ColaSimple<Persona> colaDePersonas = new ColaSimple<Persona>();
            //Persona persona1 = new Persona(61025267, "Jean Quispe");
            //Persona persona2 = new Persona(87654321, "Maria Gomez");
            //Persona persona3 = new Persona(11223344, "Carlos Lopez");

            //colaDePersonas.Encolar(persona1);
            //colaDePersonas.Encolar(persona2);
            //colaDePersonas.Encolar(persona3);
            //Console.WriteLine(colaDePersonas.Desencolar());

            ColaSimple<string> colaDeStrings = new ColaSimple<string>();


            Console.WriteLine("Ingrese una cadena de texto");
            string texto = Console.ReadLine();
            string textoAlReves = "";

            foreach (char caracter in texto)
            {
                colaDeStrings.Encolar(caracter.ToString());

            }
        }
    }
}
