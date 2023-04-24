using System;
using System.Collections;

namespace ListaColections
{
    class Questão3
    {
        public static void Main(string[] args)
        {
            Al();
            // fila();
            // pilha();
        }

        static void Al()
        {
            ArrayList AL = new ArrayList();
            for (int i = 1; i <= 26; i++)
            {
                AL.Add(i);
            }
            //Imprimindo
            Console.Write("\nNúmeros de 1 a 25:");
            foreach (int n in AL)
            {
                Console.Write(AL[i] + " ");
            }

            //Imprimindo Invertido
            Console.WriteLine("\nNúmeros de 25 a 1:");
            for (int i = AL.Count - 1; i >= 0; i--)
            {
                Console.Write(AL[i] + " ");
            }
        }

        static void fila()
        {
            Queue fila = new Queue();
            for (int i = 1; i <= 26; i++)
            {
                fila.Enqueue(i);
            }
            //Imprimindo
            Console.Write("\nNúmeros de 1 a 25:");
            foreach (int n in fila)
            {
                Console.Write(fila[i] + " ");
            }
            //Imprimindo Invertido
            Console.WriteLine("\nNúmeros de 25 a 1:");
            for (int i = fila.Count - 1; i >= 0; i--)
            {
                Console.Write(fila[i] + " ");
            }
        }

        static void pilha()
        {
            Stack pilha = new Stack();
            for (int i = 1; i <= 26; i++)
            {
                pilha.Push(i);
            }
            Console.Write("\nNúmeros de 1 a 25:");
            foreach (int n in pilha)
            {
                Console.Write(pilha[i] + " ");
            }
            //Imprimindo Invertido
            Console.WriteLine("\nNúmeros de 25 a 1:");
            for (int i = pilha.Count - 1; i >= 0; i--)
            {
                Console.Write(pilha[i] + " ");
            }
        }
    }
}
