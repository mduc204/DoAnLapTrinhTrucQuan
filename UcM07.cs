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

        public UcM07()
        {
            InitializeComponent();
            SeedData();
            BuildFilterTabs();
            WireEvents();
            LoadTableList();

            // Select B03 by default to match Figma layout
            var defaultTable = allTables.FirstOrDefault(t => t.Ma == "B03") ?? allTables.FirstOrDefault();
            if (defaultTable != null)
            {
                LoadDetail(defaultTable);
                SelectRowForTable(defaultTable);
            }
        }

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

            pnlFilterTabs.Controls.Clear();
            filterButtons.Clear();
            int x = 0;
            foreach (var (label, count) in filters)
            {
                var btn = new Button
                {
                    Text = $"{label} ({count})",
                    AutoSize = false,
                    Width = 96,
                    Height = 28,
                    Location = new Point(x, 1),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
                    Cursor = Cursors.Hand,
                };
                btn.FlatAppearance.BorderSize = 1;
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
                x += 100;
            }
            pnlFilterTabs.Width = x;
        }

        private static void SetTabStyle(Button btn, bool active)
        {
            if (active)
            {
                btn.BackColor = Espresso;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = Espresso;
                btn.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            }
            else
            {
                btn.BackColor = Color.FromArgb(250, 247, 245);
                btn.ForeColor = Color.FromArgb(80, 65, 58);
                btn.FlatAppearance.BorderColor = BorderWarm;
                btn.Font = new Font("Segoe UI", 8.5f, FontStyle.Regular);
            }
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
            {
                if (activeFilter == "Tầng 1")   filtered = filtered.Where(t => t.KhuVuc.StartsWith("Tầng 1"));
                if (activeFilter == "Tầng 2")   filtered = filtered.Where(t => t.KhuVuc.StartsWith("Tầng 2"));
                if (activeFilter == "Sân vườn") filtered = filtered.Where(t => t.KhuVuc.StartsWith("Sân vườn"));
            }
            if (!string.IsNullOrEmpty(search))
                filtered = filtered.Where(t => t.Ma.ToLower().Contains(search) || t.TenHienThi.ToLower().Contains(search));

            dgvBan.Rows.Clear();
            int perPage = 8;
            var list = filtered.ToList();
            int total = list.Count;
            int totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)perPage));
            if (currentPage > totalPages) currentPage = 1;

            var paged = list.Skip((currentPage - 1) * perPage).Take(perPage).ToList();
            foreach (var t in paged)
            {
                string sucChuaText = t.SucChua != t.SucChuaMax ? $"{t.SucChua} - {t.SucChuaMax}\nchỗ" : $"{t.SucChua}\nchỗ";
                string icon = t.TrangThai == "Tạm ngưng" ? "🔧" : (t == selectedTable ? "👁" : "✎");
                int idx = dgvBan.Rows.Add(t.Ma, t.TenHienThi, t.KhuVuc, sucChuaText, $"{t.PhuThu:N0} đ", t.MayIn, t.TrangThai, icon);
                dgvBan.Rows[idx].Tag = t;
                if (t.TrangThai == "Tạm ngưng")
                    dgvBan.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240);
                else if (t == selectedTable)
                    dgvBan.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(255, 236, 226);
                else if (idx % 2 == 1)
                    dgvBan.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 247);
            }

            lblPager.Text = $"Hiển thị {paged.Count} / {total} bàn";
            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage < totalPages;
            lblPageNum.Text = $"{currentPage}";

            UpdateStatCards();
        }

        private void SelectRowForTable(TableInfo table)
        {
            foreach (DataGridViewRow row in dgvBan.Rows)
            {
                if (row.Tag == table)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void UpdateStatCards()
        {
            int total = allTables.Count;
            int t1 = allTables.Count(t => t.KhuVuc.StartsWith("Tầng 1"));
            int t1Cho = allTables.Where(t => t.KhuVuc.StartsWith("Tầng 1")).Sum(t => t.SucChuaMax);
            int t2 = allTables.Count(t => t.KhuVuc.StartsWith("Tầng 2"));
            int t2Cho = allTables.Where(t => t.KhuVuc.StartsWith("Tầng 2")).Sum(t => t.SucChuaMax);
            int sv = allTables.Count(t => t.KhuVuc.StartsWith("Sân vườn"));
            int svCho = allTables.Where(t => t.KhuVuc.StartsWith("Sân vườn")).Sum(t => t.SucChuaMax);
            int tamNgung = allTables.Count(t => t.TrangThai == "Tạm ngưng");
            string tamNgungMa = string.Join(", ", allTables.Where(t => t.TrangThai == "Tạm ngưng").Select(t => $"Bàn {t.Ma}"));

            lblStatTotal.Text = $"{total} bàn";
            lblStatT1.Text = $"{t1} ({t1Cho} chỗ ngồi)";
            lblStatT2.Text = $"{t2} ({t2Cho} chỗ ngồi)";
            lblStatSV.Text = $"{sv} ({svCho} chỗ ngồi)";
            lblStatTamNgung.Text = tamNgung > 0 ? $"{tamNgung:D2} ({tamNgungMa})" : "00";
            pnlStatTamNgung.BackColor = tamNgung > 0 ? Color.FromArgb(255, 235, 235) : Color.FromArgb(240, 253, 244);
            lblStatTamNgungTitle.ForeColor = tamNgung > 0 ? Red : Green;
        }

        // ─── Wire events & layout ────────────────────────────────────────────
        private void WireEvents()
        {
            pnlToolbar.Layout += PnlToolbar_Layout;
            pnlStats.Resize += PnlStats_Resize;
            pnlFilterRow.Resize += PnlFilterRow_Resize;
            pnlDangerBtns.Layout += PnlDangerBtns_Layout;
            pnlPager.Resize += PnlPager_Resize;
            picQrCode.Paint += PicQrCode_Paint;

            txtSearch.TextChanged += (_, _) => { currentPage = 1; LoadTableList(); };
            dgvBan.SelectionChanged += DgvBan_SelectionChanged;
            dgvBan.CellPainting += DgvBan_CellPainting;

            btnPrevPage.Click += (_, _) => { currentPage--; LoadTableList(); };
            btnNextPage.Click += (_, _) => { currentPage++; LoadTableList(); };

            btnThemBan.Click += BtnThemBan_Click;
            btnThemKhuVuc.Click += (_, _) => MessageBox.Show("Tính năng thêm khu vực mới đang được đồng bộ với sơ đồ POS.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLuuToaDo.Click += (_, _) => MessageBox.Show("Đã lưu tọa độ sơ đồ tất cả các bàn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnXuatExcel.Click += (_, _) => MessageBox.Show($"Đã xuất danh sách {allTables.Count} bàn ra định dạng CSV.", "Xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnKeoTha.Click += (_, _) => MessageBox.Show("Chuyển sang tab 'Sơ đồ bàn' để kéo thả trực tiếp vị trí bàn.", "Vị trí sơ đồ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPrintQR.Click += (_, _) => MessageBox.Show($"Đang gửi lệnh in tem QR cho bàn {selectedTable?.Ma ?? ""} (khổ K80).", "In tem QR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDownloadSvg.Click += (_, _) => MessageBox.Show($"Đã tải ảnh QR SVG cho bàn {selectedTable?.Ma ?? ""}.", "Tải SVG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnHuyDetail.Click += (_, _) => ClearDetail();
            btnLuuDetail.Click += BtnLuuDetail_Click;
            btnTamNgung.Click += BtnTamNgung_Click;
            btnXoaBan.Click += BtnXoaBan_Click;

            PnlStats_Resize(null, EventArgs.Empty);
            PnlFilterRow_Resize(null, EventArgs.Empty);
            PnlPager_Resize(null, EventArgs.Empty);
        }

        private void PnlToolbar_Layout(object? sender, LayoutEventArgs e)
        {
            int x = pnlToolbar.Padding.Left;
            foreach (Control c in pnlToolbar.Controls)
            {
                c.Location = new Point(x, 8);
                x += c.Width + 8;
            }
        }

        private void PnlStats_Resize(object? sender, EventArgs e)
        {
            var cards = new[] { pnlStatTotal, pnlStatT1, pnlStatT2, pnlStatSV, pnlStatTamNgung };
            int gap = 10;
            int w = Math.Max(100, (pnlStats.ClientSize.Width - pnlStats.Padding.Horizontal - (cards.Length - 1) * gap) / cards.Length);
            int x = pnlStats.Padding.Left;
            foreach (var c in cards)
            {
                c.SetBounds(x, pnlStats.Padding.Top, w, 64);
                x += w + gap;
            }
        }

        private void PnlFilterRow_Resize(object? sender, EventArgs e)
        {
            btnFilterIcon.Location = new Point(pnlFilterRow.ClientSize.Width - btnFilterIcon.Width, 2);
            txtSearch.Location = new Point(btnFilterIcon.Left - txtSearch.Width - 6, 2);
        }

        private void PnlDangerBtns_Layout(object? sender, LayoutEventArgs e)
        {
            btnTamNgung.Location = new Point(0, 3);
            btnXoaBan.Location = new Point(btnTamNgung.Width + 8, 3);
        }

        private void PnlPager_Resize(object? sender, EventArgs e)
        {
            int rx = pnlPager.ClientSize.Width - 4;
            btnNextPage.Location = new Point(rx - btnNextPage.Width, 5);
            lblPageNum.Location = new Point(btnNextPage.Left - lblPageNum.Width - 6, 5);
            btnPrevPage.Location = new Point(lblPageNum.Left - btnPrevPage.Width - 6, 5);
        }

        // ─── DGV events & custom painting ────────────────────────────────────
        private void DgvBan_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count == 0) return;
            var t = dgvBan.SelectedRows[0].Tag as TableInfo;
            if (t != null && t != selectedTable)
            {
                LoadDetail(t);
                dgvBan.Invalidate();
            }
        }

        private void DgvBan_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0 || e.Graphics == null) return;
            var row = dgvBan.Rows[e.RowIndex];
            var tt = row.Tag as TableInfo;
            if (tt == null) return;

            string colName = dgvBan.Columns[e.ColumnIndex].Name;
            bool isSelected = tt == selectedTable;
            bool isSuspended = tt.TrangThai == "Tạm ngưng";

            if (colName == "colMa")
            {
                e.PaintBackground(e.CellBounds, true);
                if (isSelected)
                {
                    using var pillBrush = new SolidBrush(Brown);
                    e.Graphics.FillRectangle(pillBrush, e.CellBounds.X + 4, e.CellBounds.Y + 20, 4, 14);
                }
                var fg = isSuspended ? Red : Espresso;
                TextRenderer.DrawText(e.Graphics, tt.Ma, new Font("Segoe UI", 8.5f, FontStyle.Bold),
                    new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y, e.CellBounds.Width - 10, e.CellBounds.Height),
                    fg, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                e.Handled = true;
                return;
            }

            if (colName == "colTenHienThi")
            {
                e.PaintBackground(e.CellBounds, true);
                var fontStyle = isSuspended ? FontStyle.Strikeout : (isSelected ? FontStyle.Bold : FontStyle.Regular);
                var fg = isSuspended ? Color.Gray : Espresso;
                using var font = new Font("Segoe UI", 8.5f, fontStyle);
                var rect = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y + 4, e.CellBounds.Width - 8, e.CellBounds.Height - 8);
                TextRenderer.DrawText(e.Graphics, tt.TenHienThi, font, rect, fg,
                    TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                e.Handled = true;
                return;
            }

            if (colName == "colSucChua")
            {
                e.PaintBackground(e.CellBounds, true);
                string scText = tt.SucChua != tt.SucChuaMax ? $"{tt.SucChua} - {tt.SucChuaMax}\nchỗ" : $"{tt.SucChua}\nchỗ";
                var rect = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 8, e.CellBounds.Width - 20, e.CellBounds.Height - 16);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using var path = CreateRoundedPath(rect, 6);
                using var brush = new SolidBrush(PillWarm);
                e.Graphics.FillPath(brush, path);
                TextRenderer.DrawText(e.Graphics, scText, new Font("Segoe UI", 7.5f, FontStyle.Bold),
                    rect, Espresso, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            if (colName == "colTrangThai")
            {
                e.PaintBackground(e.CellBounds, true);
                bool active = !isSuspended;
                var bgColor = active ? GreenBg : RedBg;
                var fgColor = active ? Green : Red;
                string text = active ? "● Hoạt động" : "▌Tạm ngưng\n(Bảo trì)";

                var rect = new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 10, e.CellBounds.Width - 12, e.CellBounds.Height - 20);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using var path = CreateRoundedPath(rect, 6);
                using var brush = new SolidBrush(bgColor);
                e.Graphics.FillPath(brush, path);
                TextRenderer.DrawText(e.Graphics, text, new Font("Segoe UI", 7.5f, FontStyle.Bold),
                    rect, fgColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
            }
        }

        private void PicQrCode_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            int seed = (selectedTable?.Ma ?? "B03").GetHashCode();
            int cell = 6;
            int pad = 6;
            using var dark = new SolidBrush(Espresso);

            // Draw 3 corner finder squares + deterministic data pattern
            void Finder(int gx, int gy)
            {
                g.FillRectangle(dark, pad + gx * cell, pad + gy * cell, 3 * cell, 3 * cell);
                g.FillRectangle(Brushes.White, pad + gx * cell + 3, pad + gy * cell + 3, 3 * cell - 6, 3 * cell - 6);
                g.FillRectangle(dark, pad + gx * cell + 6, pad + gy * cell + 6, 3 * cell - 12, 3 * cell - 12);
            }
            Finder(0, 0);
            Finder(6, 0);
            Finder(0, 6);

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if ((r < 4 && c < 4) || (r < 4 && c > 4) || (r > 4 && c < 4)) continue;
                    if (((r * 13 + c * 7 + seed) & 1) == 0)
                        g.FillRectangle(dark, pad + c * cell, pad + r * cell, cell - 1, cell - 1);
                }
            }
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
            lblDetailTitle.Text = $"⊞ Thông tin bàn {t.Ma}";
            lblDetailStatus.Text = t.TrangThai == "Hoạt động" ? "● Đồng bộ POS sẵn sàng" : "▌Tạm ngưng phục vụ";
            lblDetailStatus.ForeColor = t.TrangThai == "Hoạt động" ? GreenLight : Color.FromArgb(252, 165, 165);

            txtDetailMa.Text = t.Ma;
            txtDetailTen.Text = t.TenHienThi;
            txtDetailKhuVuc.Text = t.KhuVuc;
            txtDetailLoaiBan.Text = t.LoaiBan;
            txtDetailSucChua.Text = t.SucChua.ToString();
            txtDetailSucChuaMax.Text = t.SucChuaMax.ToString();
            txtDetailX.Text = t.X.ToString();
            txtDetailY.Text = t.Y.ToString();
            txtDetailMayIn.Text = t.MayIn;
            txtDetailPhuThu.Text = $"{t.PhuThu:N0} VNĐ";
            lblQrLink.Text = $"moccafe.vn/order?table={t.Ma}";
            picQrCode.Invalidate();

            btnTamNgung.Text = t.TrangThai == "Hoạt động" ? "⏸ Tạm ngưng phục vụ" : "✓ Kích hoạt lại";
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
            if (int.TryParse(txtDetailX.Text, out int x)) selectedTable.X = x;
            if (int.TryParse(txtDetailY.Text, out int y)) selectedTable.Y = y;
            selectedTable.MayIn = txtDetailMayIn.Text.Trim();
            string cleanFee = txtDetailPhuThu.Text.Replace("VNĐ", "").Replace("đ", "").Replace(",", "").Trim();
            if (decimal.TryParse(cleanFee, out decimal pt)) selectedTable.PhuThu = pt;

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
            BuildFilterTabs();
            LoadTableList();
            LoadDetail(newTable);
            SelectRowForTable(newTable);
        }
    }
}
