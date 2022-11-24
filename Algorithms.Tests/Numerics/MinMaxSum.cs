namespace Algorithms.Tests.Numerics;
public class MinMaxSum
{
    public static void CalculateMinMaxSum(List<int> arr)
    {
        var min = arr.Min();
        var max = arr.Max();
        var sum = arr.Sum();
        Console.WriteLine($"{sum - max} {sum - min}");
    }
}
