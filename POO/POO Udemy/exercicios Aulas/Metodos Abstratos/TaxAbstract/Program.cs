using System.Globalization;
using TaxAbstract.Entities;
using TaxAbstract.Entities.Abstracts;
namespace TaxAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Count> PayerList = new List<Count> ();
            double totalTaxes = 0;
            Console.WriteLine("Nubmer of tax payers:");
            int NPayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < NPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.WriteLine("Individual or Company?(i/c)");
                char c = char.Parse(Console.ReadLine());
                double income;
                string name;
                switch (c)
                {
                    case 'i':
                        Console.WriteLine("Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Anual Income:");
                        income = double.Parse(Console.ReadLine());
                        Console.WriteLine("Health Expenditures:");
                        double exped = double.Parse(Console.ReadLine());
                        Individual individual = new Individual(name, income,exped);
                        PayerList.Add(individual);
                        break;
                    case 'c':
                        Console.WriteLine("Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Anual Income:");
                        income = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nubemr of employees:");
                        int employees = int.Parse(Console.ReadLine());
                        Company company = new Company (name, income,employees);
                        PayerList.Add(company);
                        break;
                    default:
                        Console.WriteLine("incorret data!!");
                        break;
                }
            }
            Console.WriteLine("Taxes Paid:");

            foreach (var individual in PayerList)
            {
                Console.WriteLine($"{individual.Name}: $ {individual.TaxesToPay().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += individual.TaxesToPay();
            }
            Console.WriteLine($"Total Taxes: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}