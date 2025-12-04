using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5.src
{
    public class SinhVien
    {
        private string _maSo;
        private string _hoTen;
        private string _khoa;
        private double _diemTB;
        public SinhVien(string maSo, string hoTen, string khoa, double diemTB)
        {
            this._maSo = maSo;
            this._hoTen = hoTen;
            this._khoa = khoa;
            this._diemTB = diemTB;
        }
        public string MaSo { get => _maSo; set => _maSo = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string Khoa { get => _khoa; set => _khoa = value; }
        public double DiemTB { get => _diemTB; set => _diemTB = value; }
        
    }
}
