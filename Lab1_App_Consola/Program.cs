using System;

namespace Lab1_App_Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Lab1_Arbol_Multicamino.Arbol<string> arbol = new Lab1_Arbol_Multicamino.Arbol<string>(5);

            //arbol.Insertar("A");
            //arbol.Insertar("B");
            //arbol.Insertar("C");
            //arbol.Insertar("D");
            //arbol.Insertar("E");
            int g = 3;

            Lab1_Arbol_Multicamino.Pelicula pelicula1 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula1.title = "T";

            Lab1_Arbol_Multicamino.Pelicula pelicula2 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula2.title = "S";

            Lab1_Arbol_Multicamino.Pelicula pelicula3 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula3.title = "R";

            Lab1_Arbol_Multicamino.Pelicula pelicula4 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula4.title = "Q";

            Lab1_Arbol_Multicamino.Pelicula pelicula5 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula5.title = "P";

            Lab1_Arbol_Multicamino.Pelicula pelicula6 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula6.title = "O";

            Lab1_Arbol_Multicamino.Pelicula pelicula7 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula7.title = "N";

            Lab1_Arbol_Multicamino.Pelicula pelicula8 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula8.title = "M";

            Lab1_Arbol_Multicamino.Pelicula pelicula9 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula9.title = "L";

            Lab1_Arbol_Multicamino.Pelicula pelicula10 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula10.title = "K";

            Lab1_Arbol_Multicamino.Pelicula pelicula11 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula11.title = "J";

            Lab1_Arbol_Multicamino.Pelicula pelicula12 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula12.title = "I";

            Lab1_Arbol_Multicamino.Pelicula pelicula13 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula13.title = "H";

            Lab1_Arbol_Multicamino.Pelicula pelicula14 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula14.title = "G";

            Lab1_Arbol_Multicamino.Pelicula pelicula15 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula15.title = "F";

            Lab1_Arbol_Multicamino.Pelicula pelicula16 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula16.title = "E";

            Lab1_Arbol_Multicamino.Pelicula pelicula17 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula17.title = "D";

            Lab1_Arbol_Multicamino.Pelicula pelicula18 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula18.title = "C";

            Lab1_Arbol_Multicamino.Pelicula pelicula19 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula19.title = "B";

            Lab1_Arbol_Multicamino.Pelicula pelicula20 = new Lab1_Arbol_Multicamino.Pelicula();
            pelicula20.title = "A";

            Lab1_Arbol_Multicamino.Arbol<Lab1_Arbol_Multicamino.Pelicula> arbol = new Lab1_Arbol_Multicamino.Arbol<Lab1_Arbol_Multicamino.Pelicula>(g);

            //arbol.Insertar(5, g);
            //arbol.Insertar(3, g);
            //arbol.Insertar(10, g);
            //arbol.Insertar(4, g);
            arbol.Insertar(pelicula5, g);
            arbol.Insertar(pelicula7, g);
            arbol.Insertar(pelicula6, g);
            arbol.Insertar(pelicula8, g);
            arbol.Insertar(pelicula10, g);
            arbol.Insertar(pelicula9, g);
            arbol.Insertar(pelicula11, g);
            arbol.Insertar(pelicula12, g);
            arbol.Insertar(pelicula13, g);
            arbol.Insertar(pelicula14, g);
            arbol.Insertar(pelicula15, g);
            arbol.Insertar(pelicula16, g);
            arbol.Insertar(pelicula17, g);
            arbol.Insertar(pelicula18, g);
            arbol.Insertar(pelicula19, g);
            arbol.Insertar(pelicula20, g);


            //var peli = new Lab1_Arbol_Multicamino.Pelicula { Name = "Tita", Directed_by = "asdf", Genre = "drama" };
            Console.ReadLine();
        }
    }
}
