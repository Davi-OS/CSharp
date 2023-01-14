using System;

class Program
{
    // preocedimento que faz a comparação entre os valores digitados para os valores do vetor//
    static void Teste()
    {
        int chute = 0;
        int[] valores = new int[3];
        valores = numeros();
        while (chute != valores[0] && chute != valores[1] && chute != valores[2])
        {
            Console.WriteLine("Adivinhe algum valor do vetor:");
            chute = int.Parse(Console.ReadLine());
        }
    }

    //Função que preenche o vetor//
    static int[] numeros()
    {
        Random R = new Random();
        int[] vet3 = new int[3];
        Console.WriteLine("Colinha para testar:");
        for (int x = 0; x < 3; x++)
        {
            vet3[x] = R.Next(10, 50);
            Console.WriteLine(vet3[x]);
        }
        return vet3;
    }
    //aciona o procedimento//
    public static void Main(string[] args)
    {
        Teste();
    }
}