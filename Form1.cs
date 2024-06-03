namespace IEEE754_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodedValue v, result;
            if (wewIEEEConvesionRb.Checked)
            {
                if (binRb.Checked)
                {
                    v = CodedValue.FromBin(wewBinTb.Text);
                    wewHexTb.Text = v.ToHex();
                }
                else
                {
                    v = CodedValue.FromHex(wewHexTb.Text);
                    wewBinTb.Text = v.ToBin();
                }
                result = Converter.WewToIEEEConversion(v);
                ieeeBinTb.Text = result.ToBin();
                ieeeHexTb.Text = result.ToHex();
            }
            else
            {
                if (binRb.Checked)
                {
                    v = CodedValue.FromBin(ieeeBinTb.Text);
                    ieeeHexTb.Text = v.ToHex();
                }
                else
                {
                    v = CodedValue.FromHex(ieeeHexTb.Text);
                    ieeeBinTb.Text = v.ToBin();
                }
                result = Converter.IEEEToWewConversion(v);
                wewBinTb.Text = result.ToBin();
                wewHexTb.Text = result.ToHex();
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
            char[] allowedChars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', ' '];

            foreach (char character in hex_str.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                    return false;
            }
            return true;
        }

        private bool BinInputValidation(string bin_str)
        {
            char[] allowedChars = ['0', '1', ' '];

            foreach (char character in bin_str.ToArray())
            {
                if (!allowedChars.Contains(character))
                    return false;
            }
            return true;
        }

        private void wewBinTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!BinInputValidation(wewBinTb.Text))
            {
                MessageBox.Show(string.Format("Z造 format danych - akceptowany format to znaki '0' oraz '1' z ewentualnymi sapcjami."));
                e.Cancel = true;
            }
        }

        private void wewHexTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!HexInputValidation(wewHexTb.Text))
            {
                MessageBox.Show(string.Format("Z造 format danych - akceptowany format to znaki HEX z ewentualnymi sapcjami."));
                e.Cancel = true;
            }
        }

        private void ieeeBinTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!BinInputValidation(ieeeBinTb.Text))
            {
                MessageBox.Show(string.Format("Z造 format danych - akceptowany format to znaki '0' oraz '1' z ewentualnymi sapcjami."));
                e.Cancel = true;
            }
        }

        private void ieeeHexTb_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!HexInputValidation(ieeeHexTb.Text))
            {
                MessageBox.Show(string.Format("Z造 format danych - akceptowany format to znaki HEX z ewentualnymi sapcjami."));
                e.Cancel = true;
            }
        }
    }
}
