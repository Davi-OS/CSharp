using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxAbstract.Entities.Interfaces;

namespace TaxAbstract.Entities.Abstracts
{
    abstract class Count : ITaxesCount
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public virtual double TaxesToPay()
        {
            throw new NotImplementedException();
        }
    }
}
