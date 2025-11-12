// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BTTH1
{
    class Program
    {
        static void Main( string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool run = true;
            while (run)
            {
                Console.WriteLine("Nhập để chọn bài");
                Console.WriteLine("1:  Viết chương trình cho phép tạo mảng một chiều gồm n số nguyên ngẫu nhiên. ");
                Console.WriteLine("2:  Viết chương trình nhập số nguyên dương n, tính tổng các số nguyên tố < n và \r\nxuất kết quả ra màn hình.");
                Console.WriteLine("3:  Viết chương trình nhập ngày tháng năm, cho biết ngày tháng năm đó có hợp lệ\r\nkhông?");
                Console.WriteLine("4:  Viết chương trình nhập vào tháng và năm. In ra số ngày của tháng đó.");
                Console.WriteLine("5:  Viết chương trình nhập vào ngày tháng năm, cho biết thứ trong tuần.");
                Console.WriteLine("6:  Viết chương trình cho phép tạo ma trận chứa các số nguyên ngẫu nhiên gồm n \r\ndòng, m cột. Cài đặt hàm thực hiện các chức năng sau:");
                Console.WriteLine("0:  Thoát");
                int chonBai = Convert.ToInt32(Console.ReadLine());
                switch (chonBai)
                {
                    case 1:
                        Console.WriteLine("Bai 1:");
                        Console.WriteLine("Nhập số lượng của mảng");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Bai1 bai1 = new Bai1(n);

                        Console.WriteLine("Các phần tử trong mảng:");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(bai1.arr[i] + "\t");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Cau a: Tính tổng các số lẻ trong mảng");
                        Console.WriteLine(bai1.TongCacSoLe());
                        Console.WriteLine("Cau b: Đếm số nguyên tố trong mảng");
                        Console.WriteLine(bai1.DemSNT());
                        Console.WriteLine("Cau c: Tìm số chính phương nhỏ nhất (nếu không có hàm trả về -1)");
                        Console.WriteLine(bai1.soChinhPhuongNhoNhat());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Bai 2:");
                        Bai2 bai2 = new Bai2();
                        bai2.TongCacSoNguyenToNhoHonN();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Bai 3:");
                        Bai3 bai3 = new Bai3();
                        bai3.NhapThoiGian();
                        if (bai3.checkNgayHopLe())
                        {
                            Console.WriteLine("Ngày hợp lệ.");
                        }
                        else
                        {
                            Console.WriteLine("Ngày không hợp lệ.");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Bài 4:");
                        Bai4 bai4 = new Bai4();
                        bai4.SoNgayCuaThangDo();
                        Console.WriteLine();
                        break;
                    case 5:

                        Console.WriteLine("Bai 5:");
                        Bai5 bai5 = new Bai5();
                        Console.WriteLine(bai5.ThuTrongTuan());
                        Console.WriteLine();
                        break;


                    case 6:

                        Console.WriteLine("Bai 6:");
                        Bai6 bai6 = new Bai6();
                        bai6.xuatMaTran();
                        Console.WriteLine();
                        Console.WriteLine("Cau b: Phan tử lớn nhất, nhỏ nhất");
                        int[] a = bai6.PhanTuLonNhoNhat();
                        Console.Write("Phan Tu nho nhat: ");
                        Console.WriteLine(a[0]);
                        Console.Write("Phan Tu lon nhat: ");
                        Console.WriteLine(a[1]);
                        Console.Write("\n");
                        Console.WriteLine("Cau c: Tìm dòng có tổng lớn nhất");
                        int[] line = bai6.LineCoTongLonNhat();
                        for (int i = 0; i < line.Length; i++)
                        {
                            Console.Write(line[i] + "\t");
                        }
                        Console.WriteLine();

                        Console.WriteLine("Cau d: Tính tổng các số không phải là số nguyên tố ");
                        long tongCacSoKhongLaSNT = bai6.TongCacSoKhongPhaiNguyenTo();
                        Console.Write("Tong cac so khong phai so nguyen to la: " + tongCacSoKhongLaSNT);
                        Console.WriteLine();
                        Console.WriteLine("Cau e: Xóa dòng thứ k trong ma trận");
                        Console.WriteLine("Ma Tran truoc khi xoa hang k");
                        bai6.xuatMaTran();
                        Console.Write("Nhap k: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        bai6.xoaLineK(k);
                        bai6.xuatMaTran();
                        Console.WriteLine();
                        Console.WriteLine("Cau f: Xóa cột chứa phần tử lớn nhất trong ma trận ");
                        Console.WriteLine("Ma Tran truoc khi xoa hang k");
                        bai6.xuatMaTran();
                        Console.Write("Nhap k: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        bai6.xoaColK(k);
                        bai6.xuatMaTran();
                        Console.WriteLine();
                        break;

                    default:
                        run = false;
                        break;
                }
            }
            


        }
    }
    

    class Bai1
    {
        public int n;
        public int[] arr;
        public Bai1(int n)
        {
            this.n = n;
            Random random = new Random();
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(100);
            }

        }

        public long TongCacSoLe()
        {
            long res = 0;
            for (int i=0; i<n;i++)
            {
                if (arr[i]%2 != 0)
                {
                    res += arr[i];
                }
            }
            return res;
        }

        public bool snt(int n)
        {
            float tmp = (float)Math.Sqrt(n);
            for (int i = 2; i < tmp; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int DemSNT()
        {
            int count = 0;
            for (int i=0; i < n; i++)
            {
                if (snt(this.arr[i])){
                    count++;
                }
            }
            return count;
        }

        public bool SoChinhPhuong(int n)
        {
            int tmp = (int)Math.Sqrt(n);
            if (tmp*tmp  == n)
            {
                return true;
            }
            return false;
        }

        public int soChinhPhuongNhoNhat()
        {
            int res = 9999999;
            bool check = false;
            for(int i=0; i < n; i++)
            {
                if (SoChinhPhuong(this.arr[i]))
                {
                    check = true;
                    if (this.arr[i] < res)
                    {
                        res = this.arr[i];
                    }
                }
            }
            if (check)
            {
                return res;
            }
            return -1;
        }


        
    }


    class Bai2
    {
        Bai1 a = new Bai1(5);
        public void TongCacSoNguyenToNhoHonN()
        {
            Console.WriteLine("Nhap so nguyen duong n:");
            int n = Convert.ToInt32(Console.ReadLine());
            long res = 0;
            for (int i = 2; i < n; i++)
            {
                if (a.snt(i))
                {
                    res += i;
                }
            }
            // Replace this line in class Bai2:
            // Console.WriteLine(f"Tổng các số nguyên tố bé hơn {n} là: {res}");

            // With this corrected line using string interpolation:
            Console.WriteLine($"Tổng các số nguyên tố bé hơn {n} là: {res}");
        }
    }

    class Bai3
    {
        public int ngay { get; set; }
        public int thang { get; set; }
        public int nam {  get; set; }
        public void NhapThoiGian()
        {
            Console.WriteLine("Nhap Ngay:");
            ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Thang:");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Nam:");
            nam = Convert.ToInt32(Console.ReadLine());

        }

        public bool checkNgayHopLe()
        { 
            if (nam < 0)
            {
                return false;
            }
            if (thang < 0 && thang > 12)
            {
                return false;
            }
            int ngayMax = soNgayCuaThang(thang, nam);
            //Console.WriteLine(ngayMax);
            if (ngay < 0 || ngay > ngayMax)
            {
                return false;
            }
            return true;

        }
        public bool checkNamNhuan(int nam)
        {
            if(nam%400 == 0 || (nam%100!=0 && nam % 4 == 0)){
                return true;
            }
            return false;

        }

        public int soNgayCuaThang(int thang, int nam)
        {
            if (thang ==1 ||thang==3||thang==5 ||thang ==7 ||thang==8 ||thang==10 || thang==12)
            {
                return 31;
            }
            else if (thang ==4||thang==6||thang==9||thang==11)
            {
                return 30;
            }
            else if (thang == 2)
            {
                if (checkNamNhuan(nam))
                {
                    return 29;
                }
                return 28;
            }
            else
            {
                return -1;
            }


        }
    }

    class Bai4
    {
        Bai3 b = new Bai3();
        public void SoNgayCuaThangDo()
        {
            Console.WriteLine("Nhap Thang:");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Nam:");
            int nam = Convert.ToInt32(Console.ReadLine());
            int ngay = b.soNgayCuaThang(thang, nam);
            if (ngay != -1)
            {
                Console.WriteLine($"Số ngày của tháng: {ngay}");
            }
            else
            {
                Console.WriteLine("Thời gian không hợp lệ");
            }
            

        }
    }

    class Bai5
    {
        Bai3 b = new Bai3();
        public string ThuTrongTuan()
        {
            Console.WriteLine("Nhap Ngay:");
            int ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Thang:");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Nam:");
            int nam = Convert.ToInt32(Console.ReadLine());
            b.ngay = ngay;
            b.thang = thang;
            b.nam = nam;
            if (b.checkNgayHopLe())
            {
                int[] t = [0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4];
                if (thang < 3)
                {
                    nam -= 1;
                }
                int h = (nam + (int)nam / 4 - (int)nam / 100 + (int)nam / 400 + t[thang - 1] + ngay) % 7;
                string[] a = ["Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy"];
                return a[h];
            }
            return "Lỗi ngày tháng năm";
        }
    }

    class Bai6
    {
        public int n, m;
        public int[][] arr;
        public Bai6()
        {
            Console.WriteLine("Nhap n");
            this.n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap m");
            this.m = Convert.ToInt32(Console.ReadLine());
            arr = new int[this.n][];
            Random random = new Random();
            for (int i = 0; i < this.n; i++)
            {
                arr[i] = new int[this.m];
                for(int j = 0; j < this.m; j++)
                {
                    arr[i][j] = random.Next(100);
                }

            }
        }

        public void xuatMaTran()
        {
            for (int i = 0;i < this.n; i++)
            {
                for(int j = 0; j < this.m; j++)
                {
                    Console.Write(arr[i][j]+ "\t");
                }
                Console.WriteLine();
            }
        }
        public int[] PhanTuLonNhoNhat()
        {
            int minx = this.arr[0][0];
            int maxx = this.arr[0][0];
            for (int i = 0; i< this.n; i++)
            {
                for (int j =0; j< this.m; j++)
                {
                    if (this.arr[i][j] < minx)
                    {
                        minx = arr[i][j];
                    }
                    if (this.arr[i][j] > maxx)
                    {
                        maxx = arr[i][j];
                    }
                }
            }
            return new[] { minx, maxx};

        }

        public bool snt(int n)
        {
            float tmp = (float)Math.Sqrt(n);
            for (int i = 2; i < tmp; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int[] LineCoTongLonNhat()
        {
            int[] line = new int[this.m];
            int res = 0;
            for (int i=0; i< this.n; i++)
            {
                int tmp = 0;
                for (int j =0; j< this.m; j++)
                {
                    tmp += arr[i][j];
                }
                if (tmp > res)
                {
                    line = arr[i];
                    res = tmp;
                }
            }
            Console.ReadLine();
            return line;
        }

        public long TongCacSoKhongPhaiNguyenTo()
        {
            long res = 0;
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    if (!snt(arr[i][j]))
                    {
                        res += arr[i][j];
                    }
                }
             
            }
            return res;
        }

        public void xoaLineK(int k)
        {
            if (k > n)
            {
                Console.WriteLine("Out of range"); ;
                return;
            }
            for (int i=0; i< this.n-1; i++)
            {
                if (i >= k - 1)
                {
                    arr[i] = arr[i + 1];
                }
            }
            arr[n - 1] = null;
            n -= 1;
        }

        public void xoaColK(int k)
        {
            if (k > m)
            {
                Console.WriteLine("Out of range");
                return;
            }
            for (int i=0; i< m-1; i++)
            {
                for (int j=0; j< n; j++)
                {
                    if (i >= k - 1)
                    {
                        arr[j][i] = arr[j][i+ 1];
                    }      
                }
                Array.Resize(ref arr[n], m-1);
            }
           
            m -= 1;
            
        }
        
    }

}