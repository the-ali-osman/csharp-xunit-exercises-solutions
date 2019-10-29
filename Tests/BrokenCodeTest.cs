using CSharpUnitTestExercises;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class BrokenCodeTest
    {
        BrokenCode exercise = new BrokenCode();

        /// <summary>
        /// Sum the numbers in <paramref name="numbers"/>
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <param name="expected">The sum of the numbers</param>
        [Theory]
        [
            InlineData(new int[] { }, 0),
            InlineData(new int[] { 5 }, 5),
            InlineData(new int[] { 1, 2, 3 }, 6)
        ]
        public void SumNumbers(IEnumerable<int> numbers, int expected)
        {
            Assert.Equal(expected, exercise.SumNumbers(numbers));
        }

        /// <summary>
        /// Reverse each of the strings passed in <paramref name="input"/>
        /// </summary>
        /// <param name="input">A list of strings</param>
        /// <param name="expected">A list of strings, where each string has been reversed</param>
        [Theory]
        [
            InlineData(new string[] { null }, new string[] { null }),
            InlineData(new string[] { }, new string[] { }),
            InlineData(new string[] { "abc" }, new string[] { "cba" }),
            InlineData(new string[] { "abc", "eye", "dally" }, new string[] { "cba", "eye", "yllad" }),
        ]
        public void ReverseStrings(IEnumerable<string> input, IEnumerable<string> expected)
        {
            Assert.Equal(expected, exercise.ReverseStrings(input));
        }

        /// <summary>
        /// Reverse each of the strings passed in <paramref name="input"/> using an alternate method
        /// </summary>
        /// <param name="input">A list of strings</param>
        /// <param name="expected">A list of strings, where each string has been reversed</param>
        [Theory]
        [
            InlineData(new string[] { null }, new string[] { null }),
            InlineData(new string[] { }, new string[] { }),
            InlineData(new string[] { "abc" }, new string[] { "cba" }),
            InlineData(new string[] { "abc", "eye", "dally" }, new string[] { "cba", "eye", "yllad" }),
        ]
        public void AltReverseStrings(string[] input, string[] expected)
        {
            Assert.Equal(expected, exercise.AltReverseStrings(input));
        }
    }
}