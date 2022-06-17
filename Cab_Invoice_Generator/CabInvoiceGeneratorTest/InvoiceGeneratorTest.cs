namespace CabInvoiceGeneratorTest
{
    public class InvoiceGeneratorTest
    {
        Cab_Invoice_Generator.InvoiceGenerator invoiceGenerator = null;
        [Test]
        public void GivenTimeAndDistance_CalculateTotalFare_ReturnsTotalFare()
        {
            int distanceInKms = 3, timeInMins = 5;
            invoiceGenerator = new Cab_Invoice_Generator.InvoiceGenerator();
            int actualresult=invoiceGenerator.FareCalculator(3, 5);
            Assert.AreEqual(40, actualresult);
        }
        [Test]
        public void GivenMultipleRides_FindAggregateFare_ReturnTotalFare()
        {
            string user = "hem1";
            invoiceGenerator = new Cab_Invoice_Generator.InvoiceGenerator();
            invoiceGenerator.SetMultipleRidesDetails(user,5, 5);
            invoiceGenerator.SetMultipleRidesDetails(user,10, 10);
            invoiceGenerator.SetMultipleRidesDetails(user,3, 5);
            int actualresult=invoiceGenerator.calculateAggregateTotalFare();
            Assert.That(actualresult, Is.EqualTo(215));
        }
        [Test]
        public void GivenDictionary_StoreData_ReturnCountOfUserRides()
        {
            Cab_Invoice_Generator.Rides rides1 = new Cab_Invoice_Generator.Rides();
            rides1.RideTime = 1;
            rides1.RideDistance = 1;
            Cab_Invoice_Generator.Rides rides2 = new Cab_Invoice_Generator.Rides();
            rides1.RideTime = 2;
            rides1.RideDistance = 1;
            Cab_Invoice_Generator.RidesRepository rides = new Cab_Invoice_Generator.RidesRepository();
            Cab_Invoice_Generator.RidesRepository.RideDetails.Add("sai", new List<Cab_Invoice_Generator.Rides>() { rides1 });
            Cab_Invoice_Generator.RidesRepository.RideDetails.Add("sai", new List<Cab_Invoice_Generator.Rides>() { rides2 });
            int actualResult = rides.generateInvvoice("sai");
            Assert.That(actualResult, Is.EqualTo(2));
        }

    }
}