using System;
namespace OOP
{
    public class GerenteDeTi : Gerente
    {
        // override = sobrepor ( sobrepoem o metodo da classe abstratc funcionario)
        public override void reajustar()
        {
            this.salario += 2000;
        }
    }
}