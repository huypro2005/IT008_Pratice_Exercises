using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2.DanhSachBai
{
    internal class Bai1
    {
        public static void Cau1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tháng và năm: \n");
            Console.Write("Tháng: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Năm: ");
            int year = int.Parse(Console.ReadLine());
            new Bai1().PrintCalendar(month, year);

        }
        public void PrintCalendar(int month, int year)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            var first = new DateTime(year, month, 1);
            int startCol = (int)first.DayOfWeek; // Sunday=0 ... Saturday=6

            // ─ │ ┌ ┬ ┐ ├ ┼ ┤ └ ┴ ┘
            int cellWidth = 6; // rộng mỗi ô
            string title = $"Month: {month:00}/{year}";
            Console.WriteLine(title.PadLeft((cellWidth + 1) * 7));

            DrawLine('┌', '┬', '┐', '─', cellWidth);

            // Header: Sun..Sat (căn giữa)
            string[] headers = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Console.Write('│');
            for (int i = 0; i < 7; i++)
            {
                string h = Center(headers[i], cellWidth);
                Console.Write(h + '│');
            }
            Console.WriteLine();

            DrawLine('├', '┼', '┤', '─', cellWidth);

            int day = 1;
            // Tối đa 6 hàng (tuần)
            for (int row = 0; row < 6 && day <= daysInMonth; row++)
            {
                Console.Write('│');
                for (int col = 0; col < 7; col++)
                {
                    if (row == 0 && col < startCol) // ô trống trước ngày 1
                    {
                        Console.Write(new string(' ', cellWidth) + '│');
                    }
                    else if (day <= daysInMonth)
                    {
                        // In ngày, canh phải 2 chữ số, ví dụ 06
                        string cell = $"{day:00}".PadLeft(2);
                        string content = cell.PadLeft(2).PadRight(cellWidth);
                        Console.Write(content + '│');
                        day++;
                    }
                    else
                    {
                        Console.Write(new string(' ', cellWidth) + '│');
                    }
                }
                Console.WriteLine();

                // Kẻ đường giữa các hàng (trừ hàng cuối nếu đã hết ngày)
                if (day <= daysInMonth)
                    DrawLine('├', '┼', '┤', '─', cellWidth);
            }

            DrawLine('└', '┴', '┘', '─', cellWidth);
        }

        public void DrawLine(char left, char mid, char right, char h, int cellWidth)
        {
            Console.Write(left);
            for (int i = 0; i < 7; i++)
            {
                Console.Write(new string(h, cellWidth));
                Console.Write(i < 6 ? mid : right);
            }
            Console.WriteLine();
        }

        public string Center(string s, int width)
        {
            if (s.Length >= width) return s.Substring(0, width);
            int pad = width - s.Length;
            int left = pad / 2;
            int right = pad - left;
            return new string(' ', left) + s + new string(' ', right);
        }
    }
}
