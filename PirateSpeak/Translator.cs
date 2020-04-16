using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PirateSpeak
{
    public class Translator
    {
        public List<string> Translate(List<char> characters, List<string> pirateWords)
        {
            List<string> possiblePirateWords = new List<string>();
            foreach(string word in pirateWords)
            {
                var charWord = word.ToCharArray();
                var difference = characters.Except(charWord);
                if (!difference.Any())
                {
                    possiblePirateWords.Add(word);
                }
            }
            return possiblePirateWords;
        }
    }
}
