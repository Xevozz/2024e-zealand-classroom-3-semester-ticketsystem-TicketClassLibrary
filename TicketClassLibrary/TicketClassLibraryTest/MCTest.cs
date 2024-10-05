using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace TicketClassLibrary.TicketClassLibraryTest;

    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class MCTest
    {
        [TestMethod()]
        [DataRow("")]
        public void LicenseplateTest_Valid(string expectedResult)
        {
            var mc = new MC ();

            mc.Licenseplate = expectedResult;

            string actualResult = mc.Licenseplate;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [DataRow("")]
        public void LicenseplateTest_notValid(string expectedResult)
        {
            var mc = new MC();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => mc.Licenseplate = expectedResult);
        }

        [TestMethod()]
        public void PriceTest()
        {
            var mc = new MC();

            double expectedResult = 240;

            double actualResult = mc.Price();

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void Price_With_Brobizz()
        {
            var mc = new MC();

            mc.BroBizz = true;

            double priceWithBrobizz = mc.Price();

            double expectedPrice = 240 * 0.95;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, priceWithBrobizz, delta);
        }

        [TestMethod()]
        public void Price_Without_Brobizz()
        {
            var mc = new MC();

            mc.BroBizz = false;

            double priceWithBrobizz = mc.Price();

            double expectedPrice = 240;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, priceWithBrobizz, delta);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new MC();

            string expectedResult = "Car";

            string actualResult = mc.VehicleType();

            Assert.AreEqual(expectedResult, actualResult);
        }

}