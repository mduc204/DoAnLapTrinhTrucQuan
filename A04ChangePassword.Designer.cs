namespace DoAnLapTrinhTrucQuan
{
    partial class A04ChangePassword
    {
        private System.ComponentModel.IContainer components = null;

        // ── Controls ─────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoText;

        // Current password row
        private System.Windows.Forms.Panel pnlRowCurrent;
        private System.Windows.Forms.Label lblCurrentPwd;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Panel pnlCurrentInput;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Button btnEye1;
        private System.Windows.Forms.Label lblErrorCurrent;

        // New password row
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Panel pnlNewInput;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnEye2;
        private System.Windows.Forms.Label lblErrorNew;

        // Confirm row
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.Panel pnlConfirmInput;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnEye3;
        private System.Windows.Forms.Label lblErrorConfirm;
        private System.Windows.Forms.Label lblMatchMessage;

        // Action buttons
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnConfirmChange;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoText = new System.Windows.Forms.Label();
            this.pnlRowCurrent = new System.Windows.Forms.Panel();
            this.lblCurrentPwd = new System.Windows.Forms.Label();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.pnlCurrentInput = new System.Windows.Forms.Panel();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnEye1 = new System.Windows.Forms.Button();
            this.lblErrorCurrent = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.pnlNewInput = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnEye2 = new System.Windows.Forms.Button();
            this.lblErrorNew = new System.Windows.Forms.Label();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.pnlConfirmInput = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnEye3 = new System.Windows.Forms.Button();
            this.lblErrorConfirm = new System.Windows.Forms.Label();
            this.lblMatchMessage = new System.Windows.Forms.Label();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnConfirmChange = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlRowCurrent.SuspendLayout();
            this.pnlCurrentInput.SuspendLayout();
            this.pnlNewInput.SuspendLayout();
            this.pnlConfirmInput.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 0, 8, 0);
            this.pnlHeader.Size = new System.Drawing.Size(520, 56);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.lblTitle.Location = new System.Drawing.Point(20, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đổi mật khẩu tài khoản";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(100, 80, 60);
            this.btnClose.Location = new System.Drawing.Point(472, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 56);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(240, 249, 255);
            this.pnlInfo.Controls.Add(this.lblInfoText);
            this.pnlInfo.Location = new System.Drawing.Point(20, 64);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(476, 52);
            this.pnlInfo.TabIndex = 1;

            // 
            // lblInfoText
            // 
            this.lblInfoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoText.ForeColor = System.Drawing.Color.FromArgb(30, 100, 160);
            this.lblInfoText.Location = new System.Drawing.Point(0, 0);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInfoText.Size = new System.Drawing.Size(476, 52);
            this.lblInfoText.TabIndex = 0;
            this.lblInfoText.Text = "⚹  Mật khẩu mới phải có tối thiểu 8 ký tự, bao gồm chữ hoa, chữ thường và chữ số.";
            this.lblInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlRowCurrent
            // 
            this.pnlRowCurrent.Controls.Add(this.lnkForgot);
            this.pnlRowCurrent.Controls.Add(this.lblCurrentPwd);
            this.pnlRowCurrent.Location = new System.Drawing.Point(20, 128);
            this.pnlRowCurrent.Name = "pnlRowCurrent";
            this.pnlRowCurrent.Size = new System.Drawing.Size(476, 22);
            this.pnlRowCurrent.TabIndex = 2;

            // 
            // lblCurrentPwd
            // 
            this.lblCurrentPwd.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurrentPwd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPwd.ForeColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.lblCurrentPwd.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentPwd.Name = "lblCurrentPwd";
            this.lblCurrentPwd.Size = new System.Drawing.Size(240, 22);
            this.lblCurrentPwd.TabIndex = 0;
            this.lblCurrentPwd.Text = "Mật khẩu hiện tại *";
            this.lblCurrentPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lnkForgot
            // 
            this.lnkForgot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkForgot.LinkColor = System.Drawing.Color.FromArgb(100, 70, 40);
            this.lnkForgot.Location = new System.Drawing.Point(240, 0);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(236, 22);
            this.lnkForgot.TabIndex = 1;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Quên mật khẩu?";
            this.lnkForgot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // pnlCurrentInput
            // 
            this.pnlCurrentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrentInput.Controls.Add(this.txtCurrentPassword);
            this.pnlCurrentInput.Controls.Add(this.btnEye1);
            this.pnlCurrentInput.Location = new System.Drawing.Point(20, 156);
            this.pnlCurrentInput.Name = "txtCurrentPasswordPanel";
            this.pnlCurrentInput.Size = new System.Drawing.Size(476, 36);
            this.pnlCurrentInput.TabIndex = 3;

            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCurrentPassword.Location = new System.Drawing.Point(0, 0);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtCurrentPassword.Size = new System.Drawing.Size(438, 19);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.UseSystemPasswordChar = true;

            // 
            // btnEye1
            // 
            this.btnEye1.BackColor = System.Drawing.Color.White;
            this.btnEye1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEye1.FlatAppearance.BorderSize = 0;
            this.btnEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye1.Location = new System.Drawing.Point(438, 0);
            this.btnEye1.Name = "btnEye1";
            this.btnEye1.Size = new System.Drawing.Size(36, 34);
            this.btnEye1.TabIndex = 1;
            this.btnEye1.Text = "👁";
            this.btnEye1.UseVisualStyleBackColor = false;
            this.btnEye1.Click += new System.EventHandler(this.btnEye1_Click);

            // 
            // lblErrorCurrent
            // 
            this.lblErrorCurrent.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblErrorCurrent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorCurrent.Location = new System.Drawing.Point(20, 200);
            this.lblErrorCurrent.Name = "lblErrorCurrent";
            this.lblErrorCurrent.Size = new System.Drawing.Size(476, 18);
            this.lblErrorCurrent.TabIndex = 4;
            this.lblErrorCurrent.Visible = false;

            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNewPwd.ForeColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.lblNewPwd.Location = new System.Drawing.Point(20, 228);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(476, 22);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "Mật khẩu mới *";

            // 
            // pnlNewInput
            // 
            this.pnlNewInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewInput.Controls.Add(this.txtNewPassword);
            this.pnlNewInput.Controls.Add(this.btnEye2);
            this.pnlNewInput.Location = new System.Drawing.Point(20, 256);
            this.pnlNewInput.Name = "txtNewPasswordPanel";
            this.pnlNewInput.Size = new System.Drawing.Size(476, 36);
            this.pnlNewInput.TabIndex = 6;

            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNewPassword.Location = new System.Drawing.Point(0, 0);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtNewPassword.Size = new System.Drawing.Size(438, 19);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.UseSystemPasswordChar = true;

            // 
            // btnEye2
            // 
            this.btnEye2.BackColor = System.Drawing.Color.White;
            this.btnEye2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEye2.FlatAppearance.BorderSize = 0;
            this.btnEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye2.Location = new System.Drawing.Point(438, 0);
            this.btnEye2.Name = "btnEye2";
            this.btnEye2.Size = new System.Drawing.Size(36, 34);
            this.btnEye2.TabIndex = 1;
            this.btnEye2.Text = "👁";
            this.btnEye2.UseVisualStyleBackColor = false;
            this.btnEye2.Click += new System.EventHandler(this.btnEye2_Click);

            // 
            // lblErrorNew
            // 
            this.lblErrorNew.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblErrorNew.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorNew.Location = new System.Drawing.Point(20, 300);
            this.lblErrorNew.Name = "lblErrorNew";
            this.lblErrorNew.Size = new System.Drawing.Size(476, 18);
            this.lblErrorNew.TabIndex = 7;
            this.lblErrorNew.Visible = false;

            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPwd.ForeColor = System.Drawing.Color.FromArgb(60, 40, 20);
            this.lblConfirmPwd.Location = new System.Drawing.Point(20, 328);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(476, 22);
            this.lblConfirmPwd.TabIndex = 8;
            this.lblConfirmPwd.Text = "Nhập lại mật khẩu mới *";

            // 
            // pnlConfirmInput
            // 
            this.pnlConfirmInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfirmInput.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmInput.Controls.Add(this.btnEye3);
            this.pnlConfirmInput.Location = new System.Drawing.Point(20, 356);
            this.pnlConfirmInput.Name = "txtConfirmPasswordPanel";
            this.pnlConfirmInput.Size = new System.Drawing.Size(476, 36);
            this.pnlConfirmInput.TabIndex = 9;

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 0);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.txtConfirmPassword.Size = new System.Drawing.Size(438, 19);
            this.txtConfirmPassword.TabIndex = 0;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);

            // 
            // btnEye3
            // 
            this.btnEye3.BackColor = System.Drawing.Color.White;
            this.btnEye3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye3.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEye3.FlatAppearance.BorderSize = 0;
            this.btnEye3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye3.Location = new System.Drawing.Point(438, 0);
            this.btnEye3.Name = "btnEye3";
            this.btnEye3.Size = new System.Drawing.Size(36, 34);
            this.btnEye3.TabIndex = 1;
            this.btnEye3.Text = "👁";
            this.btnEye3.UseVisualStyleBackColor = false;
            this.btnEye3.Click += new System.EventHandler(this.btnEye3_Click);

            // 
            // lblErrorConfirm
            // 
            this.lblErrorConfirm.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblErrorConfirm.ForeColor = System.Drawing.Color.Firebrick;
            this.lblErrorConfirm.Location = new System.Drawing.Point(20, 400);
            this.lblErrorConfirm.Name = "lblErrorConfirm";
            this.lblErrorConfirm.Size = new System.Drawing.Size(476, 18);
            this.lblErrorConfirm.TabIndex = 10;
            this.lblErrorConfirm.Visible = false;

            // 
            // lblMatchMessage
            // 
            this.lblMatchMessage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMatchMessage.ForeColor = System.Drawing.Color.FromArgb(27, 134, 100);
            this.lblMatchMessage.Location = new System.Drawing.Point(20, 400);
            this.lblMatchMessage.Name = "lblMatchMessage";
            this.lblMatchMessage.Size = new System.Drawing.Size(476, 18);
            this.lblMatchMessage.TabIndex = 11;
            this.lblMatchMessage.Text = "✓ Mật khẩu xác nhận khớp";
            this.lblMatchMessage.Visible = false;

            // 
            // btnCancelChange
            // 
            this.btnCancelChange.BackColor = System.Drawing.Color.White;
            this.btnCancelChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 155, 130);
            this.btnCancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelChange.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelChange.ForeColor = System.Drawing.Color.FromArgb(85, 55, 34);
            this.btnCancelChange.Location = new System.Drawing.Point(20, 430);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(140, 36);
            this.btnCancelChange.TabIndex = 12;
            this.btnCancelChange.Text = "× Hủy bỏ";
            this.btnCancelChange.UseVisualStyleBackColor = false;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);

            // 
            // btnConfirmChange
            // 
            this.btnConfirmChange.BackColor = System.Drawing.Color.FromArgb(85, 55, 34);
            this.btnConfirmChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmChange.FlatAppearance.BorderSize = 0;
            this.btnConfirmChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmChange.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmChange.ForeColor = System.Drawing.Color.White;
            this.btnConfirmChange.Location = new System.Drawing.Point(296, 430);
            this.btnConfirmChange.Name = "btnConfirmChange";
            this.btnConfirmChange.Size = new System.Drawing.Size(220, 36);
            this.btnConfirmChange.TabIndex = 13;
            this.btnConfirmChange.Text = "✓ Xác nhận đổi mật khẩu";
            this.btnConfirmChange.UseVisualStyleBackColor = false;
            this.btnConfirmChange.Click += new System.EventHandler(this.btnConfirmChange_Click);

            // 
            // A04ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlRowCurrent);
            this.Controls.Add(this.pnlCurrentInput);
            this.Controls.Add(this.lblErrorCurrent);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.pnlNewInput);
            this.Controls.Add(this.lblErrorNew);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.pnlConfirmInput);
            this.Controls.Add(this.lblErrorConfirm);
            this.Controls.Add(this.lblMatchMessage);
            this.Controls.Add(this.btnCancelChange);
            this.Controls.Add(this.btnConfirmChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A04ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";

            this.pnlHeader.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlRowCurrent.ResumeLayout(false);
            this.pnlCurrentInput.ResumeLayout(false);
            this.pnlCurrentInput.PerformLayout();
            this.pnlNewInput.ResumeLayout(false);
            this.pnlNewInput.PerformLayout();
            this.pnlConfirmInput.ResumeLayout(false);
            this.pnlConfirmInput.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
