using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class UcM05 : UserControl
    {
        public UcM05()
        {
            InitializeComponent();
            dgvNhanvien.Rows.Add("NV001", "Nguyễn Văn Hưng", "0908 123 456", "Admin", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV002", "Lê Mỹ Hạnh", "0912 345 678", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV003", "Trần Đình Nam", "0988 567 890", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV004", "Ngô Thùy Linh", "0934 998 112", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV005", "Võ Minh Trí", "0977 441 230", "Nhân viên", "Tạm khóa");
            dgvNhanvien.Rows.Add("NV006", "Hoàng Bách", "0903 881 772", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV007", "Đỗ Quỳnh Nga", "0918 776 554", "Nhân viên", "Đang làm việc");
            dgvNhanvien.Rows.Add("NV014", "Phan Tuấn Anh", "0966 223 901", "Nhân viên", "Đã nghỉ việc");
        }
    }
}