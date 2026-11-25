namespace DoAnLapTrinhTrucQuan
{
    partial class A03Personalinfo
    {
        private System.ComponentModel.IContainer components = null;

        // ── Left panel controls ──────────────────────────────────────────
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblJoinDate;

        // ── Right panel controls ─────────────────────────────────────────
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;

        private System.Windows.Forms.Label lblFullNameLabel;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.Label lblUsernameNote;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblShiftLabel;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label lblShiftNote;

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblFullNameLabel = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.lblUsernameNote = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRoleLabel = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblShiftLabel = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.lblShiftNote = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();

            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.picAvatar);
            this.pnlLeft.Controls.Add(this.lblName);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.lblStatus);
            this.pnlLeft.Controls.Add(this.lblEmployeeId);
            this.pnlLeft.Controls.Add(this.lblJoinDate);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 32, 0, 24);
            this.pnlLeft.Size = new System.Drawing.Size(280, 700);
            this.pnlLeft.TabIndex = 0;

            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(224, 213, 202);
            this.picAvatar.Location = new System.Drawing.Point(80, 36);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;

            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.lblName.Location = new System.Drawing.Point(10, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(260, 36);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(100, 80, 60);
            this.lblRole.Location = new System.Drawing.Point(10, 210);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(260, 36);
            this.lblRole.TabIndex = 2;
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(224, 247, 240);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(27, 134, 100);
            this.lblStatus.Location = new System.Drawing.Point(30, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(220, 28);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "● ĐANG HOẠT ĐỘNG · Ca trực";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeId.ForeColor = System.Drawing.Color.FromArgb(100, 90, 80);
            this.lblEmployeeId.Location = new System.Drawing.Point(10, 300);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(260, 24);
            this.lblEmployeeId.TabIndex = 4;
            this.lblEmployeeId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblJoinDate
            // 
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJoinDate.ForeColor = System.Drawing.Color.FromArgb(100, 90, 80);
            this.lblJoinDate.Location = new System.Drawing.Point(10, 328);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(260, 24);
            this.lblJoinDate.TabIndex = 5;
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlRight
            // 
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblPageTitle);
            this.pnlRight.Controls.Add(this.lblPageSubtitle);
            this.pnlRight.Controls.Add(this.lblFullNameLabel);
            this.pnlRight.Controls.Add(this.txtFullName);
            this.pnlRight.Controls.Add(this.lblUsernameLabel);
            this.pnlRight.Controls.Add(this.lblUsernameNote);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblRoleLabel);
            this.pnlRight.Controls.Add(this.txtRole);
            this.pnlRight.Controls.Add(this.lblPhoneLabel);
            this.pnlRight.Controls.Add(this.txtPhone);
            this.pnlRight.Controls.Add(this.lblEmailLabel);
            this.pnlRight.Controls.Add(this.txtEmail);
            this.pnlRight.Controls.Add(this.lblShiftLabel);
            this.pnlRight.Controls.Add(this.txtShift);
            this.pnlRight.Controls.Add(this.lblShiftNote);
            this.pnlRight.Controls.Add(this.btnChangePassword);
            this.pnlRight.Controls.Add(this.btnCancel);
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Controls.Add(this.lblMessage);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(280, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(32, 28, 32, 28);
            this.pnlRight.Size = new System.Drawing.Size(820, 700);
            this.pnlRight.TabIndex = 1;

            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.lblPageTitle.Location = new System.Drawing.Point(32, 28);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(680, 40);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Thông tin cá nhân & Tài khoản người dùng";

            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(110, 95, 80);
            this.lblPageSubtitle.Location = new System.Drawing.Point(32, 74);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(680, 24);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Chỉnh sửa thông tin liên lạc và thiết lập tài khoản của bạn.";

            // 
            // lblFullNameLabel
            // 
            this.lblFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 30);
            this.lblFullNameLabel.Location = new System.Drawing.Point(32, 112);
            this.lblFullNameLabel.Name = "lblFullNameLabel";
            this.lblFullNameLabel.Size = new System.Drawing.Size(310, 22);
            this.lblFullNameLabel.TabIndex = 2;
            this.lblFullNameLabel.Text = "Họ và tên";

            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFullName.Location = new System.Drawing.Point(32, 138);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(310, 36);
            this.txtFullName.TabIndex = 3;

            // 
            // lblUsernameLabel
            // 
            this.lblUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 30);
            this.lblUsernameLabel.Location = new System.Drawing.Point(374, 112);
            this.lblUsernameLabel.Name = "lblUsernameLabel";
            this.lblUsernameLabel.Size = new System.Drawing.Size(310, 22);
            this.lblUsernameLabel.TabIndex = 4;
            this.lblUsernameLabel.Text = "Tên đăng nhập";

            // 
            // lblUsernameNote
            // 
            this.lblUsernameNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUsernameNote.ForeColor = System.Drawing.Color.FromArgb(140, 120, 100);
            this.lblUsernameNote.Location = new System.Drawing.Point(554, 114);
            this.lblUsernameNote.Name = "lblUsernameNote";
            this.lblUsernameNote.Size = new System.Drawing.Size(130, 20);
            this.lblUsernameNote.TabIndex = 5;
            this.lblUsernameNote.Text = "⊘ Không thể sửa";

            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(242, 240, 237);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(120, 100, 80);
            this.txtUsername.Location = new System.Drawing.Point(374, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(310, 36);
            this.txtUsername.TabIndex = 6;

            // 
            // lblRoleLabel
            // 
            this.lblRoleLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRoleLabel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 30);
            this.lblRoleLabel.Location = new System.Drawing.Point(32, 204);
            this.lblRoleLabel.Name = "lblRoleLabel";
            this.lblRoleLabel.Size = new System.Drawing.Size(310, 22);
            this.lblRoleLabel.TabIndex = 7;
            this.lblRoleLabel.Text = "Vai trò";

            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.FromArgb(242, 240, 237);
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtRole.Location = new System.Drawing.Point(32, 230);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(310, 36);
            this.txtRole.TabIndex = 8;

            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 30);
            this.lblPhoneLabel.Location = new System.Drawing.Point(374, 204);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(310, 22);
            this.lblPhoneLabel.TabIndex = 9;
            this.lblPhoneLabel.Text = "Số điện thoại";

            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPhone.Location = new System.Drawing.Point(374, 230);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 36);
            this.txtPhone.TabIndex = 10;

            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 30);
            this.lblEmailLabel.Location = new System.Drawing.Point(32, 296);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(310, 22);
            this.lblEmailLabel.TabIndex = 11;
            this.lblEmailLabel.Text = "Email";

            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(32, 322);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(652, 36);
            this.txtEmail.TabIndex = 12;

            // 
            // lblShiftLabel
            // 
            this.lblShiftLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblShiftLabel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 30);
            this.lblShiftLabel.Location = new System.Drawing.Point(32, 388);
            this.lblShiftLabel.Name = "lblShiftLabel";
            this.lblShiftLabel.Size = new System.Drawing.Size(310, 22);
            this.lblShiftLabel.TabIndex = 13;
            this.lblShiftLabel.Text = "Ca làm việc";

            // 
            // txtShift
            // 
            this.txtShift.BackColor = System.Drawing.Color.FromArgb(242, 240, 237);
            this.txtShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShift.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtShift.Location = new System.Drawing.Point(32, 414);
            this.txtShift.Name = "txtShift";
            this.txtShift.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(652, 36);
            this.txtShift.TabIndex = 14;

            // 
            // lblShiftNote
            // 
            this.lblShiftNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblShiftNote.ForeColor = System.Drawing.Color.FromArgb(120, 100, 80);
            this.lblShiftNote.Location = new System.Drawing.Point(32, 464);
            this.lblShiftNote.Name = "lblShiftNote";
            this.lblShiftNote.Size = new System.Drawing.Size(630, 20);
            this.lblShiftNote.TabIndex = 15;
            this.lblShiftNote.Text = "🗓 Vui lòng liên hệ Quản lý để thay đổi ca làm việc.";

            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 155, 130);
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(85, 55, 34);
            this.btnChangePassword.Location = new System.Drawing.Point(32, 498);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(160, 36);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "⇔ Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 155, 130);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(85, 55, 34);
            this.btnCancel.Location = new System.Drawing.Point(450, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(85, 55, 34);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(544, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "✓ Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMessage.Location = new System.Drawing.Point(32, 546);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(650, 28);
            this.lblMessage.TabIndex = 19;

            // 
            // A03Personalinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 247, 243);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name = "A03Personalinfo";
            this.Size = new System.Drawing.Size(1100, 700);

            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
