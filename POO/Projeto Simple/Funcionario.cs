using System;
namespace OOP
{


    public abstract class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }

        public abstract void reajustar();
    }
}