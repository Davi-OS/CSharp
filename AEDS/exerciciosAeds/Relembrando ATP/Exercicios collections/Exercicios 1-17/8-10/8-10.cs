using System;
using System.Collections;

namespace ListaColections
{
    class Questão8_9_10
    {
        public static void Main(string[] args)
        {
            Al();
            fila();
            pilha();
        }

        // Questão 8
        static void Al()
        {
            int soma = 0;
            int mediaAritimetica;
            ArrayList AL = new ArrayList();
            int[] numeros = { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };
            for (int i = 0; i < numeros.Length; i++)
            {
                AL.Add(numeros[i]);
            }
            foreach (int n in AL)
            {
                soma += n;
            }
            mediaAritimetica = soma / AL.Count;

            Console.WriteLine("Soma = {0}", soma);
            Console.WriteLine("Media = {0}", mediaAritimetica);
        }

        // Questão 9
        static void fila()
        {
            Queue<int> fila = new Queue<int>();
            int[] numeros = { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };
            int soma = 0;
            int mediaAritimetica;
            for (int i = 0; i < numeros.Length; i++)
            {
                fila.Enqueue(numeros[i]);
            }
            foreach (int n in fila)
            {
                soma += n;
            }
            mediaAritimetica = soma / fila.Count;

            Console.WriteLine("Soma = {0}", soma);
            Console.WriteLine("Media = {0}", mediaAritimetica);
        }

        // Questão 10
        static void pilha()
        {
            Stack<int> pilha = new Stack<int>(
                (new int[] { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 })
            );
            Stack<int> temp = new Stack<int>();
            int soma = 0;
            int mediaAritimetica;
            while (pilha.Count > 0)
            {
                soma += pilha.Peek();
                int IntAtual = pilha.Pop();
                temp.Push(IntAtual);
            }
            while (temp.Count > 0)
            {
                pilha.Push(temp.Pop());
            }
            mediaAritimetica = soma / pilha.Count;

            Console.WriteLine("Soma = {0}", soma);
            Console.WriteLine("Media = {0}", mediaAritimetica);
        }
    }
}
