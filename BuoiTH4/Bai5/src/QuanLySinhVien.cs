using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5.src
{
    public class QuanLySinhVien
    {
        private List<SinhVien> _danhSachSinhVien;
        public QuanLySinhVien()
        {
            _danhSachSinhVien = new List<SinhVien>();
        }
        public void ThemSinhVien(SinhVien sv)
        {
            _danhSachSinhVien.Add(sv);
        }
        public List<SinhVien> LayDanhSachSinhVien()
        {
            return _danhSachSinhVien;
        }
        public List<SinhVien> TimKiemTheoTen(string subName)
        {
            // Có thể tìm kiểm cả chữ hoa cả chữ thường
            subName = subName.ToLower();
            return _danhSachSinhVien.Where(sv => sv.HoTen.ToLower().Contains(subName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
