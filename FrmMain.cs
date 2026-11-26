using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.UserControls;

namespace DoAnLapTrinhTrucQuan
{
    public partial class frmMain : Form
    {
        private ucPersonalInfo? profileControl;
        private string currentUsername = "Quản lý ca";
        private Button? _activeNavButton = null;
        private System.Windows.Forms.Timer? _clockTimer;

        public frmMain() : this("Quản lý ca")
        {
        }

        public frmMain(string username)
        {
            InitializeComponent();

            currentUsername = username;
            WindowState = FormWindowState.Maximized;

            // Show username in topbar
            lbTentopbar.Text = username;

            // Layout helpers
            flowLayoutPanel1.Dock = DockStyle.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                          AnchorStyles.Left | AnchorStyles.Right;
            currentUsername = string.IsNullOrWhiteSpace(username) ? "Quản lý ca" : username;
            WindowState = FormWindowState.Maximized;

            // Hiển thị tên người dùng trên topbar
            if (lbTentopbar != null)
            {
                lbTentopbar.Text = currentUsername;
            }

            // Cấu hình layout sidebar & topbar
            flowLayoutPanel1.Dock = DockStyle.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThongtincanhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            pnlSidebar.Resize += (_, _) => LayoutSidebar();
            pnlTopbar.Resize += (_, _) => LayoutTopbar();
            LayoutSidebar();
            LayoutTopbar();

            // Sidebar navigation
            btnThongtincanhan.Click += (_, _) => ShowProfile();
            btnDangxuatsidebar.Click += (_, _) => ConfirmLogout();
            btnQuanlynhanvien.Click += btnQuanlynhanvien_Click;
            KhoiTaoSuKien();
            KhoiTaoDongHo();
        }

        private void KhoiTaoSuKien()
        {
            // Hồ sơ cá nhân & Đăng xuất
            btnThongtincanhan.Click += (_, _) => ShowProfile();
            btnDangxuatsidebar.Click += (_, _) => ConfirmLogout();

            // Module M05: Quản lý nhân viên
            btnQuanlynhanvien.Click += btnQuanlynhanvien_Click;

            // Module M01: Quản lý món
            btnQuanlymon.Click += (s, e) => LoadControl(new ucProduct(), btnQuanlymon);

            // Module M04: Quản lý Voucher & Khuyến mãi
            btnVoucher.Click += (s, e) => LoadControl(new ucVoucher(), btnVoucher);

            // Module Danh mục
            btnDanhmuc.Click += (s, e) => LoadControl(new ucDanhMuc(), btnDanhmuc);

            // Module M02 & M03: Tồn kho, Nguyên liệu & Nhập xuất Excel
            btnNguyenlieukho.Click += (s, e) => LoadControl(new ucInventory(), btnNguyenlieukho);

            // Module Bán hàng & Sơ đồ bàn (UcS01 của thành viên cùng nhóm)
            btnBanhang.Click += (s, e) => LoadControl(new UcS01(), btnBanhang);
            btnSodoban.Click += (s, e) => LoadControl(new UcS01(), btnSodoban);

            // Mặc định khi mở phần mềm: Tải màn hình Quản lý kho (M02)
            LoadControl(new ucInventory(), btnNguyenlieukho);
        }

        // ── Load profile panel ──────────────────────────────────────────
        private void ShowProfile()
        {
            if (profileControl == null)
            {
                profileControl = new ucPersonalInfo();
                profileControl.ProfileUpdated += (name, _) =>
                {
                    lbTentopbar.Text = name;
                    if (lbTentopbar != null) lbTentopbar.Text = name;
                    currentUsername = name;
                };
            }
            LoadControl(profileControl, btnThongtincanhan);
        }

        // ── Logout ──────────────────────────────────────────────────────
        private void ConfirmLogout()
        {
            var result = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        // ── Layout helpers ───────────────────────────────────────────────
        private void LayoutSidebar()
        {
            const int navItemHeight = 51;
            flowLayoutPanel1.Location = new Point(0, pnlLogo.Height);
            flowLayoutPanel1.Size = new Size(
                pnlSidebar.ClientSize.Width,
                Math.Max(0, pnlSidebar.ClientSize.Height
                    - pnlLogo.Height
                    - panel1.Height
                    - btnThongtincanhan.Height));
            btnThongtincanhan.Location = new Point(
                0,
                pnlSidebar.ClientSize.Height - panel1.Height - btnThongtincanhan.Height);
            btnThongtincanhan.Width = pnlSidebar.ClientSize.Width;
            flowLayoutPanel1.AutoScrollMinSize =
                new Size(0, flowLayoutPanel1.Controls.Count * navItemHeight);
        }

        private void LayoutTopbar()
        {
            const int rightInset = 16;
            picAvttopbar.Location = new Point(
                pnlTopbar.ClientSize.Width - picAvttopbar.Width - rightInset, 12);

            lbTentopbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTentopbar.AutoSize = false;
            lbTentopbar.TextAlign = ContentAlignment.MiddleRight;
            lbTentopbar.Size = new Size(160, 26);
            lbTentopbar.Location = new Point(picAvttopbar.Left - lbTentopbar.Width - 12, 6);

            lbRoletopbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbRoletopbar.AutoSize = false;
            lbRoletopbar.TextAlign = ContentAlignment.MiddleRight;
            lbRoletopbar.Size = new Size(160, 26);
            lbRoletopbar.Location = new Point(picAvttopbar.Left - lbRoletopbar.Width - 12, 34);
        }

        // ── Load UserControl into content panel ──────────────────────────
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
                if (lblThoigian != null)
                {
                    lblThoigian.Text = $"{thu}, {now:dd/MM/yyyy HH:mm}";
                }
            };
            _clockTimer.Start();
        }

        private void btnQuanlynhanvien_Click(object? sender, EventArgs e)
        {
            LoadControl(new ucEmployee(), btnQuanlynhanvien);
        }

        private void btnXepca_Click(object sender, EventArgs e)
        {
            LoadControl(new ucShiftSchedule());
        }
    }
}
