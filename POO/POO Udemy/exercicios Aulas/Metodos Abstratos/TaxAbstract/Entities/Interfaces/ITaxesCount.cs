using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxAbstract.Entities.Interfaces
{
    interface ITaxesCount
    {
        string Name { get; set; }
        double AnualIncome { get; set; }
        public double TaxesToPay();
    }
}
