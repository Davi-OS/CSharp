using System;
namespace OOP
{
    // os : indicao que a classe ContaPoupança esta herdadando os parametros e metodos da classe Conta
    public class ContaPoupança : Conta, IConta
    {
        // os ": base" idicao que o os parametros numero e limite serão usados para preencher o construtor da classe Conta (pai da classe ContaPoupança)
        public ContaPoupança(int numero, double limite) : base(numero, limite)
        {
        }
        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("Numero da Conta é " + this.Numero);
        }

        public override bool Sacar(double valor)
        {
            //base.Sacar(valor) chama o metodo da classes mae antes de seguir para a proxima ação
            bool sacIsOk = base.Sacar(valor);
            if (sacIsOk)
            {
                this.Saldo -= 6;
            }
            return false;
        }
    }
}