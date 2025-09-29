using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class ColaSimple<T>
    {
        public Nodo<T> Frente;
        public Nodo<T> Final;

        public void Encolar(T dato)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(dato);
            if (Final == null)
            {
                Frente = nuevoNodo;
                Final = nuevoNodo;
                Console.WriteLine($"Se encolo el primer valor: {dato}");
            }
            else
            {
                Final.Siguiente = nuevoNodo;
                Final = nuevoNodo;
                Console.WriteLine($"Se encolo un valor más:    {dato}");
            }
        }
        public T Desencolar()
        {
            Nodo<T> nodoAuxiliar = Frente;  //Auxiliar que guarda el dato que se va a desencolar/eliminar
            // Input Cola 5 4 10
            if (Frente != null)
            {
                Frente = Frente.Siguiente;

                // Si la cola queda vacía, actualizar Final a null
                if (Frente == null)
                {
                    Final = null;
                }
                Console.WriteLine("Se desencolo un valor");
                return nodoAuxiliar.Dato;
            }
            else
            {
                Console.WriteLine("No se pudo desencolar, la cola está vacía");
                return default(T);
            }
        }
        public void MostrarCola()
        {
            Nodo<T> nodoAuxiliar = Frente;
            if (nodoAuxiliar != null)
            {

            }
            else
            {
                Console.WriteLine("La cola está vacía");
            }
        }
    }
}
