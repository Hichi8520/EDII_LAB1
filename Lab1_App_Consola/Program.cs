using System;

namespace Lab1_App_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lab1_Arbol_Multicamino.Arbol<string> arbol = new Lab1_Arbol_Multicamino.Arbol<string>(5);

            arbol.Insertar("A");
            arbol.Insertar("B");
            arbol.Insertar("C");
            arbol.Insertar("D");
            arbol.Insertar("E");
            Console.ReadLine();
        }
    }
}
