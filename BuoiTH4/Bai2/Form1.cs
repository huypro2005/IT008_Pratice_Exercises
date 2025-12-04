using System.Globalization;
namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại và định dạng giống hệt trong ảnh
            // dddd: Thứ (Wednesday)
            // MMMM: Tháng (October)
            // dd: Ngày (03)
            // yyyy: Năm (2007)
            // h:mm:ss tt: Giờ:Phút:Giây (AM/PM)

            timeLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy h:mm:ss tt");
        }
    }
}
