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
        Jogadores[] time = new Jogadores[15];
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
        Ordenacao Time = new Ordenacao();
        Time.Preencher(time, n);

        //exibindo os Jogadores na Ordenacao
        Time.Exibir();
    }
}

class Ordenacao
{
    public Jogadores[] Time;
    public int n;


    public void Preencher(Jogadores[] jogadoresIniciais, int qnt)
    {
        Time = jogadoresIniciais;
        n = qnt;
        OrdenarPeloNome(0, n);
    }
    void OrdenarPeloNome(int esq, int dir)
    {
        int i = esq, j = dir;
        Jogadores pivo = new Jogadores();
        pivo = Time[(esq + dir) / 2];
        while (i <= j)
        {
            int indexI = string.Compare(Time[i].nome, pivo.nome);
            while (indexI < 0)
            {
                i++;
                indexI = string.Compare(Time[i].nome, pivo.nome);
            }
            int indexJ = string.Compare(Time[j].nome, pivo.nome);
            while (indexJ > 0)
            {
                j--;
                indexJ = string.Compare(Time[j].nome, pivo.nome);
            }
            if (i <= j)
            {
                swap(i, j);
                i++;
                j--;
            }
        }

        if (esq < j)
        {
            OrdenarPeloNome(esq, j);
        }
        if (i < dir)
        {
            OrdenarPeloNome(i, dir);
        }
    }

    void swap(int menor, int index)
    {
        Jogadores temp = new Jogadores();
        temp = Time[menor];
        Time[menor] = Time[index];
        Time[index] = temp;
    }

    public void Exibir()
    {
        for (int i = 0; i < n; i++)
        {
            Time[i].imprimir();
        }
    }
}

class Jogadores
{
    public string nome;
    string foto;
    DateTime nascimento = new DateTime();
    public int id;

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
