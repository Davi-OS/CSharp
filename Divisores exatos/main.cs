using System;
using System.IO;

class Program
{
    //Caucula e armazena todos os divisores exatos em um vetor int//
    static int[] ExcConta(int Dividendo)
    {
        int i = 0;
        int Resto = 0;
        int ContaDivisores = 0;
        //for para delimitar o tamanho do vetor de resposta
        for (int Divisor = 1; Divisor <= Dividendo; Divisor++)
        {
            Resto = Dividendo % Divisor;
            if (Resto == 0)
            {
                ContaDivisores++;
            }
        }
        int[] Divisores = new int[ContaDivisores];
        //Gravando os divisores no vetor de resposta//
        for (int Divisor = 1; Divisor <= Dividendo; Divisor++)
        {
            Resto = Dividendo % Divisor;
            if (Resto == 0)
            {
                Divisores[i] = Divisor;
                i++;
            }
        }
        return Divisores;
    }
    //Exibindo os divisores no Console//
    static void Saida(int[] Divisores, int Dividendo)
    {
        Console.WriteLine("São esses os divisores de {0}:", Dividendo);
        for (int i = 0; i < Divisores.Length; i++)
        {
            Console.Write("-" + Divisores[i]);
        }
    }
    //Escreve o Arquivo//
    static void EscreveArquivo(int[] Divisores, int Dividendo)
    {
        StreamWriter sw = new
        StreamWriter(@"arquivo.txt", false);//False para que o programa sobescreva o arquivo a cada execução//
        sw.WriteLine("São esses os divisores de {0}:", Dividendo);
        for (int x = 0; x < Divisores.Length; x++)
        {
            sw.Write("-" + Divisores[x]);
        }
        sw.Close();
    }
    public static void Main(string[] args)
    {
        int entrada;
        Console.WriteLine("Informe um numero inteiro:");
        entrada = int.Parse(Console.ReadLine());
        int[] Divisores = ExcConta(entrada);//Executa uma função//
        Saida(Divisores, entrada);//Excua o procedimento de exibição no console//
        EscreveArquivo(Divisores, entrada);//Executa o procedimento para escrever o arquivo
    }
}