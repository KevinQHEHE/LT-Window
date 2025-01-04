using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_AddRoom : UserControl // Lớp UC_AddRoom kế thừa từ lớp UserControl
    {
        HotelDbContext context = new HotelDbContext(); // Tạo một đối tượng context từ lớp HotelDbContext

        public UC_AddRoom() // Hàm khởi tạo
        {
            InitializeComponent(); // Khởi tạo các thành phần của user control
        }

        private void UC_AddRoom_Load(object sender, EventArgs e) // Sự kiện khi user control được tải
        {
            dataGridView1.DataSource = context.Phongs.ToList(); // Đổ dữ liệu từ cơ sở dữ liệu vào dataGridView1
        }

        private void guna2Button1_Click(object sender, EventArgs e) // Sự kiện khi nút "Thêm" được nhấn
        {
            // Kiểm tra xem tất cả các trường nhập liệu có được điền đầy đủ hay không
            if (txtMaPhong.Text != "" && txtMaNV.Text != "" && txtTenPhong.Text != "" && txtLoaiPhong.Text != ""
                && txtGia.Text != "" && txtTinhTrang.Text != "")
            {
                // Tạo một đối tượng mới của lớp Phong
                Phong newPhong = new Phong
                {
                    MaPhong = int.Parse(txtMaPhong.Text),
                    MANV = int.Parse(txtMaNV.Text),
                    TenPhong = txtTenPhong.Text,
                    LoaiPhong = txtLoaiPhong.Text,
                    Gia = txtGia.Text,
                    TinhTrangPhong = txtTinhTrang.Text
                };

                context.Phongs.Add(newPhong); // Thêm đối tượng mới vào cơ sở dữ liệu
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                UC_AddRoom_Load(this, null); // Tải lại user control
                clearAll(); // Xóa tất cả các trường nhập
            }
            else
            {
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin ", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll() // Phương thức để xóa tất cả các trường nhập
        {
            txtMaPhong.Clear();
            txtMaNV.Clear();
            txtTenPhong.SelectedIndex = -1;
            txtLoaiPhong.SelectedIndex = -1;
            txtGia.SelectedIndex = -1;
            txtTinhTrang.SelectedIndex = -1;
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e) // Sự kiện khi user control bị rời
        {
            clearAll(); // Xóa tất cả các trường nhập
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e) // Sự kiện khi user control được nhập
        {
            UC_AddRoom_Load(this, null); // Tải lại user control
        }

        private void btnSuaPhong_Click(object sender, EventArgs e) // Sự kiện khi nút "Sửa Phòng" được nhấn
        {
            if (txtMaPhong.Text != "") // Kiểm tra xem mã phòng có được nhập hay không
            {
                Int64 maphong = Int64.Parse(txtMaPhong.Text); // Chuyển đổi mã phòng từ chuỗi sang số nguyên
                Phong phongToUpdate = context.Phongs.Find(maphong); // Tìm phòng cần cập nhật

                if (phongToUpdate != null) // Kiểm tra xem phòng cần cập nhật có tồn tại hay không
                {
                    // Cập nhật thông tin phòng
                    phongToUpdate.MANV = int.Parse(txtMaNV.Text);
                    phongToUpdate.TenPhong = txtTenPhong.Text;
                    phongToUpdate.LoaiPhong = txtLoaiPhong.Text;
                    phongToUpdate.Gia = txtGia.Text;
                    phongToUpdate.TinhTrangPhong = txtTinhTrang.Text;

                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    UC_AddRoom_Load(this, null); // Tải lại user control
                    clearAll(); // Xóa tất cả các trường nhập
                }
            }
            else
            {
                MessageBox.Show("Xin Vui Lòng Chọn Phòng Để Cập Nhật", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e) // Sự kiện khi nút "Xóa Phòng" được nhấn
        {
            if (txtMaPhong.Text != "") // Kiểm tra xem mã phòng có được nhập hay không
            {
                Int64 maphong = Int64.Parse(txtMaPhong.Text); // Chuyển đổi mã phòng từ chuỗi sang số nguyên
                Phong phongToDelete = context.Phongs.Find(maphong); // Tìm phòng cần xóa

                if (phongToDelete != null) // Kiểm tra xem phòng cần xóa có tồn tại hay không
                {
                    context.Phongs.Remove(phongToDelete); // Xóa phòng khỏi cơ sở dữ liệu
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    UC_AddRoom_Load(this, null); // Tải lại user control
                    clearAll(); // Xóa tất cả các trường nhập
                }
            }
            else
            {
                MessageBox.Show("Xin Vui Lòng Chọn Phòng Để Xóa", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
