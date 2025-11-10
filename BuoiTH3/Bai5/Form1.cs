namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (EmptyTextBox(num1)) return;
            if (EmptyTextBox(num2)) return;
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            double res = a + b;
            answer.Text = res.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (EmptyTextBox(num1)) return;
            if (EmptyTextBox(num2)) return;
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            double res = a - b;
            answer.Text = res.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (EmptyTextBox(num1)) return;
            if (EmptyTextBox(num2)) return;
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            double res = a * b;
            answer.Text = res.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (EmptyTextBox(num1)) return;
            if (EmptyTextBox(num2)) return;
            double a = double.Parse(num1.Text);
            double b = double.Parse(num2.Text);
            if (b==0)
            {
                MessageBox.Show("Mẫu số khác 0");
                return;
            }
            double res = a / b;
            answer.Text = Math.Round(res, 2).ToString();
        }

        private bool EmptyTextBox(TextBox a)
        {
            if (string.IsNullOrEmpty(a.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
                return true;
            }
            return false;
        }
    }
}
