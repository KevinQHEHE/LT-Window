namespace QuanLyKhachSan
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_BaoCao1 = new QuanLyKhachSan.All_User_Control.UC_BaoCao();
            this.uC_CheckOut1 = new QuanLyKhachSan.All_User_Control.UC_CheckOut();
            this.uC_NhanVien1 = new QuanLyKhachSan.All_User_Control.UC_NhanVien();
            this.uC_Thue1 = new QuanLyKhachSan.All_User_Control.UC_Thue();
            this.uC_CustomerRes2 = new QuanLyKhachSan.All_User_Control.UC_CustomerRes();
            this.uC_HoaDon1 = new QuanLyKhachSan.All_User_Control.UC_HoaDon();
            this.uC_CustomerRes1 = new QuanLyKhachSan.All_User_Control.UC_CustomerRes();
            this.uC_AddRoom2 = new QuanLyKhachSan.All_User_Control.UC_AddRoom();
            this.uC_AddRoom1 = new QuanLyKhachSan.All_User_Control.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(-1, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackColor = System.Drawing.Color.White;
            this.btnMinisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinisize.FillColor = System.Drawing.Color.Gray;
            this.btnMinisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinisize.Image")));
            this.btnMinisize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinisize.Location = new System.Drawing.Point(-1, 50);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(44, 45);
            this.btnMinisize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnDatPhong);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(67, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 2;
            // 
            // BtnDatPhong
            // 
            this.BtnDatPhong.BorderRadius = 18;
            this.BtnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDatPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDatPhong.ForeColor = System.Drawing.Color.White;
            this.BtnDatPhong.Location = new System.Drawing.Point(585, 3);
            this.BtnDatPhong.Name = "BtnDatPhong";
            this.BtnDatPhong.Size = new System.Drawing.Size(188, 116);
            this.BtnDatPhong.TabIndex = 6;
            this.BtnDatPhong.Text = "Đặt Phòng";
            this.BtnDatPhong.Click += new System.EventHandler(this.BtnDatPhong_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BorderRadius = 18;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(197, 3);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(188, 116);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Chi Tiết Hóa Đơn";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 18;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(391, 3);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(188, 116);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Nhân Viên";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BorderRadius = 18;
            this.btnBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(973, 3);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(188, 116);
            this.btnBaoCao.TabIndex = 1;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 18;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(779, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(188, 116);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BorderRadius = 18;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(188, 116);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Đăng Ký Khách Hàng";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 18;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1167, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 116);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Chi Tiết Phòng";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_BaoCao1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_NhanVien1);
            this.panel2.Controls.Add(this.uC_Thue1);
            this.panel2.Controls.Add(this.uC_CustomerRes2);
            this.panel2.Controls.Add(this.uC_HoaDon1);
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom2);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 852);
            this.panel2.TabIndex = 3;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.Lime;
            this.PanelMoving.Location = new System.Drawing.Point(72, 148);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(188, 7);
            this.PanelMoving.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // uC_BaoCao1
            // 
            this.uC_BaoCao1.Location = new System.Drawing.Point(-1, -1);
            this.uC_BaoCao1.Name = "uC_BaoCao1";
            this.uC_BaoCao1.Size = new System.Drawing.Size(1882, 852);
            this.uC_BaoCao1.TabIndex = 8;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CheckOut1.TabIndex = 7;
            // 
            // uC_NhanVien1
            // 
            this.uC_NhanVien1.Location = new System.Drawing.Point(-1, -1);
            this.uC_NhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_NhanVien1.Name = "uC_NhanVien1";
            this.uC_NhanVien1.Size = new System.Drawing.Size(1882, 852);
            this.uC_NhanVien1.TabIndex = 6;
            // 
            // uC_Thue1
            // 
            this.uC_Thue1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Thue1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Thue1.Name = "uC_Thue1";
            this.uC_Thue1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Thue1.TabIndex = 5;
            // 
            // uC_CustomerRes2
            // 
            this.uC_CustomerRes2.Location = new System.Drawing.Point(-1, -1);
            this.uC_CustomerRes2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_CustomerRes2.Name = "uC_CustomerRes2";
            this.uC_CustomerRes2.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerRes2.TabIndex = 5;
            // 
            // uC_HoaDon1
            // 
            this.uC_HoaDon1.Location = new System.Drawing.Point(-1, -1);
            this.uC_HoaDon1.Name = "uC_HoaDon1";
            this.uC_HoaDon1.Size = new System.Drawing.Size(1882, 852);
            this.uC_HoaDon1.TabIndex = 4;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.Location = new System.Drawing.Point(114, 197);
            this.uC_CustomerRes1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(6, 6);
            this.uC_CustomerRes1.TabIndex = 3;
            // 
            // uC_AddRoom2
            // 
            this.uC_AddRoom2.Location = new System.Drawing.Point(203, 95);
            this.uC_AddRoom2.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddRoom2.Name = "uC_AddRoom2";
            this.uC_AddRoom2.Size = new System.Drawing.Size(18, 20);
            this.uC_AddRoom2.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-1, -1);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1882, 852);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1455, 894);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button BtnDatPhong;
        private All_User_Control.UC_AddRoom uC_AddRoom2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_CustomerRes uC_CustomerRes1;
        private All_User_Control.UC_HoaDon uC_HoaDon1;
        private All_User_Control.UC_CustomerRes uC_CustomerRes2;
        private All_User_Control.UC_Thue uC_Thue1;
        private All_User_Control.UC_NhanVien uC_NhanVien1;
        private All_User_Control.UC_CheckOut uC_CheckOut1;
        private All_User_Control.UC_BaoCao uC_BaoCao1;
    }
}