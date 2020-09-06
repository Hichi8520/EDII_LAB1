using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    class Nodo<T> where T : IComparable
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
                Hijos[j] = default;
            }
        }

        
        public void Insercion(T valor)// método de inserción en el árbol
        {
            if (Es_hoja(this))//El nodo es hoja
            {
                if (Tiene_espacio(this))//Hay espacio en el nodo hoja
                {
                    //insertar el valor y ordenar si es necesario
                    InsertarValor(this, valor);
                    var sortedList = Ordenar_Lista(Valores);
                    for (int x = 0; x < sortedList.Length; x++)
                    {
                        Valores[x] = sortedList[x]; //Inserto los valores ordenados por burbuja en el vector
                    }
                }
                else //No hay espacio en el nodo hoja
                {
                    //recorremos para ver en qué hijo iría para crear allí el nuevo nodo con el nuevo valor
                    Insercion(Hijos[Posicion_hijo(this, valor)], valor);
                }
            }
            else //El nodo no es hoja
            {
                //recorremos para ver en qué hijo iría y usamos el método insert allí
                Insercion(Hijos[Posicion_hijo(this, valor)], valor);
            }
        }

        public void Insercion(Nodo<T> nodo_actual, T valor)
        {
            if (nodo_actual.Es_hoja(nodo_actual))//El nodo es hoja
            {
                if (nodo_actual.Tiene_espacio(nodo_actual))//Hay espacio en el nodo hoja
                {
                    //insertar el valor y ordenar si es necesario
                    nodo_actual.InsertarValor(nodo_actual, valor);
                    var sortedList = Ordenar_Lista(nodo_actual.Valores);
                    for (int x = 0; x < sortedList.Length; x++)
                    {
                        nodo_actual.Valores[x] = sortedList[x]; //Inserto los valores ordenados por burbuja en el vector
                    }
                }
                else //No hay espacio en el nodo hoja
                {
                    //recorremos para ver en qué hijo iría para crear allí el nuevo nodo con el nuevo valor
                    Insercion(nodo_actual.Hijos[Posicion_hijo(nodo_actual, valor)], valor);
                }
            }
            else //El nodo no es hoja
            {
                //recorremos para ver en qué hijo iría y usamos el método insert allí
                Insercion(nodo_actual.Hijos[Posicion_hijo(nodo_actual, valor)], valor);
            }
        }

        public int Posicion_hijo(Nodo<T> nodo_actual, T valor) //Recorre y compara los valores del nodo lleno 
                                                               //con el valor a insertar para ver en qué posición 
                                                               //de los hijos debería ir
        {
            int posicion = 0;

            for (int i = 0; i < m - 1; i++)
            {
                if (valor.CompareTo(nodo_actual.Valores[i]) < 0)
                {
                    if (nodo_actual.Hijos[i] == null)
                    {
                        Nodo<T> nodo_nuevo = new Nodo<T>();
                        nodo_nuevo.Padre = this;
                        nodo_actual.Hijos[i] = nodo_nuevo;
                    }
                    posicion = i;
                    break;
                }
            }
            if (valor.CompareTo(nodo_actual.Valores[m - 2]) > 0)
            {
                if (nodo_actual.Hijos[m - 1] == null)
                {
                    Nodo<T> nodo_nuevo = new Nodo<T>();
                    nodo_nuevo.Padre = this;
                    nodo_actual.Hijos[m - 1] = nodo_nuevo;
                }
                posicion = m - 1;
            }

            return posicion;
        }

        public T[] Ordenar_Lista(T[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
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

        public bool Tiene_espacio(Nodo<T> nodo_actual)// determina si tiene espacio el nodo para insertar
        {
            if (!object.Equals(nodo_actual.Valores[m - 2], default(T)))
            {
                return false;
            }
            return true;
        }

        public bool Es_hoja(Nodo<T> nodo_actual)// determina si el nodo es hoja
        {
            for (int i = 0; i < m; i++)
            {
                if (!object.Equals(nodo_actual.Hijos[i], default(T)))
                {
                    return false;
                }
            }
            return true;
        }

        public void InsertarValor(Nodo<T> nodo_actual, T valor)// inserta un valor en el nodo
        {
            for (int x = 0; x < m; x++)
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
