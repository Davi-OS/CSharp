﻿using System;
namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {


            ContaPoupança contaPoupança1 = new ContaPoupança(112, 0);
            contaPoupança1.Depositar(100);
            contaPoupança1.Sacar(10);
            double saldo = contaPoupança1.ConsultaSaldo();
            contaPoupança1.MostrarNumeroDaConta();
            Console.WriteLine("saldo da conta poupança é " + saldo);

            Conta conta = new Conta(113, 100);
            conta.Depositar(500);
            conta.Sacar(140);
            double saldoConta = conta.ConsultaSaldo();
            Console.WriteLine("saldo da conta Corrente é " + saldoConta);

        







            // Conta conta1 = new Conta(1234, 500);
            // Conta conta2 = new Conta(5678, 800);
            // Conta conta3 = new Conta(7890, 900);
            // Conta conta4 = new Conta(741320, 046);

            // Console.WriteLine("Total de Contoas Cridas " + Conta.TotalContasCriadas);
            // int a = Conta.ProximoTotalContasCriadas();
            // Console.WriteLine("Proximo Total de Contoas Cridas " + a);



            //Criando um objeto  de cada classe 
            // CartãoDeCredito cdc = new CartãoDeCredito();
            // Cliente c = new Cliente();

            // add o nome do cliente
            // c.nome = "Jose Fonseca";

            // //add numero e validade do cartão
            // cdc.numero = "123136556";
            // cdc.DataDeValidade= "02/2025";
            // cdc.Cliente = c;



            // Console.WriteLine("O nome do cliente é {0}", c.nome);
            // Console.WriteLine("O numero do cartão é {0}", cdc.numero);
            // Console.WriteLine("A data de validade do cartão é {0}", cdc.DataDeValidade);
            // Console.WriteLine("O nome do cliente do agregado é {0}", cdc.Cliente.nome);
















            // // criando uma instancia conta 1
            // Conta conta1 = new Conta(123, 300);
            // Console.WriteLine("O numero da sua conta é {0}", conta1.Numero);

            // // criando uma instancia conta 2
            // Conta conta2 = new Conta(456, 600);

            // // atribuindo valores para conta 1
            // conta1.Deposita(1500);
            // conta1.AdicionarLimite(500);


            // // atribuindo valores para conta 2
            // // conta2.Deposita(2000);
            // // conta2.AdicionarLimite(600);


            // conta1.Deposita(300);
            // Console.WriteLine("Seu Saldo é " + conta1.ConsultaSaldo());
            // Console.WriteLine("Seu limite é " + conta1.Limite);
            // conta1.Sacar(200);
            // Console.WriteLine("Seu Saldo é " + conta1.ConsultaSaldo());
        }
    }
}