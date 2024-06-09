
using ConverterConstants;

namespace IEEE754_Converter
{
    public record ConversionResult
    {
        public bool Success { get; set; }
        public string Result { get; set; }
        public string ErrorMessage { get; set; }

        public static ConversionResult SuccessfulConversion(string result)
        {
            return new ConversionResult { Success = true, Result = result, ErrorMessage = String.Empty};
        }

        public static ConversionResult FailedConversion(string error_msg)
        {
            return new ConversionResult { Success = false, Result = string.Empty, ErrorMessage = error_msg };
        }

    }
    public static class Converter
    {

        public static ConversionResult TryToWewConvert(string value)
        {
            try
            {
                if (value == IEEE754Constants.Zero)
                    return ConversionResult.SuccessfulConversion(WewConstants.Zero);

                string exponent = value[IEEE754Constants.ExponentStartIndex..(IEEE754Constants.ExponentEndIndex + 1)];
                if (exponent == IEEE754Constants.OneExponent)
                    return ConversionResult.FailedConversion("Nieprawidłowe dane wejściowe. Wprowadzona liczba po konwersji nie będzie zgodna z formatem wewnętrzym.");

                return ConversionResult.SuccessfulConversion($"{GetWewExponent(exponent)}{value[IEEE754Constants.SignIndex]}{value[IEEE754Constants.MantissaStartIndex..]}");
            }
            catch
            {
                return ConversionResult.FailedConversion("Nastąpił niespodziewany błąd podczas konwersji do kodu wewnętrznego.");
            }
        }

        public static ConversionResult TryToIEEE754Convert(string value)
        {
            try
            {
                if (value == WewConstants.Zero)
                    return ConversionResult.SuccessfulConversion(IEEE754Constants.Zero);

                string exponent = value[..(WewConstants.ExponentEndIndex + 1)];
                if (exponent == WewConstants.ZeroExponent)
                    return ConversionResult.FailedConversion("Nieprawidłowe dane wejściowe. Wprowadzona liczba po konwersji nie będzie zgodna z formatem IEEE754.");

                return ConversionResult.SuccessfulConversion($"{value[WewConstants.SignIndex]}{GetIEEE754Exponent(exponent)}{value[WewConstants.MantissaStartIndex..]}");
            }
            catch
            {
                return ConversionResult.FailedConversion("Nastąpił niespodziewany błąd podczas konwersji do kodu IEEE754.");
            }
        }

        private static string GetIEEE754Exponent(string exponent)
        {
            int exponentValue = Convert.ToInt32(exponent, 2);
            return Convert.ToString(exponentValue - 1, 2).PadLeft(IEEE754Constants.ExponentEndIndex - IEEE754Constants.ExponentStartIndex + 1, '0');
        }

        private static string GetWewExponent(string exponent)
        {
            int exponentValue = Convert.ToInt32(exponent, 2);
            return Convert.ToString(exponentValue + 1, 2).PadLeft(WewConstants.ExponentEndIndex + 1, '0');
        }

    }
}
