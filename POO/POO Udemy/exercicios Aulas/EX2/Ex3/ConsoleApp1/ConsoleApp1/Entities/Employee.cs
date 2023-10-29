using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }

        public Employee(string name, int hour, double value)
        {
            this.valuePerHour = value;
            this.Name = name;
            this.hours = hour;
        }

        public virtual double Payment()
        {
            return valuePerHour * hours;
        }
    }
}
