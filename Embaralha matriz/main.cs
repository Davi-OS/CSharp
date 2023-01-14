

using System;
class Program
{
    //troca a linha 2 com a linha 8 //
    static void trocaLinha5_10(int[,] matriz)
    {
        int aux = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                aux = 0;
                if (x == 4)
                {
                    aux = matriz[4, y];
                    matriz[4, y] = matriz[9, y];
                    matriz[9, y] = aux;
                }
            }
        }

        //exibindo as alterações//
        Console.WriteLine("\nMatriz com a lina 5 e 10 trocadas:\n ----------------------------------------");
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Console.Write(" | " + matriz[x, y]);
                if (y == 9)
                {
                    Console.WriteLine("\n |---|---|---|---|---|---|---|---|---|---");
                }

            }
        }
    }

    static void trocaDiagonalPrincipal(int[,] matriz)
    {
        //trocando a diagonal secundaria//
        int[] vetorAuxiliar = new int[10];
        int posiçãoVetor = 0;
        int posiçãoDiagonalPrincipal = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                if (x + y == 9)
                {
                    //"salvando" a Diagonal Secundaria num vetor//
                    vetorAuxiliar[posiçãoVetor] = matriz[x, y];
                    //
                    matriz[x, y] = matriz[posiçãoDiagonalPrincipal, posiçãoDiagonalPrincipal];
                    posiçãoVetor++;
                    posiçãoDiagonalPrincipal++;
                }
            }
        }
        //trocando a diagonal principal//
        for (int x = 0; x < 10; x++)
        {
            matriz[x, x] = vetorAuxiliar[x];
        }

        //exibindo alterações//
        Console.WriteLine("\nMatriz com as diagonais trocadas:\n ----------------------------------------");
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Console.Write(" | " + matriz[x, y]);
                if (y == 9)
                {
                    Console.WriteLine("\n |---|---|---|---|---|---|---|---|---|---");
                }

            }
        }
    }

    //trocando a coluna 4 com a 10//
    static void trocaColuna4_10(int[,] matriz)
    {
        int aux = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                aux = 0;
                if (y == 3)
                {
                    aux = matriz[x, 3];
                    matriz[x, 3] = matriz[x, 9];
                    matriz[x, 9] = aux;
                }
            }
        }

        //exibindo as alterações//
        Console.WriteLine("\nMatriz com a coluna 4 e 10 trocadas:\n ----------------------------------------");
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Console.Write(" | " + matriz[x, y]);
                if (y == 9)
                {
                    Console.WriteLine("\n |---|---|---|---|---|---|---|---|---|---");
                }

            }
        }
    }

    //troca a linha 2 com a linha 8 //
    static void trocaLinha2_8(int[,] matriz)
    {
        int aux = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                aux = 0;
                if (x == 1)
                {
                    aux = matriz[1, y];
                    matriz[1, y] = matriz[7, y];
                    matriz[7, y] = aux;
                }
            }
        }

        //exibindo as alterações//
        Console.WriteLine("\nMatriz com a lina 2 e 8 trocadas:\n ----------------------------------------");
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Console.Write(" | " + matriz[x, y]);
                if (y == 9)
                {
                    Console.WriteLine("\n |---|---|---|---|---|---|---|---|---|---");
                }

            }
        }
    }

    //preenche//
    static void preenche()
    {
        Random R = new Random();
        int[,] matrizOriginal = new int[10, 10];
        Console.WriteLine("Matriz original:\n ----------------------------------------");
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                matrizOriginal[x, y] = R.Next(1, 3);
                Console.Write(" | " + matrizOriginal[x, y]);
                if (y == 9)
                {
                    Console.WriteLine("\n |---|---|---|---|---|---|---|---|---|---");
                }

            }
        }
        trocaLinha2_8(matrizOriginal);
        trocaColuna4_10(matrizOriginal);
        trocaDiagonalPrincipal(matrizOriginal);
        trocaLinha5_10(matrizOriginal);

    }
    public static void Main(string[] args)
    {
        preenche();
    }
}