using FluentAssertions;
using TicketClassLibrary.ModelView;
using Xunit;

namespace TicketClassLibrary.TicketClassLibraryTest;

/// <summary>
/// UnitTests for Car
/// </summary>
public class CarTests
{
    /// <summary>
    /// Tests the character-numbers in the Licenseplate
    /// and checks if they're consisting of 7 characters.
    /// </summary>
    /// <param name="licenseplate"></param>
    [Theory]
    [InlineData("AF25290")]
    public void LicenseplateTest_Valid(string licenseplate)
    {
        // Arrange
        var car = new Car();
        car.Licenseplate = licenseplate;

        // Act
        var act = car.Licenseplate;

        // Assert
        act
            .Should()
            .Be(licenseplate);
    }

    /// <summary>
    /// Tests the character-numbers in the Licenseplate
    /// and checks if they're consisting of over 7 characters.
    /// and gives an argumentexception if it's 8 or more characters.
    /// </summary>
    /// <param name="licenseplate"></param>
    [Theory]
    [InlineData("AF252902")]
    public void LicenseplateTest_notValid(string licenseplate)
    {
        // Arrange
        var car = new Car();

        // Act
        var act = () => car.Licenseplate = licenseplate;

        // Assert
        act
            .Should()
            .Throw<ArgumentException>();
    }

    /// <summary>
    /// Tests to see if the expected price is correct.
    /// </summary>
    [Fact]
    public void PriceTest()
    {
        // Arrange
        var car = new Car();
        var expectedResult = 240;

        // Act
        var act = car.Price();

        // Assert
        act
            .Should()
            .Be(expectedResult);
    }

    /// <summary>
    /// Tests to see if the expected price is correct
    /// and Discount is gives accordingly with the Brobizz
    /// </summary>
    [Fact]
    public void Price_With_Brobizz()
    {
        // Arrange
        var car = new Car();
        car.BroBizz = true;
        var expectedPrice = 240 * 0.95;

        // Act
        var act = car.Price();

        // Assert
        act
            .Should()
            .Be(expectedPrice);
    }

    /// <summary>
    /// Tests to see if the expected price is correct
    /// and Discount is gives accordingly with the Brobizz
    /// </summary>
    [Fact]
    public void Price_Without_Brobizz()
    {
        // Arrange
        var car = new Car();
        car.BroBizz = false;
        var expectedPrice = 240;

        // Act
        var act = car.Price();

        // Assert
        act
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
        var car = new Car();
        var expectedResult = "Car";
        
        // Act
        var act = car.VehicleType();
        
        // Assert
        act
            .Should()
            .Be(expectedResult);
    }
}