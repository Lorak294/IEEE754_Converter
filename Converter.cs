
namespace IEEE754_Converter
{
    public class Converter
    {
        public static CodedValue WewToIEEEConversion(CodedValue wew_val)
        {
            if (wew_val.ComposeUInt32() == 0)
                return wew_val;

            return new CodedValue
            {
                Mantis = wew_val.Mantis,
                SignBit = !wew_val.SignBit,
                Exponent = (byte)((byte)(wew_val.Exponent >> 1) + 127),
            };
        }

        public static CodedValue IEEEToWewConversion(CodedValue ieee_val)
        {
            if (ieee_val.ComposeUInt32() == 0)
                return ieee_val;

            return new CodedValue
            {
                Mantis = ieee_val.Mantis,
                SignBit = !ieee_val.SignBit,
                Exponent = (byte)((byte)(ieee_val.Exponent - (byte)127) << 1),
            };
        }
    }
}
