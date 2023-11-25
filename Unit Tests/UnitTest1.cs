[Test]
public void TestConvertDistanceMethod()
{
    // Arrange
    Calculator calculator = new Calculator
    {
        distance = 50,
        milesOrKms = DistanceMeasurement.kms
    };

    // Act
    double convertedDistance = calculator.convertDistance();

    // Assert
    Assert.AreEqual(31.0686, convertedDistance, 0.0001); // 50 kilometers should be approximately 31.0686 miles
}
