using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class OutsurcedEmployee : Employee
    {
        public double additionalCharge { get; set; }
     

        public OutsurcedEmployee(string name, int hour, double value, double additionalChange) : base(name, hour, value)
        {
            this.additionalCharge = additionalChange;
            this.Name = name;
            this.hours = hours;
        }


        public override double Payment()
        {
            return base.Payment() + additionalCharge * 1.1;
        }
    }
}
