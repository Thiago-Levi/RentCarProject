using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject.services
{
    internal interface ITaxService
    {
        double Tax(double amount);
    }
}
