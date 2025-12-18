using System.Drawing.Drawing2D;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai8
{
    public partial class Form1 : Form
    {
        // Change the Timer declaration to explicitly use System.Windows.Forms.Timer
        private readonly System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            Text = "Analog Clock";
            DoubleBuffered = true;      // chống nhấp nháy
            BackColor = Color.Black;
            ClientSize = new Size(420, 420);

            _timer.Interval = 50;
            _timer.Tick += (_, __) => Invalidate();
            _timer.Start();
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = ClientSize.Width;
            int h = ClientSize.Height;

            int size = Math.Min(w, h) - 30;
            float r = size / 2f;
            float cx = w / 2f;
            float cy = h / 2f;

            // đưa gốc tọa độ về tâm
            g.TranslateTransform(cx, cy);

            DrawDial(g, r);
            DrawHands(g, r);

            // trả transform
            g.ResetTransform();
        }

        private void DrawDial(Graphics g, float r)
        {
            // viền ngoài
            using (var pen = new Pen(Color.White, 2))
                g.DrawEllipse(pen, -r, -r, 2 * r, 2 * r);

            // chấm phút/giờ: 60 chấm, chấm giờ to hơn
            for (int i = 0; i < 60; i++)
            {
                double angle = (Math.PI * 2) * i / 60.0; // 0..2pi
                float x = (float)(Math.Sin(angle) * (r * 0.90));
                float y = (float)(-Math.Cos(angle) * (r * 0.90));

                bool isHour = (i % 5 == 0);
                float dotR = isHour ? r * 0.03f : r * 0.012f;

                using (var b = new SolidBrush(Color.White))
                    g.FillEllipse(b, x - dotR, y - dotR, dotR * 2, dotR * 2);
            }

            // tâm
            using (var b = new SolidBrush(Color.White))
                g.FillEllipse(b, -6, -6, 12, 12);
        }

        private void DrawHands(Graphics g, float r)
        {
            DateTime now = DateTime.Now;

            // góc (radian). 12 giờ là góc 0, quay theo kim đồng hồ
            double sec = now.Second + now.Millisecond / 1000.0;
            double min = now.Minute + sec / 60.0;
            double hour = (now.Hour % 12) + min / 60.0;

            double secAngle = (Math.PI * 2) * (sec / 60.0);
            double minAngle = (Math.PI * 2) * (min / 60.0);
            double hourAngle = (Math.PI * 2) * (hour / 12.0);

            // kim giờ
            DrawHand(g, hourAngle, r * 0.55f, 6, Color.White);

            // kim phút
            DrawHand(g, minAngle, r * 0.75f, 4, Color.White);

            // kim giây (đỏ)
            DrawHand(g, secAngle, r * 0.85f, 2, Color.Red);

            // nút tâm đè lên
            using (var b = new SolidBrush(Color.White))
                g.FillEllipse(b, -7, -7, 14, 14);
        }

        private void DrawHand(Graphics g, double angle, float length, float thickness, Color color)
        {
            // chuyển angle: sin/cos như dial ở trên
            float x = (float)(Math.Sin(angle) * length);
            float y = (float)(-Math.Cos(angle) * length);

            using var pen = new Pen(color, thickness)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
            g.DrawLine(pen, 0, 0, x, y);
        }

    }
}
