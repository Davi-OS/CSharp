using System;

class Program
{
    public static void Main(string[] args)
    {
        int numeroOperacoes = int.Parse(Console.ReadLine());

        //numero de operacoes a ser realizadas
        string entrada = Console.ReadLine();
        // Console.WriteLine(entrada[0]);
        // Console.WriteLine(entrada[2]);
        for (int r = 0; r < numeroOperacoes; r++)
        {
            //Setando a base, o expoente e resultado
            int b = (int)Char.GetNumericValue(entrada[0]);
            int expoente = (int)Char.GetNumericValue(entrada[2]);
            int resultado=1;

            //realizando a operacao
            for (int m = 0; m < expoente; m++)
            {
                resultado *= b;
            }

            //exibindo o resultado
            Console.WriteLine(resultado);
            resultado = 0;

            //indo para a proxima entrada
            entrada = Console.ReadLine();
         }
    }
}
