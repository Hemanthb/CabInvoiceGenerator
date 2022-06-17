using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        int COST_PER_KM = 10, COST_PER_MIN = 1, MIN_FARE = 5;
        int totalFare;
        public int FareCalculator(int distance,int time)
        {
            totalFare = (distance * COST_PER_KM) + (COST_PER_MIN * time) + MIN_FARE;
            return totalFare;
        }
    }
}
