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
        public NodoPersona<T> Frente;
        public NodoPersona<T> Final;

        public void Encolar(T dato)
        {
            NodoPersona<T> nuevoNodo = new NodoPersona<T>(dato);
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
            NodoPersona<T> nodoAuxiliar = Frente;  //Auxiliar que guarda el dato que se va a desencolar/eliminar
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
    }
}
