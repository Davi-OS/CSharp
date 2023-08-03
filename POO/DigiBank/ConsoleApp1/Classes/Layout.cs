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
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3:
                    TelaSaldo(pessoa);
                    break;
                case 4:
                    TelaExtrato(pessoa);
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
        private static void TelaDeposito(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine("            Digite o valor de deposito:                     ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("            ===========================                     ");
            pessoa.Conta.Deposita(valor);
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                            ");
            Console.WriteLine("                                                            ");
            Console.WriteLine("            Deposito realizado com sucesso!!                ");
            Console.WriteLine("             ===========================                    ");
            Console.WriteLine("                                                            ");

            VoltarLogado(pessoa);
        }
        private static void TelaSaque(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine("            Digite o valor de saque:                     ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("            ===========================                     ");
            bool ok = pessoa.Conta.Saca(valor);
            Console.WriteLine("                                                            ");
            Console.WriteLine("                                                            ");
            if (ok)
            {

                Console.WriteLine("            Saque realizado com sucesso!!                ");

            }
            else
            {
                Console.WriteLine("                Operação invalida, saldo insuficiente!                          ");
            }
            Console.WriteLine("             ===========================                    ");
            Console.WriteLine("                                                            ");
            Console.Clear();
            TelaBoasVindas(pessoa);

            VoltarLogado(pessoa);
        }
        private static void VoltarLogado(Pessoa pessoa)
        {
            Console.WriteLine("                                                         ");
            Console.WriteLine("            Digite a opção desejada:                     ");
            Console.WriteLine("           |==============================|              ");
            Console.WriteLine("           [1] - Voltar para minha conta  |              ");
            Console.WriteLine("           |------------------------------|              ");
            Console.WriteLine("           [2] - Sair                     |              ");
            Console.WriteLine("           |==============================|              ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                ContaLogada(pessoa);
            }
            else
            {
                TelaPrincipal();
            }
        }
        private static void TelaSaldo(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine($"           Seu saldo é {pessoa.Conta.ConsultaSaldo()}   ");
            Console.WriteLine("           |==============================|              ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                                                         ");
            VoltarLogado(pessoa);
        }
        private static void TelaExtrato(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            if (pessoa.Conta.Extrato().Any())
            {
                double total = pessoa.Conta.Extrato().Sum(x => x.Valor);

                foreach (Extrato extrato in pessoa.Conta.Extrato())
                {
                    Console.WriteLine("                                                          ");
                    Console.WriteLine($"            Data:{extrato.Data.ToString("dd/MM/yyyy hh:mm:ss")}");
                    Console.WriteLine($"            Tipo de Movimentação:{extrato.Descricao}     ");
                    Console.WriteLine($"            Valor:{extrato.Valor}                        ");
                    Console.WriteLine("           |==========================================|   ");
                }


                Console.WriteLine("                                                          ");
                Console.WriteLine($"            SUB Total: {total}                           ");
                Console.WriteLine("           |===============================|              ");
            }
            else
            {
                // não ha extrato
                Console.WriteLine("                                                          ");
                Console.WriteLine("            Não ha extrato a ser exibido:                      ");
                Console.WriteLine("           |===============================|              ");
            }


            VoltarLogado(pessoa);
        }
        private static void OpcaoDeslogado()
        {
            Console.WriteLine("                                                          ");
            Console.WriteLine("            Digite a opção desejada:                      ");
            Console.WriteLine("           |===============================|              ");
            Console.WriteLine("           [1] - Voltar para menu principal|              ");
            Console.WriteLine("           |-------------------------------|              ");
            Console.WriteLine("           [2] - Sair                      |              ");
            Console.WriteLine("           |===============================|              ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                TelaPrincipal();
            }
            else if (opcao == 2)
            {
                Console.WriteLine("                    OPção invalida!                       ");
                Console.WriteLine("           |===============================|              ");
            }
        }
    }
}

