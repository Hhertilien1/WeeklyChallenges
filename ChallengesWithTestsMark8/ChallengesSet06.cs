﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsword = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsword = lc.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsword = words.Contains(word);
            }

            return containsword;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {

            int index = -1;
            bool uindex;

            for(int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if (uindex == true)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
        }
    }
}
