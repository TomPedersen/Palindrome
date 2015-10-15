using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeChecker
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindrome_True()
        {
            Palindrome obj = new Palindrome();
            Assert.IsTrue(obj.CheckIfPalindrome("racecar"));
        }

        [TestMethod]
        public void IsPalindrome_True2()
        {
            Palindrome obj = new Palindrome();
            Assert.IsTrue(obj.CheckIfPalindrome("Swap God for a janitor; rot in a jar of dog paws."));
        }

        [TestMethod]
        public void IsPalindrome_False()
        {
            Palindrome obj = new Palindrome();
            Assert.IsFalse(obj.CheckIfPalindrome("This is not a palindrome"));
        }
    }
}
