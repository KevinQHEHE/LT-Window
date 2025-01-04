using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_Thue : UserControl
    {
        // Khởi tạo một đối tượng context để tương tác với cơ sở dữ liệu
        HotelDbContext context = new HotelDbContext();

        public UC_Thue()
        {
            // Khởi tạo các thành phần trong UserControl
            InitializeComponent();
        }

        // Hàm này được gọi khi UserControl được tải
        private void UC_Thue_Load(object sender, EventArgs e)
        {
            // Đặt nguồn dữ liệu cho dataGridViewThuePhong là danh sách các Thue từ cơ sở dữ liệu
            dataGridViewThuePhong.DataSource = context.Thues.ToList();
        }

        // Hàm này được gọi khi người dùng nhấp vào nút Thuê Phòng (BTNThuePhong)
        private void BTNThuePhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường nhập liệu có được điền đầy đủ hay không
            if (txtMaKH.Text != "" && txtMaPhong.Text != "" && DTPNgayDi.Value != DateTime.Now && DTPNgayVe.Value != DateTime.Now)
            {
                // Tạo một đối tượng Thue mới và thêm vào cơ sở dữ liệu
                Thue newThue = new Thue
                {
                    MAKH = int.Parse(txtMaKH.Text),
                    MaPhong = int.Parse(txtMaPhong.Text),
                    NgayDI = DTPNgayDi.Value.ToString("dd/MM/yyyy"),
                    NgayVe = DTPNgayVe.Value.ToString("dd/MM/yyyy")
                };

                context.Thues.Add(newThue);
                context.SaveChanges();

                // Tải lại UserControl và xóa tất cả các trường nhập liệu
                UC_Thue_Load(this, null);
                clearAll();
            }
        }

        // Hàm này xóa tất cả các trường nhập liệu
        public void clearAll()
        {
            txtMaKH.Clear();
            txtMaPhong.Clear();
            DTPNgayDi.Value = DateTime.Now;
            DTPNgayVe.Value = DateTime.Now;
        }

        // Hàm này được gọi khi UserControl không còn được focus
        private void UC_Thue_Leave(object sender, EventArgs e)
        {
            // Xóa tất cả các trường nhập liệu
            clearAll();
        }

        // Hàm này được gọi khi UserControl được focus
        private void UC_Thue_Enter(object sender, EventArgs e)
        {
            // Tải lại UserControl
            UC_Thue_Load(this, null);
        }
    }

}
