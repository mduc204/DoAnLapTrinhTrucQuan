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
}
