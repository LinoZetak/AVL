using System;

namespace AppArbolesAVL01
{
    class Program
    {
        static void Main(string[] args)
        {
            cArbolAVL arbol = new cArbolAVL();

            // Agregar números al árbol AVL
            int[] numeros = { 10, 20, 30, 40, 50, 25 };
            foreach (int numero in numeros)
            {
                arbol.Agregar(numero);
            }

            // Imprimir el árbol en preorden con los factores de equilibrio (FE)
            Console.WriteLine("Árbol AVL en PreOrden con factores de equilibrio:");
            arbol.PreOrdenFE();

            // Imprimir el árbol en inorden con los factores de equilibrio (FE)
            Console.WriteLine("\nÁrbol AVL en InOrden con factores de equilibrio:");
            arbol.InOrdenFE();

            // Imprimir el árbol en postorden con los factores de equilibrio (FE)
            Console.WriteLine("\nÁrbol AVL en PostOrden con factores de equilibrio:");
            arbol.PostOrdenFE();

            Console.ReadKey();
        }
    }
}