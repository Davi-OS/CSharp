using System;

class Program
{
    //conta quantos pares de caracter existe na string, ex: se o caracter [0] == [n-1] = contapares ++;
    static int testePalindromo(string str, int repeticoes, int n, int i)
    {
        int resp = 0;
        if (repeticoes < str.Length / 2)
        {
            if (str[i] == str[n - 1])
            {
                resp = testePalindromo(str, repeticoes + 1, n - 1, i + 1) + 1;
            }
        }
        return resp;
    }

    //faz o teste que retorna true ou false, acionando o metodo de teste.
    static bool ehPalindromo(string str)
    {
        int repeticoes = 0;
        int i = 0;
        bool resp = false;
        int n = str.Length;
        int contPares = testePalindromo(str, repeticoes, n, i);
        if (contPares == str.Length / 2)
        {
            resp = true;
        }
        return resp;
    }

    //Ler  e escreve no console
    static void Leitor()
    {
        string linha = Console.ReadLine();
        bool resp;
        if (linha != "FIM")
        {
            resp = ehPalindromo(linha);
            if (resp == true)
            {
                Console.WriteLine("SIM");
            }
            else if (resp == false)
            {
                Console.WriteLine("NAO");
            }
            Leitor();
        }
    }

    public static void Main(string[] args)
    {
        Leitor();
    }
}
