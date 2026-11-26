using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class ucEmployee : UserControl
    {
        private DataGridViewRow? selectedEmployeeRow;

        public ucEmployee()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            dgvNhanvien.CellPainting += dgvNhanvien_CellPainting;

            dgvNhanvien.Rows.Add("NV001", "Nguyễn Văn Hưng", "0908 123 456", "Quản lý", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV002", "Lê Mỹ Hạnh", "0912 345 678", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV003", "Trần Đình Nam", "0988 567 890", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV004", "Ngô Thùy Linh", "0934 998 112", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV005", "Võ Minh Trí", "0977 441 230", "Nhân viên", "Tạm khóa");
            dgvNhanvien.Rows.Add("NV006", "Hoàng Bách", "0903 881 772", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV007", "Đỗ Quỳnh Nga", "0918 776 554", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV014", "Phan Tuấn Anh", "0966 223 901", "Nhân viên", "Đã nghỉ việc");

            cbTrangthai.Items.Insert(0, "Tất cả");
            cbVaitro.SelectedIndex = 0;
            cbTrangthai.SelectedIndex = 0;
            cbVaitro.SelectedIndexChanged += (_, _) => ApplyFilters();
            cbTrangthai.SelectedIndexChanged += (_, _) => ApplyFilters();
            dgvNhanvien.SelectionChanged += (_, _) => LoadSelectedEmployee();
            btnLuu.Click += (_, _) => SaveSelectedEmployee();
            btnKhoa.Click += (_, _) => LockSelectedEmployee();
            btnHuy.Click += (_, _) => CancelEmployeeEdit();
            pnlTrong.Visible = false;
            dgvNhanvien.Rows[0].Selected = true;
            LoadSelectedEmployee();
        }

        private void LoadSelectedEmployee()
        {
            if (dgvNhanvien.SelectedRows.Count == 0)
                return;

            var row = dgvNhanvien.SelectedRows[0];
            selectedEmployeeRow = row;
            tbManhanvien.Text = row.Cells[MaNV.Index].Value?.ToString() ?? string.Empty;
            tbHoten.Text = row.Cells[HoTen.Index].Value?.ToString() ?? string.Empty;
            textBox2.Text = row.Cells[SDT.Index].Value?.ToString() ?? string.Empty;
            var role = row.Cells[VaiTro.Index].Value?.ToString();
            tbVaitro.SelectedItem = role is "Nhân viên" or "Quản lý" ? role : null;
            lbManvmain.Text = tbManhanvien.Text;
            LbTennvmain.Text = tbHoten.Text;

            var employeeData = row.Tag as NewEmployeeData;
            dateTimePicker1.Value = ParseHireDate(employeeData?.HireDate ?? row.Tag) ?? DateTime.Today;
            tbEmail.Text = employeeData?.Email ?? string.Empty;
            tbUsername.Text = employeeData?.Username ?? string.Empty;

            pnlTrong.Visible = false;
            pnlChinhsua.Visible = true;
            pnlChinhsua.BringToFront();
            btnKhoa.Enabled = row.Cells[TrangThai.Index].Value?.ToString() != "Tạm khóa";
        }

        private void SaveSelectedEmployee()
        {
            if (selectedEmployeeRow is null)
                return;

            var name = tbHoten.Text.Trim();
            var phone = textBox2.Text.Trim();
            var role = tbVaitro.SelectedItem?.ToString() ?? string.Empty;
            DateTime? hireDate = dateTimePicker1.Value.Date;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone)
                || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Vui lòng nhập họ tên, số điện thoại và chọn vai trò.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedEmployeeRow.Cells[HoTen.Index].Value = name;
            selectedEmployeeRow.Cells[SDT.Index].Value = phone;
            selectedEmployeeRow.Cells[VaiTro.Index].Value = role;
            selectedEmployeeRow.Tag = selectedEmployeeRow.Tag is NewEmployeeData employeeData
                ? employeeData with { Name = name, Phone = phone, HireDate = hireDate ?? employeeData.HireDate, Role = role }
                : hireDate;
            dateTimePicker1.Value = hireDate ?? DateTime.Today;
            lbManvmain.Text = tbManhanvien.Text;
            LbTennvmain.Text = name;

            var savedRow = selectedEmployeeRow;
            ApplyFilters();
            if (savedRow.Visible)
                savedRow.Selected = true;
            MessageBox.Show("Đã lưu thay đổi thông tin nhân viên.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static DateTime? ParseHireDate(object? value)
        {
            if (value is NewEmployeeData employeeData)
                value = employeeData.HireDate;

            if (value is DateTime date)
                return date;

            return TryParseHireDate(value?.ToString(), out var parsedDate) ? parsedDate : null;
        }

        private static bool TryParseHireDate(string? value, out DateTime date)
        {
            return DateTime.TryParseExact(value?.Trim(), ["dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd"],
                CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }

        private void LockSelectedEmployee()
        {
            if (selectedEmployeeRow is null)
                return;

            selectedEmployeeRow.Cells[TrangThai.Index].Value = "Tạm khóa";
            var lockedRow = selectedEmployeeRow;
            ApplyFilters();
            if (lockedRow.Visible)
                lockedRow.Selected = true;
        }

        private void CancelEmployeeEdit()
        {
            selectedEmployeeRow = null;
            dgvNhanvien.ClearSelection();
            dgvNhanvien.CurrentCell = null;
            pnlChinhsua.Visible = false;
            pnlTrong.Visible = true;
            pnlTrong.BringToFront();
        }

        private void ApplyFilters()
        {
            var selectedRole = cbVaitro.SelectedItem?.ToString() ?? "Tất cả";
            var selectedStatus = cbTrangthai.SelectedItem?.ToString() ?? "Tất cả";

            dgvNhanvien.ClearSelection();
            dgvNhanvien.CurrentCell = null;

            foreach (DataGridViewRow row in dgvNhanvien.Rows)
            {
                var role = row.Cells[VaiTro.Index].Value?.ToString();
                var status = row.Cells[TrangThai.Index].Value?.ToString();
                var roleMatches = selectedRole == "Tất cả"
                    || (selectedRole == "Quản lý" && role is "Quản lý" or "Admin")
                    || selectedRole == role;
                var statusMatches = selectedStatus == "Tất cả" || selectedStatus == status;
                row.Visible = roleMatches && statusMatches;
            }
        }

        private void dgvNhanvien_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != VaiTro.Index && e.ColumnIndex != TrangThai.Index))
                return;

            var value = e.FormattedValue?.ToString() ?? string.Empty;
            var isRole = e.ColumnIndex == VaiTro.Index;
            var background = isRole
                ? value is "Quản lý" or "Admin" ? Color.FromArgb(62, 39, 35) : Color.FromArgb(255, 220, 196)
                : value == "Đang làm việc" ? Color.FromArgb(151, 244, 148)
                : value == "Tạm khóa" ? Color.FromArgb(255, 205, 205)
                : Color.FromArgb(235, 229, 226);
            var foreground = isRole && value is "Quản lý" or "Admin" ? Color.White
                : value == "Tạm khóa" ? Color.FromArgb(155, 25, 25)
                : Color.FromArgb(44, 22, 14);

            e.PaintBackground(e.CellBounds, true);

            using var font = new Font("Segoe UI", 10, FontStyle.Bold);
            var textSize = TextRenderer.MeasureText(value, font, Size.Empty, TextFormatFlags.NoPadding);
            var dotSpace = !isRole ? 14 : 0;
            var pillWidth = Math.Min(e.CellBounds.Width - 16, textSize.Width + dotSpace + 18);
            var pillHeight = Math.Min(28, e.CellBounds.Height - 12);
            var pillBounds = new Rectangle(
                e.CellBounds.Left + 8,
                e.CellBounds.Top + (e.CellBounds.Height - pillHeight) / 2,
                pillWidth,
                pillHeight);

            using var pillPath = CreateRoundedPath(pillBounds, pillHeight / 2);
            using var backgroundBrush = new SolidBrush(background);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(backgroundBrush, pillPath);

            var textX = pillBounds.Left + 9;
            if (!isRole)
            {
                var dotColor = value == "Đang làm việc" ? Color.FromArgb(0, 100, 25)
                    : value == "Tạm khóa" ? Color.FromArgb(155, 25, 25)
                    : Color.FromArgb(128, 77, 33);
                using var dotBrush = new SolidBrush(dotColor);
                var dotSize = 7;
                e.Graphics.FillEllipse(dotBrush, pillBounds.Left + 9, pillBounds.Top + (pillBounds.Height - dotSize) / 2, dotSize, dotSize);
                textX = pillBounds.Left + 21;
            }

            var textBounds = new Rectangle(textX, pillBounds.Top, pillBounds.Right - textX - 6, pillBounds.Height);
            TextRenderer.DrawText(e.Graphics, value, font, textBounds,
                foreground, TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            e.Handled = true;
        }

        private static GraphicsPath CreateRoundedPath(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            var diameter = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height));
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void ApplyRoundedCorners()
        {
            SetRoundedCorners(pnlDanhsachnhanvien, 14);
            SetRoundedCorners(pnlChinhsua, 14);
            SetRoundedCorners(pnlHeaderchinhsua, 12);
            SetRoundedCorners(pnlTongnhanvien, 12);
            SetRoundedCorners(pnlDanglamviec, 12);

            foreach (var button in new[] { btnThemnhanvien, btnXuatexcelnhanvien, btnDatlaimatkhau, btnLuu, btnKhoa, btnHuy })
            {
                SetRoundedCorners(button, 8);
            }
        }

        private static void SetRoundedCorners(Control control, int radius)
        {
            void UpdateRegion(object? sender, EventArgs e)
            {
                if (control.Width <= 0 || control.Height <= 0)
                    return;

                var diameter = Math.Min(radius * 2, Math.Min(control.Width, control.Height));
                using var path = new GraphicsPath();
                path.AddArc(0, 0, diameter, diameter, 180, 90);
                path.AddArc(control.Width - diameter, 0, diameter, diameter, 270, 90);
                path.AddArc(control.Width - diameter, control.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(0, control.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                var oldRegion = control.Region;
                control.Region = new Region(path);
                oldRegion?.Dispose();
            }

            control.Resize += UpdateRegion;
            UpdateRegion(control, EventArgs.Empty);
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            using (var frm = new dlgAddEmployee(GenerateNextEmployeeCode()))
            {
                if (frm.ShowDialog(this.FindForm()) != DialogResult.OK || frm.EmployeeData is not { } employee)
                    return;

                var rowIndex = dgvNhanvien.Rows.Add(employee.Code, employee.Name, employee.Phone, employee.Role, "Đang làm việc");
                dgvNhanvien.Rows[rowIndex].Tag = employee with { Password = string.Empty };
                cbVaitro.SelectedIndex = 0;
                cbTrangthai.SelectedIndex = 0;
                ApplyFilters();

                var newRow = dgvNhanvien.Rows[rowIndex];
                newRow.Selected = true;
                dgvNhanvien.CurrentCell = newRow.Cells[MaNV.Index];
            }
        }

        private string GenerateNextEmployeeCode()
        {
            var maxNumber = 0;
            foreach (DataGridViewRow row in dgvNhanvien.Rows)
            {
                var code = row.Cells[MaNV.Index].Value?.ToString();
                if (code is not null && code.StartsWith("NV", StringComparison.OrdinalIgnoreCase)
                    && int.TryParse(code.AsSpan(2), NumberStyles.None, CultureInfo.InvariantCulture, out var number))
                {
                    maxNumber = Math.Max(maxNumber, number);
                }
            }

            return $"NV{maxNumber + 1:000}";
        }
    }
}