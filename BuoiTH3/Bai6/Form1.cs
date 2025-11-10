namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            double res = Math.Sqrt(textNum);
            textBox.Text = res.ToString();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += "9";
        }

        private void btnBackS_Click(object sender, EventArgs e)
        {
            string s = textBox.Text;
            textBox.Text = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                textBox.Text += s[i];
            }
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            temp = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }


        private void btnPoint_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            updateTemp(textNum);
            textBox.Text = "0";
            previous = 0;
        }




        private void btnEqual_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            updateTemp(textNum);
            textBox.Text = temp.ToString();
            previous = 0;
            temp = 0;
        }


        private void updateTemp(double num)
        {
            if (previous == 0) temp += num;
            else if (previous == 1) temp -= num;
            else if (previous == 2) temp *= num;
            else if (previous == 3) temp /= num;
            else if (previous == 4) temp %= num;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            updateTemp(textNum);
            textBox.Text = "0";
            previous = 1;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            updateTemp(textNum);
            textBox.Text = "0";
            previous = 2;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            updateTemp(textNum);
            textBox.Text = "0";
            previous = 3;
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0") return;
            string s = textBox.Text;
            textBox.Text = "";
            if (s[0] != '-')
            {
                textBox.Text = "-" + s;
            }
            else
            {
                for (int i = 1; i < s.Length; i++)
                {
                    textBox.Text += s[i];
                }
            }
        }

        private void btnDividedBy1_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            textBox.Text = "";
            double res = 1 / textNum;
            textBox.Text = res.ToString();

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            updateTemp(textNum);
            textBox.Text = "0";
            previous = 4;
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            temp = 0;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            temp += textNum;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            textBox.Text = temp.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            double textNum = double.Parse(textBox.Text);
            temp = textNum;
        }
    }
}
