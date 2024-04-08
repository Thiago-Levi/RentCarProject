using RentCarProject.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject.services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;
        
        
        
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.EndDate.Subtract(carRental.StartDate);
            double basicPayment;

            if (duration.TotalHours <= 12)
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;

            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }



}
