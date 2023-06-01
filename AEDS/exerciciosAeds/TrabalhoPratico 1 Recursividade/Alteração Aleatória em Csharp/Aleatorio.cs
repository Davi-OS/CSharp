using System;

class Program
{
    public static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        Random gerador = new Random(4);
            char[] linhaChar = new char[linha.Length];

            char aleatorio1 = (char)('a' + (Math.Abs(gerador.Next()) % 26));
            char aleatorio2 = (char)('a' + (Math.Abs(gerador.Next()) % 26));
            Console.WriteLine("valores: {0} e {1}",aleatorio1,aleatorio2);

        while (linha != "FIM")
        {
            linhaChar = linha.ToCharArray();
            for (int i = 0; i < linhaChar.Length; i++)
            {
                if (linhaChar[i] == aleatorio1)
                {
                    linhaChar[i] = aleatorio2;
                }
            }
            string saida = string.Concat(linhaChar);
            Console.WriteLine(saida);
            linha = Console.ReadLine();
        }
        
    }
}
