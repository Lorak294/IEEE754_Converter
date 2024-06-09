
namespace ConverterConstants
{
    public static class IEEE754Constants
    {
        internal const int SignIndex = 0;

        internal const int ExponentStartIndex = 1;

        internal const int ExponentEndIndex = 8;

        internal const int MantissaStartIndex = 9;

        internal const string Zero = "00000000000000000000000000000000";

        internal const string OneExponent = "11111111";
    }

    public static class WewConstants
    {
        internal const int ExponentEndIndex = 7;

        internal const int SignIndex = 8;

        internal const int MantissaStartIndex = 9;

        internal const string Zero = "00000000000000000000000000000000";

        internal const string ZeroExponent = "00000000";
    }

    public static class InputConstants
    {
        internal const int BinaryLength = 32;

        internal const int HexadecimalLength = 8;
    }
}
