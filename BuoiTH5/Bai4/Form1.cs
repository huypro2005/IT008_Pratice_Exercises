namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }


        private void InitializeCustomComponents()
        {
            checkBold.Font = new Font(checkBold.Font, FontStyle.Bold);
            checkI.Font = new Font(checkI.Font, FontStyle.Italic);
            checkU.Font = new Font(checkU.Font, FontStyle.Underline);


            fontBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontBox.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
            fontBox.Text = "Arial";

            sizeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 8; i < 72; i += 2)
            {
                sizeBox.Items.Add(i.ToString());
            }
            sizeBox.Text = "12";

            textShow.Font = new Font("Arial", 12);
            textShow.Text = "Hello";
            textShow.BackColor = Color.White;
            textShow.ForeColor = Color.Red;
            textShow.TextAlign = ContentAlignment.MiddleLeft;

            radioLeft.Checked = true;

            fontBox.SelectedIndexChanged += (s, e) => updatePreview();
            sizeBox.SelectedIndexChanged += (s, e) => updatePreview();
            checkBold.CheckedChanged += (s, e) => updatePreview();
            checkI.CheckedChanged += (s, e) => updatePreview();
            checkU.CheckedChanged += (s, e) => updatePreview();
            radioLeft.CheckedChanged += (s, e) => updatePreview();
            radioCenter.CheckedChanged += (s, e) => updatePreview();
            radioRight.CheckedChanged += (s, e) => updatePreview();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updatePreview()
        {
            string fontName = fontBox.SelectedItem.ToString();
            float fontSize = float.Parse(sizeBox.SelectedItem.ToString());

            FontStyle style = FontStyle.Regular;
            if (checkBold.Checked) style |= FontStyle.Bold;
            if (checkI.Checked) style |= FontStyle.Italic;
            if (checkU.Checked) style |= FontStyle.Underline;

            textShow.Font = new Font(fontName, fontSize, style);
            if (radioLeft.Checked)
                textShow.TextAlign = ContentAlignment.MiddleLeft;
            else if (radioCenter.Checked)
                textShow.TextAlign = ContentAlignment.MiddleCenter;
            else if (radioRight.Checked)
                textShow.TextAlign = ContentAlignment.MiddleRight;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textShow.ForeColor = colorDialog.Color;
            }
        }
    }
}
