using System;

class Program
{
    public static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        while (numero >= 0)
        {
            //testando o resto da divisão e exibindo
            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            numero = int.Parse(Console.ReadLine());
        }
    }
}
