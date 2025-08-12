public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = "";
        var shortest = strs.OrderBy(s => s.Length).First();
        for (var i = 0; i < shortest.Length; i++)
        {
            var s = shortest[i];
            foreach (var str in strs)
            {
                if (str[i] != s)
                {
                    return result;
                }
            }
            result += s;
        }
        return result;
    }
}