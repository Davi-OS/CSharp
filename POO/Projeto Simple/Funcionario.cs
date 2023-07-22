using System;
namespace OOP
{
    // não pode ser instanciado;

    // Classes abstract são classes modelos para outras classes (Ex: a classe Funcionario é modelo para a Calsse Gerente.)
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }

        // Reajusta serve como modelo para outras classes filhas.
        public abstract void reajustar();
    }
}