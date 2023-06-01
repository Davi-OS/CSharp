using System;
using System.Collections.Generic;

namespace TP03Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> jogadores = new List<Jogador>();
            string leitura = Console.ReadLine();
            int n = 0;
            while (leitura != "FIM")
            {
                Jogador jogador = new Jogador();
                jogador.ler(leitura);
                jogadores.Add(jogador);
                leitura = Console.ReadLine();
                n++;
            }

            QuickSort(jogadores, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                jogadores[i].imprimir();
            }
        }

        public static void QuickSort(List<Jogador> jogadores, int left, int right)
        {
            if (left < right)
            {
                Jogador pivot = jogadores[right];
                int i = left - 1;

                for (int j = left; j < right; j++)
                {
                    int comparacao = 0;

                    comparacao = string.Compare(jogadores[j].nome, pivot.nome);

                    if (comparacao <= 0)
                    {
                        i++;
                        Swap(jogadores, i, j);
                    }
                }

                Swap(jogadores, i + 1, right);

                int pivotIndex = i + 1;
                QuickSort(jogadores, left, pivotIndex - 1);
                QuickSort(jogadores, pivotIndex + 1, right);
            }
        }

        public static void Swap(List<Jogador> jogadores, int i, int j)
        {
            Jogador temp = jogadores[i];
            jogadores[i] = jogadores[j];
            jogadores[j] = temp;
        }

        public class Jogador
        {
            public string nome = "";
            public string foto = "";
            public DateTime nascimento = DateTime.Parse("7/07/1994");
            public int id = 0;
            public int[] time;

            public void imprimir()
            {
                Console.Write($"{id} {nome} {nascimento.ToString("d/MM/yyyy")} {foto} ");
                Console.Write('(');
                for (int i = 0; i < this.time.Length - 1; i++)
                {
                    Console.Write($"{this.time[i]}, ");
                }
                Console.Write(this.time[this.time.Length - 1]);
                Console.WriteLine(')');
            }
            public void ler(string leitura)
            {
                int i = 0, cont = 1; string data = "", time = "", numero = "";
                while (leitura[i] != ',')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    nome += leitura[i];
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    foto += leitura[i];
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    data += leitura[i];
                    i++;
                }
                nascimento = DateTime.Parse(data);
                i++;
                while (leitura[i] != ',')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ',')
                {
                    numero += leitura[i];
                    i++;
                }
                id = int.Parse(numero);
                i++;
                while (leitura[i] != '[')
                {
                    i++;
                }
                i++;
                while (leitura[i] != ']')
                {
                    time += leitura[i];
                    if (leitura[i] == ',')
                    {
                        cont++;
                    }
                    i++;
                }
                this.time = new int[cont];
                numero = ""; i = 0;
                for (int j = 0; j <= time.Length; j++)
                {
                    if (j != time.Length)
                    {
                        if (time[j] != ',' && time[j] != ' ')
                        {
                            numero += time[j];
                        }
                        else if (numero != "")
                        {
                            this.time[i] = int.Parse(numero);
                            numero = "";
                            i++;
                        }
                    }
                    else
                    {
                        this.time[i] = int.Parse(numero);
                    }
                }
            }
        }
    }
}