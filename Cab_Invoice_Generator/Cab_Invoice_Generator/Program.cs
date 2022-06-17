Cab_Invoice_Generator.InvoiceGenerator invoice = new Cab_Invoice_Generator.InvoiceGenerator();
int dist, time;
Console.WriteLine("------WELCOME TO CAB SUBSCRIPTION INVOICE GENERATOR------\n");

/* ------ UC-1 - SINGLE RIDE TOTAL FARE------*/
GetDetails();
Console.WriteLine("Total Fare for the given ride"+invoice.FareCalculator(dist,time)+"\n");

/* ------ UC-2 - MULTIPLE RIDES AGGREGATE FARE------*/
Console.WriteLine("Enter the number of rides taken");
int noOfRides = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < noOfRides; i++)
{
    GetDetails();
    invoice.SetMultipleRidesDetails(dist,time);
}
//Console.WriteLine("Total aggregate for "+noOfRides+" rides -> Rs. "+invoice.calculateAggregateTotalFare());

void GetDetails()
{
    Console.WriteLine("Enter the distance travelled");
    dist = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the time taken for travel in mins");
    time = Convert.ToInt32(Console.ReadLine());
}
/* ------ UC-3 - MULTIPLE RIDES INVOICE------*/
int[] details = new int[noOfRides];
details = invoice.EnhancedInvoiceDetails();
Console.WriteLine("Total Rides  : " + details[0]);
Console.WriteLine("Total Fare   : " + details[1]);
Console.WriteLine("Average Fare : " + details[2]);

