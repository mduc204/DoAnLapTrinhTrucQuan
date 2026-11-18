using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    /// <summary>
    /// Placeholder cho Module Quản lý Danh mục (đang để trống theo phân công nhóm)
    /// </summary>
    public class ucDanhMuc : UserControl
    {
        public ucDanhMuc()
        {
            BackColor = UIHelper.BgMain;
            Dock = DockStyle.Fill;
            Font = new Font("Segoe UI", 11F);

            Label lbl = new Label
            {
                Text = "📁 Module: Quản lý Danh mục món\n(Phần tính năng này đang để trống - Hiện tại tập trung hoàn thiện Module Quản lý món)",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = UIHelper.TextMain,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lbl);
        }
    }

    /// <summary>
    /// Placeholder cho Module M02: Tồn kho, Nhập/Xuất kho & Thẻ kho
    /// </summary>
    public class ucQuanLyKho : UserControl
    {
        public ucQuanLyKho()
        {
            BackColor = UIHelper.BgMain;
            Dock = DockStyle.Fill;
            Font = new Font("Segoe UI", 11F);

            Label lbl = new Label
            {
                Text = "📦 Module M02: Tồn kho, Nhập/Xuất kho & Lịch sử thẻ kho\n(Đang trong quá trình hoàn thiện giao diện chi tiết)",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = UIHelper.TextMain,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lbl);
        }
    }

    /// <summary>
    /// Placeholder cho Module M03: Nhập/Xuất Excel nguyên liệu
    /// </summary>
    public class ucNhapXuatExcel : UserControl
    {
        public ucNhapXuatExcel()
        {
            BackColor = UIHelper.BgMain;
            Dock = DockStyle.Fill;
            Font = new Font("Segoe UI", 11F);

            Label lbl = new Label
            {
                Text = "📊 Module M03: Nhập/Xuất Excel nguyên liệu & Sửa tồn kho Inline\n(Đang trong quá trình hoàn thiện giao diện chi tiết)",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = UIHelper.TextMain,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(lbl);
        }
    }

}
