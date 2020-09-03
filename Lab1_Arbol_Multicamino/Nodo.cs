using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Nodo<T> where T : IComparable
    {
        public int Grado { get; set; }
        public T[] Valores { get; set; }
        public Nodo<T>[] Hijos { get; set; }
        public Nodo<T> Padre { get; set; }
        //public const int m = 5; //grado del arbol
        //public T[] Valores = new T[Grado - 1]; //arreglo de valores en el nodo
        //public Nodo<T>[] Hijos = new Nodo<T>[m]; //arreglo de nodos hijo
        //public Nodo<T> Padre;

        public Nodo(int grado)
        {
            Grado = grado;
            T[] Valores = new T[Grado - 1];
            Nodo<T>[] Hijos = new Nodo<T>[Grado];

            for (int i = 0; i < Grado - 1; i++)
            {
                Valores[i] = default(T);
            }
            for (int j = 0; j < Grado; j++)
            {
                Hijos[j] = null;
            }
        }

        public void InsertarValor(T valor)
        {
            for (int x = 0; x < Grado; x++)
            {
                if (object.Equals(this.Valores[x], default(T)))
                {
                    this.Valores[x] = valor;
                    break;
                }
            }
        }
    }
}
