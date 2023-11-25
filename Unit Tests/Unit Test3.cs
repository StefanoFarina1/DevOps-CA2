[Test]
public void TestCarbonFootprintCalculation()
{
    // Arrange
    Calculator calculator = new Calculator
    {
        distance = 30,
        milesOrKms = DistanceMeasurement.miles,
        numDays = 5,
        transportMode = TransportModes.deisel
    };

    // Act
    double carbonFootprint = calculator.CarbonFootprint;

    // Assert
    Assert.AreEqual(27, carbonFootprint, 0.0001); // The carbon footprint for diesel transport mode should be 27
}
