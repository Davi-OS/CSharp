using System;
using System.Collections;

namespace ListaColections
{
    class Questão12
    {
        public static void Main(string[] args)
        {
            Al();
            // fila();
            // pilha();
        }

        static void Al()
        {
            ArrayList numeros = new ArrayList();

            // Preenchendo o ArrayList com os números entre 1 e 25
            for (int i = 1; i <= 25; i++)
            {
                numeros.Add(i);
            }

            Console.WriteLine("Todos os elementos:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos em ordem invertida:");
            numeros.Reverse();
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos em posições ímpares:");
            for (int i = 1; i < numeros.Count; i += 2)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos ímpares:");
            foreach (int numero in numeros)
            {
                if (numero % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Apenas os elementos da primeira metade do vetor:");
            for (int i = 0; i < numeros.Count / 2; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine();
        }

        static void fila()
        {
            Queue<int> numeros = new Queue<int>();

            // Preenchendo o Queue com os números entre 1 e 25
            for (int i = 1; i <= 25; i++)
            {
                numeros.Enqueue(i);
            }

            Console.WriteLine("Todos os elementos:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos em ordem invertida:");
            int[] numerosArray = numeros.ToArray();
            Array.Reverse(numerosArray);
            foreach (int numero in numerosArray)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos em posições ímpares:");
            int index = 0;
            foreach (int numero in numeros)
            {
                if (index % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
                index++;
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos ímpares:");
            foreach (int numero in numeros)
            {
                if (numero % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Apenas os elementos da primeira metade do vetor:");
            int count = numeros.Count / 2;
            for (int i = 0; i < count; i++)
            {
                Console.Write(numeros.Dequeue() + " ");
            }
            Console.WriteLine();
        }

        static void pilha()
        {
            Stack<int> numeros = new Stack<int>();

            // Preenchendo o Stack com os números entre 1 e 25
            for (int i = 1; i <= 25; i++)
            {
                numeros.Push(i);
            }

            Console.WriteLine("Todos os elementos:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos em ordem invertida:");
            int[] numerosArray = numeros.ToArray();
            Array.Reverse(numerosArray);
            foreach (int numero in numerosArray)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos em posições ímpares:");
            int index = 0;
            foreach (int numero in numeros)
            {
                if (index % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
                index++;
            }
            Console.WriteLine();

            Console.WriteLine("Todos os elementos ímpares:");
            foreach (int numero in numeros)
            {
                if (numero % 2 != 0)
                {
                    Console.Write(numero + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Apenas os elementos da primeira metade do vetor:");
            int count = numeros.Count / 2;
            for (int i = 0; i < count; i++)
            {
                Console.Write(numeros.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
