using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.BLL;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    /// <summary>
    /// UserControl Quản lý Voucher & Khuyến mãi (ucVoucher)
    /// </summary>
    public partial class ucVoucher : UserControl
    {
        private readonly VoucherBLL _voucherBLL;
        private List<Voucher> _displayedVouchers = new List<Voucher>();
        private Voucher? _selectedVoucher = null;

        private string _currentTabKey = "TatCa"; // "TatCa", "DangHieuLuc", "SapToi", "HetHan"
        private bool _isCreatingNew = false;

        public ucVoucher()
        {
            InitializeComponent();
            _voucherBLL = new VoucherBLL();

            InitializeEvents();
            LoadVouchers();
        }

        #region 1. Khởi tạo sự kiện giao diện
        private void InitializeEvents()
        {
            btnTabAll.Click += (s, e) => SelectFilterTab("TatCa", btnTabAll);
            btnTabActive.Click += (s, e) => SelectFilterTab("DangHieuLuc", btnTabActive);
            btnTabUpcoming.Click += (s, e) => SelectFilterTab("SapToi", btnTabUpcoming);
            btnTabExpired.Click += (s, e) => SelectFilterTab("HetHan", btnTabExpired);

            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cboFilterScope.SelectedIndexChanged += (s, e) => ApplyFilter();

            dgvVoucher.SelectionChanged += DgvVoucher_SelectionChanged;
            dgvVoucher.CellPainting += DgvVoucher_CellPainting;
            dgvVoucher.CellClick += DgvVoucher_CellClick;

            rdoPercentage.CheckedChanged += (s, e) => UpdateDiscountMechanismUI();
            rdoFixedAmount.CheckedChanged += (s, e) => UpdateDiscountMechanismUI();

            toggleKichHoat.CheckedChanged += (s, e) =>
            {
                lblKichHoat.Text = toggleKichHoat.Checked ? "KÍCH HOẠT" : "TẠM NGƯNG";
                lblKichHoat.ForeColor = toggleKichHoat.Checked ? UIHelper.TextMain : ColorTranslator.FromHtml("#C0392B");
            };

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnToggleStatus.Click += BtnToggleStatus_Click;

            btnAddVoucher.Click += BtnAddVoucher_Click;
            btnExportExcel.Click += BtnExportExcel_Click;
            btnHistory.Click += BtnHistory_Click;
        }
        #endregion

        #region 2. Tải & Lọc Dữ Liệu
        private void LoadVouchers()
        {
            ApplyFilter();
            UpdateStats();
        }

        private void SelectFilterTab(string tabKey, Button activeBtn)
        {
            _currentTabKey = tabKey;

            Button[] tabs = { btnTabAll, btnTabActive, btnTabUpcoming, btnTabExpired };
            foreach (var b in tabs)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(93, 74, 61);
                b.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }

            activeBtn.BackColor = Color.FromArgb(44, 30, 20);
            activeBtn.ForeColor = Color.White;
            activeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword = (txtSearch.Text ?? "").Trim().ToLower();
            int scopeIdx = cboFilterScope.SelectedIndex;

            _displayedVouchers = _voucherBLL.LoadVouchers().Where(v =>
            {
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                    v.VoucherCode.ToLower().Contains(keyword) ||
                                    v.ProgramName.ToLower().Contains(keyword);

                bool matchTab = true;
                if (_currentTabKey == "DangHieuLuc") matchTab = v.Status == "Đang hiệu lực";
                else if (_currentTabKey == "SapToi") matchTab = v.Status == "Sắp diễn ra";
                else if (_currentTabKey == "HetHan") matchTab = v.Status == "Hết hạn" || v.Status == "Hết lượt" || v.Status == "Tạm dừng";

                bool matchScope = true;
                if (scopeIdx == 1) matchScope = v.Scope == "Tại quán" || v.Scope == "Tất cả";
                else if (scopeIdx == 2) matchScope = v.Scope == "Mang về" || v.Scope == "Tất cả";

                return matchKeyword && matchTab && matchScope;
            }).ToList();

            RenderVoucherGrid();
        }

        private void RenderVoucherGrid()
        {
            dgvVoucher.SuspendLayout();
            dgvVoucher.Rows.Clear();

            int stt = 1;
            foreach (var v in _displayedVouchers)
            {
                int rowIndex = dgvVoucher.Rows.Add(
                    stt++,
                    v.VoucherCode,
                    v.ProgramName,
                    v.UuDaiDisplay,
                    v.LuotDungDisplay,
                    v.Scope,
                    v.Status,
                    "❐"
                );
                dgvVoucher.Rows[rowIndex].Tag = v;
            }

            dgvVoucher.ResumeLayout();

            if (dgvVoucher.Rows.Count > 0)
            {
                dgvVoucher.Rows[0].Selected = true;
                DgvVoucher_SelectionChanged(null, EventArgs.Empty);
            }
        }

        private void UpdateStats()
        {
            var allVouchers = _voucherBLL.LoadVouchers();
            int total = allVouchers.Count;
            int active = allVouchers.Count(v => v.Status == "Đang hiệu lực");
            int upcoming = allVouchers.Count(v => v.Status == "Sắp diễn ra");
            int expired = allVouchers.Count(v => v.Status == "Hết hạn" || v.Status == "Hết lượt" || v.Status == "Tạm dừng");

            lblQuickStats.Text = $"{total} voucher • {active} đang hiệu lực • {upcoming} sắp diễn ra • {expired} hết hạn / tạm dừng   |   Đã giảm tháng này: 4.820.000 đ - 215 hóa đơn";

            btnTabAll.Text = $"Tất cả ({total})";
            btnTabActive.Text = $"Đang hiệu lực ({active})";
            btnTabUpcoming.Text = $"Sắp tới ({upcoming})";
            btnTabExpired.Text = $"Hết hạn ({expired})";
        }
        #endregion

        #region 3. Hiển Thị Chi Tiết Voucher Lên Form
        private void DgvVoucher_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVoucher.SelectedRows.Count == 0) return;

            var row = dgvVoucher.SelectedRows[0];
            if (row.Tag is Voucher v)
            {
                _selectedVoucher = v;
                _isCreatingNew = false;
                DisplayVoucherDetails(v);
            }
        }

        private void DisplayVoucherDetails(Voucher v)
        {
            lblDetailTitle.Text = $"🏷 Chi tiết Voucher: {v.VoucherCode}";
            toggleKichHoat.Checked = v.IsActive;

            txtVoucherCode.Text = v.VoucherCode;
            txtVoucherCode.ReadOnly = true;
            txtProgramName.Text = v.ProgramName;

            if (v.DiscountType == "PhanTram")
            {
                rdoPercentage.Checked = true;
                txtDiscountValue.Text = v.DiscountValue.ToString("0.##");
                txtMaxDiscount.Text = v.MaxDiscount > 0 ? v.MaxDiscount.ToString("#,##0") : "0";
            }
            else
            {
                rdoFixedAmount.Checked = true;
                txtDiscountValue.Text = v.DiscountValue.ToString("#,##0");
                txtMaxDiscount.Text = "0";
            }

            UpdateDiscountMechanismUI();

            txtMinOrder.Text = v.MinOrder.ToString("#,##0");

            if (v.Scope == "Tại quán") cboScope.SelectedIndex = 1;
            else if (v.Scope == "Mang về") cboScope.SelectedIndex = 2;
            else cboScope.SelectedIndex = 0;

            dtpStartDate.Value = v.StartDate;
            dtpEndDate.Value = v.EndDate;

            txtTotalUsage.Text = v.TotalUsage > 0 ? v.TotalUsage.ToString("#,##0") : "0";
            txtUsagePerOrder.Text = $"{v.LimitPerOrder} lượt / hóa đơn";

            int remaining = v.TotalUsage > 0 ? Math.Max(0, v.TotalUsage - v.UsedCount) : 9999;
            lblDaDung.Text = $"● Đã dùng: {v.UsedCount}";
            lblConLai.Text = v.TotalUsage > 0 ? $"● Còn lại: {remaining}" : "● Không giới hạn";
            if (remaining == 0 && v.TotalUsage > 0)
            {
                lblConLai.ForeColor = ColorTranslator.FromHtml("#C0392B");
                lblConLai.BackColor = ColorTranslator.FromHtml("#FDE8E8");
            }
            else
            {
                lblConLai.ForeColor = ColorTranslator.FromHtml("#16793F");
                lblConLai.BackColor = ColorTranslator.FromHtml("#E4F6EB");
            }

            txtNote.Text = v.Note;
        }

        private void UpdateDiscountMechanismUI()
        {
            if (rdoPercentage.Checked)
            {
                lblMucGiam.Text = "Mức giảm";
                lblMucGiamUnit.Text = "%";
                pnlGiamToiDaContainer.Visible = true;
            }
            else
            {
                lblMucGiam.Text = "Số tiền giảm";
                lblMucGiamUnit.Text = "đ";
                pnlGiamToiDaContainer.Visible = false;
            }
        }
        #endregion

        #region 4. Tự Vẽ DataGridView (ProgressBar Lượt Dùng, Badges, Mã Vé)
        private void DgvVoucher_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;
            Rectangle cellBounds = e.CellBounds;
            Graphics? g = e.Graphics;
            if (g == null) return;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Color rowBg = isSelected ? UIHelper.RowSelected : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(rowBg))
            {
                g.FillRectangle(bgBrush, cellBounds);
            }

            using (Pen linePen = new Pen(ColorTranslator.FromHtml("#F0EAE1"), 1f))
            {
                g.DrawLine(linePen, cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);
            }

            if (isSelected && e.ColumnIndex == 0)
            {
                using (SolidBrush orangeBrush = new SolidBrush(UIHelper.AccentOrange))
                {
                    g.FillRectangle(orangeBrush, cellBounds.Left, cellBounds.Top, 4, cellBounds.Height);
                }
            }

            if (dgvVoucher.Rows[e.RowIndex].Tag is not Voucher v) return;

            string colName = dgvVoucher.Columns[e.ColumnIndex].Name;

            if (colName == "colSTT")
            {
                TextRenderer.DrawText(g, e.Value?.ToString() ?? "", UIHelper.FontRegular, cellBounds, UIHelper.TextMuted,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            if (colName == "colMaVoucher")
            {
                string maText = $"🎫 {v.VoucherCode}";
                Size textSize = TextRenderer.MeasureText(g, maText, UIHelper.FontBold);
                int badgeW = Math.Min(cellBounds.Width - 12, Math.Max(textSize.Width + 16, 95));
                int badgeH = 28;
                Rectangle badgeRect = new Rectangle(cellBounds.Left + 6, cellBounds.Top + (cellBounds.Height - badgeH) / 2, badgeW, badgeH);

                using (GraphicsPath path = UIHelper.GetRoundedPath(badgeRect, 6))
                {
                    using (SolidBrush fillB = new SolidBrush(ColorTranslator.FromHtml("#F5EDE4")))
                    {
                        g.FillPath(fillB, path);
                    }
                    using (Pen pen = new Pen(ColorTranslator.FromHtml("#D5C7B8"), 1f))
                    {
                        g.DrawPath(pen, path);
                    }
                }

                TextRenderer.DrawText(g, maText, UIHelper.FontBold, badgeRect, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                e.Handled = true;
                return;
            }

            if (colName == "colTenChuongTrinh")
            {
                Rectangle titleRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);
                Rectangle subRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 26, cellBounds.Width - 16, 16);

                TextRenderer.DrawText(g, v.ProgramName, UIHelper.FontBold, titleRect, UIHelper.TextMain,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                TextRenderer.DrawText(g, v.ScheduleText, UIHelper.FontSmall, subRect, UIHelper.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                e.Handled = true;
                return;
            }

            if (colName == "colUuDai")
            {
                Rectangle line1Rect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);
                Rectangle line2Rect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 26, cellBounds.Width - 16, 16);

                TextRenderer.DrawText(g, v.UuDaiDisplay, UIHelper.FontBold, line1Rect, UIHelper.TextMain,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                TextRenderer.DrawText(g, v.DieuKienDisplay, UIHelper.FontSmall, line2Rect, UIHelper.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                e.Handled = true;
                return;
            }

            if (colName == "colLuotDung")
            {
                Rectangle textRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);

                if (v.TotalUsage > 0)
                {
                    TextRenderer.DrawText(g, v.LuotDungDisplay, UIHelper.FontBold, textRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                    int barW = cellBounds.Width - 20;
                    int barH = 5;
                    Rectangle barTrack = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 30, barW, barH);

                    using (GraphicsPath trackPath = UIHelper.GetCapsulePath(barTrack))
                    using (SolidBrush trackBrush = new SolidBrush(ColorTranslator.FromHtml("#EFE8E1")))
                    {
                        g.FillPath(trackBrush, trackPath);
                    }

                    double pt = v.PhanTramLuotDung;
                    int fillW = (int)Math.Max(barH, barW * (pt / 100.0));
                    if (fillW > 0)
                    {
                        Rectangle barFill = new Rectangle(barTrack.X, barTrack.Y, Math.Min(barW, fillW), barH);

                        Color fillColor = ColorTranslator.FromHtml("#6F4E37");
                        if (pt >= 100) fillColor = ColorTranslator.FromHtml("#C0392B");
                        else if (pt >= 80) fillColor = ColorTranslator.FromHtml("#E67E22");

                        using (GraphicsPath fillPath = UIHelper.GetCapsulePath(barFill))
                        using (SolidBrush fillBrush = new SolidBrush(fillColor))
                        {
                            g.FillPath(fillBrush, fillPath);
                        }
                    }
                }
                else
                {
                    TextRenderer.DrawText(g, "Không giới hạn", UIHelper.FontBold, textRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                    Rectangle subRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 26, cellBounds.Width - 16, 16);
                    TextRenderer.DrawText(g, $"Đã dùng {v.UsedCount} lượt", UIHelper.FontSmall, subRect, UIHelper.TextMuted,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                }

                e.Handled = true;
                return;
            }

            if (colName == "colPhamVi")
            {
                TextRenderer.DrawText(g, v.Scope, UIHelper.FontRegular, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            if (colName == "colTrangThai")
            {
                Color bgPill;
                Color textPill;
                string dotText;

                switch (v.Status)
                {
                    case "Đang hiệu lực":
                        bgPill = UIHelper.BadgeGreenBg;
                        textPill = UIHelper.BadgeGreenText;
                        dotText = "● Đang hiệu lực";
                        break;
                    case "Sắp diễn ra":
                        bgPill = UIHelper.BadgeOrangeBg;
                        textPill = UIHelper.BadgeOrangeText;
                        dotText = "● Sắp diễn ra";
                        break;
                    case "Hết lượt":
                    case "Hết hạn":
                        bgPill = UIHelper.BadgeRedBg;
                        textPill = UIHelper.BadgeRedText;
                        dotText = "● Hết lượt";
                        break;
                    default:
                        bgPill = UIHelper.BadgeGrayBg;
                        textPill = UIHelper.BadgeGrayText;
                        dotText = "● Tạm dừng";
                        break;
                }

                int pillW = Math.Min(cellBounds.Width - 16, 115);
                int pillH = 26;
                Rectangle pillRect = new Rectangle(cellBounds.Left + (cellBounds.Width - pillW) / 2, cellBounds.Top + (cellBounds.Height - pillH) / 2, pillW, pillH);

                using (GraphicsPath path = UIHelper.GetCapsulePath(pillRect))
                using (SolidBrush pillBrush = new SolidBrush(bgPill))
                {
                    g.FillPath(pillBrush, path);
                }

                TextRenderer.DrawText(g, dotText, UIHelper.FontSmallBold, pillRect, textPill,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
                return;
            }

            if (colName == "colThaoTac")
            {
                using (Font iconFont = new Font("Segoe UI", 11F))
                {
                    TextRenderer.DrawText(g, "❐", iconFont, cellBounds, UIHelper.TextMuted,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                e.Handled = true;
                return;
            }
        }

        private void DgvVoucher_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvVoucher.Rows.Count) return;

            if (dgvVoucher.Columns[e.ColumnIndex].Name == "colThaoTac")
            {
                if (dgvVoucher.Rows[e.RowIndex].Tag is Voucher v)
                {
                    Clipboard.SetText(v.VoucherCode);
                    MessageHelper.ShowInfo($"Đã sao chép mã voucher '{v.VoucherCode}' vào bộ nhớ tạm!", "Sao chép thành công");
                }
            }
        }
        #endregion

        #region 5. Thao Tác Lưu & Quản Lý Voucher
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string code = txtVoucherCode.Text.Trim().ToUpper();
            string name = txtProgramName.Text.Trim();

            if (string.IsNullOrEmpty(code))
            {
                MessageHelper.ShowWarning("Vui lòng nhập Mã Voucher!", "Thiếu thông tin");
                txtVoucherCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageHelper.ShowWarning("Vui lòng nhập Tên chương trình khuyến mãi!", "Thiếu thông tin");
                txtProgramName.Focus();
                return;
            }

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageHelper.ShowWarning("Thời gian kết thúc không được nhỏ hơn thời gian bắt đầu!", "Lỗi thời gian");
                dtpEndDate.Focus();
                return;
            }

            decimal.TryParse(txtDiscountValue.Text.Replace(",", "").Replace(".", "").Trim(), out decimal discountVal);
            decimal.TryParse(txtMaxDiscount.Text.Replace(",", "").Replace(".", "").Trim(), out decimal maxDiscount);
            decimal.TryParse(txtMinOrder.Text.Replace(",", "").Replace(".", "").Trim(), out decimal minOrder);
            int.TryParse(txtTotalUsage.Text.Replace(",", "").Replace(".", "").Trim(), out int totalUsage);
            string ghDigits = new string(txtUsagePerOrder.Text.TakeWhile(char.IsDigit).ToArray());
            int.TryParse(ghDigits, out int limitPerOrder);
            if (limitPerOrder <= 0) limitPerOrder = 1;

            string newStatus = "Đang hiệu lực";
            if (!toggleKichHoat.Checked)
            {
                newStatus = "Tạm dừng";
            }
            else if (totalUsage > 0 && (_selectedVoucher?.UsedCount ?? 0) >= totalUsage)
            {
                newStatus = "Hết lượt";
            }
            else if (DateTime.Now < dtpStartDate.Value)
            {
                newStatus = "Sắp diễn ra";
            }
            else if (DateTime.Now > dtpEndDate.Value)
            {
                newStatus = "Hết hạn";
            }

            string newScope = cboScope.SelectedIndex switch
            {
                1 => "Tại quán",
                2 => "Mang về",
                _ => "Tất cả"
            };

            if (_isCreatingNew || _selectedVoucher == null)
            {
                var existing = _voucherBLL.GetVoucherByCode(code);
                if (existing != null)
                {
                    MessageHelper.ShowWarning($"Mã voucher '{code}' đã tồn tại trong hệ thống. Vui lòng chọn mã khác!", "Trùng mã");
                    return;
                }

                Voucher newVoucher = new Voucher
                {
                    VoucherCode = code,
                    ProgramName = name,
                    ScheduleText = $"{dtpStartDate.Value:dd/MM} - {dtpEndDate.Value:dd/MM/yyyy}",
                    DiscountType = rdoPercentage.Checked ? "PhanTram" : "TienMat",
                    DiscountValue = discountVal,
                    MaxDiscount = rdoPercentage.Checked ? maxDiscount : 0,
                    MinOrder = minOrder,
                    Scope = newScope,
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    TotalUsage = totalUsage,
                    UsedCount = 0,
                    LimitPerOrder = limitPerOrder,
                    Status = newStatus,
                    IsActive = toggleKichHoat.Checked,
                    Note = txtNote.Text.Trim()
                };

                _voucherBLL.SaveVoucher(newVoucher, out _);
                _selectedVoucher = newVoucher;
                _isCreatingNew = false;

                ApplyFilter();
                UpdateStats();

                MessageHelper.ShowInfo($"Đã tạo mới mã voucher '{newVoucher.VoucherCode}' thành công!", "Tạo voucher thành công");
            }
            else
            {
                _selectedVoucher.ProgramName = name;
                _selectedVoucher.DiscountType = rdoPercentage.Checked ? "PhanTram" : "TienMat";
                _selectedVoucher.DiscountValue = discountVal;
                _selectedVoucher.MaxDiscount = rdoPercentage.Checked ? maxDiscount : 0;
                _selectedVoucher.MinOrder = minOrder;
                _selectedVoucher.Scope = newScope;
                _selectedVoucher.StartDate = dtpStartDate.Value;
                _selectedVoucher.EndDate = dtpEndDate.Value;
                _selectedVoucher.TotalUsage = totalUsage;
                _selectedVoucher.LimitPerOrder = limitPerOrder;
                _selectedVoucher.Status = newStatus;
                _selectedVoucher.IsActive = toggleKichHoat.Checked;
                _selectedVoucher.Note = txtNote.Text.Trim();

                _voucherBLL.SaveVoucher(_selectedVoucher, out _);

                ApplyFilter();
                UpdateStats();

                MessageHelper.ShowInfo($"Đã cập nhật thay đổi cho mã voucher '{_selectedVoucher.VoucherCode}' thành công!", "Lưu thay đổi");
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            if (_selectedVoucher != null)
            {
                DisplayVoucherDetails(_selectedVoucher);
            }
        }

        private void BtnToggleStatus_Click(object? sender, EventArgs e)
        {
            if (_selectedVoucher == null) return;

            string action = _selectedVoucher.IsActive ? "tạm ngưng" : "kích hoạt lại";
            bool confirmed = MessageHelper.Confirm($"Bạn có chắc chắn muốn {action} mã voucher '{_selectedVoucher.VoucherCode}' không?", "Xác nhận");

            if (confirmed)
            {
                _voucherBLL.ToggleVoucherStatus(_selectedVoucher.VoucherCode);

                toggleKichHoat.Checked = _selectedVoucher.IsActive;
                btnToggleStatus.Text = _selectedVoucher.IsActive ? "🚫 Tạm ngưng mã này" : "✔ Kích hoạt lại mã";

                ApplyFilter();
                UpdateStats();

                MessageHelper.ShowInfo($"Mã voucher '{_selectedVoucher.VoucherCode}' đã được chuyển sang trạng thái: {_selectedVoucher.Status}.", "Thông báo");
            }
        }

        private void BtnAddVoucher_Click(object? sender, EventArgs e)
        {
            _isCreatingNew = true;
            _selectedVoucher = null;

            lblDetailTitle.Text = "🏷 Tạo Voucher mới";
            toggleKichHoat.Checked = true;

            string newCode = MockDataService.Instance.SinhMaVoucherTuDong();
            txtVoucherCode.Text = newCode;
            txtVoucherCode.ReadOnly = false;
            txtProgramName.Text = "Khuyến mãi mới - Mộc Café";

            rdoPercentage.Checked = true;
            txtDiscountValue.Text = "10";
            txtMaxDiscount.Text = "20,000";
            txtMinOrder.Text = "50,000";
            cboScope.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(30);

            txtTotalUsage.Text = "100";
            txtUsagePerOrder.Text = "1 lượt / hóa đơn";
            lblDaDung.Text = "● Đã dùng: 0";
            lblConLai.Text = "● Còn lại: 100";
            lblConLai.ForeColor = ColorTranslator.FromHtml("#16793F");
            lblConLai.BackColor = ColorTranslator.FromHtml("#E4F6EB");
            txtNote.Text = "Áp dụng cho hóa đơn đạt giá trị tối thiểu.";

            txtVoucherCode.Focus();
        }

        private void BtnExportExcel_Click(object? sender, EventArgs e)
        {
            MessageHelper.ShowInfo($"Đã xuất danh sách {_displayedVouchers.Count} mã Voucher khuyến mãi ra file Excel thành công!", "Xuất dữ liệu");
        }

        private void BtnHistory_Click(object? sender, EventArgs e)
        {
            MessageHelper.ShowInfo("Lịch sử áp dụng: Tổng cộng 215 lượt đơn hàng đã áp dụng voucher trong tháng này, tổng tiền chiết khấu: 4.820.000 đ.", "Lịch sử áp dụng");
        }
        #endregion
    }
}
