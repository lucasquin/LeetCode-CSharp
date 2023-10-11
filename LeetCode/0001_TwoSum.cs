namespace LeetCode;

public partial class Solution
{
    // https://leetcode.com/problems/two-sum/
    // 11/10/2023
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = Array.Empty<int>();

        for (int i = 0; i < nums.Length; i++)
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if ((nums[i] + nums[j]) == target)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[^1] = i;

                    Array.Resize(ref result, result.Length + 1);
                    result[^1] = j;

                    return result;
                }
            }
        
        return result;
    }
}
