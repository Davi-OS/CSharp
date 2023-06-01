using System;

class Program
{
    // responsavel por ler e acionar os metodos
    static void Leitor()
    {
        string mensagem = Console.ReadLine();
        int repeticoes = 0;
        int tamanhoMensagem = mensagem.Length;
        int i = 0;
        if (mensagem != "FIM")
        {
            escreveNovaMensagem(mensagem, tamanhoMensagem, repeticoes, i);
            Leitor();
        }
    }

    //Escrevendo a mensagem criptografada//
    static void escreveNovaMensagem(string mensagem, int tamanho, int repeticoes, int i)
    {
        char[] mensagemChar = mensagem.ToCharArray();
        char[] Novamensagem = new char[tamanho];
        if (repeticoes < tamanho)
        {
            Novamensagem[i] = (char)(mensagemChar[i] + 3);
            Console.Write(Novamensagem[i]);
            escreveNovaMensagem(mensagem, tamanho, repeticoes + 1, i + 1);
        }
        else
        {
            //espaço para a proxima palavra
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        {
            //aciona o processo//
            Leitor();
        }
    }
}
