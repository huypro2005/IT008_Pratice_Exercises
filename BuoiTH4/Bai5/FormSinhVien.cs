using Bai5.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class FormSinhVien : Form
    {
        private IEnumerable<object> khoa_list;
        public SinhVien sinhvien { get; private set; }

        public FormSinhVien()
        {
            InitializeComponent();
            khoa_list = new List<string>()
            {
                "Công nghệ thông tin",
                "Khoa học máy tính",
                "Hệ thống thông tin",
                "Mạng máy tính và truyền thông dữ liệu",
                "Kỹ thuật phần mềm"
            };
        }
        public delegate void TruyenDuLieu(SinhVien sv);
        public event TruyenDuLieu GuiDuLieuVe;
        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            foreach (var khoa in khoa_list)
            {
                comboBoxDepartment.Items.Add(khoa);
            }
            comboBoxDepartment.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool checkEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtMaso.Text) ||
            string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(comboBoxDepartment.Text) ||
            string.IsNullOrWhiteSpace(AvgScore.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (checkEmpty()) return;

            // SỬA 2: Gán dữ liệu vào biến Public
            sinhvien = new SinhVien(
                txtMaso.Text,
                txtName.Text,
                comboBoxDepartment.Text,
                (double)AvgScore.Value
            );

            // Báo cho Form cha biết là đã bấm OK thành công
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
