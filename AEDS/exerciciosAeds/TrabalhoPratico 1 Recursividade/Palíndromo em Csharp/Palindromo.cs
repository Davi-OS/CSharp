using System;

class Program
{
    public static void Main(string[] args)
    {
        string linha = Console.ReadLine();

        while (linha != "FIM")
        {
            bool palindromo = false;
            int n = linha.Length;
            int x = 0;
            char[] char1 = new char[n];
            char[] char2 = new char[n];

            //escevendo o a string original em dois array de char, do inico para o fim e do fim para o inicio 
            for (int i = n; i > (n / 2); i--)
            {
                char1[x] = linha[x];
                char2[x] = linha[i - 1];
                x++;
            }
        
            // Convertendo novamente os dois arrays para novas  duas strings
            string str1 = new string(char1);
            string str2 = new string(char2);
            
            // Comparando as duas strings 
            palindromo = (str1.Equals(str2));

            // Exibindo o resultado da comparaação
            if (palindromo == true)
            {
                Console.WriteLine("SIM");
            }
            else
            {
                Console.WriteLine("NAO");
            }

            linha = Console.ReadLine();
        }
    }
}
