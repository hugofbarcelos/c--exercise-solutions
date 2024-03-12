using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            string answer = word;
            string[] words = word.Split(' ');

            if (String.IsNullOrEmpty(word)) return word;
            if (word == " ") return " ";
            return answer.Replace(
                    word.Substring(0, words[0].Length),
                    words[0].Replace(
                        word.Substring(0, 1),
                        word.Substring(0, 1).ToUpper())
                   );
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            char[] FirstLetter = firstName.Substring(0, 1)
                                          .ToUpper()
                                          .ToCharArray();
            char[] LastLetter = lastName.Substring(0, 1)
                                        .ToUpper()
                                        .ToCharArray();

            return FirstLetter[0] + "." + LastLetter[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            double answer = originalPrice * (vatRate / 100 + 1);
            return Math.Round(answer, 2);
        }

        public string Reverse(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            string answer = "";

            if (String.IsNullOrEmpty(sentence)) return sentence;
            foreach (var item in chars.Reverse())
            {
                answer += item;
            }
            return answer;
        }

        public int CountLinuxUsers(List<User> users)
        {
            int counter = 0;
            if (users == null) return counter;
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i].Type == "Linux")
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
