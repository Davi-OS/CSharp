using System;
using System.IO;

class Program
{
    //Responsavel por atualizar o estoque apos uma operação de venda.
    static int[,] AttEstoquePosVenda(int[,] vendas, int[,] estoque, int dia)
    {
        int[,] Att = new int[30, 4];
        for (int linha = 0; linha <= dia; linha++)
        {
            for (int Coluna = 0; Coluna < 4; Coluna++)
            {

                Att[linha, Coluna] = estoque[linha, Coluna] - vendas[dia, Coluna];

            }
        }
        //corrige o erro de ficar subtraindo sempre (ocorria se o usuario fizesse varias operaçoes no mesmo dia)//
        for (int linha = 0; linha < 30; linha++)
        {
            for (int Coluna = 0; Coluna < 4; Coluna++)
            {
                if (estoque[linha, Coluna] == Att[linha, Coluna])
                {
                    Att[linha, Coluna] = estoque[linha, Coluna];
                }
            }
        }
        return Att;
    }
    //testa se a venda é < que o estoque atual//
    static int[,] Vendas(int[,] estoque, int dia, int[,] V)
    {
        int venda;
        char opt;
        int[,] vendas = V;
        Console.WriteLine("Digite o codigo do produto que deseja vender:");
        Console.WriteLine("Produto [a]=0;Produto [b]=1;Produto [c]=2;Produto [d]=3;");
        opt = char.Parse(Console.ReadLine());
        switch (opt)
        {
            case '0':
                Console.WriteLine("Qual quantidade foi vendida?");
                venda = int.Parse(Console.ReadLine());
                if (estoque[dia, 0] >= venda)
                {
                    vendas[dia, 0] += venda;
                    Console.WriteLine("Venda Concluida");
                }
                else
                {
                    Console.WriteLine("Venda impossivel pois o estoque é {0}", estoque[dia, 0]);
                }
                break;
            case '1':
                Console.WriteLine("Qual quantidade foi vendida?");
                venda = int.Parse(Console.ReadLine());
                if (estoque[dia, 1] >= venda)
                {
                    vendas[dia, 1] += venda;
                    Console.WriteLine("Venda Concluida");
                }
                else
                {
                    Console.WriteLine("Venda impossivel pois o estoque é {0}", estoque[dia, 1]);
                }
                break;
            case '2':
                Console.WriteLine("Qual quantidade foi vendida?");
                venda = int.Parse(Console.ReadLine());
                if (estoque[dia, 2] >= venda)
                {
                    vendas[dia, 2] += venda;
                    Console.WriteLine("Venda Concluida");
                }
                else
                {
                    Console.WriteLine("Venda impossivel pois o estoque é {0}", estoque[dia, 2]);
                }
                break;
            case '3':
                Console.WriteLine("Qual quantidade foi vendida?");
                venda = int.Parse(Console.ReadLine());
                if (estoque[dia, 3] >= venda)
                {
                    vendas[dia, 3] += venda;
                    Console.WriteLine("Venda Concluida");
                }
                else
                {
                    Console.WriteLine("Venda impossivel pois o estoque é {0}", estoque[dia, 3]);
                }
                break;
        }
        return vendas;
    }
    //inicia o processo de estoque
    static int[,] Estoque(int dia, int[,] Estoque)
    {
        int entrada;
        int[,] estoque = Estoque;
        if (dia == 0)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe o saldo do produto cod {0}", i);
                entrada = int.Parse(Console.ReadLine());
                estoque[0, i] = entrada;
            }
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe o saldo para acrescer no produto cod {0}", i);
                entrada = int.Parse(Console.ReadLine());
                estoque[dia, i] = entrada + estoque[(dia - 1), i];
            }
        }
        return estoque;
    }

    //Faz a exibição da matriz no console//
    static void ExibeVendas(int[,] Vendas, int dia)
    {
        Console.WriteLine("Relatorio das vendas ate o momento:");
        Console.WriteLine("     |-A----B----C----D-|");

        for (int x = 0; x < dia + 1; x++)
        {
            Console.Write("Dia {0}", x + 1);
            for (int y = 0; y < 4; y++)
            {
                Console.Write("| " + Vendas[x, y] + " |");

                if (y == 3)
                {
                    Console.WriteLine("\n     |------------------|");
                }
            }
        }
        Console.WriteLine("|----------FIM----------|");
    }
    //Faz a exibição da matriz de Estoque no console//
    static void ExibeEstoque(int[,] estoque, int dia)
    {
        Console.WriteLine("Relatorio das Estoque ate o momento:");
        Console.WriteLine("     |-A----B----C----D-|");

        for (int x = 0; x < dia + 1; x++)
        {
            Console.Write("Dia {0}", x + 1);
            for (int y = 0; y < 4; y++)
            {
                Console.Write("| " + estoque[x, y] + " |");

                if (y == 3)
                {
                    Console.WriteLine("\n     |------------------|");
                }
            }
        }
        Console.WriteLine("|----------FIM----------|");
    }
    //Atualiza o estoque dia baseado no dia anterior//
    static int[,] AtualizaEstoque(int[,] estoque, int dia)
    {
        int[,] Att = estoque;
        if (dia != 0)
        {
            for (int Coluna = 0; Coluna < 4; Coluna++)
            {
                Att[dia, Coluna] = estoque[dia - 1, Coluna];
            }
        }
        return Att;
    }
    // Menu;
    public static void Main(string[] args)
    {
        char opç = ' ';
        int dia = 0;
        int[,] vendas = new int[30, 4];
        int[,] estoque = new int[30, 4];
        do
        {
            Console.WriteLine("Escolha a opção: \n[a]Inserir estoque.\n[b]Registrar uma venda. \n[c]Relatorio de Vendas.\n[d]Relatorio de Estoque.");
            Console.WriteLine("[e]Criar arquivo de vendas.\n[f]Proximo dia.\n[h]Sair.");
            opç = char.Parse(Console.ReadLine());
            switch (opç)
            {
                case 'a':
                    // Função Criar uma matriz estoque base//
                    estoque = Estoque(dia, estoque);
                    break;
                case 'b':
                    //Realiza as operações de venda//
                    vendas = Vendas(estoque, dia, vendas);
                    break;
                case 'c':
                    // Procedimento que vai escrever a  minha matriz de venda No console//
                    ExibeVendas(vendas, dia);
                    break;
                case 'd':
                    //Procedimento que vai escrever a  minha matriz de Estoque No console;
                    estoque = AttEstoquePosVenda(vendas, estoque, dia);
                    ExibeEstoque(estoque, dia);
                    break;
                case 'e':
                    //Procedimento que vai escrever a  minha matriz de venda em um arquivo(como resumo)//
                    CriaArquivo(vendas, dia);
                    Console.Clear();
                    break;
                case 'f':
                    //passa o dia, como se fechacem a loja//
                    dia++;
                    estoque = AtualizaEstoque(estoque, dia);
                    Console.Clear();
                    break;
                case 'h':
                    break;
            }
        } while (dia != 30 && opç != 'h');
    }
    //procedimento para criar o arquivo//
    static void CriaArquivo(int[,] vendas, int dia)
    {
        int somaA = 0, somaB = 0, somaC = 0, somaD = 0;
        StreamWriter sw = new StreamWriter(@"VendasNoMes.txt", false);
        for (int x = 0; x < 30; x++)
        {
            somaA += vendas[x, 0];
            somaB += vendas[x, 1];
            somaC += vendas[x, 2];
            somaD += vendas[x, 3];
        }
        sw.WriteLine("Relatorio de Vendas");
        sw.WriteLine("Vendas do Produto A: {0}", somaA);
        sw.WriteLine("Vendas do Produto B: {0}", somaB);
        sw.WriteLine("Vendas do Produto C: {0}", somaC);
        sw.WriteLine("Vendas do Produto D: {0}", somaD);
        sw.Close();
    }
}