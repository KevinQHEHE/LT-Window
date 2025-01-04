using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerRes : UserControl // Lớp UC_CustomerRes kế thừa từ lớp UserControl
    {
        HotelDbContext context = new HotelDbContext(); // Tạo một đối tượng context từ lớp HotelDbContext

        public UC_CustomerRes() // Hàm khởi tạo
        {
            InitializeComponent(); // Khởi tạo các thành phần của user control
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e) // Sự kiện khi nội dung của guna2TextBox3 thay đổi
        {
            // Hiện tại phương thức này đang trống
        }

        private void UC_CustomerRes_Load(object sender, EventArgs e) // Sự kiện khi user control được tải
        {
            dataGridViewKhachHang.DataSource = context.KhachHangs.ToList(); // Đổ dữ liệu từ cơ sở dữ liệu vào dataGridViewKhachHang
        }

        public void clearAll() // Phương thức để xóa tất cả các trường nhập
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
        }

        private void BtnThemKH_Click(object sender, EventArgs e) // Sự kiện khi nút "Thêm KH" được nhấn
        {
            // Kiểm tra xem tất cả các trường nhập liệu có được điền đầy đủ hay không
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtSDT.Text != "" && txtCCCD.Text != "")
            {
                // Tạo một đối tượng mới của lớp KhachHang
                KhachHang newKhachHang = new KhachHang
                {
                    MAKH = int.Parse(txtMaKH.Text),
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    CCCD = txtCCCD.Text
                };

                context.KhachHangs.Add(newKhachHang); // Thêm đối tượng mới vào cơ sở dữ liệu
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                UC_CustomerRes_Load(this, null); // Tải lại user control
                clearAll(); // Xóa tất cả các trường nhập
            }
        }
    }

}
