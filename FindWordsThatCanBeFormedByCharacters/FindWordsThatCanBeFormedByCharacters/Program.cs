// See https://aka.ms/new-console-template for more information
var sln = new Solution();
Console.WriteLine(sln.CountCharacters(["cat", "bt", "hat", "tree"], "atach"));




public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var result = 0;
        var helper = true;
        foreach (var word in words)
        {
            foreach (var ch in word)
            {
                if (word.Count(x => x == ch) <= chars.Count(x => x == ch))
                {
                    continue;
                }
                else
                {
                    helper = false;
                    break;
                }
            }
            if (helper)
            {
                result += word.Length;
                helper = true;
            }
        }
        return result;
    }
}