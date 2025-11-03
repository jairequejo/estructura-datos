using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Grafos
{
    public class Grafo
    {
        public Vertice inicioLista = null;
        public ListaEnlazada lista = null;

        public int[,] matriz;
        private Random _random = new Random();

        public Grafo(int cnt)
        {
            matriz = new int[cnt, cnt];

            // Implementación aún innecesaria
            //for (int i = 0; i < cnt; i++)
            //{
            //    Console.Write("Valor del vertice creado: ");
            //    int dato = int.Parse(Console.ReadLine());
            //    InsertarVertices(dato);
            //}
        }

        //  Método para Lista (se asume que Vertice y ListaEnlazada existen)
        // Insertar
        public void InsertarVertices(int datoNuevo)
        {
            // Verificación para evitar NullReferenceException si 'lista' es null
            if (lista != null)
            {
                lista.Insertar(datoNuevo);
            }
            else
            {
                Console.WriteLine("La lista enlazada no ha sido inicializada.");
            }
        }
        // Mostrar
        public void MostrarVertices()
        {
            if (lista != null)
            {
                lista.Mostrar();
            }
            else
            {
                Console.WriteLine("La lista enlazada no ha sido inicializada.");
            }
        }

        // Metodo para matrices
        // Crear
        public void CrearMatriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 0;
                }
            }
            Console.WriteLine($"\n Matriz de adyacencia {matriz.GetLength(0)}x{matriz.GetLength(1)} creada e inicializada a 0.");
        }

        // Llenar (Modificado para grafo DIRIGIDO)
        // Establece una arista dirigida de 'fila' a 'columna' con el valor 'valor'.
        public void LlenarMatriz(int fila, int columna, int valor)
        {
            int numVertices = matriz.GetLength(0);
            if (fila >= 0 && fila < numVertices && columna >= 0 && columna < numVertices)
            {
                matriz[fila, columna] = valor;
                // ❌ Se ELIMINA la línea: matriz[columna, fila] = valor; 
                //    Para asegurar que sea un grafo dirigido (asimetría).
                Console.WriteLine($"\n Arista dirigida agregada de {fila} a {columna} con valor {valor}.");
            }
            else
            {
                Console.WriteLine("\n⚠️ Error: Vértices fuera de rango.");
            }
        }

        // Mostrar (Mejorado visualmente)
        public void MostrarMatriz()
        {
            int numVertices = matriz.GetLength(0);

            Console.WriteLine("\n---  Matriz de Adyacencia (Dirigida) ---");

            // Imprime los encabezados de las columnas (índices de los nodos)
            Console.Write("    |");
            for (int k = 0; k < numVertices; k++)
            {
                Console.Write($" {k} ");
            }
            Console.WriteLine();
            Console.WriteLine("---+-----------------".PadRight(3 + (numVertices * 3), '-'));

            // Imprime las filas (índices y valores)
            for (int i = 0; i < numVertices; i++)
            {
                Console.Write($" {i} |");
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write($" {matriz[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------".PadRight(3 + (numVertices * 3), '-'));
        }

        // Método para Agregar Valores Aleatorios (Modificado para grafo DIRIGIDO)
        public void LlenarMatrizAleatorio()
        {
            int numVertices = matriz.GetLength(0);
            int aristasAgregadas = 0;

            // Recorrer TODA la matriz (excluyendo la diagonal para evitar auto-lazos)
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    if (i != j) // Solo si no es la diagonal
                    {
                        // Genera un valor aleatorio entre 0 (sin arista) y 1 (arista)
                        int valor = _random.Next(0, 2);

                        if (valor > 0)
                        {
                            // Solo se establece la arista dirigida de i a j
                            matriz[i, j] = valor;
                            aristasAgregadas++;
                        }
                    }
                }
            }
            Console.WriteLine($"\n🎲 Proceso completado. Se agregaron {aristasAgregadas} aristas dirigidas aleatorias.");
        }

        // Método para Contar Aristas (Modificado para grafo DIRIGIDO)
        public int ContarAristas()
        {
            int numVertices = matriz.GetLength(0);
            int contador = 0;

            // Para un grafo DIRIGIDO, se cuentan todas las entradas no cero en la matriz.
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    if (matriz[i, j] != 0)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
    }
}
