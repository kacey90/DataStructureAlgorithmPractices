namespace Algorithms.Numerics;
public static class ClosestNumbers
{
    /// <summary>
    /// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int CalculateClosestNumbers(int[] input)
    {
        var result = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            var current = input[i] * input[i + 1];
            if (current > result)
            {
                result = current;
            }
        }
        return result;
    }
}
