﻿using Bridge;
using System.Text.RegularExpressions;
using System.Globalization;

namespace System
{
    /// <summary>
    /// The String global object is a constructor for strings, or a sequence of characters.
    /// </summary>
    [Ignore]
    [Name("String")]
    [Constructor("String")]
    public sealed class String
    {
        public readonly int Length = 0;

        [InlineConst]
        public const string Empty = "";

        /// <summary>
        /// The String global object is a constructor for strings, or a sequence of characters.
        /// </summary>
        public String() { }

        /// <summary>
        /// The String global object is a constructor for strings, or a sequence of characters.
        /// </summary>
        /// <param name="thing">Anything to be converted to a string.</param>
        public String(object thing) { }

        /// <summary>
        /// Constructs a string from the value indicated by a specified character repeated a specified number of times.
        /// </summary>
        /// <param name="c">A character.</param>
        /// <param name="count">The number of times the character occurs.</param>
        [Template("Bridge.String.fromCharCount({c}, {count})")]
        public String(char c, int count) { }

        /// <summary>
        /// Indicates whether the specified string is null or an Empty string.
        /// </summary>
        /// <param name="value">The string to test. </param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        [Template("Bridge.String.isNullOrEmpty({value})")]
        public static bool IsNullOrEmpty(string value)
        {
            return false;
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or String.Empty, or if value consists exclusively of white-space characters. </returns>
        [Template("Bridge.String.isNullOrWhiteSpace({value})")]
        public static bool IsNullOrWhiteSpace(string value)
        {
            return false;
        }

        /// <summary>
        /// The static String.fromCharCode() method returns a string created by using the specified sequence of Unicode values.
        /// </summary>
        /// <param name="numbers">A sequence of numbers that are Unicode values.</param>
        /// <returns></returns>
        public static string FromCharCode(params int[] numbers)
        {
            return null;
        }

        /// <summary>
        /// The charAt() method returns the specified character from a string.
        /// </summary>
        /// <param name="index">An integer between 0 and 1-less-than the length of the string.</param>
        /// <returns></returns>
        public string CharAt(int index)
        {
            return null;
        }

        /// <summary>
        /// The charCodeAt() method returns the numeric Unicode value of the character at the given index (except for unicode codepoints > 0x10000).
        /// </summary>
        /// <param name="index">An integer greater than or equal to 0 and less than the length of the string; if it is not a number, it defaults to 0.</param>
        /// <returns></returns>
        public int CharCodeAt(int index)
        {
            return 0;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="string2">Strings to concatenate to this string.</param>
        /// <param name="string3">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(string string2, string string3)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="string2">Strings to concatenate to this string.</param>
        /// <param name="string3">Strings to concatenate to this string.</param>
        /// <param name="string4">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(string string2, string string3, string string4)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="string2">Strings to concatenate to this string.</param>
        /// <param name="string3">Strings to concatenate to this string.</param>
        /// <param name="string4">Strings to concatenate to this string.</param>
        /// <param name="string5">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(string string2, string string3, string string4, string string5)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="strings">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(params string[] strings)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="object1">Strings to concatenate to this string.</param>
        /// <param name="object2">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(object object1, object object2)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="object1">Strings to concatenate to this string.</param>
        /// <param name="object2">Strings to concatenate to this string.</param>
        /// <param name="object3">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(object object1, object object2, object object3)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="object1">Strings to concatenate to this string.</param>
        /// <param name="object2">Strings to concatenate to this string.</param>
        /// <param name="object3">Strings to concatenate to this string.</param>
        /// <param name="object4">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(object object1, object object2, object object3, object object4)
        {
            return null;
        }

        /// <summary>
        /// The concat() method combines the text of two or more strings and returns a new string.
        /// </summary>
        /// <param name="objects">Strings to concatenate to this string.</param>
        /// <returns></returns>
        public static string Concat(params object[] objects)
        {
            return null;
        }

        /// <summary>
        /// The compare() method compares two specified String objects and returns an integer that indicates their relative position in the sort order.
        /// </summary>
        /// <param name="strA">The first string to compare.</param>
        /// <param name="strB">The second string to compare.</param>
        /// <returns></returns>
        [Template("Bridge.String.compare({strA}, {strB})")]
        public static int Compare(string strA, string strB)
        {
            return 0;
        }

        /// <summary>
        /// The compare() method compares two specified String objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order.
        /// </summary>
        /// <param name="strA">The first string to compare.</param>
        /// <param name="strB">The second string to compare.</param>
        /// <param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param>
        /// <returns></returns>
        [Template("Bridge.String.compare({strA}, {strB}, {ignoreCase})")]
        public static int Compare(string strA, string strB, bool ignoreCase)
        {
            return 0;
        }

        /// <summary>
        /// The compare() method compares substrings of two specified String objects and returns an integer that indicates their relative position in the sort order.
        /// </summary>
        /// <param name="strA">The first string to compare.</param>
        /// <param name="indexA">The position of the substring within strA.</param>
        /// <param name="strB">The second string to compare.</param>
        /// <param name="indexB">The position of the substring within strB.</param>
        /// <param name="length">The maximum number of characters in the substrings to compare.</param>
        /// <returns></returns>
        [Template("Bridge.String.compare({strA}.substr({indexA}, {length}), {strB}.substr({indexB}, {length}))")]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length)
        {
            return 0;
        }

        /// <summary>
        /// The compare() method compares substrings of two specified String objects and returns an integer that indicates their relative position in the sort order.
        /// </summary>
        /// <param name="strA">The first string to compare.</param>
        /// <param name="indexA">The position of the substring within strA.</param>
        /// <param name="strB">The second string to compare.</param>
        /// <param name="indexB">The position of the substring within strB.</param>
        /// <param name="length">The maximum number of characters in the substrings to compare.</param>
        /// <param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param>
        /// <returns></returns>
        [Template("Bridge.String.compare({strA}.substr({indexA}, {length}), {strB}.substr({indexB}, {length}), {ignoreCase})")]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
        {
            return 0;
        }

        [Template("Bridge.String.compare({strA}, {strB}, {comparisonType})")]
        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
            return 0;
        }

