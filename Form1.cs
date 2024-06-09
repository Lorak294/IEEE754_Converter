using ConverterConstants;

namespace IEEE754_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool input_valid = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!input_valid)
            {
                MessageBox.Show(string.Format("Przed rozpoczêciem konwersji wprowadŸ poprawne dane wejœciowe."));
                return;
            }

            CodedValue v;
            if (wewIEEEConvesionRb.Checked)
            {
                if (binRb.Checked)
                {
                    v = CodedValue.FromBin(wewBinTb.Text);
                    wewHexTb.Text = v.HexStr;
                }
                else
                {
                    v = CodedValue.FromHex(wewHexTb.Text);
                    wewBinTb.Text = v.BinStr;
                }

                var conversion_result = Converter.TryToIEEE754Convert(v.BinStr);
                if (conversion_result.Success)
                {
                    var result_value = CodedValue.FromBin(conversion_result.Result);
                    ieeeBinTb.Text = result_value.BinStr;
                    ieeeHexTb.Text = result_value.HexStr;
                }
                else
                {
                    ieeeBinTb.Text = string.Empty;
                    ieeeHexTb.Text = string.Empty;
                    MessageBox.Show(conversion_result.ErrorMessage);
                }
            }
            else
            {
                if (binRb.Checked)
                {
                    v = CodedValue.FromBin(ieeeBinTb.Text);
                    ieeeHexTb.Text = v.HexStr;
                }
                else
                {
                    v = CodedValue.FromHex(ieeeHexTb.Text);
                    ieeeBinTb.Text = v.BinStr;
                }

                var conversion_result = Converter.TryToWewConvert(v.BinStr);
                if (conversion_result.Success)
                {
                    var result_value = CodedValue.FromBin(conversion_result.Result);
                    wewBinTb.Text = result_value.BinStr;
                    wewHexTb.Text = result_value.HexStr;
                }
                else
                {
                    wewBinTb.Text = string.Empty;
                    wewHexTb.Text = string.Empty;
                    MessageBox.Show(conversion_result.ErrorMessage);
                }
            }
        }

        private void toggleInputMode(object sender, EventArgs e)
        {
            wewBinTb.ReadOnly = !(binRb.Checked && wewIEEEConvesionRb.Checked);
            ieeeBinTb.ReadOnly = !(binRb.Checked && iEEEWewCOnversionRb.Checked);
            wewHexTb.ReadOnly = !(hexRb.Checked && wewIEEEConvesionRb.Checked);
            ieeeHexTb.ReadOnly = !(hexRb.Checked && iEEEWewCOnversionRb.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wewBinTb.Text = "";
            ieeeBinTb.Text = "";
            wewHexTb.Text = "";
            ieeeHexTb.Text = "";
        }

        private bool HexInputValidation(string hex_str)
        {
            char[] allowedChars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

            var clean_str = hex_str.Replace(" ", "").ToUpper();

            if (clean_str.Length != InputConstants.HexadecimalLength)
                return false;

            foreach (char character in clean_str.ToArray())
            {
                if (!allowedChars.Contains(character))
                    return false;
            }
            return true;
        }

        private bool BinInputValidation(string bin_str)
        {
            char[] allowedChars = ['0', '1'];

            var clean_str = bin_str.Replace(" ", "");

            if (clean_str.Length != InputConstants.BinaryLength)
                return false;

            foreach (char character in clean_str.ToArray())
            {
                if (!allowedChars.Contains(character))
                    return false;
            }
            return true;
        }

        private void wewBinTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(wewBinTb.Text))
                return;
            if (!BinInputValidation(wewBinTb.Text))
            {
                MessageBox.Show(string.Format("Z³y format danych - akceptowany format to 32 znaki '0' oraz '1' z ewentualnymi sapcjami."));
                input_valid = false;
                //e.Cancel = true;
            }
            input_valid = true;
        }

        private void wewHexTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(wewHexTb.Text))
                return;
            if (!HexInputValidation(wewHexTb.Text))
            {
                MessageBox.Show(string.Format("Z³y format danych - akceptowany format to 8 znaków HEX z ewentualnymi sapcjami."));
                input_valid = false;
                //e.Cancel = true;
            }
            input_valid = true;
        }

        private void ieeeBinTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ieeeBinTb.Text))
                return;
            if (!BinInputValidation(ieeeBinTb.Text))
            {
                MessageBox.Show(string.Format("Z³y format danych - akceptowany format to 32 znaki '0' oraz '1' z ewentualnymi sapcjami."));
                input_valid = false;
                //e.Cancel = true;
            }
            input_valid = true;
        }

        private void ieeeHexTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ieeeHexTb.Text))
                return;
            if (!HexInputValidation(ieeeHexTb.Text))
            {
                MessageBox.Show(string.Format("Z³y format danych - akceptowany format to 8 znaków HEX z ewentualnymi sapcjami."));
                input_valid = false;
                //e.Cancel = true;
            }
            input_valid = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
