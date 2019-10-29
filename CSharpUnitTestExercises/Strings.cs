using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpUnitTestExercises
{

    /// These exercises give you a chance to work with strings in C#.

    public class Strings
    {
        /*
        * Return a greeting of the form "Hello <name>!". If no name
        * is given (the argument is null or blank), then this method
        * should return "Who are you?".
        * Note, you'll need to check for null or empty strings explicitly
        */
        public string Hello(string name)
        {
            return name.Length > 0 ? "Hello " + name + "!" : "Who are you?";
        }

        /*
         * Reverse the incoming strings. Be sure to check out the
         * This is actually more complicated than it looks, as the framework doesn't
         * have a string reversal method built in.
         * Optional: Write an extension method to reverse any string
        */
        public string Reverse(string input)
        {
            var inputArray = input.ToArray();
            Array.Reverse(inputArray);
            return new string(inputArray);
        }

        /*
         * Return the first "n" characters of the given string.
        */
        public string LeadingChars(string input, int n)
        {
            if (n > input.Length)
            {
                n = input.Length;
            }
            return input.Substring(0, n);
        }

        /*
        * Replace all vowels in the given string with the character "*".
        * There are a few ways to implement this method, including regular expressions
        */

        public string ReplaceVowels(string input)
        {
            return Regex.Replace(input, "[aeiou|AEIOU]", "*");
        }

        /*
        * (Advanced) Calculate the number of characters, number of
        * lines, number of single-letter words, number of hyphenated words and
        * the number of all caps words. Return the results in a dictionary with the
        * keys:
        *       "charCount"
        *       "lineCount"
        *       "singleLetterCount"
        *       "hyphenatedCount"
        *       "allCapsCount"
        * You can do this in a number of ways, but the easiest is probably
        * through regular expressions. Ted Naleid wrote an
        * <a href="http://naleid.com/blog/2008/05/19/dont-fear-the-regexp">old
        * but still useful blog post</a> about how Groovy incorporates regex
        * support at the language level. If you're new to Java regular expressions,
        * take a look through the
        * <a href="https://docs.oracle.com/javase/tutorial/essential/regex/">Java
        * tutorial</a> first.
        *
        * Ignore contractions, such as "there's". There won't be any in the
        * sample text. Line endings will always be Unix-style, i.e. '\n'.
        */
        public dynamic WordStats(string input)
        {
            string[] words = Regex.Split(input, " ");

            Dictionary<string, int> results = new Dictionary<string, int>();
            results.Add("charCount", input.Length);
            results.Add("lineCount", input.Length == 0 ? 0 : Regex.Split(input, "\n").Count());
            results.Add("singleLetterCount", words.Where(word => word.Length == 1).Count());
            results.Add("hyphenatedCount", words.Where(word => word.Contains("-")).Count());
            results.Add("allCapsCount", input.Length == 0 ? 0 : words.Where(word => word.ToUpper().Equals(word)).Count());

            return results;
        }
    }
}