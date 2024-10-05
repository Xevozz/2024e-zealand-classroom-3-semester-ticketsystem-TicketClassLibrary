using FluentAssertions;
using Xunit;

namespace OreSundBroen.OreSundBroenTest;

public class OreSundBroenMCTest
{
    /// <summary>
    /// Tests if the Price with BroBizz - expectedprice = 73 kr.
    /// </summary>
    [Fact]
    public void Price_With_Brobizz()
    {
        // Arrange
        var oresundMC = new OresundMc();
        oresundMC.BroBizz = true;
        var expectedPrice = 73;

        // Act
        var priceWithBrobizz = oresundMC.Price();

        // Assert
        priceWithBrobizz
            .Should()
            .Be(expectedPrice);
    }

    /// <summary>
    /// Tests if the Price with BroBizz - expectedprice = 210 kr.
    /// </summary>
    [Fact]
    public void Price_Without_Brobizz()
    {
        // Arrange
        var oresundMC = new OresundMc();
        oresundMC.BroBizz = false;
        var expectedPrice = 210;

        // Act
        var priceWithBrobizz = oresundMC.Price();
        
        // Assert
        priceWithBrobizz
            .Should()
            .Be(expectedPrice);
    }

    /// <summary>
    /// Tests if the Vehicletype is correct
    /// </summary>
    [Fact]
    public void VehicleTypeTest()
    {
        // Arrange
        var oresundMc = new OresundMc();
        var expectedvehicleType = "Oresund MC";
        
        // Act
        var actualVehicleType = oresundMc.VehicleType();

        // Assert
        actualVehicleType
            .Should()
            .Be(expectedvehicleType);
    }
}