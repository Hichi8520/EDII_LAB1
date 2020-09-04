using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Arbol<T> where T : IComparable
    {
        private Nodo<T> Raiz { get; set; }
        public int Grado { get; set; }

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
                Insertar(Raiz, valor);
            }
        }

        public void Insertar(Nodo<T> nodo_actual, T valor)
        {
            if (object.Equals(nodo_actual.Hijos[0], default(T)) && object.Equals(nodo_actual.Hijos[1], default(T))) //El nodo es hoja
            {
                if (object.Equals(nodo_actual.Valores[Grado - 2], default(T))) //Hay espacio en el nodo hoja
                {
                    //insertar el valor y ordenar si es necesario
                    nodo_actual.InsertarValor(valor);
                    

                }
                else //No hay espacio en el nodo hoja
                {
                    //recorremos para ver en qué hijo iría para crear allí el nuevo nodo con el nuevo valor
                    for (int i = 0; i < Grado - 2; i++)
                    {
                        if (valor.CompareTo(nodo_actual.Valores[i]) < 0)
                        {
                            if (nodo_actual.Hijos[i] == null)
                            {
                                Nodo<T> nodo_nuevo = new Nodo<T>();
                                nodo_nuevo.Padre = nodo_actual;
                                nodo_actual.Hijos[i] = nodo_nuevo;
                                Insertar(nodo_actual.Hijos[i], valor);
                            }
                            
                        }
                    }
                    if (valor.CompareTo(nodo_actual.Valores[Grado - 2]) > 0)
                    {
                        if (nodo_actual.Hijos[Grado - 1] == null)
                        {
                            Nodo<T> nodo_nuevo = new Nodo<T>();
                            nodo_nuevo.Padre = nodo_actual;
                            nodo_actual.Hijos[Grado - 1] = nodo_nuevo;
                            Insertar(nodo_actual.Hijos[Grado - 1], valor);
                        }
                    }
                }
            }
            else //El nodo no es hoja
            {
                //recorremos para ver en qué hijo iría y usamos el método insert allí
                for (int i = 0; i < Grado - 2; i++)
                {
                    if (valor.CompareTo(nodo_actual.Valores[Grado - 2]) < 0)
                    {
                        Insertar(nodo_actual.Hijos[i], valor);
                    }
                }
                if (valor.CompareTo(nodo_actual.Valores[Grado - 2]) > 0)
                {
                    Insertar(nodo_actual.Hijos[Grado - 1], valor);
                }
            }
        }
    }
}
