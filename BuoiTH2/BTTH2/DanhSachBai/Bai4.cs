using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2.DanhSachBai
{
    internal class Bai4
    {


        public void Cau4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nhập {n} phân số:");
            PhanSo[] listPhanSo = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                listPhanSo[i] = new PhanSo();
                listPhanSo[i].Nhap();
            }
            Console.WriteLine("Danh sách phân số vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(listPhanSo[i] + "\t");
            }
            Console.WriteLine();

            int chon = 0;
            bool run = true;
            while (run)
            {
                Console.WriteLine("Chọn phép toán bạn muốn thực hiện: ");
                Console.WriteLine("1. Phân số lớn nhất");
                Console.WriteLine("2. Dãy phân số tăng dần");
                Console.WriteLine("0. Thoát");
                Console.Write("Mời bạn chọn (1-2) hoặc 0 để thoát: ");
                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        PhanSo max = listPhanSo[0];
                        for (int i = 1; i < n; i++)
                        {
                            if (listPhanSo[i] >= max)
                            {
                                max = listPhanSo[i];
                            }
                        }
                        Console.WriteLine($"Phân số lớn nhất là: {max}");
                        break;
                    case 2:
                        Console.WriteLine("Phân số sau khi sắp xếp:");
                        SapXepPhanSo(listPhanSo);
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(listPhanSo[i] + "\t");
                        }
                        Console.WriteLine();
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


        public int patition(PhanSo[] arr, int low, int high)
        {
            PhanSo pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    PhanSo temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            PhanSo temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }

        public void QuickSort(PhanSo[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = patition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public void SapXepPhanSo(PhanSo[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var ps in arr)
            {
                Console.WriteLine(ps);
            }
        }

        public class PhanSo
        {
            private int _tuso, _mauso;
            public int tuso { get; }
            public int mauso { get; }
            public PhanSo()
            {
                tuso = 0;
                mauso = 1;
            }
            public PhanSo(int tu, int mau)
            {
                tuso = tu;
                mauso = mau;
                if (mau == 0)
                {
                    throw new ArgumentException("Mẫu số không được bằng 0");
                }
            }

            public void Nhap()
            {
                Console.Write("Nhập tử số: ");
                _tuso = int.Parse(Console.ReadLine());
                Console.Write("Nhập mẫu số: ");
                _mauso = int.Parse(Console.ReadLine());
                if (_mauso == 0)
                {
                    throw new ArgumentException("Mẫu số không được bằng 0");
                }
            }
            private void RutGon()
            {
                int ucln = UCLN(Math.Abs(_tuso), Math.Abs(_mauso));
                _tuso /= ucln;
                _mauso /= ucln;
                if (_mauso < 0) // tránh mẫu âm
                {
                    _tuso = -_tuso;
                    _mauso = -_mauso;
                }
            }

            private int UCLN(int a, int b)
            {
                return b == 0 ? a : UCLN(b, a % b);
            }

            public override string ToString()
            {
                return $"{_tuso}/{_mauso}";
            }


            public static PhanSo operator +(PhanSo a, PhanSo b)
            {
                int tu = a._tuso * b._mauso + b._tuso * a._mauso;
                int mau = a._mauso * b._mauso;
                PhanSo kq = new PhanSo(tu, mau);
                kq.RutGon();
                return kq;
            }

            public static PhanSo operator -(PhanSo a, PhanSo b)
            {
                int tu = a._tuso * b._mauso - b._tuso * a._mauso;
                int mau = a._mauso * b._mauso;
                PhanSo kq = new PhanSo(tu, mau);
                kq.RutGon();
                return kq;
            }

            public static PhanSo operator *(PhanSo a, PhanSo b)
            {
                int tu = a._tuso * b._tuso;
                int mau = a._mauso * b._mauso;
                PhanSo kq = new PhanSo(tu, mau);
                kq.RutGon();
                return kq;
            }
            public static PhanSo operator /(PhanSo a, PhanSo b)
            {
                if (b._tuso == 0)
                {
                    throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0");
                }
                int tu = a._tuso * b._mauso;
                int mau = a._mauso * b._tuso;
                PhanSo kq = new PhanSo(tu, mau);
                kq.RutGon();
                return kq;
            }

            public static bool operator >=(PhanSo a, PhanSo b) => a._tuso * b._mauso >= b._tuso * a._mauso;
            public static bool operator <=(PhanSo a, PhanSo b) => a._tuso * b._mauso <= b._tuso * a._mauso;

           

        }

    }
}

