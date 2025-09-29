﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Nodo<T>
    {
        public T Dato;
        public Nodo<T> Siguiente;
        public Nodo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
