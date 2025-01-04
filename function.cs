using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Entity;

namespace QuanLyKhachSan
{
    public class function // Khai báo lớp function
    {
        public List<T> getData<T>(string query) where T : class // Phương thức getData trả về danh sách các đối tượng từ cơ sở dữ liệu theo câu truy vấn
        {
            using (var context = new HotelDbContext()) // Tạo một đối tượng context từ lớp HotelDbContext
            {
                return context.Set<T>().SqlQuery(query).ToList(); // Thực thi câu truy vấn và trả về kết quả dưới dạng danh sách
            }
        }

        public void setData(string query) // Phương thức setData thực thi câu truy vấn để thay đổi dữ liệu trong cơ sở dữ liệu
        {
            using (var context = new HotelDbContext()) // Tạo một đối tượng context từ lớp HotelDbContext
            {
                context.Database.ExecuteSqlCommand(query); // Thực thi câu truy vấn
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }

        public List<T> getForCombo<T>(string query) where T : class // Phương thức getForCombo trả về danh sách các đối tượng từ cơ sở dữ liệu theo câu truy vấn, thường được sử dụng để lấy dữ liệu cho ComboBox
        {
            using (var context = new HotelDbContext()) // Tạo một đối tượng context từ lớp HotelDbContext
            {
                return context.Set<T>().SqlQuery(query).ToList(); // Thực thi câu truy vấn và trả về kết quả dưới dạng danh sách
            }
        }
    }
}
