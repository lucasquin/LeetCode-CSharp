namespace LeetCode;

public partial class Solution
{
    // https://leetcode.com/problems/roman-to-integer/
    // 17/10/2023
    public int RomanToInt(string s)
    {
        Dictionary<char, int> num = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var chars = s.ToCharArray();
        int result = 0;

        for (int i = 0; i < chars.Length - 1; i++)             
        {
            int next = num.First(c => c.Key == chars[i + 1]).Value;
            int current = num.First(c => c.Key == chars[i]).Value;

            result += (next > current ? -1 : 1) * current;       
        }

        return result + num.First(c => c.Key == chars[^1]).Value;
    }
}