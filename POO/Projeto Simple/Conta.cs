using System;
using System.Collections.Generic;
using System.Text;
namespace OOP
{
    // ": IConta" é a interfaçe na qual Conta segue os contratos
    // diferença de herança e implementação é : 
    // Vc so póde herdar uma unica classe mas pode ter varias implementação com mais de uma interface.
    public abstract class Conta : IConta
    {
        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalContasCriadas++;
        }
        protected double Saldo { get; set; }
        public double Limite { get; private set; }
        public double Numero { get; private set; }

        //atributos estaticos pertencem a classe e nao objeto
        public static int TotalContasCriadas { get; set; }

        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }

        public void Depositar(double valor)
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

        // virtual permite que classe herdeiras possam sobreescrever esse metodo
        public virtual bool Sacar(double valor)
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