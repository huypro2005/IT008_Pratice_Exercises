using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2.DanhSachBai
{
    internal class Bai3
    {

        public void Cau3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số dòng và số cột của ma trận: ");
            Console.Write("Số dòng: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Số cột: ");
            int m = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            NhapMaTran(n, m, arr);
            int chon = 1;
            bool run = true;
            while (run)
            {
                Console.WriteLine("Chọn chức năng: ");
                Console.WriteLine("1. Xuất ma trận");
                Console.WriteLine("2. Tìm phần tử trong ma trận");
                Console.WriteLine("3. Liệt kê các số nguyên tố trong ma trận");
                Console.WriteLine("4. Tìm dòng có nhiều số nguyên tố nhất");
                Console.WriteLine("Khác. Thoát");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        XuatMaTran(n, m, arr);
                        break;
                    case 2:
                        Console.Write("Nhập phần tử cần tìm: ");
                        int tar = int.Parse(Console.ReadLine());
                        List<int[]> pos = TimPhanTu(n, m, arr, tar);
                        if (pos.Count == 0)
                        {
                            Console.WriteLine("Phần tử không tồn tại trong ma trận");
                        }
                        else
                        {
                            foreach (var p in pos)
                            {
                                Console.WriteLine($"Phần tử {tar} nằm ở vị trí: ({p[0]}, {p[1]})");
                            }
                        }
                        break;

                    case 3:
                        LietKeSNT(n, m, arr);
                        Console.WriteLine();
                        break;
                    case 4:
                        DongCoSNTNhieuNhat(n, m, arr);
                        Console.WriteLine();
                        break;
                    default:
                        run = false;
                        break;
                }

            }



        }

        public void NhapMaTran(int n, int m, int[][] arr)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void XuatMaTran(int n, int m, int[][] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public List<int[]> TimPhanTu(int n, int m, int[][] arr, int tar)
        {
            List<int[]> positions = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i][j] == tar)
                    {
                        positions.Add(new int[] { i, j });
                    }
                }
            }
            return positions;
        }
      

        public void LietKeSNT(int n, int m, int[][] arr)
        {
            Console.Write("Các số nguyên tố trong ma trận là: ");
            HashSet<int> snt_list = new HashSet<int>(); 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (snt(arr[i][j]))
                    {
                        snt_list.Add(arr[i][j]);
                    }
                }
            }
            foreach(var x in snt_list)
            {
                Console.Write($"{x}\t");
            }
        }

        public void DongCoSNTNhieuNhat(int n, int m, int[][] arr)
        {
            int[] dong = new int[n];
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (snt(arr[i][j]))
                    {
                        dong[i]++;
                    }
                }
                if (dong[i] > max) max = dong[i];
            }
            Console.Write($"Dòng có nhiều số nguyên tố nhất là: ");
            for (int i = 0; i < n; i++)
            {
                if (dong[i] == max)
                {
                    Console.Write($"{i+1} ");
                }
            }
        }

        public bool snt(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }


    }
}
