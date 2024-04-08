using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject.entities
{
    internal class CarRental
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime startDate, DateTime endDate, Vehicle vehicle)
        {
            StartDate = startDate;
            EndDate = endDate;
            Vehicle = vehicle;
            Invoice = null;

        }

    }
}
