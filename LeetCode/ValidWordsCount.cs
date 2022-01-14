using System.Collections.Generic;
using System.Linq;

namespace Learning
{
    public class ValidWordsCount
    {
        public int CountValidWords(string sentence)
        {
            var punctuationMarks = new List<char> { '!', '.', ',' };
            var tokens = sentence.Split(" ").Where(s => s != "").ToList();
            var validWords = new List<string>();
            var validWords2 = new List<string>();
            int validWordsCount = 0;

            foreach (var token in tokens)
            {
                var areValidChars = token.All(t => (t >= 'a' && t <= 'z') || t == '-' || punctuationMarks.Contains(t));
                var isHypenValid = (!token.Any(t => t == '-') || token.Count(t => t == '-') == 1)
                    && token[0] != '-' && token[^1] != '-'
                    && token.Select((v, i) => new { car = v, index = i })
                            .Where(t => t.car == '-' && t.index > 0 && t.index < token.Length - 1)
                            .All(t => 
                            {
                                return token[t.index - 1] >= 'a' && token[t.index - 1] <= 'z' && (token[t.index + 1] >= 'a' && token[t.index + 1] <= 'z');
                            });
                var punctuationMarksCount = token.Count(t => punctuationMarks.Contains(t));
                var isPunctuationValid = punctuationMarksCount == 0
                    || (punctuationMarksCount == 1 && punctuationMarks.Contains(token[^1]));

                if (areValidChars && isHypenValid && isPunctuationValid)
                {
                    validWordsCount++; 
                }
            }

            return validWordsCount;
        }
    }
}