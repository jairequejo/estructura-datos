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
        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
        public Persona()
        {
        }
        public override string ToString()
        {
            return $"DNI: {DNI} | Nombre: {Nombre}";
        }
    }
}
