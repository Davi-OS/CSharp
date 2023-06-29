using System;
namespace OOP
{
    // os : indicao que a classe ContaPoupança esta herdadando os parametros e metodos da classe Conta
    public class ContaPoupança : Conta
    {
        // os ": base" idicao que o os parametros numero e limite serão usados para preencher o construtor da classe Conta (pai da classe ContaPoupança)
        public ContaPoupança(int numero, double limite) : base(numero, limite)
        {

        }
        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("Numero da Conta é " + this.Numero);
        }
    }
}