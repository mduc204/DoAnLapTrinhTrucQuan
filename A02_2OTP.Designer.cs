namespace DoAnLapTrinhTrucQuan
{
    partial class A02_2OTP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblOTPTitle;
        private System.Windows.Forms.Label lblOTPSubtitle;
        private System.Windows.Forms.Panel pnlOTPBoxes;
        private System.Windows.Forms.TextBox otpBox0;
        private System.Windows.Forms.TextBox otpBox1;
        private System.Windows.Forms.TextBox otpBox2;
        private System.Windows.Forms.TextBox otpBox3;
        private System.Windows.Forms.TextBox otpBox4;
        private System.Windows.Forms.TextBox otpBox5;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.LinkLabel lnkResend;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;

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
            this.components = new System.ComponentModel.Container();
            this.lblOTPTitle = new System.Windows.Forms.Label();
            this.lblOTPSubtitle = new System.Windows.Forms.Label();
            this.pnlOTPBoxes = new System.Windows.Forms.Panel();
            this.otpBox0 = new System.Windows.Forms.TextBox();
            this.otpBox1 = new System.Windows.Forms.TextBox();
            this.otpBox2 = new System.Windows.Forms.TextBox();
            this.otpBox3 = new System.Windows.Forms.TextBox();
            this.otpBox4 = new System.Windows.Forms.TextBox();
            this.otpBox5 = new System.Windows.Forms.TextBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lnkResend = new System.Windows.Forms.LinkLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();

            this.pnlOTPBoxes.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblOTPTitle
            // 
            this.lblOTPTitle.AutoSize = true;
            this.lblOTPTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOTPTitle.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.lblOTPTitle.Location = new System.Drawing.Point(24, 16);
            this.lblOTPTitle.Name = "lblOTPTitle";
            this.lblOTPTitle.Size = new System.Drawing.Size(150, 30);
            this.lblOTPTitle.TabIndex = 0;
            this.lblOTPTitle.Text = "Nhập mã OTP";

            // 
            // lblOTPSubtitle
            // 
            this.lblOTPSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOTPSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblOTPSubtitle.Location = new System.Drawing.Point(24, 48);
            this.lblOTPSubtitle.Name = "lblOTPSubtitle";
            this.lblOTPSubtitle.Size = new System.Drawing.Size(392, 32);
            this.lblOTPSubtitle.TabIndex = 1;
            this.lblOTPSubtitle.Text = "Mã gồm 6 số đã được gửi đến\nsố *** *** 678";

            // 
            // pnlOTPBoxes
            // 
            this.pnlOTPBoxes.BackColor = System.Drawing.Color.Transparent;
            this.pnlOTPBoxes.Controls.Add(this.otpBox0);
            this.pnlOTPBoxes.Controls.Add(this.otpBox1);
            this.pnlOTPBoxes.Controls.Add(this.otpBox2);
            this.pnlOTPBoxes.Controls.Add(this.otpBox3);
            this.pnlOTPBoxes.Controls.Add(this.otpBox4);
            this.pnlOTPBoxes.Controls.Add(this.otpBox5);
            this.pnlOTPBoxes.Location = new System.Drawing.Point(24, 84);
            this.pnlOTPBoxes.Name = "pnlOTPBoxes";
            this.pnlOTPBoxes.Size = new System.Drawing.Size(392, 54);
            this.pnlOTPBoxes.TabIndex = 2;

            // 
            // otpBox0
            // 
            this.otpBox0.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.otpBox0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpBox0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.otpBox0.Location = new System.Drawing.Point(18, 2);
            this.otpBox0.MaxLength = 1;
            this.otpBox0.Name = "otpBox0";
            this.otpBox0.Size = new System.Drawing.Size(48, 48);
            this.otpBox0.TabIndex = 0;
            this.otpBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otpBox0.TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
            this.otpBox0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);

            // 
            // otpBox1
            // 
            this.otpBox1.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.otpBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.otpBox1.Location = new System.Drawing.Point(78, 2);
            this.otpBox1.MaxLength = 1;
            this.otpBox1.Name = "otpBox1";
            this.otpBox1.Size = new System.Drawing.Size(48, 48);
            this.otpBox1.TabIndex = 1;
            this.otpBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otpBox1.TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
            this.otpBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);

            // 
            // otpBox2
            // 
            this.otpBox2.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.otpBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.otpBox2.Location = new System.Drawing.Point(138, 2);
            this.otpBox2.MaxLength = 1;
            this.otpBox2.Name = "otpBox2";
            this.otpBox2.Size = new System.Drawing.Size(48, 48);
            this.otpBox2.TabIndex = 2;
            this.otpBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otpBox2.TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
            this.otpBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);

            // 
            // otpBox3
            // 
            this.otpBox3.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.otpBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.otpBox3.Location = new System.Drawing.Point(198, 2);
            this.otpBox3.MaxLength = 1;
            this.otpBox3.Name = "otpBox3";
            this.otpBox3.Size = new System.Drawing.Size(48, 48);
            this.otpBox3.TabIndex = 3;
            this.otpBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otpBox3.TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
            this.otpBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);

            // 
            // otpBox4
            // 
            this.otpBox4.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.otpBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.otpBox4.Location = new System.Drawing.Point(258, 2);
            this.otpBox4.MaxLength = 1;
            this.otpBox4.Name = "otpBox4";
            this.otpBox4.Size = new System.Drawing.Size(48, 48);
            this.otpBox4.TabIndex = 4;
            this.otpBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otpBox4.TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
            this.otpBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);

            // 
            // otpBox5
            // 
            this.otpBox5.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.otpBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otpBox5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.otpBox5.Location = new System.Drawing.Point(318, 2);
            this.otpBox5.MaxLength = 1;
            this.otpBox5.Name = "otpBox5";
            this.otpBox5.Size = new System.Drawing.Size(48, 48);
            this.otpBox5.TabIndex = 5;
            this.otpBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otpBox5.TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
            this.otpBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);

            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(24, 150);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(120, 15);
            this.lblCountdown.TabIndex = 3;
            this.lblCountdown.Text = "Mã hết hạn sau 01:00";

            // 
            // lnkResend
            // 
            this.lnkResend.AutoSize = true;
            this.lnkResend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkResend.LinkColor = System.Drawing.Color.Brown;
            this.lnkResend.Location = new System.Drawing.Point(330, 150);
            this.lnkResend.Name = "lnkResend";
            this.lnkResend.Size = new System.Drawing.Size(60, 15);
            this.lnkResend.TabIndex = 4;
            this.lnkResend.TabStop = true;
            this.lnkResend.Text = "Gửi lại mã";
            this.lnkResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResend_LinkClicked);

            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnConfirm);
            this.pnlButtons.Location = new System.Drawing.Point(24, 188);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(392, 42);
            this.pnlButtons.TabIndex = 5;

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(176, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(216, 40);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // 
            // A02_2OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 247, 243);
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.Controls.Add(this.lblOTPTitle);
            this.Controls.Add(this.lblOTPSubtitle);
            this.Controls.Add(this.pnlOTPBoxes);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lnkResend);
            this.Controls.Add(this.pnlButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A02_2OTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác nhận OTP";

            this.pnlOTPBoxes.ResumeLayout(false);
            this.pnlOTPBoxes.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
