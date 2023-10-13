namespace LeetCode;

public partial class Solution
{
    // https://leetcode.com/problems/palindrome-number/
    // 13/10/2023
    public bool IsPalindrome(int x)
    {
        var y = x.ToString().ToCharArray();
        var z = y.Reverse().ToArray();

        for (int i = 0; i < y.Length; i++)
            if(y[i] != z[i])
                return false;
        
        return true;
    }
}
