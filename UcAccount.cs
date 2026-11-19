using System.Text.RegularExpressions;

namespace DoAnLapTrinhTrucQuan
{
    public partial class UcAccount : UserControl
    {
        private string accountEmail = "admin@lttqcafe.vn";
        private string accountPassword = "Cafe@123";
        private string fullName = "Trần Văn An";
        private string phone = "090 123 4567";

        public string DisplayName => fullName;

        public event Action<string>? LoginSucceeded;
        public event Action<string, string>? ProfileUpdated;

        public UcAccount()
        {
            InitializeComponent();
            txtLoginEmail.Text = accountEmail;
            txtLoginPassword.Text = accountPassword;
            txtProfileName.Text = fullName;
            txtProfileEmail.Text = accountEmail;
            txtProfilePhone.Text = phone;
            brandPanel.Resize += (_, _) => LayoutBrandPanel();
            workspace.Resize += (_, _) => CenterCard();
            LayoutBrandPanel();
            CenterCard();
            ShowLogin();
        }

        public void ShowLogin()
        {
            txtLoginEmail.Text = accountEmail;
            txtLoginPassword.Clear();
            ShowPage(pageLogin);
        }

        public void ShowProfile()
        {
            txtProfileName.Text = fullName;
            txtProfileEmail.Text = accountEmail;
            txtProfilePhone.Text = phone;
            ShowPage(pageProfile);
        }

        private void LayoutBrandPanel()
        {
            int inset = Math.Min(56, Math.Max(24, (brandPanel.ClientSize.Width - 340) / 2));
            int textWidth = Math.Max(280, brandPanel.ClientSize.Width - inset * 2);
            picBrandLogo.Location = new Point(inset, 48);
            lblBrandName.Location = new Point(inset, 138);
            lblBrandTitle.Location = new Point(inset, 190);
            lblBrandTitle.Width = textWidth;
            lblBrandDescription.Location = new Point(inset, 320);
            lblBrandDescription.Width = textWidth;
            lblBrandFeatures.Location = new Point(inset, 410);
            lblBrandFeatures.Width = textWidth;
        }

        private void CenterCard()
        {
            card.Left = Math.Max(12, (workspace.ClientSize.Width - card.Width) / 2);
            card.Top = Math.Max(0, (workspace.ClientSize.Height - card.Height) / 2);
        }

        private void ShowPage(Panel page)
        {
            pageLogin.Visible = false;
            pageProfile.Visible = false;
            pageForgotPassword.Visible = false;
            pageOtp.Visible = false;
            pageResetPassword.Visible = false;
            page.Visible = true;
            page.BringToFront();
            CenterCard();
        }

        private void BackToLoginButton_Click(object? sender, EventArgs e)
        {
            ShowLogin();
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            if (!IsValidEmail(email))
            {
                ShowMessage(lblLoginMessage, "Vui lòng nhập địa chỉ email hợp lệ.");
                return;
            }
            if (!string.Equals(email, accountEmail, StringComparison.OrdinalIgnoreCase) || txtLoginPassword.Text != accountPassword)
            {
                ShowMessage(lblLoginMessage, "Email hoặc mật khẩu chưa chính xác.");
                return;
            }
            LoginSucceeded?.Invoke(email);
        }

        private void ForgotPasswordButton_Click(object? sender, EventArgs e)
        {
            txtForgotEmail.Text = accountEmail;
            ShowMessage(lblForgotMessage, string.Empty, isError: false);
            ShowPage(pageForgotPassword);
        }

        private void SendOtpButton_Click(object? sender, EventArgs e)
        {
            string email = txtForgotEmail.Text.Trim();
            if (!IsValidEmail(email))
            {
                ShowMessage(lblForgotMessage, "Vui lòng nhập địa chỉ email hợp lệ.");
                return;
            }
            if (!string.Equals(email, accountEmail, StringComparison.OrdinalIgnoreCase))
            {
                ShowMessage(lblForgotMessage, "Email không khớp với tài khoản demo.");
                return;
            }
            lblOtpEmail.Text = $"Mã xác thực đã được gửi đến {email}";
            txtOtpCode.Clear();
            ShowPage(pageOtp);
        }

        private void VerifyOtpButton_Click(object? sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtOtpCode.Text.Trim(), "^[0-9]{6}$"))
            {
                ShowMessage(lblOtpMessage, "Mã OTP cần gồm đúng 6 chữ số.");
                return;
            }
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            ShowPage(pageResetPassword);
        }

        private void ResetPasswordButton_Click(object? sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            if (newPassword.Length < 8)
            {
                ShowMessage(lblResetMessage, "Mật khẩu cần có ít nhất 8 ký tự.");
                return;
            }
            if (newPassword != txtConfirmPassword.Text)
            {
                ShowMessage(lblResetMessage, "Mật khẩu xác nhận chưa trùng khớp.");
                return;
            }
            accountPassword = newPassword;
            ShowPage(pageLogin);
            txtLoginEmail.Text = accountEmail;
            txtLoginPassword.Clear();
            ShowMessage(lblLoginMessage, "Mật khẩu đã được cập nhật. Vui lòng đăng nhập lại.", isError: false);
        }

        private void SaveProfileButton_Click(object? sender, EventArgs e)
        {
            string name = txtProfileName.Text.Trim();
            string email = txtProfileEmail.Text.Trim();
            string newPhone = txtProfilePhone.Text.Trim();
            if (name.Length < 2)
            {
                ShowMessage(lblProfileMessage, "Vui lòng nhập họ và tên hợp lệ.");
                return;
            }
            if (!IsValidEmail(email))
            {
                ShowMessage(lblProfileMessage, "Vui lòng nhập địa chỉ email hợp lệ.");
                return;
            }
            fullName = name;
            accountEmail = email;
            phone = newPhone;
            ProfileUpdated?.Invoke(fullName, accountEmail);
            ShowProfile();
            ShowMessage(lblProfileMessage, "Thông tin cá nhân đã được cập nhật.", isError: false);
        }

        private void ChangePasswordButton_Click(object? sender, EventArgs e)
        {
            lblOtpEmail.Text = $"Mã xác thực đã được gửi đến {accountEmail}";
            txtOtpCode.Clear();
            ShowMessage(lblOtpMessage, string.Empty, isError: false);
            ShowPage(pageOtp);
        }

        private void ShowMessage(Label label, string text, bool isError = true)
        {
            label.Text = text;
            label.ForeColor = isError ? Color.Firebrick : Color.FromArgb(46, 125, 50);
        }

        private static bool IsValidEmail(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}
