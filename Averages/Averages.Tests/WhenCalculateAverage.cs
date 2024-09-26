using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Averages.Tests;

[TestClass]
public class WhenCalculateAverage
{
    [TestMethod]
    public void SingleInputProduceSameResult()
    {
        string[] inputs = { "1" };
        double result = AverageCalculator.ArithmeticMean(inputs);
        Assert.AreEqual(1.0, result, 1E-14);       
    }

    [TestMethod]
    public void MultipleInputsProduceAverageAsResult()
    {
        string[] inputs = { "1", "2", "3" };
        double result = AverageCalculator.ArithmeticMean(inputs);
        Assert.AreEqual(2.0, result, 1E-14);
    }
}