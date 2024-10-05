using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.ModelView;
using TicketClassLibrary;

namespace OreSundBroen.OreSundBroenTest;

[ExcludeFromCodeCoverage]
[TestClass()]
public class OreSundBroenMCTest
        {
            [TestMethod()]
                   public void Price_With_Brobizz()
                    {
                        var oresundMC = new OresundMC();
                        
                        OresundMC.BroBizz = true;
            
                        double priceWithBrobizz = OresundMC.Price();
                        
                        double expectedPrice = 161
                        
                        Assert.AreEqual(actualPrice, expectedPrice);
                    }
                    
                    [TestMethod()]
                    public void Price_Without_Brobizz()
                    {
                        var oresundMC = new OresundMC();
                        
                        oresundCar.BroBizz = false;
            
                        double priceWithBrobizz = OresundMC.Price();
                        
                        double expectedPrice = 410;
                        
                        Assert.AreEqual(actualPrice, expectedPrice);
                    }
            
                    [TestMethod()]
                    public void VehicleTypeTest()
                    {
                        var oresundMC = new OresundMC();
                        
                        string actualVehicleType = OresundMC.VehicleType();
                        
                        string expectedvehicleType = "Oresund MC"();
                        
                        Assert.AreEqual(actualVehicleType, expectedvehicleType);
                    }
                    
        }