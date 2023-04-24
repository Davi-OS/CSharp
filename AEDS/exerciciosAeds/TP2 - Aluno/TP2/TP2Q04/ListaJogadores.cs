using System;
using System.Collections;
using System.Text;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        lista lista = new lista(20);
    }
}

public class lista
{
    Jogadores[] time;
    int n;

    public lista(int tamanho)
    {
        Jogadores[] time = new Jogadores[tamanho];
        Jogadores temp = new Jogadores();
        Jogadores temp2 = new Jogadores();
        n = 0;
        int numOperacoes;
        string instrucao = "";
        string segundaParte;
        string linha = ConverteCaracterEspecial(Console.ReadLine());
        while (linha != "FIM")
        {
            time[n] = new Jogadores();
            time[n].Ler(linha);
            n++;
            linha = ConverteCaracterEspecial(Console.ReadLine());
        }

        // retirando o num de operações a serem ralizadas;
        linha = Console.ReadLine();
        numOperacoes = int.Parse(linha);

        //retirando as instruções do oque sera feito;
        for (int h = 0; h < numOperacoes; h++)
        {
            linha = Console.ReadLine();
            instrucao = RetiraInstrucao(linha);
            segundaParte = Restante(linha);
            int pos = 0;

            switch (instrucao)
            {
                case "II":

                    temp.Ler(linha);
                    inserirInicio(temp);

                    break;
                case "I*":

                    pos = RetiraPos(segundaParte);
                    temp2.Ler(RetiraDados(segundaParte));
                    Inserir(temp2, pos);

                    break;
                case "IF":

                    temp.Ler(linha);
                    inserirFinal(temp);

                    break;
                case "R*":

                    pos = RetiraPos(segundaParte);
                    temp = remover(pos);

                    break;
                case "RI":

                    temp = removerInicio();

                    break;
                case "RF":
                    temp = removerFinal();
                    break;
            }
        }

        //imprimindo
        for (int i = 0; i < n; i++)
        {
            time[i].imprimir();
        }

        Jogadores removerFinal()
        {
            if (n == 0)
                throw new Exception("Erro! Lista Vazia");
            return time[--n];
        }

        Jogadores removerInicio()
        {
            if (n == 0)
                throw new Exception("Erro! Lista Vazia");
            Jogadores resp = time[0];
            n--;
            for (int i = 0; i < n; i++)
            {
                time[i] = time[i + 1];
            }
            return resp;
        }

        Jogadores remover(int pos)
        {
            if (n == 0 || pos < 0 || pos >= n)
                throw new Exception("Erro! Lista Vazia");
            Jogadores resp = time[pos];
            n--;

            //voltando os elementos para o inicio
            for (int i = pos; i < n; i++)
            {
                time[i] = time[i + 1];
            }
            return resp;
        }

        void Inserir(Jogadores jogador, int pos)
        {
            if (n >= time.Length || pos < 0 || pos > n)
                throw new Exception("Erro!");
            //levar elementos para o fim do array
            for (int j = n; j > pos; j--)
            {
                time[j] = time[j - 1];
            }
            time[pos] = jogador;
            n++;
        }

        void inserirFinal(Jogadores jogador)
        {
            if (n >= time.Length)
            {
                throw new Exception("Erro! Lista Cheia!");
            }

            time[n] = jogador;
            n++;
        }

        void inserirInicio(Jogadores jogador)
        {
            if (n >= time.Length)
            {
                throw new Exception("Erro! Lista Cheia!");
            }
            //movendo elementos para o fim.
            for (int i = n; i > 0; i--)
            {
                time[i] = time[i - 1];
            }

            time[0] = jogador;
            n++;
        }
    }

    // retira os dados para serem transformados em um Jogador.
    public static string RetiraDados(string s)
    {
        string resp;
        string[] str = s.Split(' ', 2);
        resp = str[1];
        return resp;
    }

    //retira a posição em que o elemento vai ser inserido ou retirado
    public static int RetiraPos(string s)
    {
        int resp;
        string[] str = s.Split(' ');
        resp = int.Parse(str[0]);
        return resp;
    }

    //retira a segunda parte da Instrução
    public static string Restante(string s)
    {
        string restante = "";
        string[] str = s.Split(' ', 2);
        for (int i = 1; i < str.Length; i++)
        {
            restante += str[i];
        }
        return restante;
    }

    // retira a instrução da operação a ser realizada
    public static string RetiraInstrucao(string s)
    {
        string resp;
        string[] str = s.Split(' ', 2);
        resp = str[0];
        return resp;
    }

    public static string ConverteCaracterEspecial(string s)
    {
        string texto = s;
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        byte[] dadosUTF8 = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes);
        string textoCodificado = Encoding.UTF8.GetString(dadosUTF8);
        return textoCodificado;
    }
}

class Jogadores
{
    public string nome;
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
