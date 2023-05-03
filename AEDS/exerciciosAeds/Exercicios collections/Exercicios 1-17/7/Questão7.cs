using System;
using System.Collections;

namespace ListaColections
{
    class Questão7
    {
        public static void Main(string[] args)
        {
            // Al();
            // fila();
            pilha();
        }

        static void Al()
        {
            ArrayList AL = new ArrayList() { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };
            while (AL.Contains(5))
            {
                AL.Remove(5);
            }
            while (AL.Contains(13))
            {
                AL.Remove(13);
            }
            foreach (int n in AL)
            {
                Console.Write("{0} - ", n);
            }
        }

        static void fila()
        {
            Queue<int> fila = new Queue<int>();
            int[] numeros = { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };
            for (int i = 0; i < numeros.Length; i++)
            {
                fila.Enqueue(numeros[i]);
            }
            int count = fila.Count;
            for (int i = 0; i < count; i++)
            {
                int IntAtual = fila.Dequeue();
                if (IntAtual != 5 && IntAtual != 13)
                {
                    fila.Enqueue(IntAtual);
                }
            }
            foreach (int n in fila)
            {
                Console.Write("{0} - ", n);
            }
        }

        static void pilha()
        {
            Stack<int> pilha = new Stack<int>((new int[] { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 }));
            Stack<int> temp = new Stack<int>();
            while (pilha.Count > 0)
            {
                int IntAtual = pilha.Pop();
                if (IntAtual != 5 && IntAtual != 13)
                {
                    temp.Push(IntAtual);
                }
            }
            // empilhando os valores sem os 5 e 13
            while (temp.Count > 0)
            {
                pilha.Push(temp.Pop());
            }
            foreach (int n in pilha)
            {
                Console.Write("{0} - ", n);
            }
        }
    }
}
