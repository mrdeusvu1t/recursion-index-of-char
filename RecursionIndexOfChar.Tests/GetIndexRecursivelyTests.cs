using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace RecursionIndexOfChar.Tests
{
    [TestFixture]
    public sealed class GetIndexRecursivelyTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void GetIndexOfChar_EmptyString_ThrowsException(string str)
        {
            Assert.Throws<ArgumentNullException>(() => GetIndexRecursively.GetIndexOfChar(str, 'a'));
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
            return GetIndexRecursively.GetIndexOfChar(str, value);
        }
    }
}
