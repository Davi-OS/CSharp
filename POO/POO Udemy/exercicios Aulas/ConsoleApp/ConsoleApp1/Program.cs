using ConsoleApp1.Entitie;
using ConsoleApp1.Entitie.Enums;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Departament:");
            string departament = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level  (Junior, MidLevel, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary:");
            double Bsalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departament dpt = new Departament(departament);
            Worker worker = new Worker(name, level, Bsalary, dpt);

            Console.WriteLine("How many contracts for this worker ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} contract:");
                Console.WriteLine("Enter Data ( DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours):");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string monthandYear = Console.ReadLine();
            int month = int.Parse(monthandYear.Substring(0, 2));
            int year = int.Parse(monthandYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthandYear}: {worker.income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}