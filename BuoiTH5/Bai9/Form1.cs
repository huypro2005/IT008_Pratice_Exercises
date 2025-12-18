using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        private ComboBox cboShape = new ComboBox();
        private Panel canvas = new Panel();
        public Form1()
        {
            Text = "ComboBoxTest";
            Width = 520;
            Height = 420;

            cboShape.Dock = DockStyle.Top;
            cboShape.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShape.Items.AddRange(new object[]
            {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie",
            });
            cboShape.SelectedIndex = 0;
            cboShape.SelectedIndexChanged += (_, __) => canvas.Invalidate();

            canvas.Dock = DockStyle.Fill;
            canvas.BackColor = Color.White;
            canvas.Paint += Canvas_Paint;

            Controls.Add(canvas);
            Controls.Add(cboShape);
            DoubleBuffered = true;
            InitializeComponent();
        }
        private void Canvas_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // vùng vẽ "đẹp": chừa lề
            Rectangle rect = canvas.ClientRectangle;
            rect.Inflate(-60, -60);

            // màu giống hình minh hoạ (đỏ sẫm)
            using var fillBrush = new SolidBrush(Color.FromArgb(140, 20, 20));
            using var borderPen = new Pen(Color.Black, 2);

            string mode = cboShape.SelectedItem?.ToString() ?? "Circle";
            bool filled = mode.StartsWith("Filled ");
            string shape = filled ? mode.Replace("Filled ", "") : mode;

            switch (shape)
            {
                case "Circle":
                    // ép vuông để thành hình tròn
                    Rectangle circleRect = MakeSquare(rect);
                    if (filled) g.FillEllipse(fillBrush, circleRect);
                    else g.DrawEllipse(borderPen, circleRect);
                    break;

                case "Square":
                    Rectangle sq = MakeSquare(rect);
                    if (filled) g.FillRectangle(fillBrush, sq);
                    else g.DrawRectangle(borderPen, sq);
                    break;

                case "Ellipse":
                    if (filled) g.FillEllipse(fillBrush, rect);
                    else g.DrawEllipse(borderPen, rect);
                    break;

                case "Pie":
                    // vẽ hình quạt (ví dụ 30° -> 300°)
                    float startAngle = 30f;
                    float sweepAngle = 300f;
                    if (filled) g.FillPie(fillBrush, rect, startAngle, sweepAngle);
                    else g.DrawPie(borderPen, rect, startAngle, sweepAngle);
                    break;
            }
        }

        private static Rectangle MakeSquare(Rectangle r)
        {
            int side = Math.Min(r.Width, r.Height);
            int x = r.X + (r.Width - side) / 2;
            int y = r.Y + (r.Height - side) / 2;
            return new Rectangle(x, y, side, side);
        }

  
    }
}
