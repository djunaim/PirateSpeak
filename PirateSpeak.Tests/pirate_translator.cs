using System;
using Xunit;
using System.Collections.Generic;

namespace PirateSpeak.Tests
{
    public class pirate_translator
    {
        [Fact]
        public void translate_ortsp()
        {
            List<char> characters = new List<char> { 'o', 'r', 't', 's', 'p' };
            List<string> expectedResult = new List<string> { "sport", "ports" };
            List<string> pirateWords = new List<string> { "sport", "parrot", "ports", "matey" };
            var translator = new Translator();

            var actualResult = translator.Translate(characters, pirateWords);

            Assert.Equal(expectedResult, actualResult);
        }

    }
}
