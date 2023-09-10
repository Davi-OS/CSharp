using LINQ___LAMBDA.Entities;
using System.Linq;
namespace LINQ___LAMBDA
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


            var R1 = products.Where(p => p.Category.Tier == 1 && p.Price <= 900.00);
            Print("Tier 1 and Price < 900:", R1);

            var R2 = products.Where(p => p.Category.Name == "Tools").Select(P => P.Name);
            Print("Name of products from tools:", R2);

            var R3 = products.Where(P => P.Name.StartsWith("C")).Select(P => new { P.Name, P.Price, CategoryName = P.Category.Name });
            Print("Name of products Stars with C :", R3);

            var R4 = products.Where(p => p.Category.Tier == 1).OrderBy(P => P.Price).ThenBy(P => P.Name);
            Print("Tier 1 Order by price and name:", R4);

            var R5 = R4.Skip(2).Take(4);
            Print("Tier 1 Order by price and name skip 2 and take 4:", R5);

            var R6 = products.First();
            Console.WriteLine("First test 1: " + R6);

            var R7 = products.Where(P => P.Price > 3000).FirstOrDefault();
            Console.WriteLine("First test 2: " + R7);

            var R8 = products.Where(P => P.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default test 1: " + R8);

            var R9 = products.Where(P => P.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Default test 2: " + R9);

            var R10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price " + R10);

            var R11 = products.Min(p => p.Price);
            Console.WriteLine("Minimal Price " + R11);

            var R12 = products.Where(P => P.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + R12);

            var R13 = products.Where(P => P.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + R13);

            var R14 = products.Where(P => P.Category.Id == 5).Select(P => P.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Category 5 Average prices: " + R14);

            // map reduce 

            var R15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 agregate sum: " + R15);

            Console.WriteLine();

            var R16 = products.GroupBy(p => p.Category);
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