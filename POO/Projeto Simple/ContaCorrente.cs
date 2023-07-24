using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //Conta corrente herda tudo da Classe abstrata Conta;
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int Numero, double limite) : base(Numero, limite)
        {

        }
    }
}