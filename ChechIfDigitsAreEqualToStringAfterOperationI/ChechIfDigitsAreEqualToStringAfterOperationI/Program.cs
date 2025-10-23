public class Solution
{
    public bool HasSameDigits(string s)
    {
        var s1 = string.Empty;
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (s.Length <= 2)
            {
                break;
            }
            var a = s[i] - '0' + s[i + 1] - '0';
            s1 = s1 + $"{a%10}";
            if (i + 2 == s.Length)
            {
                s = s1;
                s1 = string.Empty;
                i = -1;
            }
        }
        return s[0] == s[1];

    }
}