using System;

namespace Lab1_App_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lab1_Arbol_Multicamino.Arbol<int> arbol = new Lab1_Arbol_Multicamino.Arbol<int>(5);
            Console.ReadLine();
        }
    }
}
