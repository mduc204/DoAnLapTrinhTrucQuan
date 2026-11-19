namespace DoAnLapTrinhTrucQuan
{
    partial class UcS01
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlHeader = new Panel();
            pnlContent = new Panel();
            btnSoDoBan = new Button();
            btnBanHang = new Button();
            btnDonHang = new Button();
            btnHoaDon = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnHoaDon);
            pnlMenu.Controls.Add(btnDonHang);
            pnlMenu.Controls.Add(btnBanHang);
            pnlMenu.Controls.Add(btnSoDoBan);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(168, 850);
            pnlMenu.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(168, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1272, 125);
            pnlHeader.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(168, 125);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1272, 725);
            pnlContent.TabIndex = 2;
            // 
            // btnSoDoBan
            // 
            btnSoDoBan.Location = new Point(27, 125);
            btnSoDoBan.Name = "btnSoDoBan";
            btnSoDoBan.Size = new Size(94, 29);
            btnSoDoBan.TabIndex = 0;
            btnSoDoBan.Text = "Sơ Đồ Bàn";
            btnSoDoBan.UseVisualStyleBackColor = true;
            // 
            // btnBanHang
            // 
            btnBanHang.Location = new Point(27, 160);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(94, 29);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnDonHang
            // 
            btnDonHang.Location = new Point(27, 195);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(94, 29);
            btnDonHang.TabIndex = 2;
            btnDonHang.Text = "Đơn Hàng";
            btnDonHang.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(27, 230);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(94, 29);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // UcS01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMenu);
            Name = "UcS01";
            Size = new Size(1440, 850);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Button btnSoDoBan;
        private Button btnHoaDon;
        private Button btnDonHang;
        private Button btnBanHang;
    }
}