        [Template("Bridge.String.compare({strA}, {strB}, {ignoreCase}, {culture})")]
        public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
        {
            return 0;
        }

        [Template("Bridge.String.compare({strA}.substr({indexA}, {length}), {strB}.substr({indexB}, {length}), {comparisonType})")]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
        {
            return 0;
        }

        [Template("Bridge.String.compare({strA}.substr({indexA}, {length}), {strB}.substr({indexB}, {length}), {ignoreCase}, {culture})")]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
        {
            return 0;
        }

        /// <summary>
        /// The indexOf() method returns the index within the calling String object of the first occurrence of the specified value. Returns -1 if the value is not found.
        /// </summary>
        /// <param name="searchValue">A character to search for.</param>
        /// <returns>The zero-based index position of value if that character is found, or -1 if it is not.</returns>
        [Template("Bridge.String.indexOf({this}, String.fromCharCode({searchValue}))")]
        public int IndexOf(char searchValue)
        {
            return -1;
        }

        /// <summary>
        /// The indexOf() method returns the index within the calling String object of the first occurrence of the specified value, starting the search at fromIndex. Returns -1 if the value is not found.
        /// </summary>
        /// <param name="searchValue">A character to search for.</param>
        /// <param name="fromIndex">The location within the calling string to start the search from.</param>
        /// <returns>The zero-based index position of value if that character is found, or -1 if it is not.</returns>
        [Template("Bridge.String.indexOf({this}, String.fromCharCode({searchValue}), {fromIndex})")]
        public int IndexOf(char searchValue, int fromIndex)
        {
            return -1;
        }

        /// <summary>
        /// The indexOf() method returns the index within the calling String object of the first occurrence of the specified value. Returns -1 if the value is not found.
        /// </summary>
        /// <param name="searchValue">A string representing the value to search for.</param>
        /// <returns></returns>
        [Template("Bridge.String.indexOf({this}, {searchValue})")]
        public int IndexOf(string searchValue)
        {
            return -1;
        }

        /// <summary>
        /// The indexOf() method returns the index within the calling String object of the first occurrence of the specified value, starting the search at fromIndex. Returns -1 if the value is not found.
        /// </summary>
        /// <param name="searchValue">A string representing the value to search for.</param>
        /// <param name="fromIndex">The location within the calling string to start the search from.</param>
        /// <returns></returns>
        [Template("Bridge.String.indexOf({this}, {searchValue}, {fromIndex})")]
        public int IndexOf(string searchValue, int fromIndex)
        {
            return -1;
        }

