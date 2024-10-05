using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace TicketClassLibrary.TicketClassLibraryTest;

    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        [DataRow("")]
        public void LicenseplateTest_Valid(string expectedResult)
        {
            var car = new Car();
            
            car.Licenseplate = expectedResult;
            
            string actualResult = car.Licenseplate;
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        [DataRow("    ")]
        public void LicenseplateTest_notValid(string expectedResult)
        {
            var car = new Car();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Licenseplate = expectedResult);
        }

        [TestMethod()]
        public void PriceTest()
        {
            var car = new Car();

            double expectedResult = 240;
            
            double actualResult = car.Price();
            
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod()]
        public void Price_With_Brobizz()
        {
            var car = new Car();
            
            car.BroBizz = true;

            double priceWithBrobizz = car.Price();
            
            double expectedPrice = 240 * 0.95;
            
            double delta = 0.01;
            
            Assert.AreEqual(expectedPrice, priceWithBrobizz, delta);
        }
        
        [TestMethod()]
        public void Price_Without_Brobizz()
        {
            var car = new Car();
            
            car.BroBizz = false;

            double priceWithBrobizz = car.Price();
            
            double expectedPrice = 240;
            
            double delta = 0.01;
            
            Assert.AreEqual(expectedPrice, priceWithBrobizz, delta);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new Car();
            
            string expectedResult = "Car";
            
            string actualResult = car.VehicleType();
            
            Assert.AreEqual(expectedResult, actualResult);
        }
        
    }