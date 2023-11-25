using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void CalculateTotalCarbonFootprint_Electric_ReturnsCorrectFootprint()
    {
        // Arrange
        Calculator calculator = new Calculator
        {
            distance = 50,
            milesOrKms = DistanceMeasurement.miles,
            numDays = 3,
            transportMode = TransportModes.electric
        };

        // Act
        double result = calculator.CarbonFootprint;

        // Assert
        Assert.AreEqual(0.02 * 50 * 3, result);
    }
}

