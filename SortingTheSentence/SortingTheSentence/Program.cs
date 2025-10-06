    public class Solution
    {
        public string SortSentence(string s)
        {
            var splitedArray = s.Split(' ');
            var result = new string[splitedArray.Length];

            for (var i = 0; i < splitedArray.Length; i++)
            {
 
                var word = splitedArray[i];
                var index = word[^1] - '0';
                var gap = word[..^1];

                result[index - 1] = gap;
            }
            return string.Join(" ", result);
        }
    }