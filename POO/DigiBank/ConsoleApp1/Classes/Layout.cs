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


            //agurda 1 seg

            Thread.Sleep(1000);
            ContaLogada(pessoa);



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

            Pessoa pessoa = pessoaList.FirstOrDefault(x => x.CPF == CPF && x.Senha == senha);
            if (pessoa != null)
            {
                TelaBoasVindas(pessoa);
                ContaLogada(pessoa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("            Pessoa não cadastrada!                       ");
                Console.WriteLine("            =============================                ");
                Thread.Sleep(1000);
                TelaPrincipal();
                

            }
        }
        private static void TelaBoasVindas(Pessoa pessoa)
        {
            Console.Clear();

            string msgTelaBenvindo =
      $"{pessoa.Nome} | Banco: {pessoa.Conta.GetCodigoDoBanco()}" +
      $" | Agencia: {pessoa.Conta.GetNumeroAgencia()} | Conta: {pessoa.Conta.GetNumeroDaConta()}";
            Console.WriteLine("");
            Console.WriteLine($"        Seja Benvindo(a), {msgTelaBenvindo}");
            Console.WriteLine("");
        }
        private static void ContaLogada(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                         ");
            Console.WriteLine("            Digite a opção desejada:                     ");
            Console.WriteLine("           |==============================|              ");
            Console.WriteLine("           [1] - Realizar um deposito     |              ");
            Console.WriteLine("           |------------------------------|              ");
            Console.WriteLine("           [2] - Realizar um saque        |              ");
            Console.WriteLine("           |------------------------------|              ");
            Console.WriteLine("           [3] - Consultar o saldo        |              ");
            Console.WriteLine("           |------------------------------|              ");
            Console.WriteLine("           [4] - Extrato                  |              ");
            Console.WriteLine("           |------------------------------|              ");
            Console.WriteLine("           [5] - Sair                     |              ");
            Console.WriteLine("           |==============================|              ");

            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    TelaPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção invalida!");
                    break;
            }


        }
    }
}

