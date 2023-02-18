using System;

class Program
{
    //preenchedor//
    static void Preenche(int n)
    {
        Random R = new Random();
        int[] vetorX = new int[n];
        int[] vetorY = new int[n];
        for (int x = 0; x < n; x++)
        {
            vetorX[x] = R.Next(0, 100);
            vetorY[x] = R.Next(0, 100);
        }
        novoV(vetorX, vetorY);
    }
    //Novo vetor par/impar//
    static void novoV(int[] vetorimp, int[] vetorpar)
    {
        int[] novoVetor = new int[20];
        int y = 0;
        for (int x = 0; x < 20; x += 2)
        {
            novoVetor[x] = vetorpar[y];
            y++;
        }
        y = 0;
        for (int x = 1; x < 20; x += 2)
        {
            novoVetor[x] = vetorimp[y];
            y++;
        }
        Exibidor(novoVetor);
    }

    //Resultado//
    static void Exibidor(int[] resultado)
    {
        for (int x = 0; x < 20; x++)
        {
            Console.Write("|" + resultado[x]);
        }
    }



    public static void Main(string[] args)
    {
        int n = 10;
        Preenche(n);
    }
}