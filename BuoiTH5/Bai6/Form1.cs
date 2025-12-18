namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            // Custom initialization code can go here

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;

            // 2. Tăng chiều cao dòng. Font size 14 cần khoảng 25-30px, mặc định 13px sẽ bị cắt chữ.
            listBox1.ItemHeight = 30;

            foreach (var font in FontFamily.Families)
            {
                listBox1.Items.Add(font.Name);
            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Kiểm tra nếu danh sách rỗng hoặc index lỗi thì không làm gì
            if (e.Index < 0) return;

            // 1. Vẽ nền (Background)
            // Tự động xử lý màu xanh khi chọn, màu trắng khi không chọn
            e.DrawBackground();

            // 2. Lấy tên font từ item hiện tại
            string fontName = listBox1.Items[e.Index].ToString();

            // 3. Tạo Font để vẽ
            Font fontToDraw;
            try
            {
                // Cố gắng tạo font theo tên, cỡ chữ 14
                fontToDraw = new Font(fontName, 14, FontStyle.Regular);
            }
            catch
            {
                // Một số font lỗi hoặc không có kiểu Regular sẽ gây crash
                // Nếu lỗi, dùng font mặc định Arial
                fontToDraw = new Font("Arial", 14, FontStyle.Italic);
            }

            // 4. Chọn màu bút vẽ (Brush)
            // Nếu đang chọn dòng đó -> Chữ màu trắng. Nếu không -> Chữ màu đen
            Brush textBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                textBrush = Brushes.White;
            }
            else
            {
                textBrush = Brushes.Black;
            }

            // 5. Vẽ chuỗi tên font ra màn hình bằng chính font đó
            // e.Bounds là hình chữ nhật bao quanh dòng hiện tại
            e.Graphics.DrawString(fontName, fontToDraw, textBrush, e.Bounds.X + 2, e.Bounds.Y + 2);

            // 6. Vẽ viền nét đứt khi focus (nếu cần)
            e.DrawFocusRectangle();

            // 7. Dọn dẹp bộ nhớ (Rất quan trọng khi làm việc với Font)
            // Trừ font Arial mặc định ra thì dispose các font do mình tạo
            if (fontName != "Arial")
            {
                fontToDraw.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
