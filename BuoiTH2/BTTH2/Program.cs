using BTTH2.DanhSachBai;
using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        int chon;
        while (run)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chọn bài bạn muốn chạy (1-5) hoặc 0 để thoát: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Bai1.Cau1();
                    break;
                case 2:
                    Bai2 bai2 = new Bai2();
                    bai2.Cau2();
                    break;
                case 3:
                    Bai3 bai3 = new Bai3();
                    bai3.Cau3();
                    break;
                case 4:
                    Bai4 bai4 = new Bai4();
                    bai4.Cau4();
                    break;
                case 5:
                    Bai5 bai5 = new Bai5();
                    bai5.Cau5();
                    break;
                case 0:
                    run = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
 
    }
}
