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
        int n1, n2, r = 2, final = 1;
        Console.WriteLine("Digite dois números inteiros: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        while (n1 > 1 || n2 > 1)
        {
            if ((n1 % r == 0) && (n2 % r == 0))
            {
                final = final * r;
                n1 = n1 / r;
                n2 = n2 / r;
            }
            else
            {
                if ((n1 % r == 0))
                {
                    final = final * r;
                    n1 = n1 / r;
                }
                else
                {
                    if ((n2 % r == 0))
                    {
                        final = final * r;
                        n2 = n2 / r;
                    }
                    else
                        r++;
                }
            }
            Console.WriteLine(n1 + ", " + n2 + " | " + r);
        }
        Console.WriteLine("Final: " + final);
        Console.ReadKey();
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
        OrdenarPeloId();
    }
    void OrdenarPeloId()
    {
        for (int i = 0; i < (n - 1); i++)
        {
            int menor = i;
            for (int j = (i + 1); j < n; j++)
            {
                if (listaJogadores[menor].id > listaJogadores[j].id)
                {
                    menor = j;
                }
            }
            swap(menor, i);
        }

    }

    void swap(int menor, int index)
    {
        Jogadores temp = listaJogadores[menor];
        listaJogadores[menor] = listaJogadores[index];
        listaJogadores[index] = temp;
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
