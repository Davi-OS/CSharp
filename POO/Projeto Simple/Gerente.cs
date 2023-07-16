using System;
namespace OOP
{
    public class Gerente : Funcionario
    {
        // override = sobrepor ( sobrepoem o metodo da classe abstratc funcionario)
        public override void reajustar()
        {
            this.salario += 1000;
        }
    }
}