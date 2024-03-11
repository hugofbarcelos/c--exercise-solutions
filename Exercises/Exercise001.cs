using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            // Replace the exception statement below with your code!
            throw new NotImplementedException();

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }
    }
}
