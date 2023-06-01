using System;

class Program
{
    static bool testeVogal(string str)
    {
        bool teste = false;
        int cont = 0;
        char[] vogais = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        //teste com dois for eio
        for (int letra = 0; letra < str.Length; letra++)
        {
            for (int vogal = 0; vogal < 10; vogal++)
            {
                if (str[letra] == vogais[vogal])
                {
                    cont++;
                }
            }
        }

        if (cont == str.Length)
        {
            teste = true;
        }
        return teste;
    }

    static bool testeConsoante(string i)
    {
        bool teste = true;
        char[] vogais = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] numeros = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        //teste com dois for
        for (int letra = 0; letra < i.Length; letra++)
        {
            for (int vogal = 0; vogal < 10; vogal++)
            {
                if (i[letra] == vogais[vogal])
                {
                    vogal = 10;
                    letra = i.Length;
                    teste = false;
                }
                else if (i[letra] == numeros[vogal])
                {
                    vogal = 10;
                    letra = i.Length;
                    teste = false;
                }
            }
        }
        return teste;
    }

    static bool testeInt(string str)
    {
        bool teste = int.TryParse(str, out var valor);
        return teste;
    }

    static bool testeReal(string str)
    {
        str = str.Replace(".", ",");
        int cont = 0;
        bool teste = double.TryParse(str, out var valor);
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ',' || str[i] == '.')
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

    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        while (str != "FIM")
        {
            if (testeVogal(str) == true)
            {
                Console.WriteLine("SIM NAO NAO NAO");
            }
            else if (testeConsoante(str) == true)
            {
                Console.WriteLine("NAO SIM NAO NAO");
            }
            else if (testeInt(str) == true)
            {
                Console.WriteLine("NAO NAO SIM SIM");
            }
            else if (testeReal(str) == true)
            {
                Console.WriteLine("NAO NAO NAO SIM");
            }
            else
            {
                Console.WriteLine("NAO NAO NAO NAO");
            }

            str = Console.ReadLine();
        }
    }
}
