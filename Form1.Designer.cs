namespace IEEE754_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            wewHexTb = new TextBox();
            wewBinTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ieeeHexTb = new TextBox();
            ieeeBinTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            iEEEWewCOnversionRb = new RadioButton();
            wewIEEEConvesionRb = new RadioButton();
            groupBox4 = new GroupBox();
            button2 = new Button();
            hexRb = new RadioButton();
            binRb = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(wewHexTb);
            groupBox1.Controls.Add(wewBinTb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kodowanie wew.";
            // 
            // wewHexTb
            // 
            wewHexTb.Location = new Point(79, 101);
            wewHexTb.Name = "wewHexTb";
            wewHexTb.ReadOnly = true;
            wewHexTb.Size = new Size(606, 23);
            wewHexTb.TabIndex = 3;
            wewHexTb.Validating += wewHexTb_Validating;
            // 
            // wewBinTb
            // 
            wewBinTb.Location = new Point(79, 66);
            wewBinTb.Name = "wewBinTb";
            wewBinTb.Size = new Size(606, 23);
            wewBinTb.TabIndex = 2;
            wewBinTb.Validating += wewBinTb_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "HEX";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 69);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 0;
            label1.Text = "BIN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ieeeHexTb);
            groupBox2.Controls.Add(ieeeBinTb);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 156);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kodowanie IEEE754";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // ieeeHexTb
            // 
            ieeeHexTb.Location = new Point(79, 99);
            ieeeHexTb.Name = "ieeeHexTb";
            ieeeHexTb.ReadOnly = true;
            ieeeHexTb.Size = new Size(606, 23);
            ieeeHexTb.TabIndex = 5;
            ieeeHexTb.Validating += ieeeHexTb_Validating;
            // 
            // ieeeBinTb
            // 
            ieeeBinTb.Location = new Point(79, 67);
            ieeeBinTb.Name = "ieeeBinTb";
            ieeeBinTb.ReadOnly = true;
            ieeeBinTb.Size = new Size(606, 23);
            ieeeBinTb.TabIndex = 4;
            ieeeBinTb.Validating += ieeeBinTb_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 102);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "HEX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 70);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 2;
            label4.Text = "BIN";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(iEEEWewCOnversionRb);
            groupBox3.Controls.Add(wewIEEEConvesionRb);
            groupBox3.Location = new Point(413, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Konwersja";
            // 
            // button1
            // 
            button1.Location = new Point(117, 31);
            button1.Name = "button1";
            button1.Size = new Size(143, 44);
            button1.TabIndex = 2;
            button1.Text = "Konwertuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // iEEEWewCOnversionRb
            // 
            iEEEWewCOnversionRb.AutoSize = true;
            iEEEWewCOnversionRb.Location = new Point(18, 56);
            iEEEWewCOnversionRb.Name = "iEEEWewCOnversionRb";
            iEEEWewCOnversionRb.Size = new Size(93, 19);
            iEEEWewCOnversionRb.TabIndex = 1;
            iEEEWewCOnversionRb.Text = "IEEE -> WEW";
            iEEEWewCOnversionRb.UseVisualStyleBackColor = true;
            iEEEWewCOnversionRb.CheckedChanged += toggleInputMode;
            // 
            // wewIEEEConvesionRb
            // 
            wewIEEEConvesionRb.AutoSize = true;
            wewIEEEConvesionRb.Checked = true;
            wewIEEEConvesionRb.Location = new Point(18, 31);
            wewIEEEConvesionRb.Name = "wewIEEEConvesionRb";
            wewIEEEConvesionRb.Size = new Size(93, 19);
            wewIEEEConvesionRb.TabIndex = 0;
            wewIEEEConvesionRb.TabStop = true;
            wewIEEEConvesionRb.Text = "WEW -> IEEE";
            wewIEEEConvesionRb.UseVisualStyleBackColor = true;
            wewIEEEConvesionRb.CheckedChanged += toggleInputMode;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(hexRb);
            groupBox4.Controls.Add(binRb);
            groupBox4.Location = new Point(12, 176);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(259, 90);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Typ danych wej.";
            // 
            // button2
            // 
            button2.Location = new Point(132, 28);
            button2.Name = "button2";
            button2.Size = new Size(107, 44);
            button2.TabIndex = 2;
            button2.Text = "wyczyść dane";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hexRb
            // 
            hexRb.AutoSize = true;
            hexRb.Location = new Point(25, 53);
            hexRb.Name = "hexRb";
            hexRb.Size = new Size(47, 19);
            hexRb.TabIndex = 1;
            hexRb.Text = "HEX";
            hexRb.UseVisualStyleBackColor = true;
            hexRb.CheckedChanged += toggleInputMode;
            // 
            // binRb
            // 
            binRb.AutoSize = true;
            binRb.Checked = true;
            binRb.Location = new Point(25, 28);
            binRb.Name = "binRb";
            binRb.Size = new Size(44, 19);
            binRb.TabIndex = 0;
            binRb.TabStop = true;
            binRb.Text = "BIN";
            binRb.UseVisualStyleBackColor = true;
            binRb.CheckedChanged += toggleInputMode;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox wewHexTb;
        private TextBox wewBinTb;
        private TextBox ieeeHexTb;
        private TextBox ieeeBinTb;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Button button1;
        private RadioButton iEEEWewCOnversionRb;
        private RadioButton wewIEEEConvesionRb;
        private GroupBox groupBox4;
        private RadioButton hexRb;
        private RadioButton binRb;
        private Button button2;
    }
}
