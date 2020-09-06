using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Arbol_Multicamino
{
    public class Pelicula : IComparable
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Directed_by { get; set; }

        public string[] Stars = new string[10];
        public string Genre { get; set; }


        public int CompareTo(object obj)
        {
            var pelicula2 = (Pelicula)obj;

            if (Name.CompareTo(pelicula2.Name) < 0) return -1;
            else return 1;
        }
    }
}
