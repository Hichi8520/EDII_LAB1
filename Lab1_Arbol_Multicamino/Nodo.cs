using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    class Nodo<T>
    {
        public List<T> Valores { get; set; }
        public List<Nodo<T>> Hijos { get; set; }

    }
}
