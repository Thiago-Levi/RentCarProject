using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using RentCarProject.entities;
using RentCarProject.services;

namespace RentCarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental car:");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(startDate, endDate, new Vehicle(model));

            Console.WriteLine("Enter price per hour");
            double pricePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day");
            double pricePerDay = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine(carRental.Invoice);

        }
    }
}
