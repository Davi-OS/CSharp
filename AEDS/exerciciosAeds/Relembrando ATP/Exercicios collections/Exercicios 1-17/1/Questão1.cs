using System;
using System.Collections;

namespace ListaColections
{
    class Questão1
    {
        public static void Main(string[] args)
        {
            Al();
            fila();
            pilha();
        }

        static void Al()
        {
            ArrayList AL = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                AL.Add(i);
            }
            //Imprimindo
            Console.WriteLine("ArrayList:");
            foreach (int n in AL)
            {
                Console.Write(n + " ");
            }
             Console.WriteLine();
        }

        static void fila()
        {
            Queue fila = new Queue();
            for (int i = 0; i < 10; i++)
            {
                fila.Enqueue(i);
            }
            //Imprimindo
             Console.WriteLine("Fila:");
            foreach (int n in fila)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        static void pilha()
        {
            Stack pilha = new Stack();
            for (int i = 0; i < 10; i++)
            {
                pilha.Push(i);
            }
            //Imprimindo
             Console.WriteLine("Pilha:");
            foreach (int n in pilha)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

        }
    }
}
