using System.Net.WebSockets;
using System.Runtime.Serialization.Formatters;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');
        if (pattern.Length != words.Length) return false;
        var charToWord = new Dictionary<char, string>();
        var wordToChar = new Dictionary<string, char>();
        var c = ' ';
        var w = " ";
        for (var i = 0; i < pattern.Length; i++)
        {
            c = pattern[i];
            w = words[i];
            if (charToWord.ContainsKey(c))
            {
                if (charToWord[c] != w) return false;
            }
            else
            {
                if (wordToChar.ContainsKey(w)) return false;
                charToWord[c] = w;
                wordToChar[w] = c;
            }

        }
        return true;

    }
}