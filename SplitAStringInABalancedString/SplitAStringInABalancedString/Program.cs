public class Solution
{
    public int BalancedStringSplit(string s)
    {
        //"RLRRLLRLRL"
        var rCount = 0;
        var lCount = 0;
        var result = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'R')
            {
                rCount++;
            }
            else
            {
                lCount++;
            }
            if (rCount == lCount)
            {
                result++;
                rCount = 0;
                lCount = 0;
            }
        }
        return result;
    }
}