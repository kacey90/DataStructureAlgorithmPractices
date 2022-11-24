namespace Algorithms.Numerics;

/// <summary>
/// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

///Return the running sum of nums.
/// </summary>
public static class RunningSum
{
    /// <summary>
    /// Calculates the running sum of the given sequence.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int[] CalculateRunningSum(int[] nums)
    {
        var result = new int[nums.Length];
        result[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] + nums[i];
        }
        return result;
    }
}
