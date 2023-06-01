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

        MergeSort(time, 0, n - 1);

          for (int i = 0; i < n; i++)
        {
            time[i].imprimir();
        }

    }
    public static void MergeSort(Jogadores[] jogadores, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(jogadores, left, middle);
            MergeSort(jogadores, middle + 1, right);
            Merge(jogadores, left, middle, right);
        }
    }

    public static void Merge(Jogadores[] jogadores, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Criar arrays temporários
        Jogadores[] leftArray = new Jogadores[n1];
        Jogadores[] rightArray = new Jogadores[n2];

        // Copiar dados para os arrays temporários
        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = jogadores[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = jogadores[middle + 1 + j];
        }

        // Realizar o merge dos arrays temporários de volta ao array original
        int k = left;
        int i1 = 0;
        int i2 = 0;
        while (i1 < n1 && i2 < n2)
        {
            if (leftArray[i1].nascimento <= rightArray[i2].nascimento)
            {
                jogadores[k] = leftArray[i1];
                i1++;
            }
            else
            {
                jogadores[k] = rightArray[i2];
                i2++;
            }
            k++;
        }

        // Copiar os elementos restantes do array esquerdo, se houver
        while (i1 < n1)
        {
            jogadores[k] = leftArray[i1];
            i1++;
            k++;
        }

        // Copiar os elementos restantes do array direito, se houver
        while (i2 < n2)
        {
            jogadores[k] = rightArray[i2];
            i2++;
            k++;
        }
    }
}


class Jogadores
{
    public string nome;
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
