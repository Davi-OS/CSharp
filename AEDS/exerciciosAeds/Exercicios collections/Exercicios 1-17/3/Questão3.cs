using System;
using System.Collections;

namespace ListaColections
{
    class Questão3
    {
        public static void Main(string[] args)
        {
            Al();
            fila();
            pilha();
        }

        static void Al()
        {
            int soma = 0;
            ArrayList AL = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) != 0)
                {
                    AL.Add(i);
                }
            }
            foreach (int n in AL)
            {
                soma += n;
            }
            Console.WriteLine(soma);
        }

        static void fila()
        {
            int soma = 0;
            Queue fila = new Queue();
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) != 0)
                {
                    fila.Enqueue(i);
                }
            }
            foreach (int n in fila)
            {
                soma += n;
            }
            Console.WriteLine(soma);
        }

        static void pilha()
        {
            int soma = 0;
            Stack pilha = new Stack();
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) != 0)
                {
                    pilha.Push(i);
                }
            }
            foreach (int n in pilha)
            {
                soma += n;
            }
            Console.WriteLine(soma);
        }
    }
}
