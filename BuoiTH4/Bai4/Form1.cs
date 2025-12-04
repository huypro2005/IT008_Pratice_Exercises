using System.Drawing.Text;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (var font in fonts.Families)
            {
                cmbFont.Items.Add(font.Name);
            }
            cmbFont.SelectedItem = "Tahoma";
            var sizes = new List<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var size in sizes)
            {
                cmbSize.Items.Add(size);
            }
            cmbSize.SelectedItem = 14;
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    style |= FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void btnNghieng_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    style |= FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline;
                }
                else
                {
                    style |= FontStyle.Underline;
                }
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }

        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void toolStripNewFile_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FilterIndex == 2)
                {
                    richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
                }

            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveFileMenu_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FilterIndex == 2)
                {
                    richTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void NewFileMenu_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newFile()
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Nội dung chưa được lưu. Bạn có muốn lưu lại không?",
                    "Thông báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    saveFile(); // Gọi lại hàm lưu file bạn đã viết ở câu trước
                }
                else if (result == DialogResult.Cancel)
                {
                    return; // Nếu chọn Cancel thì dừng lại, không làm gì cả
                }
                // Nếu chọn No thì đi tiếp xuống dưới (xóa không lưu)
            }

            // --- Bắt đầu tạo mới ---

            // 1. Xóa sạch nội dung cũ
            richTextBox1.Clear();

            // 2. Reset lại Font và Size mặc định (giống trên ToolStrip của bạn)
            // Ví dụ: Font Tahoma, Size 14
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);

            // 3. Reset lại các ComboBox trên ToolStrip về giá trị mặc định (để đồng bộ giao diện)
            if (cmbFont != null) cmbFont.SelectedItem = "Tahoma";
            if (cmbSize != null) cmbSize.SelectedItem = 14;
        }




        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Kiểm tra Null TRƯỚC khi làm bất cứ việc gì để tránh crash
            if (cmbSize.SelectedItem == null || cmbFont.SelectedItem == null)
            {
                return; // Nếu chưa chọn gì thì thoát hàm luôn
            }

            try
            {
                // 2. Lấy tên font và size
                string fontName = cmbFont.SelectedItem.ToString();
                float fontSize = float.Parse(cmbSize.SelectedItem.ToString());

                // 3. Giữ nguyên định dạng cũ (Đậm, Nghiêng, Gạch chân)
                // Nếu không có dòng này, đổi size xong sẽ bị mất in đậm/nghiêng
                FontStyle currentStyle = FontStyle.Regular;

                // Kiểm tra xem hiện tại đang chọn văn bản nào không
                if (richTextBox1.SelectionFont != null)
                {
                    currentStyle = richTextBox1.SelectionFont.Style;
                }

                // 4. Áp dụng Font mới với Size mới + Style cũ
                richTextBox1.SelectionFont = new Font(fontName, fontSize, currentStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn size: " + ex.Message);
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSize.SelectedItem == null || cmbFont.SelectedItem == null)
            {
                return; // Nếu chưa chọn gì thì thoát hàm luôn
            }

            try
            {
                // 2. Lấy tên font và size
                string fontName = cmbFont.SelectedItem.ToString();
                float fontSize = float.Parse(cmbSize.SelectedItem.ToString());

                // 3. Giữ nguyên định dạng cũ (Đậm, Nghiêng, Gạch chân)
                // Nếu không có dòng này, đổi size xong sẽ bị mất in đậm/nghiêng
                FontStyle currentStyle = FontStyle.Regular;

                // Kiểm tra xem hiện tại đang chọn văn bản nào không
                if (richTextBox1.SelectionFont != null)
                {
                    currentStyle = richTextBox1.SelectionFont.Style;
                }

                // 4. Áp dụng Font mới với Size mới + Style cũ
                richTextBox1.SelectionFont = new Font(fontName, fontSize, currentStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn size: " + ex.Message);
            }
        }
    }
}
