using System;
namespace OOP
{
    // não pode ser instanciado;

    // Classes abstract são classes modelos para outras classes (Ex: a classe Funcionario é modelo para a Calsse Gerente.)
    public abstract class Funcionario
    {
        private string nome { get; set; }
        public double salario { get; protected set; }

        // Reajusta serve como modelo para outras classes filhas.
        public abstract void reajustar();

        public void addNome(string Primeironome, string segundoNome)
        {
            string nomeCompleto = Primeironome + " " + segundoNome;
            this.nome = nomeCompleto;
        }

        public void AddicionarSalarioPadrao(double salario)
        {
            this.salario = salario;
        }
    }
}