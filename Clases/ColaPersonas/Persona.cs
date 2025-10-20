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
        public bool EsPrioridad;

        public Persona() { }

        public Persona(int dNI, string nombre, bool prioridad)
        {
            DNI = dNI;
            Nombre = nombre;
            EsPrioridad = prioridad;
        }
        public override string ToString()
        {
            return $"DNI: {DNI} \nNombres: {Nombre}";
        }
    }
}
