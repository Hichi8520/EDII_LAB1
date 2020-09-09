using System;
using System.Collections.Generic;

namespace Lab1_App_Consola
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------Arbol Multicamino-----------------------");
            Console.WriteLine("1.-Ingrese el grado del Arbol para generarlo");
            int g = Convert.ToInt32(Console.ReadLine());

            Lab1_Arbol_Multicamino.Arbol<int> Tree = new Lab1_Arbol_Multicamino.Arbol<int>(g);

            Console.WriteLine("2.-Ingrese unicamente enteros al arbol para un correcto almacenaje - Ingrese 0 para salir");
            int input = Convert.ToInt32(Console.ReadLine());
            Tree.Insertar(input, g);
            while (input != 0)
            {
                if (input != 0)
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if(input != 0)
                    {
                        Tree.Insertar(input, g);
                    }                   
                }
            }

            Console.WriteLine("El ingreso de información ha finalizado ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Recorrido InOrder");
            List<int> InOrden = new List<int>();
            InOrden = Tree.InOrder(g);
            for (int i = 0; i < InOrden.Count; i++)
            {
                Console.Write(InOrden[i]+" , ");
            }
            Console.WriteLine();

            Console.WriteLine("Recorrido PreOrder");
            List<int> PreOrden = new List<int>();
            PreOrden = Tree.PreOrder(g);
            for (int i = 0; i < PreOrden.Count; i++)
            {
                Console.Write(PreOrden[i] + " , ");
            }

            Console.WriteLine();

            Console.WriteLine("Recorrido PostOrder");
            List<int> PostOrden = new List<int>();
            PostOrden = Tree.PostOrder(g);
            for (int i = 0; i < PostOrden.Count; i++)
            {
                Console.Write(PostOrden[i] + " , ");
            }
            Console.ReadLine();
        }
    }
}
