using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_CheckOut : UserControl // Lớp UC_CheckOut kế thừa từ lớp UserControl
    {
        HotelDbContext context = new HotelDbContext(); // Tạo một đối tượng context từ lớp HotelDbContext

        public UC_CheckOut() // Hàm khởi tạo
        {
            InitializeComponent(); // Khởi tạo các thành phần của user control
        }

        private void btnCheckOut_Click(object sender, EventArgs e) // Sự kiện khi nút "Check Out" được nhấn
        {
            if (txtMaHD3.Text != "") // Kiểm tra xem mã hóa đơn có được nhập hay không
            {
                Int64 maHD = Int64.Parse(txtMaHD3.Text); // Chuyển đổi mã hóa đơn từ chuỗi sang số nguyên
                HoaDon hoaDonToUpdate = context.HoaDons.Find(maHD); // Tìm hóa đơn cần cập nhật

                if (hoaDonToUpdate != null) // Kiểm tra xem hóa đơn cần cập nhật có tồn tại hay không
                {
                    // Cập nhật ngày thanh toán
                    hoaDonToUpdate.NgayTT = guna2DateTimePicker1.Value.ToString("yyyy-MM-dd");

                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    MessageBox.Show("Ngày thanh toán đã được cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại.");
                }
            }
        }

        private void UC_CheckOut_Load(object sender, EventArgs e) // Sự kiện khi user control được tải
        {
            Check.DataSource = context.HoaDons.ToList(); // Đổ dữ liệu từ cơ sở dữ liệu vào Check
            Check.Refresh(); // Làm mới Check
        }

        public void clearAll() // Phương thức để xóa tất cả các trường nhập
        {
            // Hiện tại phương thức này đang trống
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e) // Sự kiện khi user control bị rời
        {
            clearAll(); // Xóa tất cả các trường nhập
        }
    }

}
