[Test]
public void TestSustainabilityWeightingCalculation()
{
    // Arrange
    Calculator calculator = new Calculator
    {
        distance = 20,
        milesOrKms = DistanceMeasurement.miles,
        numDays = 3,
        transportMode = TransportModes.electric
    };

    // Act
    double sustainabilityWeighting = calculator.sustainabilityWeighting;

    // Assert
    Assert.AreEqual(1.8, sustainabilityWeighting, 0.0001); // The sustainability weighting for electric transport mode should be 1.8
}

