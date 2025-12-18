using System.Drawing.Drawing2D;

namespace Bai10
{
    public partial class Form1 : Form
    {
        private readonly ComboBox cboDashStyle = new ComboBox();
        private readonly NumericUpDown nudWidth = new NumericUpDown();
        private readonly ComboBox cboLineJoin = new ComboBox();
        private readonly ComboBox cboDashCap = new ComboBox();
        private readonly ComboBox cboStartCap = new ComboBox();
        private readonly ComboBox cboEndCap = new ComboBox();
        private readonly Panel canvas = new Panel();
        public Form1()
        {
            Text = "Pen Demo";
            ClientSize = new Size(720, 420);
            DoubleBuffered = true;

            var split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                SplitterDistance = 260,
                FixedPanel = FixedPanel.Panel1
            };
            Controls.Add(split);

            // ==== LEFT: controls ====
            var left = split.Panel1;
            left.Padding = new Padding(12);

            int y = 10;
            AddLabel(left, "Dash Style:", ref y);
            SetupCombo(cboDashStyle, left, ref y, new object[]
            {
            DashStyle.Solid, DashStyle.Dash, DashStyle.Dot, DashStyle.DashDot, DashStyle.DashDotDot
            });

            AddLabel(left, "Width:", ref y);
            nudWidth.Parent = left;
            nudWidth.SetBounds(0, y, 220, 28);
            nudWidth.Minimum = 1;
            nudWidth.Maximum = 30;
            nudWidth.Value = 9;
            nudWidth.ValueChanged += (_, __) => canvas.Invalidate();
            y += 40;

            AddLabel(left, "Line Join:", ref y);
            SetupCombo(cboLineJoin, left, ref y, new object[]
            {
            LineJoin.Miter, LineJoin.Bevel, LineJoin.Round
            });

            AddLabel(left, "Dash Cap:", ref y);
            SetupCombo(cboDashCap, left, ref y, new object[]
            {
            DashCap.Flat, DashCap.Round, DashCap.Triangle
            });

            AddLabel(left, "Start Cap:", ref y);
            SetupCombo(cboStartCap, left, ref y, new object[]
            {
            LineCap.Flat, LineCap.Round, LineCap.Square, LineCap.Triangle, LineCap.RoundAnchor, LineCap.ArrowAnchor
            });

            AddLabel(left, "End Cap:", ref y);
            SetupCombo(cboEndCap, left, ref y, new object[]
            {
            LineCap.Flat, LineCap.Round, LineCap.Square, LineCap.Triangle, LineCap.RoundAnchor, LineCap.ArrowAnchor
            });

            // defaults giống kiểu demo
            cboDashStyle.SelectedItem = DashStyle.DashDot;
            cboLineJoin.SelectedItem = LineJoin.Round;
            cboDashCap.SelectedItem = DashCap.Triangle;
            cboStartCap.SelectedItem = LineCap.Triangle;
            cboEndCap.SelectedItem = LineCap.RoundAnchor;

            // ==== RIGHT: canvas ====
            var right = split.Panel2;
            right.Padding = new Padding(12);

            canvas.Dock = DockStyle.Fill;
            canvas.BackColor = Color.White;
            canvas.Paint += Canvas_Paint;
            right.Controls.Add(canvas);
            InitializeComponent();
        }
        


        private void Canvas_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float w = (float)nudWidth.Value;

            using var pen = new Pen(Color.Red, w);

            // lấy option từ combobox (đã add enum trực tiếp)
            pen.DashStyle = (DashStyle)cboDashStyle.SelectedItem!;
            pen.LineJoin = (LineJoin)cboLineJoin.SelectedItem!;
            pen.DashCap = (DashCap)cboDashCap.SelectedItem!;
            pen.StartCap = (LineCap)cboStartCap.SelectedItem!;
            pen.EndCap = (LineCap)cboEndCap.SelectedItem!;

            // Vẽ 1 polyline để thấy rõ: start cap, dash, line join, end cap
            var rect = canvas.ClientRectangle;
            rect.Inflate(-40, -40);

            PointF p1 = new PointF(rect.Left + 40, rect.Top + 30);
            PointF p2 = new PointF(rect.Left + rect.Width * 0.55f, rect.Top + rect.Height * 0.55f);
            PointF p3 = new PointF(rect.Left + rect.Width * 0.80f, rect.Top + rect.Height * 0.25f);
            PointF p4 = new PointF(rect.Right - 30, rect.Bottom - 30);

            g.DrawLines(pen, new[] { p1, p2, p3, p4 });

            // (tuỳ chọn) vẽ điểm để dễ nhìn khúc gấp
            using var b = new SolidBrush(Color.FromArgb(60, Color.Black));
            foreach (var p in new[] { p1, p2, p3, p4 })
                g.FillEllipse(b, p.X - 4, p.Y - 4, 8, 8);
        }

        private static void AddLabel(Control parent, string text, ref int y)
        {
            var lb = new Label
            {
                Parent = parent,
                Text = text,
                AutoSize = true,
                Top = y,
                Left = 0
            };
            y += 22;
        }

        private void SetupCombo(ComboBox cbo, Control parent, ref int y, object[] items)
        {
            cbo.Parent = parent;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SetBounds(0, y, 220, 28);
            cbo.Items.Clear();
            cbo.Items.AddRange(items);
            cbo.SelectedIndexChanged += (_, __) => canvas.Invalidate();
            cbo.SelectedIndex = 0;
            y += 40;
        }
    }
}