using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxAbstract.Entities.Abstracts;
using TaxAbstract.Entities.Interfaces;

namespace TaxAbstract.Entities
{
    internal class Company : Count
    {
        public int NumberEmployees { get; set; }
        public Company(string name, double income, int numberEmploees)
        {

            this.Name = name;
            this.AnualIncome = income;
            NumberEmployees = numberEmploees;
        }
        public override double TaxesToPay()
        {
            double total = 0;
            if (this.NumberEmployees > 10)
            {
                total = this.AnualIncome * 0.14;
            }
            else
            {
                total = this.AnualIncome * 0.16;
            }
            return total;
        }
    }
}
