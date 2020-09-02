using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Nodo<T> where T : IComparable
    {
        public const int m = 5; //grado del arbol
        public T[] Valores = new T[m - 1]; //arreglo de valores en el nodo
        public Nodo<T>[] Hijos = new Nodo<T>[m]; //arreglo de nodos hijo
        public Nodo<T> Padre;

        public Nodo()
        {
            for (int i = 0; i < m - 1; i++)
            {
                Valores[i] = default(T);
            }
            for (int j = 0; j < m; j++)
            {
                Hijos[j] = null;
            }
        }

    }
}
