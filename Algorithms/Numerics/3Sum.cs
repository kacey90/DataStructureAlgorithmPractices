﻿using System.Security.Cryptography;

namespace Algorithms.Numerics; 
public class _3Sum 
{/// <summary>
 /// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.


 /// Notice that the solution set must not contain duplicate triplets.
/// </summary>
/// <param name="nums"></param>
/// <returns></returns>
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                int low = i + 1;
                int high = nums.Length - 1;
                int sum = 0 - nums[i];
                while (low < high)
                {
                    if (nums[low] + nums[high] == sum)
                    {
                        result.Add(new List<int> { nums[i], nums[low], nums[high] });
                        while (low < high && nums[low] == nums[low + 1]) low++;
                        while (low < high && nums[high] == nums[high - 1]) high--;
                        low++;
                        high--;
                    }
                    else if (nums[low] + nums[high] < sum) low++;
                    else high--;
                }
            }
        }
        return result;
    }
}
