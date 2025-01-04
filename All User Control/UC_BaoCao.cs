using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_User_Control
{
    public partial class UC_BaoCao : UserControl // Lớp UserControl UC_BaoCao
    {
        HotelDbContext context = new HotelDbContext(); // Khởi tạo đối tượng context để làm việc với cơ sở dữ liệu

        public UC_BaoCao() // Phương thức khởi tạo của lớp UC_BaoCao
        {
            InitializeComponent(); // Khởi tạo các thành phần của giao diện người dùng
        }

        private void btnBaoCao_Click(object sender, EventArgs e) // Sự kiện khi nhấn nút Báo cáo
        {
            try // Thử thực hiện các câu lệnh trong khối này
            {
                // Tải dữ liệu từ cơ sở dữ liệu
                var hoaDons = context.HoaDons.ToList();

                // Tính doanh thu hàng ngày
                var dailyRevenue = hoaDons
                    .Where(hd => DateTime.Parse(hd.NgayTT).Date == DateTime.Today)
                    .Sum(hd => (double?)double.Parse(hd.ThanhTien)) ?? 0;
                labelDoanhThuTheoNgay.Text = "Doanh thu theo ngày: " + dailyRevenue.ToString() + " VND";

                // Tính doanh thu hàng tháng
                var monthlyRevenue = hoaDons
                    .Where(hd => DateTime.Parse(hd.NgayTT).Month == DateTime.Today.Month && DateTime.Parse(hd.NgayTT).Year == DateTime.Today.Year)
                    .Sum(hd => (double?)double.Parse(hd.ThanhTien)) ?? 0;
                labelDoanhThuTheoThang.Text = "Doanh thu theo tháng: " + monthlyRevenue.ToString() + " VND";

                // Tính doanh thu hàng năm
                var yearlyRevenue = hoaDons
                    .Where(hd => DateTime.Parse(hd.NgayTT).Year == DateTime.Today.Year)
                    .Sum(hd => (double?)double.Parse(hd.ThanhTien)) ?? 0;
                labelDoanhThuTheoNam.Text = "Doanh thu theo năm: " + yearlyRevenue.ToString() + " VND";
            }
            catch (Exception ex) // Bắt lỗi nếu có
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); // Hiển thị thông báo lỗi
            }
        }
    }
}

