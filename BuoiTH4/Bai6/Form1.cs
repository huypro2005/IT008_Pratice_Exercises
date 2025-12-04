namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selectSourceBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                sourceBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void selectDistBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                distBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcePath = sourceBox.Text;
                string distPath = distBox.Text;
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(sourcePath);
                System.IO.FileInfo[] files = dir.GetFiles();
                progress.Maximum = files.Length;
                int count = 0;
                string preLabel = "Đang sao chép: ";
                foreach (System.IO.FileInfo file in files)
                {
                    string tempPath = System.IO.Path.Combine(distPath, file.Name);
                    file.CopyTo(tempPath, true);
                    count++;
                    progress.Value = count;
                    labelProgress.Text = $"{preLabel}{tempPath}";
                    Application.DoEvents(); // Cập nhật giao diện người dùng
                }
                MessageBox.Show("Sao chép thành công");
                progress.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }
    }
}
