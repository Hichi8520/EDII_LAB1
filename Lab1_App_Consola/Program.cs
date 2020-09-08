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

            Lab1_Arbol_Multicamino.Arbol<Lab1_Arbol_Multicamino.Pelicula> arbol = new Lab1_Arbol_Multicamino.Arbol<Lab1_Arbol_Multicamino.Pelicula>(5);

            arbol.Insertar(pelicula1);
            arbol.Insertar(pelicula2);
            arbol.Insertar(pelicula3);
            arbol.Insertar(pelicula4);
            arbol.Insertar(pelicula5);
            arbol.Insertar(pelicula6);
            arbol.Insertar(pelicula7);
            arbol.Insertar(pelicula8);
            arbol.Insertar(pelicula9);
            arbol.Insertar(pelicula10);
            arbol.Insertar(pelicula11);
            arbol.Insertar(pelicula12);
            arbol.Insertar(pelicula13);
            arbol.Insertar(pelicula14);
            arbol.Insertar(pelicula15);
            arbol.Insertar(pelicula16);
            arbol.Insertar(pelicula17);
            arbol.Insertar(pelicula18);
            arbol.Insertar(pelicula19);
            arbol.Insertar(pelicula20);


            //var peli = new Lab1_Arbol_Multicamino.Pelicula { Name = "Tita", Directed_by = "asdf", Genre = "drama" };
            Console.ReadLine();
        }
    }
}
