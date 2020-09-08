using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    class Nodo<T> where T : IComparable
    {
        public List<T> Valores = new List<T>(); //arreglo de valores en el nodo
        public List<Nodo<T>> Hijos = new List<Nodo<T>>(); //arreglo de nodos hijo
        public Nodo<T> Padre;

        public Nodo(int g)
        {
            for (int i = 0; i < (g - 1); i++)
            {
                Valores.Add(default(T));
            }
            for (int j = 0; j < g; j++)
            {
                Hijos.Add(default);
            }
        }

        
        public void Insercion(T valor, int g)// método de inserción en el árbol
        {

            if (Es_hoja(this, g))//El nodo es hoja
            {
                if (Tiene_espacio(this, g))//Hay espacio en el nodo hoja
                {
                    //insertar el valor y ordenar si es necesario
                    InsertarValor(this, valor, g);
                    var sortedList = Ordenar_Lista(Valores);
                    for (int x = 0; x < sortedList.Count; x++)
                    {
                        Valores[x] = sortedList[x]; //Inserto los valores ordenados por burbuja en el vector
                    }
                }
                else //No hay espacio en el nodo hoja
                {
                    //recorremos para ver en qué hijo iría para crear allí el nuevo nodo con el nuevo valor
                    Insercion(Hijos[Posicion_hijo(this, valor, g)], valor, g);
                }
            }
            else //El nodo no es hoja
            {
                //recorremos para ver en qué hijo iría y usamos el método insert allí
                Insercion(Hijos[Posicion_hijo(this, valor, g)], valor, g);
            }
        }

        void Insercion(Nodo<T> nodo_actual, T valor, int g)
        {
            if (nodo_actual.Es_hoja(nodo_actual, g))//El nodo es hoja
            {
                if (nodo_actual.Tiene_espacio(nodo_actual, g))//Hay espacio en el nodo hoja
                {
                    //insertar el valor y ordenar si es necesario
                    nodo_actual.InsertarValor(nodo_actual, valor, g);
                    var sortedList = Ordenar_Lista(nodo_actual.Valores);
                    for (int x = 0; x < sortedList.Count; x++)
                    {
                        nodo_actual.Valores[x] = sortedList[x]; //Inserto los valores ordenados por burbuja en el vector
                    }
                }
                else //No hay espacio en el nodo hoja
                {
                    //recorremos para ver en qué hijo iría para crear allí el nuevo nodo con el nuevo valor
                    Insercion(nodo_actual.Hijos[Posicion_hijo(nodo_actual, valor, g)], valor, g);
                }
            }
            else //El nodo no es hoja
            {
                //recorremos para ver en qué hijo iría y usamos el método insert allí
                Insercion(nodo_actual.Hijos[Posicion_hijo(nodo_actual, valor, g)], valor, g);
            }
        }

        public int Posicion_hijo(Nodo<T> nodo_actual, T valor, int g) //Recorre y compara los valores del nodo lleno 
                                                               //con el valor a insertar para ver en qué posición 
                                                               //de los hijos debería ir
        {
            int posicion = 0;

            for (int i = 0; i < g - 1; i++)
            {
                if (valor.CompareTo(nodo_actual.Valores[i]) < 0)
                {
                    if (nodo_actual.Hijos[i] == null)
                    {
                        Nodo<T> nodo_nuevo = new Nodo<T>(g);
                        nodo_nuevo.Padre = this;
                        nodo_actual.Hijos[i] = nodo_nuevo;
                    }
                    posicion = i;
                    break;
                }
            }
            if (valor.CompareTo(nodo_actual.Valores[g - 2]) > 0)
            {
                if (nodo_actual.Hijos[g - 1] == null)
                {
                    Nodo<T> nodo_nuevo = new Nodo<T>(g);
                    nodo_nuevo.Padre = this;
                    nodo_actual.Hijos[g - 1] = nodo_nuevo;
                }
                posicion = g - 1;
            }

            return posicion;
        }

        public List<T> Ordenar_Lista(List<T> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (!object.Equals(data[i], default(T)) && !object.Equals(data[j], default(T)))
                    {
                        if (data[i].CompareTo(data[j]) > 0)
                        {
                            var aux = data[i];
                            data[i] = data[j];
                            data[j] = aux;
                        }
                    }
                }
            }
            return data;
        }

        public bool Tiene_espacio(Nodo<T> nodo_actual,int g)// determina si tiene espacio el nodo para insertar
        {
            if (!object.Equals(nodo_actual.Valores[g - 2], default(T)))
            {
                return false;
            }
            return true;
        }

        public bool Es_hoja(Nodo<T> nodo_actual, int g)// determina si el nodo es hoja
        {
            for (int i = 0; i < g; i++)
            {
                if (!object.Equals(nodo_actual.Hijos[i], default(T)) && (!object.Equals(nodo_actual.Hijos[i], null)))
                {
                    return false;
                }
            }
            return true;
        }

        public void InsertarValor(Nodo<T> nodo_actual, T valor, int g)// inserta un valor en el nodo
        {
            for (int x = 0; x < g; x++)
            {
                if (object.Equals(nodo_actual.Valores[x], default(T)))
                {
                    nodo_actual.Valores[x] = valor;
                    break;
                }
            }
        }
    }
}
