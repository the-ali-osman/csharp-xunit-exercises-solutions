using CSharpUnitTestExercises;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Dynamic;
using Xunit;

namespace Tests
{
    public class StringsTest
    {
        Strings exercise = new Strings();

        /// <summary>
        /// Generate greeting for <paramref name="name"/>
        /// </summary>
        /// <param name="name">The name of the person</param>
        /// <param name="expected">The expected result</param>
        [Theory]
        [
            InlineData("Peter", "Hello Peter!"),
            InlineData("", "Who are you?"),
            InlineData("A", "Hello A!"),
            InlineData("习近平", "Hello 习近平!")
        ]
        public void Hello(string name, string expected)
        {

            Assert.Equal(expected, exercise.Hello(name));

        }

        /// <summary>
        /// Reverse the string <paramref name="input"/>
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="expected">The reversed string</param>
        [Theory]
        [
            InlineData("essay", "yasse"),
            InlineData("", ""),
            InlineData("A bat", "tab A"),
            InlineData("eye", "eye"),
            InlineData("习近平", "平近习")
        ]
        public void Reverse(string input, string expected)
        {
            Assert.Equal(expected, exercise.Reverse(input));
        }

        /// <summary>
        /// Extract the first <paramref name="n"/> characters of <paramref name="input"/>
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="n">The number of characters to return</param>
        /// <param name="expected">The first <paramref name="n"/> characters</param>
        [Theory]
        [
            InlineData("essay", 3, "ess"),
            InlineData("A bat", 0, ""),
            InlineData("conundrum", 1, "c"),
            InlineData("A bat", 10, "A bat"),
            InlineData("", 0, "")
        ]
        public void LeadingChars(string input, int n, string expected)
        {
            Assert.Equal(expected, exercise.LeadingChars(input, n));
        }

        /// <summary>
        /// Extract the first <paramref name="n"/> characters of <paramref name="input"/>
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="n">The number of characters to return</param>
        /// <param name="expected">The first <paramref name="n"/> characters</param>
        [Theory]
        [
            InlineData("essay", "*ss*y"),
            InlineData("uoiea", "*****"),
            InlineData("cnhsj", "cnhsj"),
            InlineData("A bat", "* b*t"),
        ]
        public void ReplaceVowels(string input, string expected)
        {
            Assert.Equal(expected, exercise.ReplaceVowels(input));
        }

        public static IEnumerable<object[]> WordStatsData()
        {
            return new[]
            {
                new object[] { "", new { charCount = 0, lineCount = 0, singleLetterCount = 0, hyphenatedCount = 0, allCapsCount = 0 } },
                new object[]{ "Hello world", new { charCount = 11, lineCount = 1, singleLetterCount = 0, hyphenatedCount = 0, allCapsCount = 0 } },
                new object[]{ "This is not a PARROT, it is a friendly-looking OWL.", new { charCount = 51, lineCount = 1, singleLetterCount = 2, hyphenatedCount = 1, allCapsCount = 2 } },
                new object[]{ @"There are various aspects to using test-driven development, 
for example the principles of 'keep it simple, stupid' KISS 
and 'You aren't gonna need it' YAGNI. 
By focusing on writing only the code necessary to pass tests, 
designs can often be cleaner and clearer than is achieved by 
other methods.", new {charCount = 305, lineCount = 6, singleLetterCount = 0, hyphenatedCount = 1, allCapsCount = 2 } }
            };
        }

        [Theory]
        [MemberData(nameof(WordStatsData))]
        public void WordStats(string input, dynamic expected)
        {
            var converter = new ExpandoObjectConverter();
            ExpandoObject expectedExpando = JsonConvert.DeserializeObject<ExpandoObject>(JsonConvert.SerializeObject(expected), converter);
            ExpandoObject result = JsonConvert.DeserializeObject<ExpandoObject>(JsonConvert.SerializeObject(exercise.WordStats(input)), converter);

            Assert.Equal(expectedExpando, result);
        }
    }
}