using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string str, char value)
        {
            // TODO #1. Analyze the implementation of "GetLastIndexOfChar(string, char)" method, and implement the method using recursion.
            // The method should return the position of a "value" char in the "str" string. If "str" string has no "value" char then returns -1.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            return GetIndexOfCharRecursion(str, value, 0);
        }

        public static int GetIndexOfCharRecursion(string str, char value, int i)
        {
            if (i >= str.Length)
            {
                return -1;
            }

            if (str[i] == value)
            {
                return i;
            }

            return GetIndexOfCharRecursion(str, value, ++i);
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            // TODO #2. Analyze the implementation of "GetLastIndexOfChar(string, char, int, int)" method, and implement the method using recursion.
            // The method should return the position of a "value" char in the "str" string. If "str" string has no "value" char then returns -1.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str) || count == 0)
            {
                return -1;
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length + 1");
            }

            return GetIndexOfCharRecursive(str, value, startIndex, count, startIndex);
        }

        public static int GetIndexOfCharRecursive(string str, char value, int startIndex, int count, int i)
        {
            if (i >= startIndex + count)
            {
                return -1;
            }

            if (str[i] == value)
            {
                return i;
            }

            return GetIndexOfCharRecursive(str, value, startIndex, count, ++i);
        }
    }
}
