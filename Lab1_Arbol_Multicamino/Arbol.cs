using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Arbol<T> where T : IComparable
    {
        private Nodo<T> Raiz { get; set; }
        public int Grado { get; set; }

        List<T> ListValuesToShow = new List<T>();

        public Arbol(int grado)
        {
            Raiz = null;
            Grado = grado;
        }

        public bool Vacio()
        {
            if (Raiz == null) { return true; } else { return false; };
        }

        public void Insertar(T valor)
        {
            if (Raiz == null) //si el arbol esta vacio
            {
                Nodo<T> nodo = new Nodo<T>();
                nodo.Padre = null;
                nodo.Valores[0] = valor;
                Raiz = nodo;
            }
            else //si hay otro valor en el arbol
            {
                Raiz.Insercion(valor);
            }
        }
    }
}
