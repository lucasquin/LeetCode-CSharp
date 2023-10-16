namespace LeetCode;

public partial class Solution
{
    // https://leetcode.com/problems/palindrome-number/
    // 13/10/2023
    public bool IsPalindrome(int x)
    {
        var z = x.ToString().ToCharArray();
        Array.Reverse(z);
        return x.ToString() == new string(z);
    }

    // 13/10/2023
    public bool IsPalindrome_(int x)
    {
        var y = x.ToString().ToCharArray();
        var z = y.Reverse().ToArray();

        for (int i = 0; i < y.Length; i++)
            if(y[i] != z[i])
                return false;
        
        return true;
    }
}
