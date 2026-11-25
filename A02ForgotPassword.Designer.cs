namespace DoAnLapTrinhTrucQuan
{
    partial class A02ForgotPassword
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
            pnlMain = new Panel();
            stepOne = new Panel();
            lblFPTitle = new Label();
            lblFPSubtitle = new Label();
            lblFPUsernameLabel = new Label();
            pnlFPUsername = new Panel();
            txtFPUsername = new TextBox();
            lblFPContactLabel = new Label();
            pnlFPContact = new Panel();
            txtFPContact = new TextBox();
            btnCancel = new Button();
            btnSendOTP = new Button();
            stepTwo = new Panel();
            lblRPTitle = new Label();
            lblRPSubtitle = new Label();
            lblNewPwdLabel = new Label();
            pnlNewPwd = new Panel();
            txtNewPassword = new TextBox();
            btnToggleNewPwd = new Button();
            lblConfirmPwdLabel = new Label();
            pnlConfirmPwd = new Panel();
            txtConfirmPassword = new TextBox();
            btnToggleConfirmPwd = new Button();
            btnBack = new Button();
            btnChangePassword = new Button();
            pnlMain.SuspendLayout();
            stepOne.SuspendLayout();
            pnlFPUsername.SuspendLayout();
            pnlFPContact.SuspendLayout();
            stepTwo.SuspendLayout();
            pnlNewPwd.SuspendLayout();
            pnlConfirmPwd.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(stepOne);
            pnlMain.Controls.Add(stepTwo);
            pnlMain.Location = new Point(37, 119);
            pnlMain.Margin = new Padding(6, 6, 6, 6);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(817, 725);
            pnlMain.TabIndex = 0;
            // 
            // stepOne
            // 
            stepOne.BackColor = Color.White;
            stepOne.Controls.Add(lblFPTitle);
            stepOne.Controls.Add(lblFPSubtitle);
            stepOne.Controls.Add(lblFPUsernameLabel);
            stepOne.Controls.Add(pnlFPUsername);
            stepOne.Controls.Add(lblFPContactLabel);
            stepOne.Controls.Add(pnlFPContact);
            stepOne.Controls.Add(btnCancel);
            stepOne.Controls.Add(btnSendOTP);
            stepOne.Dock = DockStyle.Fill;
            stepOne.Location = new Point(0, 0);
            stepOne.Margin = new Padding(6, 6, 6, 6);
            stepOne.Name = "stepOne";
            stepOne.Size = new Size(817, 725);
            stepOne.TabIndex = 0;
            // 
            // lblFPTitle
            // 
            lblFPTitle.AutoSize = true;
            lblFPTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblFPTitle.ForeColor = Color.FromArgb(86, 57, 39);
            lblFPTitle.Location = new Point(202, 43);
            lblFPTitle.Margin = new Padding(6, 0, 6, 0);
            lblFPTitle.Name = "lblFPTitle";
            lblFPTitle.Size = new Size(420, 72);
            lblFPTitle.TabIndex = 0;
            lblFPTitle.Text = "Quên mật khẩu";
            // 
            // lblFPSubtitle
            // 
            lblFPSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFPSubtitle.ForeColor = Color.Gray;
            lblFPSubtitle.Location = new Point(45, 126);
            lblFPSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblFPSubtitle.Name = "lblFPSubtitle";
            lblFPSubtitle.Size = new Size(728, 85);
            lblFPSubtitle.TabIndex = 1;
            lblFPSubtitle.Text = "Nhập tên đăng nhập và số điện thoại hoặc email đã đăng ký để nhận mã OTP.";
            // 
            // lblFPUsernameLabel
            // 
            lblFPUsernameLabel.AutoSize = true;
            lblFPUsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFPUsernameLabel.Location = new Point(45, 239);
            lblFPUsernameLabel.Margin = new Padding(6, 0, 6, 0);
            lblFPUsernameLabel.Name = "lblFPUsernameLabel";
            lblFPUsernameLabel.Size = new Size(183, 32);
            lblFPUsernameLabel.TabIndex = 2;
            lblFPUsernameLabel.Text = "Tên đăng nhập";
            // 
            // pnlFPUsername
            // 
            pnlFPUsername.BackColor = Color.White;
            pnlFPUsername.BorderStyle = BorderStyle.FixedSingle;
            pnlFPUsername.Controls.Add(txtFPUsername);
            pnlFPUsername.Location = new Point(45, 292);
            pnlFPUsername.Margin = new Padding(6, 6, 6, 6);
            pnlFPUsername.Name = "pnlFPUsername";
            pnlFPUsername.Size = new Size(726, 79);
            pnlFPUsername.TabIndex = 1;
            // 
            // txtFPUsername
            // 
            txtFPUsername.BorderStyle = BorderStyle.None;
            txtFPUsername.Font = new Font("Segoe UI", 10F);
            txtFPUsername.Location = new Point(19, 17);
            txtFPUsername.Margin = new Padding(6, 6, 6, 6);
            txtFPUsername.Name = "txtFPUsername";
            txtFPUsername.PlaceholderText = "Nhập tên đăng nhập";
            txtFPUsername.Size = new Size(687, 36);
            txtFPUsername.TabIndex = 0;
            // 
            // lblFPContactLabel
            // 
            lblFPContactLabel.AutoSize = true;
            lblFPContactLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFPContactLabel.Location = new Point(45, 410);
            lblFPContactLabel.Margin = new Padding(6, 0, 6, 0);
            lblFPContactLabel.Name = "lblFPContactLabel";
            lblFPContactLabel.Size = new Size(294, 32);
            lblFPContactLabel.TabIndex = 3;
            lblFPContactLabel.Text = "Số điện thoại hoặc email";
            // 
            // pnlFPContact
            // 
            pnlFPContact.BackColor = Color.White;
            pnlFPContact.BorderStyle = BorderStyle.FixedSingle;
            pnlFPContact.Controls.Add(txtFPContact);
            pnlFPContact.Location = new Point(45, 459);
            pnlFPContact.Margin = new Padding(6, 6, 6, 6);
            pnlFPContact.Name = "pnlFPContact";
            pnlFPContact.Size = new Size(726, 79);
            pnlFPContact.TabIndex = 2;
            // 
            // txtFPContact
            // 
            txtFPContact.BorderStyle = BorderStyle.None;
            txtFPContact.Font = new Font("Segoe UI", 10F);
            txtFPContact.Location = new Point(19, 17);
            txtFPContact.Margin = new Padding(6, 6, 6, 6);
            txtFPContact.Name = "txtFPContact";
            txtFPContact.PlaceholderText = "0912 345 678 hoặc email@moccafe.vn";
            txtFPContact.Size = new Size(687, 36);
            txtFPContact.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 235, 230);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(86, 57, 39);
            btnCancel.Location = new Point(45, 585);
            btnCancel.Margin = new Padding(6, 6, 6, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(189, 85);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "× Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSendOTP
            // 
            btnSendOTP.BackColor = Color.FromArgb(86, 57, 39);
            btnSendOTP.FlatAppearance.BorderSize = 0;
            btnSendOTP.FlatStyle = FlatStyle.Flat;
            btnSendOTP.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSendOTP.ForeColor = Color.White;
            btnSendOTP.Location = new Point(517, 585);
            btnSendOTP.Margin = new Padding(6, 6, 6, 6);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new Size(255, 85);
            btnSendOTP.TabIndex = 4;
            btnSendOTP.Text = "Gửi mã OTP →";
            btnSendOTP.UseVisualStyleBackColor = false;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // stepTwo
            // 
            stepTwo.BackColor = Color.White;
            stepTwo.Controls.Add(lblRPTitle);
            stepTwo.Controls.Add(lblRPSubtitle);
            stepTwo.Controls.Add(lblNewPwdLabel);
            stepTwo.Controls.Add(pnlNewPwd);
            stepTwo.Controls.Add(lblConfirmPwdLabel);
            stepTwo.Controls.Add(pnlConfirmPwd);
            stepTwo.Controls.Add(btnBack);
            stepTwo.Controls.Add(btnChangePassword);
            stepTwo.Dock = DockStyle.Fill;
            stepTwo.Location = new Point(0, 0);
            stepTwo.Margin = new Padding(6, 6, 6, 6);
            stepTwo.Name = "stepTwo";
            stepTwo.Size = new Size(817, 725);
            stepTwo.TabIndex = 1;
            stepTwo.Visible = false;
            // 
            // lblRPTitle
            // 
            lblRPTitle.AutoSize = true;
            lblRPTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblRPTitle.ForeColor = Color.FromArgb(86, 57, 39);
            lblRPTitle.Location = new Point(45, 43);
            lblRPTitle.Margin = new Padding(6, 0, 6, 0);
            lblRPTitle.Name = "lblRPTitle";
            lblRPTitle.Size = new Size(448, 72);
            lblRPTitle.TabIndex = 0;
            lblRPTitle.Text = "Đặt lại mật khẩu";
            // 
            // lblRPSubtitle
            // 
            lblRPSubtitle.Font = new Font("Segoe UI", 9F);
            lblRPSubtitle.ForeColor = Color.Gray;
            lblRPSubtitle.Location = new Point(45, 126);
            lblRPSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblRPSubtitle.Name = "lblRPSubtitle";
            lblRPSubtitle.Size = new Size(728, 85);
            lblRPSubtitle.TabIndex = 1;
            lblRPSubtitle.Text = "Tạo mật khẩu mới cho tài khoản.\nTối thiểu 8 ký tự, gồm chữ hoa và số.";
            // 
            // lblNewPwdLabel
            // 
            lblNewPwdLabel.AutoSize = true;
            lblNewPwdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNewPwdLabel.Location = new Point(45, 239);
            lblNewPwdLabel.Margin = new Padding(6, 0, 6, 0);
            lblNewPwdLabel.Name = "lblNewPwdLabel";
            lblNewPwdLabel.Size = new Size(172, 32);
            lblNewPwdLabel.TabIndex = 2;
            lblNewPwdLabel.Text = "Mật khẩu mới";
            // 
            // pnlNewPwd
            // 
            pnlNewPwd.BackColor = Color.White;
            pnlNewPwd.BorderStyle = BorderStyle.FixedSingle;
            pnlNewPwd.Controls.Add(txtNewPassword);
            pnlNewPwd.Controls.Add(btnToggleNewPwd);
            pnlNewPwd.Location = new Point(45, 292);
            pnlNewPwd.Margin = new Padding(6, 6, 6, 6);
            pnlNewPwd.Name = "pnlNewPwd";
            pnlNewPwd.Size = new Size(726, 79);
            pnlNewPwd.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.Location = new Point(19, 17);
            txtNewPassword.Margin = new Padding(6, 6, 6, 6);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.Size = new Size(622, 36);
            txtNewPassword.TabIndex = 0;
            // 
            // btnToggleNewPwd
            // 
            btnToggleNewPwd.BackColor = Color.White;
            btnToggleNewPwd.FlatAppearance.BorderSize = 0;
            btnToggleNewPwd.FlatStyle = FlatStyle.Flat;
            btnToggleNewPwd.Location = new Point(659, 13);
            btnToggleNewPwd.Margin = new Padding(6, 6, 6, 6);
            btnToggleNewPwd.Name = "btnToggleNewPwd";
            btnToggleNewPwd.Size = new Size(46, 53);
            btnToggleNewPwd.TabIndex = 1;
            btnToggleNewPwd.Text = "👁";
            btnToggleNewPwd.UseVisualStyleBackColor = false;
            btnToggleNewPwd.Click += btnToggleNewPwd_Click;
            // 
            // lblConfirmPwdLabel
            // 
            lblConfirmPwdLabel.AutoSize = true;
            lblConfirmPwdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmPwdLabel.Location = new Point(45, 410);
            lblConfirmPwdLabel.Margin = new Padding(6, 0, 6, 0);
            lblConfirmPwdLabel.Name = "lblConfirmPwdLabel";
            lblConfirmPwdLabel.Size = new Size(283, 32);
            lblConfirmPwdLabel.TabIndex = 3;
            lblConfirmPwdLabel.Text = "Xác nhận mật khẩu mới";
            // 
            // pnlConfirmPwd
            // 
            pnlConfirmPwd.BackColor = Color.White;
            pnlConfirmPwd.BorderStyle = BorderStyle.FixedSingle;
            pnlConfirmPwd.Controls.Add(txtConfirmPassword);
            pnlConfirmPwd.Controls.Add(btnToggleConfirmPwd);
            pnlConfirmPwd.Location = new Point(45, 459);
            pnlConfirmPwd.Margin = new Padding(6, 6, 6, 6);
            pnlConfirmPwd.Name = "pnlConfirmPwd";
            pnlConfirmPwd.Size = new Size(726, 79);
            pnlConfirmPwd.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(19, 17);
            txtConfirmPassword.Margin = new Padding(6, 6, 6, 6);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(622, 36);
            txtConfirmPassword.TabIndex = 0;
            // 
            // btnToggleConfirmPwd
            // 
            btnToggleConfirmPwd.BackColor = Color.White;
            btnToggleConfirmPwd.FlatAppearance.BorderSize = 0;
            btnToggleConfirmPwd.FlatStyle = FlatStyle.Flat;
            btnToggleConfirmPwd.Location = new Point(659, 13);
            btnToggleConfirmPwd.Margin = new Padding(6, 6, 6, 6);
            btnToggleConfirmPwd.Name = "btnToggleConfirmPwd";
            btnToggleConfirmPwd.Size = new Size(46, 53);
            btnToggleConfirmPwd.TabIndex = 1;
            btnToggleConfirmPwd.Text = "👁";
            btnToggleConfirmPwd.UseVisualStyleBackColor = false;
            btnToggleConfirmPwd.Click += btnToggleConfirmPwd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 235, 230);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.FromArgb(86, 57, 39);
            btnBack.Location = new Point(45, 585);
            btnBack.Margin = new Padding(6, 6, 6, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 85);
            btnBack.TabIndex = 3;
            btnBack.Text = "← Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(86, 57, 39);
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(527, 585);
            btnChangePassword.Margin = new Padding(6, 6, 6, 6);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(245, 85);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Đổi mật khẩu ✓";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // A02ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 210, 200);
            ClientSize = new Size(891, 964);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "A02ForgotPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quên mật khẩu";
            pnlMain.ResumeLayout(false);
            stepOne.ResumeLayout(false);
            stepOne.PerformLayout();
            pnlFPUsername.ResumeLayout(false);
            pnlFPUsername.PerformLayout();
            pnlFPContact.ResumeLayout(false);
            pnlFPContact.PerformLayout();
            stepTwo.ResumeLayout(false);
            stepTwo.PerformLayout();
            pnlNewPwd.ResumeLayout(false);
            pnlNewPwd.PerformLayout();
            pnlConfirmPwd.ResumeLayout(false);
            pnlConfirmPwd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Field declarations
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel stepOne;
        private System.Windows.Forms.Label lblFPTitle;
        private System.Windows.Forms.Label lblFPSubtitle;
        private System.Windows.Forms.Label lblFPUsernameLabel;
        private System.Windows.Forms.Panel pnlFPUsername;
        private System.Windows.Forms.TextBox txtFPUsername;
        private System.Windows.Forms.Label lblFPContactLabel;
        private System.Windows.Forms.Panel pnlFPContact;
        private System.Windows.Forms.TextBox txtFPContact;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSendOTP;
        private System.Windows.Forms.Panel stepTwo;
        private System.Windows.Forms.Label lblRPTitle;
        private System.Windows.Forms.Label lblRPSubtitle;
        private System.Windows.Forms.Label lblNewPwdLabel;
        private System.Windows.Forms.Panel pnlNewPwd;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnToggleNewPwd;
        private System.Windows.Forms.Label lblConfirmPwdLabel;
        private System.Windows.Forms.Panel pnlConfirmPwd;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnToggleConfirmPwd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
