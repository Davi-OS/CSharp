using System;
namespace OOP
{
    public class CartãoDeCredito
    {
        public string numero { get; set; }
        public string DataDeValidade { get; set; }

        //agregação
        public Cliente Cliente { get; set; }
    }
}