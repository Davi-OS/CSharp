using System;
using System.Collections.Generic;
using System.Text;
namespace OOP
{
    public class Conta
    {
        public Conta(int numero,double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
        }
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public double Numero { get; private set; }

        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                Console.WriteLine("Depoisito de ${0} realizado", valor);
            }
            else
            {
                Console.WriteLine("Valor de Deposito Invalido!");
            }
        }

        public double ConsultaSaldo()
        {
            double resp = this.Saldo + this.Limite;
            return resp;
        }
        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }
        public bool Sacar(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldo();
            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Valor de saque indisponivel");
                return false;
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine("Saque de ${0} realizado", valor);
                return true;
            }
        }

    }
}