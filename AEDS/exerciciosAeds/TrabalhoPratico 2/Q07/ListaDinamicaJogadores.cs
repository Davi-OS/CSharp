using System;
using System.Collections;
using System.Collections.Generic;
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
        ListaDinamica ListaJogadores = new ListaDinamica();
        ListaJogadores.preencheLista(time);
        ListaJogadores.ExibirLista();
    }
}

class ListaDinamica
{
    public List<Jogadores> ListJogadores = new List<Jogadores>();
    int numOperacoes;
    string instrucao = "";
    string linha;

    //Jogadores temporarios necessarios para realiar as operações de  Remoçãoo e inserção na lista
    Jogadores[] temp = new Jogadores[10];
    int contaJogadoresTemp = 0;

    public void preencheLista(Jogadores[] jogadoresIniciais)
    {
        //Inserindo jogadores iniciais
        ListJogadores = new List<Jogadores>(jogadoresIniciais);
        numOperacoes = int.Parse(Console.ReadLine());
        for (int h = 0; h < numOperacoes; h++)
        {
            linha = Console.ReadLine();
            instrucao = RetiraInstrucao(linha);
            int pos = 0;

            switch (instrucao)
            {
                case "II":
                    temp[contaJogadoresTemp] = new Jogadores();
                    temp[contaJogadoresTemp].Ler(linha);
                    ListJogadores.Insert(0, temp[contaJogadoresTemp]);
                    contaJogadoresTemp++;

                    break;
                case "I*":
                    temp[contaJogadoresTemp] = new Jogadores();
                    pos = RetiraPos(linha);
                    temp[contaJogadoresTemp].Ler(linha);
                    ListJogadores.Insert(pos, temp[contaJogadoresTemp]);
                    contaJogadoresTemp++;

                    break;
                case "IF":
                    int i = 0;
                    pos = 0;
                    temp[contaJogadoresTemp] = new Jogadores();
                    temp[contaJogadoresTemp].Ler(linha);
                    //Caminha ate a ultima posição
                    while (ListJogadores[i] != null)
                    {
                        pos++;
                        i++;
                    }
                    ListJogadores.Insert(pos, temp[contaJogadoresTemp]);
                    contaJogadoresTemp++;
                    // ExibirLista();

                    break;
                case "R*":

                    pos = RetiraPos(linha);
                    ListJogadores.RemoveAt(pos);

                    break;
                case "RI":
                    ListJogadores.RemoveAt(0);

                    break;
                case "RF":
                    i = 0;
                    pos = -1;
                    while (ListJogadores[i] != null)
                    {
                        pos++;
                        i++;
                    }

                    //retira a ultima posição PREENCHIDA(ultima posição - 1)
                    ListJogadores.RemoveAt(pos);

                    break;
            }
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

    //retira a posição em que o elemento vai ser inserido ou retirado
    public static int RetiraPos(string s)
    {
        int resp;
        string[] str = s.Split(' ');
        resp = int.Parse(str[1]);
        return resp;
    }

    // retira os dados para serem transformados em um Jogador.


    //exibindo os jogadores da lista
    public void ExibirLista()
    {
        int i = 0;
        while (ListJogadores[i] != null)
        {
            ListJogadores[i].imprimir();
            i++;
        }
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
