using Bridge;

namespace System
{
    [Ignore]
    [Name("Bridge.Int")]
    public struct UInt32 : IComparable, IComparable<UInt32>, IEquatable<UInt32>, IFormattable
    {
		private UInt32(int i)
        {
		}

        [InlineConst]
        public const uint MinValue = 0;

        [InlineConst]
        public const uint MaxValue = 4294967295;

        [Template("Bridge.Int.parseInt({s}, 0, 4294967295)")]
        public static uint Parse(string s)
        {
            return 0;
        }

        [Template("Bridge.Int.parseInt({s}, 0, 4294967295, {radix})")]
        public static uint Parse(string s, int radix)
        {
            return 0;
        }

        [Template("Bridge.Int.tryParseInt({s}, {result}, 0, 4294967295)")]
        public static bool TryParse(string s, out uint result)
        {
            result = 0;
            return false;
        }

        [Template("Bridge.Int.tryParseInt({s}, {result}, 0, 4294967295, {radix})")]
        public static bool TryParse(string s, out uint result, int radix)
        {
            result = 0;
            return false;
        }

        public string ToString(int radix)
        {
            return null;
        }

        [Template("Bridge.Int.format({this}, {format})")]
        public string Format(string format)
        {
            return null;
        }

        [Template("Bridge.Int.format({this}, {format}, {provider})")]
        public string Format(string format, IFormatProvider provider)
        {
            return null;
        }

        [Template("Bridge.Int.format({this}, {format})")]
        public string ToString(string format)
        {
            return null;
        }

        [Template("Bridge.Int.format({this}, {format}, {provider})")]
        public string ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        [Template("Bridge.compare({this}, {other})")]
        public int CompareTo(uint other)
        {
            return 0;
        }

        [Template("Bridge.compare({this}, {obj})")]
        public int CompareTo(object obj)
        {
            return 0;
        }

        [Template("Bridge.equalsT({this}, {other})")]
        public bool Equals(uint other)
        {
            return false;
        }
	}
}
