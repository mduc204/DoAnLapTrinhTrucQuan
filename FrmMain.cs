using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.UserControls;

namespace DoAnLapTrinhTrucQuan
{
    /// <summary>
    /// Màn hình chính của hệ thống Mộc Café (frmMain)
    /// </summary>
    public partial class frmMain : Form
    {
        private Button? _activeNavButton = null;
        private System.Windows.Forms.Timer? tmrClock;

        public frmMain()
        {
            InitializeComponent();
            InitializeEvents();
            InitializeClock();
            ApplySessionPermissions();
        }

        private void InitializeEvents()
        {
            // Module Sản phẩm / Quản lý món
            btnMenuProduct.Click += (s, e) => LoadControl(new ucProduct(), btnMenuProduct);

            // Module Danh mục
            btnMenuCategory.Click += (s, e) => LoadControl(new ucDanhMuc(), btnMenuCategory);

            // Module Nguyên liệu & Kho
            btnMenuInventory.Click += (s, e) => LoadControl(new ucQuanLyKho(), btnMenuInventory);

            // Module Voucher & Khuyến mãi
            btnMenuVoucher.Click += (s, e) => LoadControl(new ucVoucher(), btnMenuVoucher);

            // Module Bán hàng & Sơ đồ bàn
            btnMenuOrder.Click += (s, e) => LoadControl(new UcS01(), btnMenuOrder);
            btnMenuTable.Click += (s, e) => LoadControl(new UcS01(), btnMenuTable);

            // Đăng xuất
            btnLogout.Click += (s, e) =>
            {
                if (MessageHelper.Confirm("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất"))
                {
                    Session.Logout();
                    Close();
                }
            };

            // Mặc định tải màn hình Quản lý món
            LoadControl(new ucProduct(), btnMenuProduct);
        }

        private void ApplySessionPermissions()
        {
            // Quy ước: 1 frmMain duy nhất, ẩn/hiện nút theo Session.IsAdmin
            lbRoletopbar.Text = Session.Role;
            lbTentopbar.Text = Session.FullName;

            bool isAdmin = Session.IsAdmin;
            btnMenuStaff.Visible = isAdmin;
            btnMenuShift.Visible = isAdmin;
            btnMenuSchedule.Visible = isAdmin;
            btnMenuReport.Visible = isAdmin;
        }

        private void LoadControl(UserControl uc, Button? navBtn = null)
        {
            NavigationHelper.NavigateTo(pnlContent, uc, navBtn);
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

        private void InitializeClock()
        {
            tmrClock = new System.Windows.Forms.Timer();
            tmrClock.Interval = 1000;
            tmrClock.Tick += (s, e) =>
            {
                DateTime now = DateTime.Now;
                string dayOfWeek = now.DayOfWeek switch
                {
                    DayOfWeek.Monday => "Thứ 2",
                    DayOfWeek.Tuesday => "Thứ 3",
                    DayOfWeek.Wednesday => "Thứ 4",
                    DayOfWeek.Thursday => "Thứ 5",
                    DayOfWeek.Friday => "Thứ 6",
                    DayOfWeek.Saturday => "Thứ 7",
                    _ => "Chủ nhật"
                };
                lblThoigian.Text = $"{dayOfWeek}, {FormatHelper.FormatDate(now)}";
            };
            tmrClock.Start();
        }
    }

    /// <summary>
    /// Wrapper tương thích ngược cho frmMain theo quy ước Form: frmMain
    /// </summary>
    public class FrmMain : frmMain
    {
    }
}
