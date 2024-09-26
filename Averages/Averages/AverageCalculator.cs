namespace Averages;

public static class AverageCalculator
{
    public static double ArithmeticMean(string[] inputs)
    {
        if (inputs.Length == 0){
            Console.WriteLine("Empty input");
            return 0.0;
        }
        else {
            return inputs.Select(numText => double.Parse(numText)).Average();
        }
    }
}
