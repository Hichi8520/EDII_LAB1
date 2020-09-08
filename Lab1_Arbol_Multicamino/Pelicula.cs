using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Pelicula : IComparable
    {
        public string director { get; set; }
        public double imdbRating { get; set; }
        public string genre { get; set; }
        public string releaseDate { get; set; }
        public int rottenTomatoesRating { get; set; }
        public string title { get; set; }        

        //public int CompareTo(object obj) //Comparación del Nombre de las peliculas
        //                                 //retorna los siguientes 3 valores -1 menor, 0 igual, 1 mayor
        //{
        //    return this.Name.CompareTo(((Pelicula)obj).Name);
        //}
        //public static Comparison<Pelicula> CompareByName = delegate (Pelicula s1, Pelicula s2)
        //{
        //    return s1.CompareTo(s2);
        //};

        public int CompareTo(object obj)
        {
            var pelicula2 = (Pelicula)obj;

            if (title.CompareTo(pelicula2.title) < 0) return -1;
            else return 1;
        }
    }
}
