using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxAbstract.Entities.Abstracts;
using TaxAbstract.Entities.Interfaces;

namespace TaxAbstract.Entities
{
    class Individual : Count
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double income, double healthExpenditures)
        {
            this.Name = name;
            this.AnualIncome = income;
            HealthExpenditures = healthExpenditures;
        }
        public override double TaxesToPay()
        {
            double total = 0;
            if (this.AnualIncome < 20000)
            {
                total = this.AnualIncome * 0.15;
            }
            else
            {
                total = this.AnualIncome * 0.25;
            }

            total -= HealthExpenditures / 2;

            return total;

        }
    }
}
