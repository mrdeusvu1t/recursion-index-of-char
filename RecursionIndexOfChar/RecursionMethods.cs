using System;

namespace RecursionIndexOfChar
{
    public static class RecursionMethods
    {
        public static int GetIndexOfChar(string str, char value)
        {
            // TODO Analyze the implementation of "GetLastIndexOfChar" and "GetLastIndexOfCharRecursive" methods, and implement the method using recursion.
            throw new NotImplementedException();
        }

        public static int GetLastIndexOfChar(string str, char value)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return RecursionMethods.GetLastIndexOfCharRecursive(str, value);
        }

        private static int GetLastIndexOfCharRecursive(string str, char value)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            int lastCharIndex = str.Length - 1;
            char currentChar = str[lastCharIndex];
            if (currentChar == value)
            {
                return lastCharIndex;
            }

            string substring = str.Substring(0, str.Length - 1);
            int result = RecursionMethods.GetLastIndexOfCharRecursive(substring, value);
            return result < 0 ? -1 : result;
        }
    }
}
