using System;
using System.Collections;

namespace ListaColections
{
    class Questão5
    {
        public static void Main(string[] args)
        {
            Al();
            fila();
            pilha();
        }

        static void Al()
        {
            ArrayList fila = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) == 0)
                {
                    fila.Add(i);
                }
            }
            int soma = 0;
            int index = 0;
            do
            {
                int num = (int)fila[index];
                soma += num;
                index++;
            } while (index < fila.Count);
            Console.WriteLine(soma);
        }

        static void fila()
        {
            int soma = 0;
            Queue fila = new Queue();
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) == 0)
                {
                    fila.Enqueue(i);
                }
            }
            int j = 0;
            soma = 0;
            // calcula a soma dos números da fila usando o comando while
            do
            {
                if (fila.Count > 0)
                {
                    int num = (int)fila.Dequeue();
                    soma += num;
                }
            } while (fila.Count > 0);
            Console.WriteLine(soma);
        }

        static void pilha()
        {
            int soma = 0;
            Stack pilha = new Stack();
            for (int i = 0; i < 100; i++)
            {
                if ((i % 2) == 0)
                {
                    pilha.Push(i);
                }
            }
            // calcula a soma dos números da pilha usando o comando do-while
            do
            {
                if (pilha.Count > 0)
                {
                    int num = (int)pilha.Pop();
                    soma += num;
                }
            } while (pilha.Count > 0);

            Console.WriteLine(soma);
        }
    }
}
