using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_NhanVien : UserControl
    {
        // Khởi tạo một đối tượng context để tương tác với cơ sở dữ liệu
        HotelDbContext context = new HotelDbContext();

        public UC_NhanVien()
        {
            // Khởi tạo các thành phần trong UserControl
            InitializeComponent();
        }

        // Hàm này được gọi khi UserControl được tải
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
        }

        // Hàm này xóa tất cả các trường nhập liệu
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtAD.Clear();
            txtMAHD.Clear();
            txtMANV.Clear();
        }

        // Hàm này đặt nguồn dữ liệu cho DataGridView là danh sách các NhanVien từ cơ sở dữ liệu
        public void setEmployee(DataGridView dgv)
        {
            dgv.DataSource = context.NhanViens.ToList();
        }

        // Hàm này được gọi khi người dùng nhấp vào nút (guna2Button1)
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường nhập liệu có được điền đầy đủ hay không
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtAD.Text != "" && txtMAHD.Text != "" && txtMANV.Text != "")
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string name = txtName.Text;
                string mobile = txtMobile.Text;
                string gender = txtGender.Text;
                string Address = txtAD.Text;
                int MAHD = int.Parse(txtMAHD.Text);
                int MANV = int.Parse(txtMANV.Text);

                // Kiểm tra xem số điện thoại có đúng 10 chữ số hay không
                if (mobile.Length != 10)
                {
                    MessageBox.Show("Mobile number must be 10 digits", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo một đối tượng NhanVien mới và thêm vào cơ sở dữ liệu
                NhanVien newNhanVien = new NhanVien
                {
                    MANV = MANV,
                    MaHD = MAHD,
                    HoTenNV = name,
                    DiaChi = Address,
                    SDTNV = mobile,
                    ChucVu = gender
                };

                context.NhanViens.Add(newNhanVien);
                context.SaveChanges();

                // Tải lại UserControl và xóa tất cả các trường nhập liệu
                UC_NhanVien_Load(this, null);
                clearAll();
            }
            else
            {
                // Nếu không, hiển thị thông báo yêu cầu người dùng nhập đầy đủ thông tin
                MessageBox.Show("Xin Vui Lòng Điền Đầy Đủ Thông Tin ", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm này được gọi khi người dùng nhấp vào nút Xóa (btnDelete)
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem trường txtID có được điền hay không
            if (txtID.Text != "")
            {
                // Nếu có, hỏi người dùng xác nhận việc xóa
                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Tìm NhanVien cần xóa trong cơ sở dữ liệu và xóa nó
                    int manv = int.Parse(txtID.Text);
                    NhanVien nhanVienToDelete = context.NhanViens.Find(manv);

                    if (nhanVienToDelete != null)
                    {
                        context.NhanViens.Remove(nhanVienToDelete);
                        context.SaveChanges();

                        // Cập nhật DataGridView
                        tabEmployee_SelectedIndexChanged_1(this, null);
                    }
                }
            }
        }

        // Hàm này được gọi khi UserControl không còn được focus
        private void UC_NhanVien_Leave_1(object sender, EventArgs e)
        {
            // Xóa tất cả các trường nhập liệu
            clearAll();
        }

        // Hàm này được gọi khi người dùng chuyển tab trong tabEmployee
        private void tabEmployee_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Đặt nguồn dữ liệu cho DataGridView tương ứng với tab được chọn
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }
    }

}
