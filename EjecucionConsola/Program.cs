using Clases;
using Clases.Arbol;
using Clases.ColaPersonas;
using Clases.Grafos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        // El número de vértices inicial, coincidente con el código original (Grafo(5))
        Grafo grafito = new Grafo(5);
        grafito.CrearMatriz();
        // grafito.LlenarMatriz(0, 0, 1); // La línea inicial, si es necesaria.
        grafito.MostrarMatriz();
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();

        // ------------------------------------------------------------------
        // Menú de Opciones
        // ------------------------------------------------------------------

        while (true)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║        M E N Ú   G R A F O        ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║ 1. 🔗 Agregar Arista (Manual)     ║");
            Console.WriteLine("║ 2. 🎲 Agregar Aristas (Aleatorio) ║");
            Console.WriteLine("║ 3. 🗺️ Mostrar Matriz              ║");
            Console.WriteLine("║ 4. 🔢 Contar Aristas Actuales     ║");
            Console.WriteLine("║ 5. 🚪 Salir                       ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write($"\nEl grafo actual tiene: {grafito.ContarAristas()} aristas.");
            Console.Write("\n\nElige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarAristaManual(grafito);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("--- 🎲 GENERAR ARISTAS ALEATORIAS ---");
                    // Se usa 1 como valor máximo, para grafo no ponderado.
                    grafito.LlenarMatrizAleatorio();
                    Console.WriteLine("Presiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case "3":
                    grafito.MostrarMatriz();
                    Console.WriteLine("Presiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("--- 🔢 CONTADOR DE ARISTAS ---");
                    Console.WriteLine($"\nEl número total de aristas en el grafo es: **{grafito.ContarAristas()}**");
                    Console.WriteLine("Presiona Enter para continuar...");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("\n👋 ¡Adiós!");
                    return;
                default:
                    Console.WriteLine("\n❌ Opción no válida. Presiona Enter para reintentar...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // Método auxiliar para la opción 1 del menú
    static void AgregarAristaManual(Grafo grafo)
    {
        Console.Clear();
        Console.WriteLine("--- 🔗 AGREGAR ARISTA MANUALMENTE ---");
        try
        {
            int numVertices = grafo.matriz.GetLength(0);

            Console.Write($"Ingresa el nodo de origen (0 a {numVertices - 1}): ");
            if (!int.TryParse(Console.ReadLine(), out int origen))
            {
                Console.WriteLine("\n⚠️ Entrada no válida para origen.");
                Console.ReadLine();
                return;
            }

            Console.Write($"Ingresa el nodo de destino (0 a {numVertices - 1}): ");
            if (!int.TryParse(Console.ReadLine(), out int destino))
            {
                Console.WriteLine("\n⚠️ Entrada no válida para destino.");
                Console.ReadLine();
                return;
            }

            // Para este ejemplo de grafo simple (no ponderado), el valor de la arista es 1.
            grafo.LlenarMatriz(origen, destino, 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n❌ Ocurrió un error: {ex.Message}");
        }
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
    }
}