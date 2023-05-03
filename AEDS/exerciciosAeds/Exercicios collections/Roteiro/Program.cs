using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList Al = new ArrayList();
        Console.WriteLine(
            "Capacidade de Al = {0} Quantidade de Elementos = {1}",
            Al.Capacity,
            Al.Count
        );
        Al.Add(19);
        Al.Add(7);
        Al.Add(11);
        Console.WriteLine(
            "Capacidade de Al = {0} Quantidade de Elementos = {1}",
            Al.Capacity,
            Al.Count
        );
        Al.Add(5);
        Al.Add(7);
        Al.Add(17);
        Console.WriteLine(
            "Capacidade de Al = {0} Quantidade de Elementos = {1}",
            Al.Capacity,
            Al.Count
        );
        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.Insert(0, 5);
        Al.Insert(2, 5);

        // Ao tentar usar o Insert na posição 10 ele da o erro ArgumentOutOfRangeException

        if (Al.Capacity >= 10)
        {
            Al.Insert(10, 5);
        }
        else
        {
            // Caso a posição esteja fora dos limites, adicionar o número 5 ao final do ArrayList
            Al.Add(5);
        }
        // imprimindo
        for (int i = 0; i < Al.Count; i++)
        {
            Console.Write(Al[i] + " - ");
        }
        Console.Write("\n");

        int primeiraPosicao = -1;
        int ultimaPosicao = -1;
        for (int i = 0; i < Al.Count; i++)
        {
            if ((int)Al[i] == 7)
            {
                if (primeiraPosicao == -1)
                {
                    primeiraPosicao = i;
                }
                ultimaPosicao = i;
            }
        }
        if (primeiraPosicao != -1)
        {
            Console.WriteLine("A primeira posição que contém o número 7 é: " + primeiraPosicao);
            Console.WriteLine("A última posição que contém o número 7 é: " + ultimaPosicao);
        }

        ArrayList posicoesDeCinco = new ArrayList();
        for (int i = 0; i < Al.Count; i++)
        {
            if ((int)Al[i] == 5)
            {
                posicoesDeCinco.Add(i);
            }
        }
        Console.Write("O número 5 está nas posições: ");
        foreach (int n in posicoesDeCinco)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.Add(5);
        Al.Add(23);
        Al.Add(47);
        Al.Add(5);
        Al.Add(5);

        int pos = 0;
        while (pos < Al.Count)
        {
            Console.Write("{0} - ", Al[pos]);
            pos++;
        }
        Console.Write("\n");

        // BinarySearch
        int index = Al.BinarySearch(5);
        if (index >= 0)
        {
            Console.WriteLine(
                "A posição do número 5 encontrada pelo método BinarySearch é: " + index
            );
        }

        // IndexOf
        index = Al.IndexOf(5);
        while (index >= 0)
        {
            Console.WriteLine("A posição do número 5 encontrada pelo método IndexOf é: " + index);
            index = Al.IndexOf(5, index + 1);
        }

        // LastIndexOf
        index = Al.LastIndexOf(5);
        while (index >= 1)
        {
            Console.WriteLine(
                "A posição do número 5 encontrada pelo método LastIndexOf é: " + index
            );
            index = Al.LastIndexOf(5, index - 1);
        }
        index = Al.LastIndexOf(5, 0);
        Console.WriteLine("A posição do número 5 encontrada pelo método LastIndexOf é: " + index);

        Al.Sort();

        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.Remove(23);
        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.RemoveAt(7);
        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.RemoveRange(2, 3);
        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.Sort(new ReverseTudo());
        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");

        Al.Clear();
        foreach (int n in Al)
        {
            Console.Write("{0} - ", n);
        }
        Console.Write("\n");
        
        Console.WriteLine(
            "Capacidade de Al = {0} Quantidade de Elementos = {1}",
            Al.Capacity,
            Al.Count
        );
    }

    class ReverseTudo : IComparer
    {
        public int Compare(object x, object y)
        {
            return Comparer.Default.Compare(y, x);
        }
    }
}
