using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface IConta
    {
        //Contratos devem ser seguidos por Conta;
        void Depositar(double valor);
        void AdicionarLimite(double valor);
        bool Sacar(double valor);
        double ConsultaSaldo();
    }
}