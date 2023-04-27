using System;

class Program
{
    public static void Main(string[] args)
    {
        FilaCircular filaCircular = new FilaCircular(5);
        filaCircular.Inserir(9);
        filaCircular.Inserir(3);
        filaCircular.Inserir(4);
        filaCircular.Inserir(5);
        filaCircular.Inserir(7);
        filaCircular.Display();
    }
}

public class FilaCircular
{
    private int[] Fila;
    private int Primeiro;
    private int Ultimo;
    private int nElementos;

    public FilaCircular(int size)
    {
        Fila = new int[size];
        Primeiro = 0;
        Ultimo = -1;
        nElementos = 0;
    }

    public void Inserir(int item)
    {
        if (nElementos == Fila.Length)
        {
            throw new Exception("Fila Cheia.");
        }

        Ultimo = (Ultimo + 1) % Fila.Length;
        Fila[Ultimo] = item;
        nElementos++;
    }

    public int Remover()
    {
        if (nElementos == 0)
        {
            throw new Exception("Fila Vazia.");
        }

        int item = Fila[Primeiro];
        Primeiro = (Primeiro + 1) % Fila.Length;
        nElementos--;
        return item;
    }

    public bool IsEmpty()
    {
        return nElementos == 0;
    }

    public bool IsFull()
    {
        return nElementos == Fila.Length;
    }

    public int Size()
    {
        return nElementos;
    }

    public void Display()
    {
        if (nElementos == 0)
        {
            Console.WriteLine("Fila vazia.");
            return;
        }

        int index = Primeiro;

        for (int i = 0; i < nElementos; i++)
        {
            Console.Write(Fila[index] + " ");
            index = (index + 1) % Fila.Length;
        }

        Console.WriteLine();
    }
}
