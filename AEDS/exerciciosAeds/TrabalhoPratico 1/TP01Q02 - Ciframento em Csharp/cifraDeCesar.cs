using System;

class Program
{
    static int[] converteASCII(string mensagem)
    {
        char[] chars = mensagem.ToCharArray(); //converte a string em um vetor de char//
        int[] ASCII = new int[chars.Length];
        for (int i = 0; i < chars.Length; i++)
        {
            ASCII[i] = chars[i]; //converte Char em int//
        }

        return ASCII;
    }

    static void cripitografo()
    {
        string mensagem = Console.ReadLine();
        while (mensagem != "FIM")
        {
            int chaveCriptografica = 3;
            //aciona uma função para converter a menssagem(string) para numeros (vetor de int) //
            int[] ASCII = converteASCII(mensagem);
            for (int i = 0; i < ASCII.Length; i++)
            {
                ASCII[i] += chaveCriptografica;
            }
            escreveNovaMensagem(ASCII);
            mensagem = Console.ReadLine();
        }
    }

    //Escrevendo a mensagem criptografada//
    static void escreveNovaMensagem(int[] Codigo)
    {
        string novaMensagem;
        char[] mensagemChar = new char[Codigo.Length];
        for (int i = 0; i < Codigo.Length; i++)
        {
            mensagemChar[i] = (char)Codigo[i]; //converte int em char//
        }
        novaMensagem = string.Concat(mensagemChar); //concatena um vetor de char numa string//
        Console.WriteLine(novaMensagem);
    }

    public static void Main(string[] args)
    {
        {
            //aciona o processo//
            cripitografo();
        }
    }
}
