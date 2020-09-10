using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1_Arbol_Multicamino;

namespace Lab1_API.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }

        public int g = 0;
        public Arbol<Pelicula> Arbol_Pelis = new Arbol<Pelicula>(5);
        public List<Pelicula> Lista_Pelis = new List<Pelicula>();
    }
}
