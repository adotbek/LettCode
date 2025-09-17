public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        foreach(var ch in t)
        {
            if (!s.Contains(ch) || t.Count(x=>x==ch) > s.Count(x=>x==ch)) return ch;
        }
        return 'o';
    }
}