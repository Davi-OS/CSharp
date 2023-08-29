using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();
            int n;
            Console.WriteLine("Enter the number of employees:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine("Enter Employee Data:");
                Console.WriteLine("Name:");
                string emploeeyName = Console.ReadLine();
                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double ValPerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Outsourced? (y/n)");
                char Outsourced = char.Parse(Console.ReadLine());

                if (Outsourced == 'y')
                {
                    Console.WriteLine("Additinal charge:");
                    double AddCharge = double.Parse(Console.ReadLine());
                    Employee employee = new OutsurcedEmployee(emploeeyName,hours,ValPerHour,AddCharge);
                    listEmployee.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(emploeeyName,hours,ValPerHour); 
                    listEmployee.Add(employee);
                }

            }
            Console.Clear();
            Console.WriteLine("Payments:");
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2")}");
            }


        }
    }
}