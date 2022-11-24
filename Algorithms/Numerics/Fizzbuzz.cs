namespace Algorithms.Numerics; 
public class Fizzbuzz 
{
    /// <summary>
    /// Given an integer n, return a string array answer (1-indexed) where:
    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i if non of the above conditions are true.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static string[] CalculateFizzbuzz(int n)
    {
        var result = new string[n];
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result[i - 1] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                result[i - 1] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                result[i - 1] = "Buzz";
            }
            else
            {
                result[i - 1] = i.ToString();
            }
        }
        return result;
    }
}
