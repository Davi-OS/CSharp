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

        // Criando a Lista
        Pilha listaJogadores = new Pilha();
        listaJogadores.preencheLista(time, n);

        //exibindo os Jogadores na Pilha
        listaJogadores.ExibirLista();
    }
}

class Pilha
{
    int numOperacoes;
    string instrucao = "";
    string linha;

    //Jogadores temporarios necessarios para realizar as operações de  Remoçãoo e inserção na Pilha
    Jogadores[] temp = new Jogadores[10];
    int contaJogadoresTemp = 0;

    Celula primeiro, ultimo;


    public void preencheLista(Jogadores[] jogadoresIniciais, int qnt)
    {
        primeiro = new Celula();
        ultimo = primeiro;

        // inserindo jogadores iniciais 
        for (int i = 0; i < qnt; i++)
        {
            inserirFinal(jogadoresIniciais[i]);
        }

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
                    inserirFinal(temp[contaJogadoresTemp]);
                    contaJogadoresTemp++;

                    break;

                case "R":
                    temp[contaJogadoresTemp] = new Jogadores();
                    temp[contaJogadoresTemp] = removerFinal();
                    contaJogadoresTemp++;
                    break;
            }
        }
    }

    Jogadores removerFinal()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro! Lista Vazia");
        Celula i;
        for (i = primeiro; i.prox != ultimo; i = i.prox) ;
        Jogadores resp = ultimo.elemento;
        ultimo = i;
        i = ultimo.prox = null;
        return resp;
    }
    void inserirFinal(Jogadores jogador)
    {
        ultimo.prox = new Celula(jogador);
        ultimo = ultimo.prox;
    }
    //retira a instrução da operação a ser realizada
    public static string RetiraInstrucao(string s)
    {
        string resp;
        string[] str = s.Split(' ');
        resp = str[0];
        return resp;
    }

    //Conta quantos elementos tem na pilha
    public int length()
    {
        int countProx = 0;
        for (Celula i = primeiro.prox; i != ultimo; i = i.prox)
        {
            countProx++;
        }

        return countProx;
    }

    //exibindo os jogadores da Pilha
    public void ExibirLista()
    {
        Celula tmp = new Celula();
        tmp = primeiro;
        while (tmp.prox != ultimo.prox)
        {
            tmp = tmp.prox;
            tmp.elemento.imprimir();
        }
        tmp = null;
    }
}

class Celula
{
    public Jogadores elemento;
    public Celula prox;


    public Celula()
    {
        Jogadores cafeComLeite = new Jogadores();
        this.elemento = cafeComLeite;
    }
    public Celula(Jogadores x)
    {
        this.elemento = x;
        this.prox = null;
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
