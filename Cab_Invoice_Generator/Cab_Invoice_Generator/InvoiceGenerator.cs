using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        int COST_PER_KM, COST_PER_MIN, MIN_FARE;
        int totalFare=0,rideCount = 0;
        int[] fares;
        List<Rides> rides = new List<Rides>();
        Rides ride;

        public int FareCalculator(int distance,int time,int choice)
        {
            switch (choice)
            {
                case 1:
                    COST_PER_KM = 15;
                    COST_PER_MIN = 2;
                    MIN_FARE = 20;
                    break;
                case 2:
                    COST_PER_KM = 10;
                    COST_PER_MIN = 1;
                    MIN_FARE = 5;
                    break;
            }
            int totFare = (distance * COST_PER_KM) + (COST_PER_MIN * time) + MIN_FARE;
            return totFare;
        }
        public void SetMultipleRidesDetails(string userId,int distance, int time,int choice)
        {
            ride = new Rides();
            ride.RideDistance = distance;
            ride.RideTime = time;
            ride.RideChoice = choice;
            rides.Add(ride);
            if (RidesRepository.RideDetails.ContainsKey(userId))
            {
                RidesRepository.RideDetails[userId] = rides;
            }
            else
            {
                RidesRepository.RideDetails.Add(userId, rides);
            }
        }
        public int calculateAggregateTotalFare()
        {
            foreach (Rides ride in rides)
            {
                totalFare += FareCalculator(ride.RideDistance,ride.RideTime,ride.RideChoice);
            }
            return totalFare;
        }
        public int[] EnhancedInvoiceDetails()
        {
            int[] details = new int[3];
            details[0] = rides.Count();
            details[1] = calculateAggregateTotalFare();
            details[2] = (int)(details[1] / details[0]);
            return details;
        }
    }
}
