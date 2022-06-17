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
        int totalFare=0,rideCount = 0;
        int[] fares;
        List<Rides> rides = new List<Rides>();
        Rides ride;

        public int FareCalculator(int distance,int time)
        {
            int totFare = (distance * COST_PER_KM) + (COST_PER_MIN * time) + MIN_FARE;
            return totFare;
        }
        public void SetMultipleRidesDetails(int distance, int time)
        {
            ride = new Rides();
            ride.RideDistance = distance;
            ride.RideTime = time;
            rides.Add(ride);
            
        }
        public int calculateAggregateTotalFare()
        {
            foreach (Rides ride in rides)
            {
                totalFare += FareCalculator(ride.RideDistance,ride.RideTime);
            }
            return totalFare;
        }
    }
}
