using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class KhachHang
    {
        [Key] // Khóa chính
        public int MAKH { get; set; } // Mã khách hàng
        public string TenKH { get; set; } // Tên khách hàng
        public string SDT { get; set; } // Số điện thoại
        public string CCCD { get; set; } // Chứng minh nhân dân
    }

    public class HoaDon
    {
        [Key] // Khóa chính
        public int MaHD { get; set; } // Mã hóa đơn

        public int MAKH { get; set; } // Mã khách hàng

        [ForeignKey("MAKH")] // Khóa ngoại
        public virtual KhachHang KhachHang { get; set; } // Khách hàng tương ứng với hóa đơn

        public string NgayTT { get; set; } // Ngày thanh toán
        public string ThanhTien { get; set; } // Thành tiền
        public string TenHD { get; set; } // Tên hóa đơn
        public string NgayTao { get; set; } // Ngày tạo hóa đơn
    }

    public class NhanVien
    {
        [Key] // Khóa chính
        public int MANV { get; set; } // Mã nhân viên

        public int MaHD { get; set; } // Mã hóa đơn

        [ForeignKey("MaHD")] // Khóa ngoại
        public virtual HoaDon HoaDon { get; set; } // Hóa đơn tương ứng với nhân viên

        public string HoTenNV { get; set; } // Họ tên nhân viên
        public string DiaChi { get; set; } // Địa chỉ
        public string SDTNV { get; set; } // Số điện thoại nhân viên
        public string ChucVu { get; set; } // Chức vụ
    }

    public class Phong
    {
        [Key] // Khóa chính
        public int MaPhong { get; set; } // Mã phòng

        public int MANV { get; set; } // Mã nhân viên

        [ForeignKey("MANV")] // Khóa ngoại
        public virtual NhanVien NhanVien { get; set; } // Nhân viên tương ứng với phòng

        public string TenPhong { get; set; } // Tên phòng
        public string LoaiPhong { get; set; } // Loại phòng
        public string Gia { get; set; } // Giá phòng
        public string TinhTrangPhong { get; set; } // Tình trạng phòng
    }

    public class Thue
    {
        [Key] // Khóa chính
        public int MAKH { get; set; } // Mã khách hàng

        public int MaPhong { get; set; } // Mã phòng

        [ForeignKey("MAKH")] // Khóa ngoại
        public virtual KhachHang KhachHang { get; set; } // Khách hàng tương ứng với thuê

        [ForeignKey("MaPhong")] // Khóa ngoại
        public virtual Phong Phong { get; set; } // Phòng tương ứng với thuê

        public string NgayDI { get; set; } // Ngày đi
        public string NgayVe { get; set; } // Ngày về
    }


    public class HotelDbContext : DbContext
    {
        public HotelDbContext() : base(@"Data Source=DESKTOP-BSIOOIV\DKHOA03;Initial Catalog=QuanLyKhachSan;Integrated Security=True")
        {
            this.Configuration.ProxyCreationEnabled = false; // Tắt chế độ tạo proxy tự động

        }
        public DbSet<KhachHang> KhachHangs { get; set; } // Tập hợp các khách hàng
        public DbSet<HoaDon> HoaDons { get; set; } // Tập hợp các hóa đơn
        public DbSet<NhanVien> NhanViens { get; set; } // Tập hợp các nhân viên
        public DbSet<Phong> Phongs { get; set; } // Tập hợp các phòng
        public DbSet<Thue> Thues { get; set; } // Tập hợp các thuê
    }


}


