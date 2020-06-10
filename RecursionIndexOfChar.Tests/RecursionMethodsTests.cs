using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace RecursionIndexOfChar.Tests
{
    [TestFixture]
    public sealed class RecursionMethodsTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void GetIndexOfChar_EmptyString_ThrowsException(string str)
        {
            Assert.Throws<ArgumentNullException>(() => RecursionMethods.GetIndexOfChar(str, 'a'));
        }

        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', ExpectedResult = 0)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', ExpectedResult = 1)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'c', ExpectedResult = 2)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'x', ExpectedResult = 23)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'y', ExpectedResult = 24)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', ExpectedResult = 25)]
        [TestCase("abcefghijklmnoprstquvwxyzabcefghijklmnoprstquvwxyz", 'd', ExpectedResult = -1)]
        public int GetIndexOfChar_NonEmptyString_ReturnsPosition(string str, char value)
        {
            return RecursionMethods.GetIndexOfChar(str, value);
        }

        [TestCase(null)]
        [TestCase("")]
        public void GetLastIndexOfChar_EmptyString_ThrowsException(string str)
        {
            Assert.Throws<ArgumentNullException>(() => RecursionMethods.GetLastIndexOfChar(str, 'a'));
        }

        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'a', ExpectedResult = 26)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'b', ExpectedResult = 27)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'c', ExpectedResult = 28)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'x', ExpectedResult = 49)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'y', ExpectedResult = 50)]
        [TestCase("abcdefghijklmnoprstquvwxyzabcdefghijklmnoprstquvwxyz", 'z', ExpectedResult = 51)]
        [TestCase("abcefghijklmnoprstquvwxyzabcefghijklmnoprstquvwxyz", 'd', ExpectedResult = -1)]
        public int GetLastIndexOfChar_NonEmptyString_ReturnsPosition(string str, char value)
        {
            return RecursionMethods.GetLastIndexOfChar(str, value);
        }
    }
}
