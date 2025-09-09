public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s= s.Trim();
        var result = s.Split(" ");
        return result[result.Length - 1].Length;
    }
}