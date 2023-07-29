using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoaList = new List<Pessoa>();
        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("                                                         ");
            Console.WriteLine("            Digete a Opção Desejada :                    ");
            Console.WriteLine("            =============================                ");
            Console.WriteLine("            1 - Criar Conta                              ");
            Console.WriteLine("            =============================                ");
            Console.WriteLine("            2 - Entrar com CPF e Senha                   ");
            Console.WriteLine("            =============================                ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
        private static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("                                                         ");
            Console.WriteLine("            Digete seu nome:                             ");
            string nome = Console.ReadLine();
            Console.WriteLine("            =============================                ");
            Console.WriteLine("            Digite o CPF:                                ");
            string CPF = Console.ReadLine();
            Console.WriteLine("            =============================                ");
            Console.WriteLine("            Digite sua senha:                            ");
            string senha = Console.ReadLine();
            Console.WriteLine("            =============================                ");

            // Criando Conta e pessoa
            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();
            pessoa.setNome(nome);
            pessoa.setCPF(CPF);
            pessoa.setSenha(senha);
            pessoa.Conta = contaCorrente;
            pessoaList.Add(pessoa);
            Console.Clear();

            Console.WriteLine("            =============================                ");
            Console.WriteLine("            Conta cadastrada com sucesso.                ");
            Console.WriteLine("            =============================                ");


        }

        private static void TelaLogin()
        {
            Console.Clear();

            Console.WriteLine("                                                         ");
            Console.WriteLine("            Digite o CPF:                                ");
            string CPF = Console.ReadLine();
            Console.WriteLine("            =============================                ");
            Console.WriteLine("            Digite sua senha:                            ");
            string senha = Console.ReadLine();
            Console.WriteLine("            =============================                ");


        }
    }
}

