using System;
using System.Collections;

namespace ListaColections
{
    class Questão2
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
                AL.Add((Console.ReadLine()));
            }
            foreach (string n in AL)
            {
                Console.Write("{0} - ", n);
            }
        }

        static void fila()
        {
            Queue fila = new Queue();
            for (int i = 0; i < 10; i++)
            {
                fila.Enqueue((Console.ReadLine()));
            }
            foreach (string n in fila)
            {
                Console.Write("{0} - ", n);
            }
        }

        static void pilha()
        {
            Stack pilha = new Stack();
            for (int i = 0; i < 10; i++)
            {
                pilha.Push((Console.ReadLine()));
            }
            foreach (string n in pilha)
            {
                Console.Write("{0} - ", n);
            }
        }
    }
}
