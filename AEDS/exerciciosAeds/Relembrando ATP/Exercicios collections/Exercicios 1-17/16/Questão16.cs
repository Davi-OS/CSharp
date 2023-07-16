using System;
using System.Collections;

class Questão16
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
        fila.Enqueue(-7);
        fila.Enqueue(4);
        fila.Enqueue(-2);
        fila.Enqueue(2);
        fila.Enqueue(1);
        int positivos = posFila(fila);
        Console.WriteLine("exitem {0} numeros positivos nessa fila", positivos);
    }

    static void Stack()
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(-2);
        pilha.Push(4);
        pilha.Push(-7);

        int positivos = posPilha(pilha);
        Console.WriteLine("exitem {0} numeros positivos nessa pilha", positivos);
    }

    static void ArrayList()
    {
        ArrayList AL = new ArrayList() { 1, 2, -2, 4, -7, 6 };
        int positivos = posArraylist(AL);

        Console.WriteLine("exitem {0} numeros positivos nesse ArrayList", positivos);
    }

    static int posArraylist(ArrayList original)
    {
        int resp = 0;
        foreach (int item in original)
        {
            if (item >= 0)
            {
                resp++;
            }
        }
        return resp;
    }

    static int posFila(Queue<int> original)
    {
        int temp;
        int resp = 0;
        for (int i = original.Count; i > 0; i--)
        {
            temp = original.Dequeue();
            if (temp >= 0)
            {
                resp++;
            }
        }
        return resp;
    }

    static int posPilha(Stack<int> original)
    {
        int temp;
        int resp = 0;
        for (int i = original.Count; i > 0; i--)
        {
            temp = original.Pop();
            if (temp >= 0)
            {
                resp++;
            }
        }
        return resp;
    }
}
