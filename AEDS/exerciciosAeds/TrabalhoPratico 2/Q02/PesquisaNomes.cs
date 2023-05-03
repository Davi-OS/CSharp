using System;
using System.Collections;
using System.Text;
using System.IO;

class Program
{
    public static string ConverteCaracterEspecial(string s)
    {
        string texto = s;
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        byte[] dadosUTF8 = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes);
        string textoCodificado = Encoding.UTF8.GetString(dadosUTF8);
        return textoCodificado;
    }

    // Delimitando a Chave de Pesquisa
    public static string[] ChavePesquisa()
    {
        string linha = Console.ReadLine();
        string nomes = "";
        while (linha != "FIM")
        {
            nomes += linha + ',';
            linha = Console.ReadLine();
        }
        string[] chavePesquisa = nomes.Split(',');
        return chavePesquisa;
    }

    public static void pesquisa(string[] chave, string[] nomes)
    {
        for (int i = 0; i < chave.Length - 1; i++)
        {
            for (int j = 0; j < nomes.Length; j++)
            {
                if (chave[i] == nomes[j])
                {
                    Console.WriteLine("SIM");
                    j = nomes.Length;
                }
                else if (j >= nomes.Length - 1)
                {
                    Console.WriteLine("NAO");
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        Jogadores[] time = new Jogadores[30];
        int n = 0;
        string linha = ConverteCaracterEspecial(Console.ReadLine());
        while (linha != "FIM")
        {
            time[n] = new Jogadores();
            time[n].Ler(linha);
            n++;
            linha = ConverteCaracterEspecial(Console.ReadLine());
        }

        //dados para a pesquisa
        string[] chave = ChavePesquisa();
        //retirando os nomes do objeto array de objetos
        string[] nomes = new string[n];
        for (int i = 0; i < n; i++)
        {
            nomes[i] = time[i].nome;
        }

        //pesquisando
        pesquisa(chave, nomes);
    }
}

class Jogadores
{
    public string nome;
    public int[] times;

    public void Ler(string linha)
    {
        string[] str;
        str = linha.Split(',');

        nome = str[1];

        // extraindo os valores TIMES da string pub in
        string[] strTEMP;
        string[] timeStr;
        char[] delimitadores = { '[', ']' };
        char[] delimitadores2 = { ',', ' ' };
        strTEMP = linha.Split(delimitadores);
        timeStr = strTEMP[1].Split(delimitadores2);
        int contaTimes = 0;
        int number;
        for (int i = 0; i < timeStr.Length; i++)
        {
            bool success = int.TryParse(timeStr[i], out number);
            if (success == true)
            {
                contaTimes++;
            }
        }
        times = new int[contaTimes];
        int indexTimes = 0;
        for (int i = 0; i < timeStr.Length; i++)
        {
            bool success = int.TryParse(timeStr[i], out number);
            if (success == true)
            {
                times[indexTimes] = int.Parse(timeStr[i]);
                indexTimes++;
            }
        }
    }

    // public void imprimir()
    // {
    //     //tratando o Array "Times"
    //     string strtimes = "";
    //     for (int i = 0; i < times.Length - 1; i++)
    //     {
    //         strtimes += times[i] + ", ";
    //     }
    //     strtimes += times[times.Length - 1];

    //     // tratando o DateTime
    //     string data = nascimento.ToString("d/MM/yyyy");
    //     Console.WriteLine("{0} {1} {2} {3} ({4})", id, nome, data, foto, strtimes);
    // }
}
