using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeAssessor
{
    public class Palindrome
    {
        public bool CheckIfPalindrome(string entry)
        {
            var cleanedEntry = Regex.Replace(entry, @"\W", string.Empty).ToLower();

            var reversedEntry = cleanedEntry.Reverse().ToArray();
        }
    }
}
