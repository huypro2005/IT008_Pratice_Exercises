using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;

namespace Bai11
{
    public partial class Form1 : Form
    {
        private Point lastpoint;
        private bool isDrawing = false;
        private Color color = Color.Black;
        private float penWidth = 2.0f;
        private Brush brush = new SolidBrush(Color.Black);
        private int brushType = 0;  // 0: Solid, 1: Hatch, 2: Texture, 3: Gradient
        private int shapeType = 0; // 0: Line, 1: Rectangle, 2: Ellipse
        private Bitmap mainBitmap;
        private Graphics gBitmap;
        private Point currentPoint;
        private Bitmap textureImage;
        public Form1()
        {
            InitializeComponent();
            InitialComponentCustom();
            CreateSampleTexture();
            InitBitmap();
        }

        private void CreateSampleTexture()
        {
            // Tạo một ô vuông nhỏ 20x20 pixel có hình tròn bên trong để làm họa tiết
            textureImage = new Bitmap(20, 20);
            using (Graphics g = Graphics.FromImage(textureImage))
            {
                g.Clear(Color.White); // Nền trắng
                g.DrawEllipse(Pens.Blue, 0, 0, 18, 18); // Vẽ vòng tròn xanh
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void InitialComponentCustom()
        {
            panelControl.BackColor = Color.Beige;
            // Select Line by default
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            // 1. Vẽ hình nền cũ lên trước
            if (mainBitmap != null)
                e.Graphics.DrawImage(mainBitmap, 0, 0);

            // 2. Vẽ hình đang kéo chuột (Preview)
            if (isDrawing)
            {
                DrawShape(e.Graphics); // Gọi hàm vẽ chung
            }
        }

        private void DrawShape(Graphics g)
        {
            // Tính toán hình chữ nhật
            Rectangle rect = new Rectangle(
                Math.Min(lastpoint.X, currentPoint.X),
                Math.Min(lastpoint.Y, currentPoint.Y),
                Math.Abs(lastpoint.X - currentPoint.X),
                Math.Abs(lastpoint.Y - currentPoint.Y));

            // Tránh lỗi Gradient nếu kích thước = 0
            if (rect.Width == 0 || rect.Height == 0) return;

            switch (shapeType)
            {
                case 0: // Line (Vẫn dùng Pen để vẽ đường thẳng)
                    using (Pen pen = new Pen(color, penWidth))
                    {
                        g.DrawLine(pen, lastpoint, currentPoint);
                    }
                    break;

                case 1: // Rectangle (Dùng Brush để TÔ MÀU theo yêu cầu)
                    using (Brush b = GetCurrentBrush(rect))
                    {
                        g.FillRectangle(b, rect);
                    }
                    break;

                case 2: // Ellipse (Dùng Brush để TÔ MÀU theo yêu cầu)
                    using (Brush b = GetCurrentBrush(rect))
                    {
                        g.FillEllipse(b, rect);
                    }
                    break;
            }
        }
        private void InitBitmap()
        {
            // Chỉ tạo nếu panel có kích thước hợp lệ
            if (panelDrawing.Width > 0 && panelDrawing.Height > 0)
            {
                Bitmap newBitmap = new Bitmap(panelDrawing.Width, panelDrawing.Height);
                Graphics g = Graphics.FromImage(newBitmap);
                g.Clear(Color.White);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Copy hình cũ sang hình mới nếu có
                if (mainBitmap != null)
                {
                    g.DrawImage(mainBitmap, 0, 0);
                    mainBitmap.Dispose();
                    // Kiểm tra gBitmap có tồn tại không trước khi Dispose
                    if (gBitmap != null) gBitmap.Dispose();
                }

                mainBitmap = newBitmap;
                gBitmap = g;
            }
        }
        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastpoint = e.Location;
                isDrawing = true;
            }
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDrawing)
            {
                currentPoint = e.Location;
                (sender as Panel).Invalidate();
            }
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                currentPoint = e.Location;

                // KIỂM TRA AN TOÀN: Nếu gBitmap chưa được tạo thì không vẽ gì cả
                if (gBitmap == null) return;

                // Vẽ chốt hình vào Bitmap
                DrawShape(gBitmap);

                (sender as Panel).Invalidate();
            }
        }

        private void panelDrawing_SizeChanged(object sender, EventArgs e)
        {
            //Panel p = sender as Panel;
            //if (p.Width > 0 && p.Height > 0)
            //{
            //    Bitmap newBitmap = new Bitmap(p.Width, p.Height);
            //    Graphics g = Graphics.FromImage(newBitmap);
            //    g.Clear(Color.White);
            //    g.SmoothingMode = SmoothingMode.AntiAlias;
            //    if (mainBitmap != null)
            //    {
            //        g.DrawImage(mainBitmap, 0, 0);
            //        mainBitmap.Dispose();
            //        gBitmap.Dispose();
            //    }
            //    mainBitmap = newBitmap;
            //    gBitmap = g;
            //}
            InitBitmap();
        }

        private void textWidth_TextChanged(object sender, EventArgs e)
        {
            if (textWidth != null)
            {
                if (float.TryParse(textWidth.Text, out float width))
                {
                    penWidth = width;
                }
            }
        }

        private void radioLine_CheckedChanged(object sender, EventArgs e) { if (radioLine.Checked) shapeType = 0; }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { if (radioRectangle.Checked) shapeType = 1; } // Lưu ý: Tên hàm cũ của bạn là radioButton2
        private void radioElipse_CheckedChanged(object sender, EventArgs e) { if (radioElipse.Checked) shapeType = 2; }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                btnColor.BackColor = color;
            }
        }


        private Brush GetCurrentBrush(Rectangle rect)
        {
            switch (brushType)
            {
                case 0: // SolidBrush: Màu Green
                    return new SolidBrush(Color.Green);

                case 1: // HatchBrush: Horizontal, Blue & Green
                    return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);

                case 2: // TextureBrush: Tô bằng bitmap
                    return new TextureBrush(textureImage);

                case 3: // LinearGradientBrush: Vertical, Red & Green
                    // Gradient cần biết kích thước hình chữ nhật để tô màu chuyển sắc
                    return new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);

                default:
                    return new SolidBrush(Color.Green);
            }
        }
        private void radioSolidBrush_CheckedChanged(object sender, EventArgs e) { if (radioSolidBrush.Checked) brushType = 0; }
        private void radioHashBrush_CheckedChanged(object sender, EventArgs e) { if (radioHashBrush.Checked) brushType = 1; }
        private void radioTextureBrush_CheckedChanged(object sender, EventArgs e) { if (radioTextureBrush.Checked) brushType = 2; }
        private void radioLinear_CheckedChanged(object sender, EventArgs e) { if (radioLinear.Checked) brushType = 3; }

   

    }

}
