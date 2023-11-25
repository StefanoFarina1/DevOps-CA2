using Calculator;
using NUnit.Framework;
namespace MyJourneyToWorkBDD.StepDefinitions;

[Binding]
public class SustainabilityWeightingSteps
{
    private Calculator.Calculator calculator;
    private double result;

    [Given(@"I have chosen '(.*)' as my transport mode")]
    public void GivenIHaveChosenAsMyTransportMode(string mode)
    {
        calculator = new Calculator.Calculator();
        calculator.transportMode = (TransportModes)Enum.Parse(typeof(TransportModes), mode);
    }

    [Given(@"I set the distance to '(.*)' miles")]
    public void GivenISetTheDistanceToMiles(int distance)
    {
        calculator.distance = distance;
        calculator.milesOrKms = DistanceMeasurement.miles;
    }

    [Given(@"I travel '(.*)' days a week")]
    public void GivenITravelDaysAWeek(int days)
    {
        calculator.numDays = days;
    }

    [When(@"I calculate the sustainability weighting")]
    public void WhenICalculateTheSustainabilityWeighting()
    {
        result = calculator.sustainabilityWeighting;
    }

    [Then(@"the result should be '(.*)'")]
    public void ThenTheResultShouldBe(int expected)
    {
        Assert.AreEqual(expected, result);
    }
}
