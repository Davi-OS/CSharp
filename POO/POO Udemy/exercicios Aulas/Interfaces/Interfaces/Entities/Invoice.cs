using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    class Invoice
    {
        public double Tax { get; set; }
        public double BasicPayment { get; set; }

        public Invoice(double tax, double basicPayment)
        {
            Tax = tax;
            BasicPayment = basicPayment;
        }

        public double TotalPayment()
        {
            return Tax + BasicPayment;
        }
        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment.ToString("F2")}" +
                $"\nTax: {Tax.ToString("F2")}" +
                $"\nTotal payment: {TotalPayment().ToString("F2")}";
        }
    }
}
