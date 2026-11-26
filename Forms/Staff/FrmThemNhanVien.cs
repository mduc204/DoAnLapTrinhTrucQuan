using System.Drawing.Drawing2D;
using System.Globalization;
using System.Net.Mail;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class FrmThemNhanVien : Form
    {
        public NewEmployeeData? EmployeeData { get; private set; }

        public FrmThemNhanVien()
            : this("NV015")
        {
        }

        public FrmThemNhanVien(string employeeCode)
        {
            InitializeComponent();
            ApplyRoundedRegions();
            tbManv.Text = employeeCode;
            dateTimePicker1.Value = DateTime.Today;

            button1.Click += (_, _) => SaveEmployee();
            btnHuy.Click += (_, _) => CancelEmployee();
            btnDong.Click += (_, _) => CancelEmployee();
            AcceptButton = button1;
            CancelButton = btnHuy;
        }

        private void SaveEmployee()
        {
            var name = tbHoten.Text.Trim();
            var phone = tbSDT.Text.Trim();
            var email = textBox1.Text.Trim();
            var role = cbVaitro.SelectedItem?.ToString() ?? string.Empty;
            var username = tbTendangnhap.Text.Trim();
            var password = tbMatkhau.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone)
                || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc.", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMatkhau.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(email) && !MailAddress.TryCreate(email, out _))
            {
                MessageBox.Show("Email công việc chưa đúng định dạng.", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            EmployeeData = new NewEmployeeData(
                tbManv.Text,
                name,
                phone,
                dateTimePicker1.Value.Date,
                email,
                role,
                username,
                password);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelEmployee()
        {
            EmployeeData = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ApplyRoundedRegions()
        {
            SetRoundedRegion(this, 12);
            foreach (var control in new Control[] { btnDong, button1, btnHuy, cbVaitro })
                SetRoundedRegion(control, 8);
        }

        private static void SetRoundedRegion(Control control, int radius)
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
    }

    public sealed record NewEmployeeData(
        string Code,
        string Name,
        string Phone,
        DateTime HireDate,
        string Email,
        string Role,
        string Username,
        string Password);
}
