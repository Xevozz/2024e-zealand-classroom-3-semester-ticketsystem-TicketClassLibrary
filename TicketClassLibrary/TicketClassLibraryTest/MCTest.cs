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
            var mc = new Mc();

            Mc.LicensePlate = expectedResult;

            string actualResult = Mc.LicensePlate;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [DataRow("")]
        public void LicenseplateTest_notValid(string expectedResult)
        {
            var mc = new Mc();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Mc.LicensePlate = expectedResult);
        }

        [TestMethod()]
        public void PriceTest()
        {
            var mc = new Mc();

            double expectedResult = 240;

            double actualResult = mc.Price();

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void Price_With_Brobizz()
        {
            var mc = new Mc();

            mc.BroBizz = true;

            double priceWithBrobizz = mc.Price();

            double expectedPrice = 240 * 0.95;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, priceWithBrobizz, delta);
        }

        [TestMethod()]
        public void Price_Without_Brobizz()
        {
            var mc = new Mc();

            mc.BroBizz = false;

            double priceWithBrobizz = mc.Price();

            double expectedPrice = 240;

            double delta = 0.01;

            Assert.AreEqual(expectedPrice, priceWithBrobizz, delta);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new Mc();

            string expectedResult = "Car";

            string actualResult = mc.VehicleType();

            Assert.AreEqual(expectedResult, actualResult);
        }

}