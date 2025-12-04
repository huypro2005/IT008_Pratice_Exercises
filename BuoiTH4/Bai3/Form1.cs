namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Media Files|*.mp3;*.mp4;*.wav;*.wmv;*.avi|All Files|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                WINPlayer.URL = dlg.FileName;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WINPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateStatus();
        }

        private void updateStatus()
        {
            DateTime now = DateTime.Now;
            String timeText = $"Hôm nay là ngày {now:dd/MM/yyyy} - Bây giờ là {now:HH:mm:ss} {now.ToString("tt")}";
            labelStatus.Text = timeText;
        }
    }
}
