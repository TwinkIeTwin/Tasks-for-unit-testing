﻿using System;
using System.Collections.Generic;

namespace Task1
{
    /// <summary>
    /// contains additional methods for strings.
    /// </summary>
    public static class StringHelper
    {
        private static readonly List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        /// <summary>
        /// returns count of vowels from input string.
        /// </summary>
        /// <param name="str">input string.</param>
        /// <returns>count of Vowels. </returns>
        /// <example>
        /// <code>
        /// string s = "aaabb";
        /// int c = StringHelper.GetVowelCount(s);
        /// if (c == s.Length)
        /// {
        ///     Console.WriteLine("whole the string cosist from vowels!");
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.ArgumentNullException">Thrown when str parameter is null.
        /// </exception>
        /// /// <exception cref="System.ArgumentException">Thrown when str is empty.
        /// </exception>
        public static int GetVowelCount(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str), "string can not be null");
            }
            else if (str.Length == 0)
            {
                throw new ArgumentException("string can not be empty.");
            }
            else
            {
                int countOfVowels = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < Vowels.Count; j++)
                    {
                        if (str[i] == Vowels[j])
                        {
                            countOfVowels++;
                            break;
                        }
                    }
                }

                return countOfVowels;
            }
        }
    }
}
