using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class RidesRepository
    {
        InvoiceGenerator invoice = new InvoiceGenerator();  
        public static Dictionary<string,List<Rides>> RideDetails = new Dictionary<string,List<Rides>>();

        public int generateInvvoice(string userID)
        {
            int NoOfRides=0;
            if(RideDetails.ContainsKey(userID))
            {
                int total = 0;
                Console.WriteLine("Invoice for User - " + userID);
                NoOfRides = RideDetails[userID].Count();
                Console.WriteLine("Total Rides Taken -> " + NoOfRides);
                foreach(Rides ride in RideDetails[userID])
                {
                    total += invoice.FareCalculator(ride.RideDistance, ride.RideTime,ride.RideChoice);
                }
                Console.WriteLine("Total Aggregate cost -> " + total);
                Console.WriteLine("Average Aggregate cost -> " + (total/ userID.Count()));
                return NoOfRides;
            }
            return 0;
        }
    }
}
