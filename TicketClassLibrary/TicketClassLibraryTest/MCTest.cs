using TicketClassLibrary.ModelView;
using Xunit;
using FluentAssertions;

namespace TicketClassLibrary.TicketClassLibraryTest;

/// <summary>
/// UnitTests for MC
/// </summary>
public class MCTest
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
        //Arrange
        var mc = new MC();
        mc.Licenseplate = licenseplate;
        
        //Act
        var act  = mc.Licenseplate;
        
        //Assert
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
        //Arrange
        var mc = new MC();
        
        //Act
        var act = () => mc.Licenseplate = licenseplate;
        
        //Assert
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
        var mc = new MC();
        var expectedResult = 125;

        // Act
        var act = mc.Price();

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
        var mc = new MC();
        mc.BroBizz = true;
        var expectedPrice = 125 * 0.95;

        // Act
        var act = mc.Price();

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
        var mc = new MC();
        mc.BroBizz = false;
        var expectedPrice = 240;

        // Act
        var act = mc.Price();

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
        var mc = new MC();
        var expectedResult = "MC";
        
        // Act
        var act = mc.VehicleType();
        
        // Assert
        act
            .Should()
            .Be(expectedResult);
    }
}