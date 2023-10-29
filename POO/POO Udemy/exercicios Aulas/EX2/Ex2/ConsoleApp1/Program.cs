using ConsoleApp1.Enteties;
using ConsoleApp1.Enteties.Enums;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.WriteLine("Name:");
            string clienteName = Console.ReadLine();
            Console.WriteLine("Email:");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Birthday (DD/MM/YYYY):");
            string clientBDay = Console.ReadLine();
            Client client = new Client(clienteName, clientEmail, clientBDay);
            Console.Clear();

            Console.WriteLine("Enter Order data:");
            Console.WriteLine("Status (PedingPayment, Processing, Shipped ,Delivered :");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many Itens ?");
            int nItens = int.Parse(Console.ReadLine());
            Order order = new Order(client, status);
            Console.Clear();

            for (int i = 0; i < nItens; i++)
            {
                Console.WriteLine($"Enter produtc {i + 1} Data:");
                Console.WriteLine("Enter Name:");
                string producName = Console.ReadLine();
                Console.WriteLine("Enter price:");
                double productPrice = double.Parse(Console.ReadLine());
                Product product = new Product(producName, productPrice);
                Console.WriteLine("Enter quantity:");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, product);
                order.Itens.Add(orderItem);
            }

            order.Sumarry();
           
        }
    }
}