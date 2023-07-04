using System;
using System.Collections;

class Questão14
{
    public static void Main(string[] args)
    {
        ArrayList();
        Stack();
        Queue();
    }

    static void Queue()
    {
        Queue fila = new Queue();
        fila.Enqueue(5);
        fila.Enqueue(4);
        fila.Enqueue(3);
        fila.Enqueue(2);
        fila.Enqueue(1);
        Queue filareversa = new Queue();
       filareversa = ReverteFila(fila);
        foreach (var item in filareversa)
        {
            Console.Write(" - {0}", item);
        }
    }
    static void Stack()
    {
        Stack pilha = new Stack();
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(3);
        pilha.Push(4);
        pilha.Push(5);
        Stack pilhaReversa = new Stack();
        pilhaReversa = RevertePilha(pilha);
        foreach (var item in pilhaReversa)
        {
            Console.Write(" - {0}", item);
        }
    }

    static void ArrayList()
    {
        ArrayList AL = new ArrayList() { 1, 2, 3, 4, 5, 6 };
        ArrayList ALReverso = new ArrayList();
        ALReverso = ReverteAL(AL);

        foreach (var item in ALReverso)
        {
            Console.Write(" - {0}", item);
        }
        Console.WriteLine();
    }

    static ArrayList ReverteAL(ArrayList Original)
    {
        ArrayList resp = new ArrayList();
        for (int i = Original.Count; i >= 0; i--)
        {
            resp.Add(i);
        }
        return resp;
    }

    static Stack RevertePilha(Stack Original)
    {
        Stack resp = new Stack();
        for (int i = Original.Count; i > 0 ; i--)
        {
            resp.Push(Original.Pop());
        }
        return resp;
    }
    static Queue ReverteFila(Queue Original)
    {
        Queue resp = new Queue();
        for (int i = Original.Count; i > 0 ; i--)
        {
            resp.Enqueue(Original.Dequeue());
        }
        return resp;
    }
}
