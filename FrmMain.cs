using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.UserControls;

namespace DoAnLapTrinhTrucQuan
{
    public partial class FrmMain : Form
    {
        private Button? _activeNavButton = null;
        private System.Windows.Forms.Timer? _clockTimer;

        public FrmMain()
        {
            InitializeComponent();
            KhoiTaoSuKien();
            KhoiTaoDongHo();
        }

        private void KhoiTaoSuKien()
        {
            // Module M01: Quản lý món & Định lượng (BOM)
            btnQuanlymon.Click += (s, e) => LoadControl(new ucQuanLyMon(), btnQuanlymon);

            // Module Danh mục: Để trống theo yêu cầu (hiện tại chỉ phụ trách Quản lý món)
            btnDanhmuc.Click += (s, e) => LoadControl(new ucDanhMuc(), btnDanhmuc);

            // Module M02 & M03: Nguyên liệu, Kho, Thẻ kho & Nhập xuất Excel
            btnNguyenlieukho.Click += (s, e) => LoadControl(new ucQuanLyKho(), btnNguyenlieukho);

            // Module M04: Quản lý Voucher & Khuyến mãi
            btnVoucher.Click += (s, e) => LoadControl(new ucKhuyenMai(), btnVoucher);

            // Module Bán hàng & Sơ đồ bàn (UcS01 của thành viên cùng nhóm)
            btnBanhang.Click += (s, e) => LoadControl(new UcS01(), btnBanhang);
            btnSodoban.Click += (s, e) => LoadControl(new UcS01(), btnSodoban);

            // Các nút khác
            btnDangxuatsidebar.Click += (s, e) =>
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            };

            // Mặc định khi mở phần mềm: Tải màn hình Quản lý món (M01)
            LoadControl(new ucQuanLyMon(), btnQuanlymon);
        }

        private void LoadControl(UserControl uc, Button? navBtn = null)
        {
            pnlContent.SuspendLayout();
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
            pnlContent.ResumeLayout();

            if (navBtn != null)
            {
                SetActiveNavButton(navBtn);
            }
        }

        private void SetActiveNavButton(Button btn)
        {
            if (_activeNavButton != null && _activeNavButton != btn)
            {
                _activeNavButton.BackColor = Color.FromArgb(85, 55, 34);
                _activeNavButton.ForeColor = Color.FromArgb(238, 193, 164);
                _activeNavButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            }

            _activeNavButton = btn;
            _activeNavButton.BackColor = Color.FromArgb(106, 80, 63);
            _activeNavButton.ForeColor = Color.White;
            _activeNavButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void KhoiTaoDongHo()
        {
            _clockTimer = new System.Windows.Forms.Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += (s, e) =>
            {
                DateTime now = DateTime.Now;
                string thu = now.DayOfWeek switch
                {
                    DayOfWeek.Monday => "Thứ 2",
                    DayOfWeek.Tuesday => "Thứ 3",
                    DayOfWeek.Wednesday => "Thứ 4",
                    DayOfWeek.Thursday => "Thứ 5",
                    DayOfWeek.Friday => "Thứ 6",
                    DayOfWeek.Saturday => "Thứ 7",
                    _ => "Chủ nhật"
                };
                lblThoigian.Text = $"{thu}, {now:dd/MM/yyyy HH:mm}";
            };
            _clockTimer.Start();
        }
    }
}
