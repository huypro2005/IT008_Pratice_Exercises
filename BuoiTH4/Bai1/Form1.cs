namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            alert.Text = $"Chuột được nhấn tại vị trí ({e.X}, {e.Y})";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            alert.Text = $"Phím được nhấn: {e.KeyCode}, ASCII: {(int)e.KeyCode}";

        }
    }
}
