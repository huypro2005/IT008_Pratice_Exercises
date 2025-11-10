namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
