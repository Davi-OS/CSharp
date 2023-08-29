using Interfaces.Entities;
using Interfaces.Entities.Services;
using System.Globalization;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.WriteLine("Car Model:");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup  (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("Return  (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter Price Hour:");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price Day:");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService retalService = new RentalService(hour, day, new BrazilTaxService());
            retalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}