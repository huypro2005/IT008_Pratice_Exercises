using Bai5.src;

namespace Bai5
{
    public partial class Form1 : Form
    {
        private QuanLySinhVien quanlysinhvien;
        public Form1()
        {
            InitializeComponent();
            quanlysinhvien = new QuanLySinhVien();
            dgvDanhSach.Columns.Add("colSTT", "Số TT");
            dgvDanhSach.Columns.Add("colMSSV", "Mã Số SV");
            dgvDanhSach.Columns.Add("colTen", "Tên Sinh Viên");
            dgvDanhSach.Columns.Add("colKhoa", "Khoa");
            dgvDanhSach.Columns.Add("colDiem", "Điểm TB");
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripBtnAddMem_Click(object sender, EventArgs e)
        {
            AddSinhVien();
        }
        private void toolStripAddMem_Click(object sender, EventArgs e)
        {
            AddSinhVien();
        }

        private void AddSinhVien()
        {
            var formSinhVien = new FormSinhVien();

            // SỬA 4: Kiểm tra kết quả trả về từ Form con
            if (formSinhVien.ShowDialog() == DialogResult.OK)
            {
                // Lấy dữ liệu từ biến Public bên FormSinhVien
                SinhVien svMoi = formSinhVien.sinhvien;

                // Thêm vào danh sách quản lý (Giả sử class QuanLySinhVien có hàm Them)
                quanlysinhvien.ThemSinhVien(svMoi);

                // Hiển thị lại lên Grid
                showDanhSachSinhVien();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            showDanhSachSinhVien();
        }

        private void showDanhSachSinhVien()
        {
            dgvDanhSach.Rows.Clear();
            var danhSach = quanlysinhvien.LayDanhSachSinhVien();
            int stt = 1;
            foreach (var sv in danhSach)
            {
                dgvDanhSach.Rows.Add(stt++, sv.MaSo, sv.HoTen, sv.Khoa, sv.DiemTB);
            }
        }

        private void toolStripTxtFIndMem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTxtFIndMem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toolStripTxtFIndMem.Text))
            {
                string subName = toolStripTxtFIndMem.Text;
                var ketQuaTimKiem = quanlysinhvien.TimKiemTheoTen(subName);
                dgvDanhSach.Rows.Clear();
                int stt = 1;
                foreach (var sv in ketQuaTimKiem)
                {
                    dgvDanhSach.Rows.Add(stt++, sv.MaSo, sv.HoTen, sv.Khoa, sv.DiemTB);
                }
            }
            else
            {
                showDanhSachSinhVien();
            }
           
        }
    }
}
