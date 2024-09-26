namespace Averages;

public static class AverageCalculator
{
    public static double ArithmeticMean(string[] inputs)
    {
        return inputs.Select(numText => double.Parse(numText)).Average();
    }

}
