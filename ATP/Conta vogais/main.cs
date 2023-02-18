using System;
using System.IO;

class Program
{//Preenche o arquivocom letras//
    static void PreencheArquivo(int qntLetras)
    {
        Random r = new Random();
        StreamWriter sw = new
      StreamWriter(@"Arquivo.txt", false);
        for (int x = 0; x < qntLetras; x++)
        {
            sw.Write((char)r.Next(97, 122));
        }
        sw.Close();
    }
    //Ler o Arquivo//
    static void ContaVogal()
    {
        string texto = @"Arquivo.txt"; // Atribui o meu aquivo à uma variavel string//
        int Contavog = 0;
        using (StreamReader sr = new StreamReader(texto))
        {
            string line = sr.ReadLine();
            while (line != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'a')
                    {
                        Contavog++;
                    }
                    else if (line[i] == 'e')
                    {
                        Contavog++;
                    }
                    else if (line[i] == 'i')
                    {
                        Contavog++;
                    }
                    else if (line[i] == 'o')
                    {
                        Contavog++;
                    }
                    else if (line[i] == 'u')
                    {
                        Contavog++;
                    }
                }
                line = sr.ReadLine();
            }
            sr.Close();
            Console.WriteLine("O arquivo contem {0} Vogais", Contavog);
        }
    }
    public static void Main(string[] args)
    {
        int nLetras;
        Console.WriteLine("Informe o numero de letras:");
        nLetras = int.Parse(Console.ReadLine());
        PreencheArquivo(nLetras);
        ContaVogal();
    }
}