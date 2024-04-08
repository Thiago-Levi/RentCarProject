﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RentCarProject.services
{
    internal class BrazilTaxService : ITaxService
    {

        public double Tax(double amount)
        {

            if (amount <= 100.0)
            {
                return amount * 0.2;
            }

            return amount * 0.15;
        }

    }
}
