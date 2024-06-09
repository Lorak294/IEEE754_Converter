
using System.Security.Cryptography;

namespace IEEE754_Converter
{
    public class CodedValue
    { 
        private string bin_value;
        private string hex_value;

        public string HexStr { get { return hex_value; } }  
        public string BinStr { get { return bin_value; } }  

        private CodedValue(string bin_value, string hex_value)
        {
            this.bin_value = bin_value;
            this.hex_value = hex_value;
        }

        public static CodedValue FromHex(string hex_str) 
        {
            hex_str = hex_str.Replace(" ","");
            string bin_str = Convert.ToString(Convert.ToInt32(hex_str, 16), 2).PadLeft(32, '0');
            return new CodedValue(bin_str, hex_str);
        }

        public static CodedValue FromBin(string bin_str)
        {
            bin_str = bin_str.Replace(" ", "");
            string hex_str = Convert.ToString(Convert.ToInt32(bin_str, 2), 16).PadLeft(8, '0').ToUpper();
            return new CodedValue(bin_str, hex_str);
        }
    }
}
