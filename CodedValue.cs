
using System.Security.Cryptography;

namespace IEEE754_Converter
{
    public class CodedValue
    { 
        public bool SignBit { get; set; }
        public byte Exponent { get; set; }
        public UInt32 Mantis { get; set; }

        public static CodedValue FromHex(string hex_str) 
        {
            hex_str = hex_str.Replace(" ","");
            return FromBin(Convert.ToString(Convert.ToInt32(hex_str, 16),2).PadLeft(32,'0'));
        }

        public static CodedValue FromBin(string bin_str)
        {
            bin_str = bin_str.Replace(" ", "");
            return FromFullBin(bin_str.PadLeft(32, '0'));
        }

        private static CodedValue FromFullBin(string bin_str)
        {
            return new CodedValue{
                SignBit = bin_str[0] == '1',
                Exponent = Convert.ToByte(bin_str.Substring(1, 8), 2),
                Mantis = Convert.ToUInt32(bin_str.Substring(9), 2)
            };
        }

        public UInt32 ComposeUInt32()
        {
            UInt32 val = 0;
            val += Mantis;
            val += (UInt32)Exponent << 23;
            if (SignBit)
                val += (UInt32)1 << 31;
            return val;
        }
        public string ToHex()
        {
            return Convert.ToString(ComposeUInt32(), 16).PadLeft(4, '0').ToUpper();
        }

        public string ToBin()
        {
            return Convert.ToString(ComposeUInt32(), 2).PadLeft(32, '0');
        }
    }
}
