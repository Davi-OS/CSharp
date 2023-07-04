using System;
using System.Collections;

class Questão15
{
    public static void Main(string[] args)
    {
        ArrayList();
        Stack();
        Queue();
    }

    static void Queue()
    {
        Queue<int> fila = new Queue<int>();
        fila.Enqueue(5);
        fila.Enqueue(4);
        fila.Enqueue(3);
        fila.Enqueue(2);
        fila.Enqueue(1);
        int soma = 0;

        foreach (var item in fila)
        {
            soma += item;
        }
         Console.WriteLine("Soma fila = {0}",soma);
    }

    static void Stack()
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);
        pilha.Push(4);
        pilha.Push(5);
        int soma = 0;

        foreach (var item in pilha)
        {
            soma += item;
        }
         Console.WriteLine("Soma pilha = {0}",soma);
    }

    static void ArrayList()
    {
        ArrayList AL = new ArrayList() { 1, 2, 3, 4, 5, 6 };
        int soma = 0;
        foreach (int item in AL)
        {
            soma += item;
        }
        Console.WriteLine("Soma AL = {0}",soma);
    }
}
