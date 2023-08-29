using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enteties
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product product { get; set; }
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
            this.product = product;
        }

        public double SubTotal()
        {
            double sum = this.Quantity * this.Price;
            return sum;
        }
    }
}
