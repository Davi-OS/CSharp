using DigiBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroDaAgencia = "0001";
            Conta.NumeroSequencial++;
        }
        public double Saldo { get; protected set; }
        public string NumeroDaAgencia { get; protected set; }
        public string NumeroDaConta { get; protected set; }
        public static int NumeroSequencial { get; protected set; }
        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            if (valor > 0)
            {

                this.Saldo += valor;
            }
            else
            {
                Console.WriteLine("Operação invalida");
            }
        }

        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroDaAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroDaConta;
        }

        public bool Saca(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Operação Invalida");
                return false;
            }
        }
    }
}
