using System;
using System.Collections.Generic;

namespace Task1
{
    public static class StringHelper
    {
        private static readonly List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

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
