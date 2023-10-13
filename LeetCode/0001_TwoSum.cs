namespace LeetCode;

public partial class Solution
{
    // https://leetcode.com/problems/two-sum/

    // 13/10/2023
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = 0; j < nums.Length; j++)
                if (i != j && nums[i] + nums[j] == target)
                    return new int[] { i, j };

        return Array.Empty<int>();
    }

    // 11/10/2023
    public int[] TwoSum_(int[] nums, int target)
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
