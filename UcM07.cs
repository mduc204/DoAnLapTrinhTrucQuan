using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class UcM07 : UserControl
    {
        // ─── Data model ──────────────────────────────────────────────────────
        private class TableInfo
        {
            public string Ma { get; set; } = "";
            public string TenHienThi { get; set; } = "";
            public string KhuVuc { get; set; } = "";
            public string LoaiBan { get; set; } = "Bàn vuông";
            public int SucChua { get; set; } = 4;
            public int SucChuaMax { get; set; } = 8;
            public decimal PhuThu { get; set; } = 0;
            public string MayIn { get; set; } = "Quầy thu ngân 1";
            public string TrangThai { get; set; } = "Hoạt động"; // "Hoạt động" | "Tạm ngưng"
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;
        }

        private readonly List<TableInfo> allTables = new();
        private TableInfo? selectedTable;
        private string activeFilter = "Tất cả";
        private int currentPage = 1;
        private readonly Dictionary<string, Button> filterButtons = new();

        private static readonly Color Espresso = Color.FromArgb(44, 29, 22);
        private static readonly Color Brown = Color.FromArgb(92, 56, 36);
        private static readonly Color Green = Color.FromArgb(21, 128, 61);
        private static readonly Color GreenBg = Color.FromArgb(151, 244, 148);
        private static readonly Color GreenLight = Color.FromArgb(134, 239, 172);
        private static readonly Color RedBg = Color.FromArgb(255, 214, 214);
        private static readonly Color Red = Color.FromArgb(185, 28, 28);
        private static readonly Color BorderWarm = Color.FromArgb(229, 220, 214);
        private static readonly Color PillWarm = Color.FromArgb(250, 238, 232);

        private bool suppressSelection;
        private static readonly Color FieldBorder = Color.FromArgb(236, 226, 220);

        private static readonly Font FontCellBold = new("Segoe UI", 8.5f, FontStyle.Bold);
        private static readonly Font FontCell = new("Segoe UI", 8.5f, FontStyle.Regular);
        private static readonly Font FontCellStrike = new("Segoe UI", 8.5f, FontStyle.Strikeout);
        private static readonly Font FontSmall = new("Segoe UI", 8f, FontStyle.Regular);
        private static readonly Font FontPill = new("Segoe UI", 7.5f, FontStyle.Bold);
        private static readonly Font FontIcon = new("Segoe UI", 10f, FontStyle.Regular);

        public UcM07()
        {
            InitializeComponent();
            SeedData();
            WireEvents();
        }

        /// <summary>Đổi đơn vị thiết kế (96 DPI) sang pixel thực tế của màn hình.</summary>
        private int S(int logical) => LogicalToDeviceUnits(logical);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Chạy sau khi control đã được auto-scale theo DPI của form cha
            dgvBan.ColumnHeadersHeight = S(40);
            dgvBan.RowTemplate.Height = S(RowHeight);

            // Icon vuông bên phải mỗi thẻ thống kê: căn giữa theo chiều dọc
            foreach (var (card, icon) in new[] { (pnlStatTotal, lblStatTotalIcon), (pnlStatT1, lblStatT1Icon),
                                                 (pnlStatT2, lblStatT2Icon), (pnlStatSV, lblStatSVIcon),
                                                 (pnlStatTamNgung, lblStatTamNgungIcon) })
            {
                icon.Anchor = AnchorStyles.None;
                void Place() => icon.Location = new Point(card.ClientSize.Width - icon.Width - S(10), (card.ClientSize.Height - icon.Height) / 2);
                card.Resize += (_, _) => Place();
                Place();
                icon.BringToFront();
            }

            BuildFilterTabs();
            LoadTableList();

            // Mặc định chọn B03 giống thiết kế Figma
            var defaultTable = allTables.FirstOrDefault(t => t.Ma == "B03") ?? allTables.FirstOrDefault();
            if (defaultTable != null)
            {
                LoadDetail(defaultTable);
                LoadTableList();
                SelectRowForTable(defaultTable);
            }
            ActiveControl = dgvBan; // để ô tìm kiếm hiện placeholder
        }

        private const int RowHeight = 56;

        // ─── Seed data ───────────────────────────────────────────────────────
        private void SeedData()
        {
            allTables.AddRange(new[]
            {
                new TableInfo { Ma="B01", TenHienThi="Bàn B01 - Cửa chính ra vào",     KhuVuc="Tầng 1 – Trong nhà",   LoaiBan="Bàn vuông", SucChua=4,  SucChuaMax=4,  MayIn="Quầy thu ngân 1", TrangThai="Hoạt động", X=100, Y=80  },
                new TableInfo { Ma="B02", TenHienThi="Bàn B02 - Vách gương tường tây", KhuVuc="Tầng 1 – Trong nhà",   LoaiBan="Bàn vuông", SucChua=2,  SucChuaMax=2,  MayIn="Quầy thu ngân 1", TrangThai="Hoạt động", X=200, Y=80  },
                new TableInfo { Ma="B03", TenHienThi="Bàn B03 - Góc sofa tầng 1",      KhuVuc="Tầng 1 – Máy lạnh",    LoaiBan="Bàn vuông", SucChua=4,  SucChuaMax=8,  MayIn="Quầy 1 (mặc định)", TrangThai="Hoạt động", X=240, Y=180 },
                new TableInfo { Ma="B04", TenHienThi="Bàn B04 - Cửa sổ kính trung tâm",KhuVuc="Tầng 1 – Trong nhà",   LoaiBan="Bàn vuông", SucChua=6,  SucChuaMax=6,  MayIn="Quầy thu ngân 1", TrangThai="Hoạt động", X=340, Y=80  },
                new TableInfo { Ma="T01", TenHienThi="Bàn T01 - Ban công ngắm phố",    KhuVuc="Tầng 2 – Ban công",    LoaiBan="Bàn tròn",  SucChua=4,  SucChuaMax=4,  MayIn="Trạm tầng 2",     TrangThai="Hoạt động", X=120, Y=160 },
                new TableInfo { Ma="T06", TenHienThi="Bàn T06 - Bàn dài họp nhóm lớn", KhuVuc="Tầng 2 – Phòng lạnh",  LoaiBan="Bàn dài",   SucChua=10, SucChuaMax=10, MayIn="Trạm tầng 2",     TrangThai="Hoạt động", X=250, Y=260 },
                new TableInfo { Ma="S01", TenHienThi="Bàn S01 - Dưới gốc bàng",        KhuVuc="Sân vườn ngoài trời",  LoaiBan="Bàn vuông", SucChua=4,  SucChuaMax=4,  MayIn="Quầy thu ngân 1", TrangThai="Hoạt động", X=80,  Y=100 },
                new TableInfo { Ma="S04", TenHienThi="Bàn S04 - Dưới tán dù hoa",      KhuVuc="Sân vườn ngoài trời",  LoaiBan="Bàn vuông", SucChua=4,  SucChuaMax=4,  MayIn="Quầy thu ngân 1", TrangThai="Tạm ngưng", X=180, Y=200 },
            });
        }

        // ─── Filter tabs ─────────────────────────────────────────────────────
        private void BuildFilterTabs()
        {
            var filters = new[]
            {
                ("Tất cả",   allTables.Count),
                ("Tầng 1",   allTables.Count(t => t.KhuVuc.StartsWith("Tầng 1"))),
                ("Tầng 2",   allTables.Count(t => t.KhuVuc.StartsWith("Tầng 2"))),
                ("Sân vườn", allTables.Count(t => t.KhuVuc.StartsWith("Sân vườn"))),
            };

            pnlFilterTabs.SuspendLayout();
            foreach (Control c in pnlFilterTabs.Controls.Cast<Control>().ToList()) c.Dispose();
            pnlFilterTabs.Controls.Clear();
            filterButtons.Clear();
            foreach (var (label, count) in filters)
            {
                var btn = new Button
                {
                    Text = $"{label} ({count})",
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Padding = new Padding(S(6), 0, S(6), 0),
                    Margin = new Padding(0, 0, S(2), 0),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                };
                btn.FlatAppearance.BorderSize = 0;
                SetTabStyle(btn, label == activeFilter);
                string capturedLabel = label;
                btn.Click += (_, _) =>
                {
                    activeFilter = capturedLabel;
                    currentPage = 1;
                    RefreshFilterTabStyles();
                    LoadTableList();
                };
                pnlFilterTabs.Controls.Add(btn);
                filterButtons[label] = btn;
            }
            pnlFilterTabs.ResumeLayout(true);
        }

        private static void SetTabStyle(Button btn, bool active)
        {
            btn.BackColor = active ? Espresso : Color.FromArgb(250, 245, 242);
            btn.ForeColor = active ? Color.White : Color.FromArgb(70, 55, 48);
            btn.FlatAppearance.MouseOverBackColor = active ? Espresso : Color.FromArgb(244, 234, 228);
            btn.Font = active ? FontCellBold : FontCell;
        }

        private void RefreshFilterTabStyles()
        {
            foreach (var kv in filterButtons)
                SetTabStyle(kv.Value, kv.Key == activeFilter);
        }

        // ─── Load table into DataGridView ────────────────────────────────────
        private void LoadTableList()
        {
            string search = txtSearch.Text.Trim().ToLower();
            var filtered = allTables.AsEnumerable();
            if (activeFilter != "Tất cả")
                filtered = filtered.Where(t => t.KhuVuc.StartsWith(activeFilter));
            if (!string.IsNullOrEmpty(search))
                filtered = filtered.Where(t => t.Ma.ToLower().Contains(search) || t.TenHienThi.ToLower().Contains(search));

            const int perPage = 8;
            var list = filtered.ToList();
            int total = list.Count;
            int totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)perPage));
            if (currentPage > totalPages) currentPage = 1;
            var paged = list.Skip((currentPage - 1) * perPage).Take(perPage).ToList();

            suppressSelection = true;
            dgvBan.Rows.Clear();
            foreach (var t in paged)
            {
                int idx = dgvBan.Rows.Add(t.Ma, t.TenHienThi, t.KhuVuc, "", $"{t.PhuThu:N0} đ", t.MayIn, t.TrangThai, "");
                var row = dgvBan.Rows[idx];
                row.Tag = t;
                row.Height = S(RowHeight);
                ApplyRowStyle(row, t);
            }
            dgvBan.ClearSelection();
            suppressSelection = false;

            lblPager.Text = $"Hiển thị {paged.Count} / {total} bàn";
            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
            lblPageNum.Text = $"{currentPage}";

            UpdateStatCards();
        }

        private void ApplyRowStyle(DataGridViewRow row, TableInfo t)
        {
            Color bg = t.TrangThai == "Tạm ngưng" ? Color.FromArgb(253, 236, 236)
                     : t == selectedTable ? Color.FromArgb(253, 233, 224)
                     : Color.White;
            row.DefaultCellStyle.BackColor = bg;
            row.DefaultCellStyle.SelectionBackColor = bg;
        }

        private void SelectRowForTable(TableInfo table)
        {
            suppressSelection = true;
            foreach (DataGridViewRow row in dgvBan.Rows)
            {
                if (row.Tag == table)
                {
                    dgvBan.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    break;
                }
            }
            suppressSelection = false;
        }

        private void UpdateStatCards()
        {
            int CountOf(string prefix) => allTables.Count(t => t.KhuVuc.StartsWith(prefix));
            int SeatsOf(string prefix) => allTables.Where(t => t.KhuVuc.StartsWith(prefix)).Sum(t => t.SucChuaMax);
            var tamNgung = allTables.Where(t => t.TrangThai == "Tạm ngưng").ToList();

            lblStatTotal.Text = $"{allTables.Count}";
            lblStatTotalSub.Text = "bàn";
            lblStatT1.Text = $"{CountOf("Tầng 1")}";
            lblStatT1Sub.Text = $"({SeatsOf("Tầng 1")} chỗ ngồi)";
            lblStatT2.Text = $"{CountOf("Tầng 2")}";
            lblStatT2Sub.Text = $"({SeatsOf("Tầng 2")} chỗ ngồi)";
            lblStatSV.Text = $"{CountOf("Sân vườn")}";
            lblStatSVSub.Text = $"({SeatsOf("Sân vườn")} chỗ ngồi)";
            lblStatTamNgung.Text = $"{tamNgung.Count:D2}";
            lblStatTamNgungSub.Text = tamNgung.Count > 0 ? $"({string.Join(", ", tamNgung.Select(t => $"Bàn {t.Ma}"))})" : "(không có)";

            bool hasIssue = tamNgung.Count > 0;
            pnlStatTamNgung.BackColor = hasIssue ? Color.FromArgb(255, 235, 235) : Color.FromArgb(240, 253, 244);
            lblStatTamNgungTitle.ForeColor = hasIssue ? Red : Green;
            lblStatTamNgung.ForeColor = hasIssue ? Red : Green;
        }

        // ─── Wire events ─────────────────────────────────────────────────────
        private void WireEvents()
        {
            // Viền mảnh cho các thẻ / ô nhập giống Figma
            foreach (var c in new Control[] { pnlStatTotal, pnlStatT1, pnlStatT2, pnlStatSV, pnlLeft, pnlDetail,
                                              boxSearch, boxMa, boxTen, boxKhuVuc, boxLoaiBan, boxSucChua })
                c.Paint += PaintBorder;
            pnlStatTamNgung.Paint += (s, e) => PaintBorder(s, e, Color.FromArgb(252, 200, 200));

            txtSearch.TextChanged += (_, _) => { currentPage = 1; LoadTableList(); };
            dgvBan.SelectionChanged += DgvBan_SelectionChanged;
            dgvBan.CellPainting += DgvBan_CellPainting;

            btnPrevPage.Click += (_, _) => { currentPage--; LoadTableList(); };
            btnNextPage.Click += (_, _) => { currentPage++; LoadTableList(); };

            btnThemBan.Click += BtnThemBan_Click;
            btnThemKhuVuc.Click += (_, _) => MessageBox.Show("Tính năng thêm khu vực mới đang được đồng bộ với sơ đồ POS.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuuToaDo.Click += (_, _) => MessageBox.Show("Đã lưu tọa độ sơ đồ tất cả các bàn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnXuatExcel.Click += (_, _) => MessageBox.Show($"Đã xuất danh sách {allTables.Count} bàn ra định dạng CSV.", "Xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnHuyDetail.Click += (_, _) =>
            {
                if (selectedTable != null)
                {
                    LoadDetail(selectedTable);
                    LoadTableList();
                    SelectRowForTable(selectedTable);
                }
            };
            btnLuuDetail.Click += BtnLuuDetail_Click;
            btnTamNgung.Click += BtnTamNgung_Click;
            btnXoaBan.Click += BtnXoaBan_Click;
        }

        private void PaintBorder(object? sender, PaintEventArgs e) => PaintBorder(sender, e, FieldBorder);

        private static void PaintBorder(object? sender, PaintEventArgs e, Color color)
        {
            if (sender is not Control c) return;
            using var pen = new Pen(color);
            e.Graphics.DrawRectangle(pen, 0, 0, c.ClientSize.Width - 1, c.ClientSize.Height - 1);
        }

        // ─── DGV events & custom painting ────────────────────────────────────
        private void DgvBan_SelectionChanged(object? sender, EventArgs e)
        {
            if (suppressSelection || dgvBan.SelectedRows.Count == 0) return;
            if (dgvBan.SelectedRows[0].Tag is TableInfo t && t != selectedTable)
            {
                LoadDetail(t);
                foreach (DataGridViewRow row in dgvBan.Rows)
                    if (row.Tag is TableInfo rt) ApplyRowStyle(row, rt);
                dgvBan.Invalidate();
            }
        }

        private void DgvBan_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0 || e.Graphics == null) return;
            if (dgvBan.Rows[e.RowIndex].Tag is not TableInfo tt) return;

            var g = e.Graphics;
            var cb = e.CellBounds;
            string colName = dgvBan.Columns[e.ColumnIndex].Name;
            bool isSelected = tt == selectedTable;
            bool isSuspended = tt.TrangThai == "Tạm ngưng";
            var muted = Color.FromArgb(120, 100, 90);
            var faded = Color.FromArgb(150, 130, 120);
            var leftFlags = TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;
            var centerFlags = TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPadding;
            Rectangle Inset(int dx, int dy) => new(cb.X + S(dx), cb.Y + S(dy), cb.Width - S(dx) * 2, cb.Height - S(dy) * 2);

            e.PaintBackground(cb, false);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            switch (colName)
            {
                case "colMa":
                {
                    if (isSelected)
                    {
                        using var bar = new SolidBrush(Brown);
                        using var p = CreateRoundedPath(new Rectangle(cb.X + S(6), cb.Y + cb.Height / 2 - S(7), S(4), S(14)), S(2));
                        g.FillPath(bar, p);
                    }
                    var fg = isSuspended ? Red : isSelected ? Brown : Espresso;
                    TextRenderer.DrawText(g, tt.Ma, FontCellBold, Inset(isSelected ? 7 : 2, 0), fg,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                    break;
                }
                case "colTenHienThi":
                {
                    var rect = Inset(4, 4);
                    if (isSelected)
                    {
                        var textRect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height - S(18));
                        TextRenderer.DrawText(g, tt.TenHienThi, FontCellBold, textRect, Espresso, leftFlags);
                        const string badge = "Đang chọn";
                        var sz = TextRenderer.MeasureText(badge, FontPill);
                        var badgeRect = new Rectangle(rect.X, rect.Bottom - S(17), sz.Width + S(4), S(16));
                        using var bb = new SolidBrush(Color.FromArgb(254, 240, 199));
                        g.FillRectangle(bb, badgeRect);
                        TextRenderer.DrawText(g, badge, FontPill, badgeRect, Color.FromArgb(146, 64, 14),
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    }
                    else
                    {
                        TextRenderer.DrawText(g, tt.TenHienThi, isSuspended ? FontCellStrike : FontCell, rect,
                            isSuspended ? faded : Espresso, leftFlags);
                    }
                    break;
                }
                case "colKhuVuc":
                    TextRenderer.DrawText(g, tt.KhuVuc.Replace("–", "-"), FontSmall, Inset(4, 4),
                        isSuspended ? faded : Color.FromArgb(80, 65, 58), leftFlags);
                    break;
                case "colSucChua":
                {
                    string scText = tt.SucChua != tt.SucChuaMax ? $"{tt.SucChua} - {tt.SucChuaMax}\nchỗ" : $"{tt.SucChua}\nchỗ";
                    var sz = TextRenderer.MeasureText(scText, FontPill);
                    int w = sz.Width + S(10), h = sz.Height + S(6);
                    var rect = new Rectangle(cb.X + (cb.Width - w) / 2, cb.Y + (cb.Height - h) / 2, w, h);
                    bool big = tt.SucChuaMax >= 10;
                    using var path = CreateRoundedPath(rect, S(4));
                    using var brush = new SolidBrush(big ? Color.FromArgb(254, 226, 196) : PillWarm);
                    g.FillPath(brush, path);
                    TextRenderer.DrawText(g, scText, FontPill, rect, big ? Color.FromArgb(154, 52, 18) : Espresso,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    break;
                }
                case "colPhuThu":
                    TextRenderer.DrawText(g, $"{tt.PhuThu:N0} đ", isSelected ? FontCellBold : FontCell, cb, Espresso,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    break;
                case "colMayIn":
                {
                    var rect = Inset(4, 4);
                    TextRenderer.DrawText(g, "🖶", FontSmall, new Rectangle(rect.X, rect.Y, S(16), rect.Height),
                        isSelected ? Brown : muted, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
                    TextRenderer.DrawText(g, tt.MayIn, FontSmall, new Rectangle(rect.X + S(16), rect.Y, rect.Width - S(16), rect.Height),
                        isSuspended ? faded : Color.FromArgb(80, 65, 58), leftFlags);
                    break;
                }
                case "colTrangThai":
                {
                    bool active = !isSuspended;
                    var fgColor = active ? Green : Red;
                    string text = active ? "Hoạt\nđộng" : "Tạm\nngưng\n(Bảo trì)";
                    var rect = Inset(6, active ? 14 : 8);
                    using var path = CreateRoundedPath(rect, S(4));
                    using var brush = new SolidBrush(active ? GreenBg : RedBg);
                    g.FillPath(brush, path);
                    using var dot = new SolidBrush(fgColor);
                    int d = S(5);
                    g.FillEllipse(dot, rect.X + S(7), rect.Y + rect.Height / 2 - d / 2, d, d);
                    TextRenderer.DrawText(g, text, FontPill, new Rectangle(rect.X + S(12), rect.Y, rect.Width - S(12), rect.Height),
                        fgColor, centerFlags);
                    break;
                }
                case "colThaoTac":
                {
                    string icon = isSuspended ? "🔧" : isSelected ? "👁" : "✎";
                    var fg = isSuspended ? Red : isSelected ? Brown : muted;
                    TextRenderer.DrawText(g, icon, FontIcon, cb, fg, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    break;
                }
                default:
                    return;
            }
            e.Handled = true;
        }

        private static GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int diameter = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height));
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        // ─── Detail panel ────────────────────────────────────────────────────
        private void LoadDetail(TableInfo t)
        {
            selectedTable = t;
            pnlDetail.Visible = true;
            lblDetailTitle.Text = $"☷  Thông tin bàn {t.Ma}";
            lblDetailStatus.Text = t.TrangThai == "Hoạt động" ? "● Đồng bộ POS sẵn sàng" : "▌Tạm ngưng phục vụ";
            lblDetailStatus.ForeColor = t.TrangThai == "Hoạt động" ? GreenLight : Color.FromArgb(252, 165, 165);

            txtDetailMa.Text = t.Ma;
            txtDetailTen.Text = t.TenHienThi;
            txtDetailKhuVuc.Text = t.KhuVuc;
            txtDetailLoaiBan.Text = t.LoaiBan;
            txtDetailSucChua.Text = t.SucChua.ToString();
            txtDetailSucChuaMax.Text = t.SucChuaMax.ToString();

            btnTamNgung.Text = t.TrangThai == "Hoạt động" ? "⏸  Tạm ngưng phục vụ" : "✓  Kích hoạt lại";
            btnTamNgung.ForeColor = t.TrangThai == "Hoạt động" ? Red : Green;
            btnTamNgung.FlatAppearance.BorderColor = t.TrangThai == "Hoạt động" ? Color.FromArgb(254, 202, 202) : Green;
        }

        private void ClearDetail()
        {
            selectedTable = null;
            pnlDetail.Visible = false;
            dgvBan.ClearSelection();
        }

        private void BtnLuuDetail_Click(object? sender, EventArgs e)
        {
            if (selectedTable == null) return;
            selectedTable.TenHienThi = txtDetailTen.Text.Trim();
            selectedTable.KhuVuc = txtDetailKhuVuc.Text.Trim();
            selectedTable.LoaiBan = txtDetailLoaiBan.Text.Trim();
            if (int.TryParse(txtDetailSucChua.Text, out int sc)) selectedTable.SucChua = sc;
            if (int.TryParse(txtDetailSucChuaMax.Text, out int scm)) selectedTable.SucChuaMax = scm;

            BuildFilterTabs();
            LoadTableList();
            SelectRowForTable(selectedTable);
            MessageBox.Show($"Đã lưu thông tin bàn {selectedTable.Ma}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTamNgung_Click(object? sender, EventArgs e)
        {
            if (selectedTable == null) return;
            bool wasActive = selectedTable.TrangThai == "Hoạt động";
            string action = wasActive ? "tạm ngưng" : "kích hoạt lại";
            var result = MessageBox.Show($"Bạn có muốn {action} bàn {selectedTable.Ma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectedTable.TrangThai = wasActive ? "Tạm ngưng" : "Hoạt động";
                LoadDetail(selectedTable);
                LoadTableList();
                SelectRowForTable(selectedTable);
            }
        }

        private void BtnXoaBan_Click(object? sender, EventArgs e)
        {
            if (selectedTable == null) return;
            var result = MessageBox.Show($"Bạn có chắc muốn xóa bàn {selectedTable.Ma}?\nHành động này không thể hoàn tác.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                allTables.Remove(selectedTable);
                ClearDetail();
                BuildFilterTabs();
                LoadTableList();
            }
        }

        private void BtnThemBan_Click(object? sender, EventArgs e)
        {
            string newMa = $"B{(allTables.Count + 1):D2}";
            var newTable = new TableInfo
            {
                Ma = newMa,
                TenHienThi = $"Bàn {newMa} - Mới",
                KhuVuc = "Tầng 1 – Trong nhà",
                TrangThai = "Hoạt động",
                X = 50,
                Y = 50
            };
            allTables.Add(newTable);
            activeFilter = "Tất cả";
            LoadDetail(newTable);
            BuildFilterTabs();
            LoadTableList();
            SelectRowForTable(newTable);
        }
    }
}
