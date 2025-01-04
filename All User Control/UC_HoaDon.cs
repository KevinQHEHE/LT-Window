using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_HoaDon : UserControl // Lớp UC_HoaDon kế thừa từ lớp UserControl
    {
        HotelDbContext context = new HotelDbContext(); // Tạo một đối tượng context từ lớp HotelDbContext

        public UC_HoaDon() // Hàm khởi tạo
        {
            InitializeComponent(); // Khởi tạo các thành phần của user control
        }

        private void UC_HoaDon_Load(object sender, EventArgs e) // Sự kiện khi user control được tải
        {
            dataGridView1.DataSource = context.HoaDons.ToList(); // Đổ dữ liệu từ cơ sở dữ liệu vào dataGridView1
            dataGridView1.Refresh(); // Làm mới dataGridView1
        }

        public void clearAll() // Phương thức để xóa tất cả các trường nhập
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtNgayTT.Value = DateTime.Now;
            txtThanhTien.Clear();
            txtTenHD.Clear();
            txtNgayTao.Value = DateTime.Now;
        }

        private void UC_HoaDon_Leave(object sender, EventArgs e) // Sự kiện khi user control bị rời
        {
            clearAll(); // Xóa tất cả các trường nhập
        }

        private void UC_HoaDon_Enter(object sender, EventArgs e) // Sự kiện khi user control được nhập
        {
            UC_HoaDon_Load(this, null); // Tải lại user control
        }

        private void btnThemHD_Click(object sender, EventArgs e) // Sự kiện khi nút "Thêm HD" được nhấn
        {
            // Kiểm tra xem tất cả các trường nhập liệu có được điền đầy đủ hay không
            if (txtMaHD.Text != "" && txtNgayTT.Text != "" && txtThanhTien.Text != "" && txtTenHD.Text != "" && txtNgayTao.Text != "")
            {
                // Tạo một đối tượng mới của lớp HoaDon
                HoaDon newHoaDon = new HoaDon
                {
                    MaHD = int.Parse(txtMaHD.Text),
                    MAKH = int.Parse(txtMaKH.Text),
                    NgayTT = txtNgayTT.Text,
                    ThanhTien = txtThanhTien.Text,
                    TenHD = txtTenHD.Text,
                    NgayTao = txtNgayTao.Text
                };

                context.HoaDons.Add(newHoaDon); // Thêm đối tượng mới vào cơ sở dữ liệu
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                UC_HoaDon_Load(this, null); // Tải lại user control
                clearAll(); // Xóa tất cả các trường nhập
            }
            else
            {
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin ", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e) // Sự kiện khi nút "Sửa HD" được nhấn
        {
            if (txtMaHD.Text != "") // Kiểm tra xem mã hóa đơn có được nhập hay không
            {
                int mahd = int.Parse(txtMaHD.Text); // Chuyển đổi mã hóa đơn từ chuỗi sang số nguyên
                HoaDon hoaDonToUpdate = context.HoaDons.Find(mahd); // Tìm hóa đơn cần cập nhật

                if (hoaDonToUpdate != null) // Kiểm tra xem hóa đơn cần cập nhật có tồn tại hay không
                {
                    // Cập nhật thông tin hóa đơn
                    hoaDonToUpdate.MAKH = int.Parse(txtMaKH.Text);
                    hoaDonToUpdate.NgayTT = txtNgayTT.Text;
                    hoaDonToUpdate.ThanhTien = txtThanhTien.Text;
                    hoaDonToUpdate.TenHD = txtTenHD.Text;
                    hoaDonToUpdate.NgayTao = txtNgayTao.Text;

                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    UC_HoaDon_Load(this, null); // Tải lại user control
                    clearAll(); // Xóa tất cả các trường nhập
                }
                else
                {
                    MessageBox.Show("Xin Vui Lòng Chọn Hóa Đơn Để Cập Nhật", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e) // Sự kiện khi nút "Xóa HD" được nhấn
        {
            if (txtMaHD.Text != "") // Kiểm tra xem mã hóa đơn có được nhập hay không
            {
                int mahd = int.Parse(txtMaHD.Text); // Chuyển đổi mã hóa đơn từ chuỗi sang số nguyên
                HoaDon hoaDonToDelete = context.HoaDons.Find(mahd); // Tìm hóa đơn cần xóa

                if (hoaDonToDelete != null) // Kiểm tra xem hóa đơn cần xóa có tồn tại hay không
                {
                    context.HoaDons.Remove(hoaDonToDelete); // Xóa hóa đơn khỏi cơ sở dữ liệu
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    UC_HoaDon_Load(this, null); // Tải lại user control
                    clearAll(); // Xóa tất cả các trường nhập
                }
                else
                {
                    MessageBox.Show("Xin Vui Lòng Chọn Hóa Đơn Để Xóa", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiện tại phương thức này đang trống
        }
    }

}
