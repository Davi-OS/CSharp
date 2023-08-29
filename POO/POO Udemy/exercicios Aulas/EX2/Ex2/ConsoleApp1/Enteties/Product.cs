using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enteties
{
    internal class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
