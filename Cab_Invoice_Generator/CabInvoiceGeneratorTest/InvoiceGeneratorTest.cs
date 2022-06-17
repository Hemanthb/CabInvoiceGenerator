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
            invoiceGenerator = new Cab_Invoice_Generator.InvoiceGenerator();
            invoiceGenerator.SetMultipleRidesDetails(5, 5);
            invoiceGenerator.SetMultipleRidesDetails(10, 10);
            invoiceGenerator.SetMultipleRidesDetails(3, 5);
            int actualresult=invoiceGenerator.calculateAggregateTotalFare();
            Assert.That(actualresult, Is.EqualTo(215));
        }

    }
}