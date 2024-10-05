using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace OreSundBroen.OreSundBroenTest;

[ExcludeFromCodeCoverage]
[TestClass()]
public class OresundBroenCarTest
{
    
      [TestMethod()]
      public void Price_With_Brobizz()
      {
           var oresundCar = new OresundCar();
                                                                    
           oresundCar.BroBizz = true;
                                                        
           double priceWithBrobizz = oresundCar.Price();
                                                                    
           double expectedPrice = 161
                                                                    
           Assert.AreEqual(actualPrice, expectedPrice);
       }
                            
       [TestMethod()]
       public void Price_Without_Brobizz()
       {
           var oresundCar = new OresundCar();
                                    
           oresundCar.BroBizz = false;
                        
           double priceWithBrobizz = oresundCar.Price();
                                    
           double expectedPrice = 410;
                                    
           Assert.AreEqual(actualPrice, expectedPrice);
        }
                    
        [TestMethod()]
        public void VehicleTypeTest()
        {
           var oresundCar = new OresundCar();
                                
           string actualVehicleType = oresundCar.VehicleType();
                                
           string expectedvehicleType = "Oresund Car"();
                                
           Assert.AreEqual(actualVehicleType, expectedvehicleType);
        }
}