using ConsoleApp1.Enteties.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enteties
{
    internal class Order
    {
        public DateTime Moment = new DateTime();
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order(Client client, OrderStatus status)
        {
            this.Client = client;
            this.Moment = DateTime.Now;
            this.Status = status;

        }
        public void RemoveItem(OrderItem Item) { Itens.Remove(Item); }
        public void AddItem(OrderItem Item) { Itens.Add(Item); }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Itens)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public void Sumarry()
        {
            Console.Clear();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order Moment:{this.Moment.ToString("dd/mm/yyyy HH:mm:ss")}");
            Console.WriteLine($"Order Status:{this.Status}");
            Console.WriteLine($"Client:{this.Client.Name} ({this.Client.birthDay.ToString("dd/mm/yyyy")}) - {this.Client.Email}");
            Console.WriteLine("Order Itens:");
            foreach (OrderItem item in Itens)
            {
                Console.WriteLine($"{item.product.Name}, ${item.Price.ToString("F2")}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2")}");
            }
            Console.WriteLine($"Total price {this.Total().ToString("F2")}");
        }
    }
}
