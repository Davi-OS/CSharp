using System;

class Program
{
    public static void Main(string[] args)
    {
        string palavra = Console.ReadLine();
        while (palavra != "FIM")
        {
            int contaLetrasMaiusculas = 0;
            char[] letras = palavra.ToCharArray();
            //Convertento char em int
            int[] ASCII = new int[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                ASCII[i] = letras[i];
            }
            //Teste logico tabela ASCII
            for (int i = 0; i < ASCII.Length; i++)
            {
                if (ASCII[i] > 64 && ASCII[i] <= 90)
                {
                    contaLetrasMaiusculas++;
                }
            }
            //exibe a quantidade de letras maiusculas
            Console.WriteLine(contaLetrasMaiusculas);
            // Entra nova palavra
            palavra = Console.ReadLine();
        }
    }
}
