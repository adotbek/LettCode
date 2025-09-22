public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n is 1) return n;
        if (n is 2) return n;

        var first = 1;
        var second = 2;
        var result = 0;
        for (var i = 3; i <= n; i++)
        {
            result = first + second;
            first = second;
            second = result;
        }
        return second;
    }
}