namespace DoAnLapTrinhTrucQuan.Forms
{
    partial class FormPreviewExcel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            pnlBottom = new System.Windows.Forms.Panel();
            btnDong = new DoAnLapTrinhTrucQuan.RoundedButton();
            lblCount = new System.Windows.Forms.Label();
            dgvPreview = new System.Windows.Forms.DataGridView();
            pnlHeader.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.White;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(20, 14, 20, 10);
            pnlHeader.Size = new System.Drawing.Size(860, 64);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            lblTitle.Location = new System.Drawing.Point(18, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(236, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Xem trước dữ liệu Excel (.xlsx)";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblSubtitle.Location = new System.Drawing.Point(20, 35);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(378, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Kiểm tra kỹ thông tin nguyên liệu trước khi áp dụng vào kho Mộc Café";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = System.Drawing.Color.White;
            pnlBottom.Controls.Add(lblCount);
            pnlBottom.Controls.Add(btnDong);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottom.Location = new System.Drawing.Point(0, 460);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(860, 56);
            pnlBottom.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDong.BackColor = System.Drawing.Color.FromArgb(106, 80, 63);
            btnDong.BorderColor = System.Drawing.Color.FromArgb(106, 80, 63);
            btnDong.BorderRadius = 8;
            btnDong.BorderWidth = 1;
            btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDong.DownBackColor = System.Drawing.Color.FromArgb(85, 55, 34);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnDong.ForeColor = System.Drawing.Color.White;
            btnDong.HoverBackColor = System.Drawing.Color.FromArgb(85, 55, 34);
            btnDong.IsOutlined = false;
            btnDong.Location = new System.Drawing.Point(740, 10);
            btnDong.Name = "btnDong";
            btnDong.NormalBackColor = System.Drawing.Color.FromArgb(106, 80, 63);
            btnDong.Size = new System.Drawing.Size(100, 36);
            btnDong.TabIndex = 0;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblCount.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            lblCount.Location = new System.Drawing.Point(20, 18);
            lblCount.Name = "lblCount";
            lblCount.Size = new System.Drawing.Size(155, 17);
            lblCount.TabIndex = 1;
            lblCount.Text = "Tổng số: 0 nguyên liệu";
            // 
            // dgvPreview
            // 
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.AllowUserToDeleteRows = false;
            dgvPreview.AllowUserToResizeRows = false;
            dgvPreview.BackgroundColor = System.Drawing.Color.White;
            dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPreview.EnableHeadersVisualStyles = false;
            dgvPreview.Location = new System.Drawing.Point(0, 64);
            dgvPreview.MultiSelect = false;
            dgvPreview.Name = "dgvPreview";
            dgvPreview.ReadOnly = true;
            dgvPreview.RowHeadersVisible = false;
            dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPreview.Size = new System.Drawing.Size(860, 396);
            dgvPreview.TabIndex = 2;
            // 
            // FormPreviewExcel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 245, 242);
            ClientSize = new System.Drawing.Size(860, 516);
            Controls.Add(dgvPreview);
            Controls.Add(pnlBottom);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPreviewExcel";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Xem trước dữ liệu Excel";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlBottom;
        private DoAnLapTrinhTrucQuan.RoundedButton btnDong;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvPreview;
    }
}