        /// <summary>
        /// The indexOf() method returns the index within the calling String object of the first occurrence of the specified value. The search starts at a specified character position and
        /// examines a specified number of character positions. Returns -1 if the value is not found.
        /// </summary>
        /// <param name="searchValue">A character to search for.</param>
        /// <param name="fromIndex">The location within the calling string to start the search from.</param>
        /// <param name="count">The number of character positions to examine.</param>
        /// <returns></returns>
        [Template("Bridge.String.indexOf({this}, String.fromCharCode({searchValue}), {fromIndex}, {count})")]
        public int IndexOf(char searchValue, int fromIndex, int count)
        {
            return -1;
        }

        /// <summary>
        /// The indexOf() method returns the index within the calling String object of the first occurrence of the specified value. The search starts at a specified character position and
        /// examines a specified number of character positions. Returns -1 if the value is not found.
        /// </summary>
        /// <param name="searchValue">A string representing the value to search for.</param>
        /// <param name="fromIndex">The location within the calling string to start the search from.</param>
        /// <param name="count">The number of character positions to examine.</param>
        /// <returns></returns>
        [Template("Bridge.String.indexOf({this}, {searchValue}, {fromIndex}, {count})")]
        public int IndexOf(string searchValue, int fromIndex, int count)
        {
            return -1;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current System.String object. A parameter specifies the type of search
        //  to use for the specified string.
        /// </summary>
        /// <param name="searchValue">The string to search for.</param>
        /// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
        /// <returns>The zero-based index position of value if that string is found, or -1 if it is not. If value is System.String.Empty, the return value is 0.</returns>
        [Template("Bridge.String.indexOf({this}, {searchValue}, 0, {this}.length, {comparisonType})")]
        public int IndexOf(string searchValue, StringComparison comparisonType)
        {
            return -1;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current System.String object. Parameters specify the starting search
        //  position in the current string and the type of search to use for the specified string.
        /// </summary>
        /// <param name="searchValue">The string to search for.</param>
        /// <param name="fromIndex">The search starting position.</param>
        /// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
        /// <returns>The zero-based index position of value if that string is found, or -1 if it is not. If value is System.String.Empty, the return value is 0.</returns>
        [Template("Bridge.String.indexOf({this}, {searchValue}, {fromIndex}, {this}.length, {comparisonType})")]
        public int IndexOf(string searchValue, int fromIndex, StringComparison comparisonType)
        {
            return -1;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in the current System.String object. Parameters specify the starting search
        //  position in the current string, the number of characters in the current string
        //  to search, and the type of search to use for the specified string.
        /// </summary>
        /// <param name="searchValue">The string to search for.</param>
        /// <param name="fromIndex">The search starting position.</param>
        /// <param name="count">The number of character positions to examine.</param>
        /// <param name="comparisonType">One of the enumeration values that specifies the rules for the search.</param>
        /// <returns>The zero-based index position of value if that string is found, or -1 if it is not. If value is System.String.Empty, the return value is 0.</returns>
        [Template("Bridge.String.indexOf({this}, {searchValue}, {fromIndex}, {count}, {comparisonType})")]
        public int IndexOf(string searchValue, int fromIndex, int count, StringComparison comparisonType)
        {
            return -1;
        }

        /// <summary>
        /// The lastIndexOf() method returns the index within the calling String object of the last occurrence of the specified value, or -1 if not found. The calling string is searched backward, starting at fromIndex.
        /// </summary>
        /// <param name=" searchValue">A string representing the value to search for.</param>
        /// <returns></returns>
        public int LastIndexOf(string searchValue)
        {
            return -1;
        }

        /// <summary>
        /// The lastIndexOf() method returns the index within the calling String object of the last occurrence of the specified value, or -1 if not found. The calling string is searched backward, starting at fromIndex.
        /// </summary>
        /// <param name=" searchValue">A string representing the value to search for.</param>
        /// <param name="fromIndex">The location within the calling string to start the search at, indexed from left to right. It can be any integer. The default value is searchValue.length - 1. If fromIndex &lt; 0 or fromIndex &gt;= searchValue.length, the method will return -1.</param>
        /// <returns></returns>
        public int LastIndexOf(string searchValue, int fromIndex)
        {
            return -1;
        }

        /// <summary>
        /// The localeCompare() method returns a number indicating whether a reference string comes before or after or is the same as the given string in sort order.
        /// The new locales and options arguments let applications specify the language whose sort order should be used and customize the behavior of the function. In older implementations, which ignore the locales and options arguments, the locale and sort order used are entirely implementation dependent.
        /// </summary>
        /// <param name="compareString">The string against which the referring string is comparing</param>
        /// <returns></returns>
        public int LocaleCompare(string compareString)
        {
            return 0;
        }

        /// <summary>
        /// The localeCompare() method returns a number indicating whether a reference string comes before or after or is the same as the given string in sort order.
        /// The new locales and options arguments let applications specify the language whose sort order should be used and customize the behavior of the function. In older implementations, which ignore the locales and options arguments, the locale and sort order used are entirely implementation dependent.
        /// </summary>
        /// <param name="compareString">The string against which the referring string is comparing</param>
        /// <param name="locales">A string with a BCP 47 language tag, or an array of such strings. For the general form and interpretation of the locales argument, see the Intl page. The following Unicode extension keys are allowed:</param>
        /// <returns></returns>
        public int LocaleCompare(string compareString, string locales)
        {
            return 0;
        }

        /// <summary>
        /// The localeCompare() method returns a number indicating whether a reference string comes before or after or is the same as the given string in sort order.
        /// The new locales and options arguments let applications specify the language whose sort order should be used and customize the behavior of the function. In older implementations, which ignore the locales and options arguments, the locale and sort order used are entirely implementation dependent.
        /// </summary>
        /// <param name="compareString">The string against which the referring string is comparing</param>
        /// <param name="locales">A string with a BCP 47 language tag, or an array of such strings. For the general form and interpretation of the locales argument, see the Intl page. The following Unicode extension keys are allowed:</param>
        /// <param name="options">An object with some or all of the following properties:</param>
        /// <returns></returns>
        public int LocaleCompare(string compareString, string locales, LocaleOptions options)
        {
            return 0;
        }

        /// <summary>
        /// The match() method retrieves the matches when matching a string against a regular expression.
        /// </summary>
        /// <param name="Regex">A regular expression object. If a non-Regex object obj is passed, it is implicitly converted to a Regex by using new Regex(obj).</param>
        /// <returns></returns>
        public string[] Match(Regex Regex)
        {
            return null;
        }

        /// <summary>
        /// The match() method retrieves the matches when matching a string against a regular expression.
        /// </summary>
        /// <param name="Regex">A regular expression object. If a non-Regex object obj is passed, it is implicitly converted to a Regex by using new Regex(obj).</param>
        /// <returns></returns>
        public string[] Match(string Regex)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="Regex">A Regex object. The match is replaced by the return value of parameter #2.</param>
        /// <param name="newSubStr">The String that replaces the substring received from parameter #1. A number of special replacement patterns are supported; see the "Specifying a string as a parameter" section below.</param>
        /// <returns></returns>
        public string Replace(Regex Regex, string newSubStr)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="Regex">A Regex object. The match is replaced by the return value of parameter #2.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(Regex Regex, Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="Regex">A Regex object. The match is replaced by the return value of parameter #2.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(Regex Regex, Func<string, string> callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="Regex">A Regex object. The match is replaced by the return value of parameter #2.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(Regex Regex, Func<string, int, string> callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="Regex">A Regex object. The match is replaced by the return value of parameter #2.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(Regex Regex, Func<string, int, string, string> callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="substr">A String that is to be replaced by newSubStr.</param>
        /// <param name="newSubStr">The String that replaces the substring received from parameter #1. A number of special replacement patterns are supported; see the "Specifying a string as a parameter" section below.</param>
        /// <returns></returns>
        public string Replace(string substr, string newSubStr)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="substr">A String that is to be replaced by newSubStr.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(string substr, Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="substr">A String that is to be replaced by newSubStr.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(string substr, Func<string, string> callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="substr">A String that is to be replaced by newSubStr.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(string substr, Func<string, int, string> callback)
        {
            return null;
        }

        /// <summary>
        /// The replace() method returns a new string with some or all matches of a pattern replaced by a replacement.  The pattern can be a string or a Regex, and the replacement can be a string or a function to be called for each match.
        /// </summary>
        /// <param name="substr">A String that is to be replaced by newSubStr.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public string Replace(string substr, Func<string, int, string, string> callback)
        {
            return null;
        }

        /// <summary>
        /// The search() method executes a search for a match between a regular expression and this String object.
        /// </summary>
        /// <param name="Regex">A regular expression object. If a non-Regex object obj is passed, it is implicitly converted to a Regex by using new Regex(obj).</param>
        /// <returns></returns>
        public int Search(Regex Regex)
        {
            return 0;
        }

        /// <summary>
        /// The search() method executes a search for a match between a regular expression and this String object.
        /// </summary>
        /// <param name="Regex">A regular expression object. If a non-Regex object obj is passed, it is implicitly converted to a Regex by using new Regex(obj).</param>
        /// <returns></returns>
        public int Search(string Regex)
        {
            return 0;
        }

        /// <summary>
        /// The slice() method extracts a section of a string and returns a new string.
        /// </summary>
        /// <param name="beginSlice">The zero-based index at which to begin extraction. If negative, it is treated as (sourceLength-beginSlice) where sourceLength is the length of the string (for example, if beginSlice is -3 it is treated as sourceLength-3).</param>
        /// <returns></returns>
        public string Slice(int beginSlice)
        {
            return null;
        }

        /// <summary>
        /// The slice() method extracts a section of a string and returns a new string.
        /// </summary>
        /// <param name="beginSlice">The zero-based index at which to begin extraction. If negative, it is treated as (sourceLength-beginSlice) where sourceLength is the length of the string (for example, if beginSlice is -3 it is treated as sourceLength-3).</param>
        /// <param name="endSlice">The zero-based index at which to end extraction. If omitted, slice extracts to the end of the string. If negative, it is treated as (sourceLength-endSlice) where sourceLength is the length of the string.</param>
        /// <returns></returns>
        public string Slice(int beginSlice, int endSlice)
        {
            return null;
        }

        /// <summary>
        /// The split() method splits a String object into an array of strings by separating the string into substrings.
        /// </summary>
        /// <param name="separator">Specifies the character(s) to use for separating the string. The separator is treated as a string or a regular expression. If separator is omitted, the array returned contains one element consisting of the entire string. If separator is an empty string, str is converted to an array of characters.</param>
        /// <returns></returns>
        public string[] Split(string separator)
        {
            return null;
        }

        /// <summary>
        /// The split() method splits a String object into an array of strings by separating the string into substrings.
        /// </summary>
        /// <param name="separator">Specifies the character(s) to use for separating the string. The separator is treated as a string or a regular expression. If separator is omitted, the array returned contains one element consisting of the entire string. If separator is an empty string, str is converted to an array of characters.</param>
        /// <returns></returns>
        public string[] Split(Regex separator)
        {
            return null;
        }

        /// <summary>
        /// The split() method splits a String object into an array of strings by separating the string into substrings.
        /// </summary>
        /// <param name="separator">Specifies the character(s) to use for separating the string. The separator is treated as a string or a regular expression. If separator is omitted, the array returned contains one element consisting of the entire string. If separator is an empty string, str is converted to an array of characters.</param>
        /// <param name="limit">Integer specifying a limit on the number of splits to be found. The split method still splits on every match of separator, but it truncates the returned array to at most limit elements.</param>
        /// <returns></returns>
        public string[] Split(string separator, int limit)
        {
            return null;
        }

        /// <summary>
        /// The split() method splits a String object into an array of strings by separating the string into substrings.
        /// </summary>
        /// <param name="separator">Specifies the character(s) to use for separating the string. The separator is treated as a string or a regular expression. If separator is omitted, the array returned contains one element consisting of the entire string. If separator is an empty string, str is converted to an array of characters.</param>
        /// <param name="limit">Integer specifying a limit on the number of splits to be found. The split method still splits on every match of separator, but it truncates the returned array to at most limit elements.</param>
        /// <returns></returns>
        public string[] Split(Regex separator, int limit)
        {
            return null;
        }

        /// <summary>
        /// The substring() method returns a subset of a string between one index and another, or through the end of the string.
        /// </summary>
        /// <param name="indexA">An integer between 0 and the length of the string.</param>
        /// <returns></returns>
        public string Substring(int indexA)
        {
            return null;
        }

        /// <summary>
        /// The substring() method returns a subset of a string between one index and another, or through the end of the string.
        /// </summary>
        /// <param name="indexA">An integer between 0 and the length of the string.</param>
        /// <param name="indexB">An integer between 0 and the length of the string.</param>
        /// <returns></returns>
        public string Substring(int indexA, int indexB)
        {
            return null;
        }

        /// <summary>
        /// The substr() method returns the characters in a string beginning at the specified location through the specified number of characters.
        /// </summary>
        /// <param name="start">Location at which to begin extracting characters. If a negative number is given, it is treated as strLength+start where strLength = to the length of the string (for example, if start is -3 it is treated as strLength-3.)</param>
        /// <returns></returns>
        public string Substr(int start)
        {
            return null;
        }

        /// <summary>
        /// The substr() method returns the characters in a string beginning at the specified location through the specified number of characters.
        /// </summary>
        /// <param name="start">Location at which to begin extracting characters. If a negative number is given, it is treated as strLength+start where strLength = to the length of the string (for example, if start is -3 it is treated as strLength-3.)</param>
        /// <param name="length">The number of characters to extract.</param>
        /// <returns></returns>
        public string Substr(int start, int length)
        {
            return null;
        }

        /// <summary>
        /// The toLower() method returns the calling string value converted to lowercase.
        /// </summary>
        /// <returns></returns>
        [Template("{this}.toLowerCase()")]
        public string ToLower()
        {
            return null;
        }

        /// <summary>
        /// The toUpper() method returns the calling string value converted to uppercase.
        /// </summary>
        /// <returns></returns>
        [Template("{this}.toUpperCase()")]
        public string ToUpper()
        {
            return null;
        }

        /// <summary>
        /// The trim() method removes whitespace from both ends of a string. Whitespace in this context is all the whitespace characters (space, tab, no-break space, etc.) and all the line terminator characters (LF, CR, etc.).
        /// </summary>
        /// <returns>The trimmed string</returns>
        public string Trim()
        {
            return null;
        }

        /// <summary>
        /// Returns a value indicating whether a specified substring occurs within this string.
        /// </summary>
        /// <param name="value">The string to seek. </param>
        /// <returns>true if the value parameter occurs within this string, or if value is the empty string (""); otherwise, false.</returns>
        [Template("Bridge.String.contains({this},{value})")]
        public bool Contains(string value)
        {
            return false;
        }

        [Template("Bridge.String.endsWith({this}, {suffix})")]
        public bool EndsWith(string suffix)
        {
            return false;
        }

        [Template("Bridge.String.startsWith({this}, {prefix})")]
        public bool StartsWith(string prefix)
        {
            return false;
        }

        [Template("Bridge.String.format({format}, {values})")]
        public static string Format(string format, params object[] values)
        {
            return null;
        }

        [Template("Bridge.String.indexOfAny({this}, {anyOf})")]
        public int IndexOfAny(char[] anyOf)
        {
            return -1;
        }

        [Template("Bridge.String.indexOfAny({this}, {anyOf}, {startIndex})")]
        public int IndexOfAny(char[] anyOf, int startIndex)
        {
            return -1;
        }

        [Template("Bridge.String.indexOfAny({this}, {anyOf}, {startIndex}, {count})")]
        public int IndexOfAny(char[] anyOf, int startIndex, int count)
        {
            return -1;
        }

        [Template("Bridge.String.toCharArray({this}, 0, {this}.length)")]
        public char[] ToCharArray()
        {
            return null;
        }

        [Template("Bridge.String.toCharArray({this}, {startIndex}, {count})")]
        public char[] ToCharArray(int startIndex, int count)
        {
            return null;
        }

        public static bool operator ==(string s1, string s2)
        {
            return false;
        }

        public static bool operator !=(string s1, string s2)
        {
            return false;
        }

        public char this[int index]
        {
            [Ignore]
            [Template("charCodeAt({0})")]
            get
            {
                return default(char);
            }
        }
    }
}