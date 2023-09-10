

using LINQ___LAMBDA.Entities;
using System.Linq;
namespace LINQ___SQL
{
    internal class Program
    {
        static void Print<T>(string mensage, IEnumerable<T> values)
        {
            Console.WriteLine(mensage);
            foreach (T obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category C1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category C2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category C3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){ Id= 1, Name = "Computer", Price = 1100.00, Category = C2},
                new Product(){ Id= 2, Name = "Hammer", Price = 90, Category = C1},
                new Product(){ Id= 3, Name = "TV", Price = 1700, Category = C3},
                new Product(){ Id= 4, Name = "Notebook", Price = 1300.00, Category = C2},
                new Product(){ Id= 5, Name = "Saw", Price = 80, Category = C1},
                new Product(){ Id= 6, Name = "Tablet", Price = 700, Category = C2},
                new Product(){ Id= 7, Name = "Camera", Price = 700, Category = C3},
                new Product(){ Id= 8, Name = "Printer", Price = 350, Category = C3},
                new Product(){ Id= 9, Name = "MacBok", Price = 1800, Category = C2},
                new Product(){ Id= 10, Name = "Sound Bar", Price = 700, Category = C3},
                new Product(){ Id= 11, Name = "Level", Price = 70, Category = C1}
            };


            var R1 =
            from p in products
            where p.Category.Tier == 1 && p.Price < 900.0
            select p;
            Print("Tier 1 and Price < 900:", R1);

            var R2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;
            Print("Name of products from tools:", R2);

            var R3 = from p in products
                     where p.Name[0] == 'C'
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };
            Print("Name of products Stars with C :", R3);

            var R4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
            Print("Tier 1 Order by price and name:", R4);

            var R5 = (from p in R4 select p).Skip(2).Take(4);
            Print("Tier 1 Order by price and name skip 2 and take 4:", R5);

            var R6 = (from p in products select p).First();
            Console.WriteLine("First test 1: " + R6);

            var R7 = (from p in products
                      where p.Price > 3000.0
                      select p).FirstOrDefault();
            Console.WriteLine("First test 2: " + R7);

            Console.WriteLine();

            var R16 = from p in products
                      group p by p.Category;
            foreach (IGrouping<Category, Product> group in R16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
    }
}
