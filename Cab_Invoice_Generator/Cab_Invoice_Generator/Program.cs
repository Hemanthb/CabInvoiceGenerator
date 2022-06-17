Cab_Invoice_Generator.InvoiceGenerator invoice = new Cab_Invoice_Generator.InvoiceGenerator();
Console.WriteLine("------WELCOME TO CAB SUBSCRIPTION INVOICE GENERATOR------\n");

Console.WriteLine("Enter the distance travelled");
int dist = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the time taken for travel in mins");
int time = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Total Fare for the given ride"+invoice.FareCalculator(dist,time));