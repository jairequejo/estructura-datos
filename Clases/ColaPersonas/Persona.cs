using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public int DNI;
        public string Nombre;
        public int Prioridad; // 1 si tiene prioridad y 0 si no tiene

        public Persona() { }

        public Persona(int dNI, string nombre, int prioridad)
        {
            DNI = dNI;
            Nombre = nombre;
            Prioridad = prioridad;
        }
        public override string ToString()
        {
            return $"DNI: {DNI} \nNombres: {Nombre}";
        }
    }
}
