using System;
using System.Collections;
using System.Text;
using System.IO;

class Program
{
    // metodo para testar apenas uma linha de entrada
    // public static void Main(string[] args)
    // {
    //     Jogadores jogador = new Jogadores();
    //     string linha = Console.ReadLine();
    //     jogador.Ler(linha);
    //     jogador.imprimir();
    // }

    public static string ConverteCaracterEspecial(string s)
    {
        string texto = s;
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        byte[] dadosUTF8 = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes);
        string textoCodificado = Encoding.UTF8.GetString(dadosUTF8);
        return textoCodificado;
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

        // Criando a class ordenacao
        Ordenacao listaJogadores = new Ordenacao();
        listaJogadores.Preencher(time, n);

        //exibindo os Jogadores na Ordenacao
        listaJogadores.Exibir();
    }
}

class Ordenacao
{
    public Jogadores[] listaJogadores;
    public int n;

    public void Preencher(Jogadores[] jogadoresIniciais, int qnt)
    {
        listaJogadores = jogadoresIniciais;
        n = qnt;
        OrdenarPelaIdade(0, n);
    }
    void OrdenarPelaIdade(int esq, int dir)
    {
        if (esq < dir)
        {
            int meio = (esq + dir) / 2;
            OrdenarPelaIdade(esq, meio);
            OrdenarPelaIdade(meio + 1, dir);
            Intercalar(esq, meio, dir);
        }
    }

    void Intercalar(int esq, int meio, int dir)
    {
        // definindo o tamanho dos subAarrays
        int nEsq = (meio + 1) - esq;
        int nDir = dir - meio;

        Jogadores[] arrayEsq = new Jogadores[nEsq + 1];
        Jogadores[] arrayDir = new Jogadores[nDir + 1];

        //sentinela

        Jogadores Sentinela = new Jogadores();
        Sentinela.Ler("000,Sentinela,Sentinela.png,31/12/9999,Sentinela,001,[00000]");
        
        arrayEsq[nEsq] = new Jogadores();
        arrayDir[nDir] = new Jogadores();

        arrayEsq[nEsq] = arrayDir[nDir] = Sentinela;

        int iEsq, iDir, i;

        //inicializando o Subarray

        for (iEsq = 0; iEsq < nEsq; iEsq++)
        {
            arrayEsq[iEsq] = new Jogadores();
            arrayEsq[iEsq] = listaJogadores[esq + iEsq];
        }

        //inicializando o Subarray

        for (iDir = 0; iDir < nDir; iDir++)
        {
            arrayDir[iDir] = new Jogadores();
            arrayEsq[iDir] = listaJogadores[(meio + 1) + iDir];
        }

        // interpolacão 

        for (iEsq = iDir = 0, i = iEsq; i <= dir; i++)
        {
            listaJogadores[i] = (arrayEsq[iEsq].nascimento <= arrayDir[iDir].nascimento) ? arrayEsq[iEsq++] : arrayDir[iDir++];
        }

    }

    public void Exibir()
    {
        for (int i = 0; i < n; i++)
        {
            listaJogadores[i].imprimir();
        }
    }
}

class Jogadores
{
    string nome;
    string foto;
    public DateTime nascimento = new DateTime();
    int id;

    public int[] times;

    public void Ler(string linha)
    {
        string[] str;
        str = linha.Split(',');
        id = int.Parse(str[5]);
        nome = str[1];
        foto = str[2];
        nascimento = DateTime.Parse(str[3]);

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

        //                  *não funciona no verde
        // extraindo os valores TIMES da string pub in  *não funciona no verde
        //         string[] strTEMP;
        //         string[] timeStr;
        //         char[] delimitadores = { '[', ']' };
        //         strTEMP = linha.Split(delimitadores);
        //         timeStr = strTEMP[1].Split(", ");

        //         //criando o "times"
        //         times = new int[timeStr.Length];
        //         for (int i = 0; i < timeStr.Length; i++)
        //         {
        //             times[i] = int.Parse(timeStr[i]);
        //         }
    }

    public void imprimir()
    {
        //tratando o Array "Times"
        string strtimes = "";
        for (int i = 0; i < times.Length - 1; i++)
        {
            strtimes += times[i] + ", ";
        }
        strtimes += times[times.Length - 1];

        // tratando o DateTime
        string data = nascimento.ToString("d/MM/yyyy");
        Console.WriteLine("{0} {1} {2} {3} ({4})", id, nome, data, foto, strtimes);
    }
}
