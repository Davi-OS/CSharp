﻿using System;
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

        Jogadores[] jogadoresOrdenados = MergeSort(time);

    }
    static Jogadores[] MergeSort(Jogadores[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        Jogadores[] leftArray = new Jogadores[middle];
        Jogadores[] rightArray = new Jogadores[array.Length - middle];

        Array.Copy(array, 0, leftArray, 0, middle);
        Array.Copy(array, middle, rightArray, 0, array.Length - middle);

        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        return Merge(leftArray, rightArray);
    }



    static Jogadores[] Merge(Jogadores[] leftArray, Jogadores[] rightArray)
    {
        int leftLength = leftArray.Length;
        int rightLength = rightArray.Length;
        int totalLength = leftLength + rightLength;

        Jogadores[] mergedArray = new Jogadores[totalLength];

        int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

        while (leftIndex < leftLength && rightIndex < rightLength)
        {
            if (leftArray[leftIndex].nascimento <= rightArray[rightIndex].nascimento)
            {
                mergedArray[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                mergedArray[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }

            mergedIndex++;
        }

        while (leftIndex < leftLength)
        {
            mergedArray[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < rightLength)
        {
            mergedArray[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }

        return mergedArray;
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
