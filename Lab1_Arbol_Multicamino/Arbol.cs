using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Arbol<T> where T : IComparable
    {
        private Nodo<T> Raiz { get; set; }

        List<T> ListValuesToShow = new List<T>();

        public Arbol(int grado)
        {
            Raiz = null;
        }

        public bool Vacio()
        {
            if (Raiz == null) { return true; } else { return false; };
        }

        public void Insertar(T valor, int g)
        {
            if (Raiz == null) //si el arbol esta vacio
            {
                Nodo<T> nodo = new Nodo<T>(g);
                nodo.Padre = null;
                nodo.Valores[0] = valor;
                Raiz = nodo;
            }
            else if(Raiz.Valores.Count > 0) //si hay otro valor en el arbol
            {
                Raiz.Insercion(valor, g);
            }
        }

        private void InOrder(Nodo<T> nodo_actual, int g)
        {
            for (int i = 0; i < g; i++)
            {
                if (!object.Equals(nodo_actual.Hijos[i], default))
                {
                    InOrder(nodo_actual.Hijos[i], g);
                }
                if (i < g - 1)
                {
                    if (!object.Equals(nodo_actual.Valores[i], default(T)))
                    {
                        ListValuesToShow.Add(nodo_actual.Valores[i]);

                    }
                }
            }
        }
        public List<T> InOrder(int g)
        {
            ListValuesToShow.Clear();
            InOrder(Raiz,g);
            return ListValuesToShow;
        }
    }
}
