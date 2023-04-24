using System;

class Program
{
    static int contaVogais(string str, int indice, int conta, int indiceVogais)
    {
        int cont = 0;
        char[] vogais = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        if (indiceVogais < vogais.Length && indice < str.Length)
        {
            if (str[indice] == vogais[indiceVogais])
            {
                cont = 1 + (contaVogais(str, indice + 1, conta, indiceVogais = 0));
            }
            else
            {
                cont = contaVogais(str, indice, conta, indiceVogais + 1);
            }
        }
        return cont;
    }

    static int contaNumeros(string str, int indice, int conta, int indiceVogais)
    {
        int cont = 0;
        char[] vogais = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        if (indiceVogais < vogais.Length && indice < str.Length)
        {
            if (str[indice] == vogais[indiceVogais])
            {
                cont = 1 + (contaVogais(str, indice + 1, conta, indiceVogais = 0));
            }
            else
            {
                cont = contaVogais(str, indice, conta, indiceVogais + 1);
            }
            cont = (contaVogais(str, indice + 1, conta, indiceVogais = 0));
        }
        return cont;
    }

    static bool testeVogal(string linha)
    {
        int conta = 0;
        int indice = 0;
        int indiceVogais = 0;
        bool teste = false;
        int cont = contaVogais(linha, indice, conta, indiceVogais);

        //teste  se o numero de vogais contadas é o tamanho da string
        if (cont == linha.Length)
        {
            teste = true;
        }
        return teste;
    }

    static bool ehConsoante(string i)
    {
        bool teste = true;
        int conta = 0;
        int indice = 0;
        int indiceVogais = 0;
        int contVogais = contaVogais(i, indice, conta, indiceVogais);
        int contNumeros = contaNumeros(i, indice, conta, indiceVogais);
        if (contVogais > 0 || contNumeros > 0)
        {
            teste = false;
        }
        //teste com dois for
        // for (int letra = 0; letra < i.Length; letra++)
        // {
        //     for (int vogal = 0; vogal < 10; vogal++)
        //     {
        //         if (i[letra] == vogais[vogal])
        //         {
        //             vogal = 10;
        //             letra = i.Length;
        //             teste = false;
        //         }
        //         else if (i[letra] == numeros[vogal])
        //         {
        //             vogal = 10;
        //             letra = i.Length;
        //             teste = false;
        //         }
        //     }
        // }
        return teste;
    }

    static bool testeInt(string linha)
    {
        bool teste = int.TryParse(linha, out var valor);
        return teste;
    }

    static bool testeReal(string linha)
    {
        linha = linha.Replace(".", ",");
        int cont = 0;
        bool teste = double.TryParse(linha, out var valor);
        for (int i = 0; i < linha.Length; i++)
        {
            if (linha[i] == ',' || linha[i] == '.')
            {
                cont++;
            }
            if (cont >= 2)
            {
                teste = false;
            }
        }
        return teste;
    }

    static void Leitor()
    {
        string linha = Console.ReadLine();
        if (linha != "FIM")
        {
            if (testeVogal(linha) == true)
            {
                Console.WriteLine("SIM NAO NAO NAO");
            }
            else if (ehConsoante(linha) == true)
            {
                Console.WriteLine("NAO SIM NAO NAO");
            }
            else if (testeInt(linha) == true)
            {
                Console.WriteLine("NAO NAO SIM SIM");
            }
            else if (testeReal(linha) == true)
            {
                Console.WriteLine("NAO NAO NAO SIM");
            }
            else
            {
                Console.WriteLine("NAO NAO NAO NAO");
            }
            Leitor();
        }
    }

    public static void Main(string[] args)
    {
        Leitor();
    }
}
