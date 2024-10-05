using FluentAssertions;
using Xunit;

namespace OreSundBroen.OreSundBroenTest;

/// <summary>
/// UnitTests for OreSundsbroen
/// </summary>
public class OresundBroenCarTest
{
    /// <summary>
    /// Tests if the Price with BroBizz - expectedprice = 161 kr.
    /// </summary>
    [Fact]
    public void Price_With_Brobizz()
    {
        // Arrange
        var oresundCar = new OresundCar();
        oresundCar.BroBizz = true;
        var expectedPrice = 161;

        // Act
        var priceWithBrobizz = oresundCar.Price();

        // Assert
        priceWithBrobizz
            .Should()
            .Be(expectedPrice);
    }

    /// <summary>
    /// Tests if the Price without BroBizz - expectedprice = 410 kr.
    /// </summary>
    [Fact]
    public void Price_Without_Brobizz()
    {
        // Arrange
        var oresundCar = new OresundCar();
        oresundCar.BroBizz = false;
        var expectedPrice = 410;

        // Act
        var priceWithBrobizz = oresundCar.Price();

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
        var oresundCar = new OresundCar();
        var expectedvehicleType = "Oresund Car";

        // Act
        var actualVehicleType = oresundCar.VehicleType();

        // Assert
        actualVehicleType
            .Should()
            .Be(expectedvehicleType);
    }
}