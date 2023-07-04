using System;
using System.Collections;

class Questão17
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
        int ocorencias = contaOcorrenciasFila(fila);
        Console.WriteLine("exitem {0} numeros  nessa fila", ocorencias);
    }

    static void Stack()
    {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(1);
        pilha.Push(2);
        pilha.Push(-2);
        pilha.Push(4);
        pilha.Push(-7);
        int ocorencias = contaOcorrenciasPilha(pilha);
        Console.WriteLine("exitem {0} numeros  nessa pilha",ocorencias);
    }

    static void ArrayList()
    {
        ArrayList AL = new ArrayList() { 1, 2, -2, 4, -7, 6 };
        int ocorencias = contaOcorrenciasArr(AL);
        Console.WriteLine("exitem {0} numeros  nesse ArrayList", ocorencias);
    }

    static int contaOcorrenciasArr(ArrayList oriArray)
    {
        int conta = 0;
        foreach (var item in oriArray)
        {
            conta++;
        }
        return conta;
    }

    static int contaOcorrenciasFila(Queue<int> oriFila)
    {
        int conta = 0;
        foreach (int item in oriFila)
        {
            conta++;
        }

        return conta;
    }

    static int contaOcorrenciasPilha(Stack<int> oriPilha)
    {
        int conta = 0;
        foreach (int item in oriPilha)
        {
            conta++;
        }
        return conta;
    }
}
