using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e) // Sự kiện khi form được tải
        {
            // Ẩn các user control khi form được tải
            uC_AddRoom1.Visible = false;
            uC_HoaDon1.Visible = false;
            uC_CustomerRes2.Visible = false;
            uC_Thue1.Visible = false;
            uC_NhanVien1.Visible = false;
            btnAdd.PerformClick(); // Thực hiện click vào nút "Thêm"
        }

        private void btnAdd_Click(object sender, EventArgs e) // Sự kiện khi nút "Thêm" được nhấn
        {
            PanelMoving.Left = btnAdd.Left + 50; // Di chuyển panel
            uC_AddRoom1.Visible = true; // Hiển thị user control "Thêm phòng"
            uC_AddRoom1.BringToFront(); // Đưa user control "Thêm phòng" lên trước
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnHoaDon.Left + 60;
            uC_HoaDon1.Visible = true;
            uC_HoaDon1.BringToFront();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomer.Left+60;
            uC_CustomerRes2.Visible = true;
            uC_CustomerRes2.BringToFront() ;
        }

        private void BtnDatPhong_Click(object sender, EventArgs e)
        {
            PanelMoving.Left=BtnDatPhong.Left+60;
            uC_Thue1.Visible = true;
            uC_Thue1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnEmployee.Left + 60;
            uC_NhanVien1.Visible = true;  
            uC_NhanVien1.BringToFront();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCheckOut.Left + 60;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnBaoCao.Left + 60;
            uC_BaoCao1.Visible = true;
            uC_BaoCao1.BringToFront();
        }
    }
}
