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

        // Criando a filaJogadores
        FilaCircularJogadores filaJogadores = new FilaCircularJogadores();
        //setando o tamanho da fila circular(uma posição é vazia)
        int tamanho = 6;
        filaJogadores.preencheFila(time, n, tamanho);

        //exibindo os Jogadores na FilaCircularJogadores
        filaJogadores.ExibirFila();
    }
}

class FilaCircularJogadores
{
    Jogadores[] filaJogadores;
    int Primeiro;
    int Ultimo;
    int nElementos;
    int numOperacoes;
    string instrucao = "";
    string linha;

    //Jogadores temporarios necessarios para realizar as operações de  Remoçãoo e inserção na FilaCircularJogadores
    Jogadores[] temp = new Jogadores[10];
    int contaJogadoresTemp = 0;

    public void preencheFila(Jogadores[] jogadoresIniciais, int qnt, int tamanho)
    {
        filaJogadores = new Jogadores[tamanho];
        Primeiro = 0;
        Ultimo = -1;
        nElementos = 0;
        //inserindo os jogadores iniciais
        InserirIniciais(jogadoresIniciais, qnt);

        numOperacoes = int.Parse(Console.ReadLine());
        for (int h = 0; h < numOperacoes; h++)
        {
            linha = Console.ReadLine();
            instrucao = RetiraInstrucao(linha);

            switch (instrucao)
            {
                case "I":
                    temp[contaJogadoresTemp] = new Jogadores();
                    temp[contaJogadoresTemp].Ler(linha);
                    inserir(temp[contaJogadoresTemp]);
                    contaJogadoresTemp++;

                    break;

                case "R":
                    temp[contaJogadoresTemp] = new Jogadores();
                    temp[contaJogadoresTemp] = remover();
                    contaJogadoresTemp++;
                    break;
            }
        }
    }

    Jogadores remover()
    {
        if (nElementos == 0)
        {
            throw new Exception("filaJogadores Vazia.");
        }

        Jogadores resp = filaJogadores[Primeiro];
        Primeiro = (Primeiro + 1) % filaJogadores.Length;
        nElementos--;
        return resp;
    }

    public void InserirIniciais(Jogadores[] jogador, int qnt)
    {
        if (nElementos == filaJogadores.Length)
        {
            throw new Exception("Queue is full.");
        }

        for (int i = 0; i < qnt; i++)
        {
            Ultimo = (Ultimo + 1) % filaJogadores.Length;
            filaJogadores[Ultimo] = jogador[i];
            nElementos++;
        }
    }

    public void inserir(Jogadores jogador)
    {
        if (nElementos == filaJogadores.Length)
        {
            throw new Exception("filaJogadores Cheia.");
        }

        Ultimo = (Ultimo + 1) % filaJogadores.Length;
        filaJogadores[Ultimo] = jogador;
        nElementos++;
    }

    public void ExibirFila()
    {
        int i = Primeiro;
        while (i != Ultimo + 1)
        {
            filaJogadores[i].imprimir();
            i = (i + 1) % filaJogadores.Length;
        }
    }

    // retira a instrução da operação a ser realizada
    public static string RetiraInstrucao(string s)
    {
        string resp;
        string[] str = s.Split(' ');
        resp = str[0];
        return resp;
    }
}

class Jogadores
{
    string nome;
    string foto;
    DateTime nascimento = new DateTime();
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
