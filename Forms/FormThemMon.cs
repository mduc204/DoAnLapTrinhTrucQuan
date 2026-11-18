using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class FormThemMon : Form
    {
        public Mon? MonMoi { get; private set; }

        private class LoaiMonConfig
        {
            public string MaDanhMuc { get; set; } = "";
            public string TenDanhMuc { get; set; } = "";
            public string Prefix { get; set; } = "";
            public Color MauSacMinhHoa { get; set; }
            public string TenMonMacDinh { get; set; } = "";
            public string MoTaMacDinh { get; set; } = "";
            public decimal GiaBanMacDinh { get; set; } = 35000;

            public override string ToString() => $"{TenDanhMuc} (Tiền tố: {Prefix})";
        }

        private readonly List<LoaiMonConfig> _cauHinhLoaiMon = new List<LoaiMonConfig>
        {
            new LoaiMonConfig
            {
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                Prefix = "CF",
                MauSacMinhHoa = ColorTranslator.FromHtml("#6F4E37"),
                TenMonMacDinh = "Cà phê muối xứ Huế",
                MoTaMacDinh = "Cà phê phin truyền thống thơm nồng kết hợp lớp kem muối béo nhẹ mặn ngọt cân bằng.",
                GiaBanMacDinh = 35000
            },
            new LoaiMonConfig
            {
                MaDanhMuc = "DM02",
                TenDanhMuc = "Cà phê pha máy",
                Prefix = "PM",
                MauSacMinhHoa = ColorTranslator.FromHtml("#4A3222"),
                TenMonMacDinh = "Espresso Con Panna",
                MoTaMacDinh = "Chiết xuất cà phê áp suất cao tiêu chuẩn Ý phủ bông kem tươi tuyết trắng mịn béo ngậy.",
                GiaBanMacDinh = 42000
            },
            new LoaiMonConfig
            {
                MaDanhMuc = "DM03",
                TenDanhMuc = "Trà trái cây nhiệt đới",
                Prefix = "TE",
                MauSacMinhHoa = ColorTranslator.FromHtml("#D35400"),
                TenMonMacDinh = "Trà ổi hồng phúc bồn tử",
                MoTaMacDinh = "Trà hoa quả chua ngọt thanh mát, đượm vị ổi xá lị tươi và phúc bồn tử bổ sung vitamin.",
                GiaBanMacDinh = 45000
            },
            new LoaiMonConfig
            {
                MaDanhMuc = "DM04",
                TenDanhMuc = "Trà sữa & Macchiato",
                Prefix = "TS",
                MauSacMinhHoa = ColorTranslator.FromHtml("#A0522D"),
                TenMonMacDinh = "Trà sữa Ô long nướng Trân châu",
                MoTaMacDinh = "Trà Ô long ủ đậm đà kết hợp sữa tươi béo thơm và thạch trân châu hoàng kim dai giòn.",
                GiaBanMacDinh = 42000
            },
            new LoaiMonConfig
            {
                MaDanhMuc = "DM05",
                TenDanhMuc = "Đá xay & Sinh tố",
                Prefix = "DX",
                MauSacMinhHoa = ColorTranslator.FromHtml("#2980B9"),
                TenMonMacDinh = "Matcha đá xay kem tuyết",
                MoTaMacDinh = "Bột trà xanh Nhật Bản xay nhuyễn mát lạnh với đá viên tinh khiết RO, phủ kem béo bùi.",
                GiaBanMacDinh = 48000
            },
            new LoaiMonConfig
            {
                MaDanhMuc = "DM06",
                TenDanhMuc = "Bánh tươi & Ăn nhẹ",
                Prefix = "BK",
                MauSacMinhHoa = ColorTranslator.FromHtml("#B8860B"),
                TenMonMacDinh = "Bánh Tiramisu phô mai cacao",
                MoTaMacDinh = "Bánh bông lan mềm xốp tẩm hương cà phê rượu rum và lớp kem phô mai Mascarpone béo ngậy.",
                GiaBanMacDinh = 40000
            }
        };

        private Image? _anhTuyChinh = null;
        private bool _daChonAnhThuCong = false;

        public FormThemMon()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            // Nạp danh mục
            cboDanhMuc.DataSource = _cauHinhLoaiMon;
            cboDanhMuc.DisplayMember = "TenDanhMuc";

            // Nạp trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang bán");
            cboTrangThai.Items.Add("Tạm ngưng");
            cboTrangThai.SelectedIndex = 0;

            // Bắt sự kiện
            cboDanhMuc.SelectedIndexChanged += (s, e) => ApDungLoaiMonDangChon(tuDongDienThongTin: true);
            btnTaoMaTuDong.Click += (s, e) => SinhMaTuDong();
            btnChonAnh.Click += BtnChonAnh_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            txtTenMon.TextChanged += (s, e) => CapNhatAnhMacDinhNeuChuaChon();

            // Áp dụng cấu hình ban đầu
            ApDungLoaiMonDangChon(tuDongDienThongTin: true);
        }

        private void ApDungLoaiMonDangChon(bool tuDongDienThongTin)
        {
            if (cboDanhMuc.SelectedItem is LoaiMonConfig cfg)
            {
                SinhMaTuDong();

                if (tuDongDienThongTin)
                {
                    txtTenMon.Text = cfg.TenMonMacDinh;
                    txtMoTa.Text = cfg.MoTaMacDinh;
                    numGiaBan.Value = cfg.GiaBanMacDinh;
                }

                CapNhatAnhMacDinhNeuChuaChon();
            }
        }

        private void SinhMaTuDong()
        {
            if (cboDanhMuc.SelectedItem is LoaiMonConfig cfg)
            {
                txtMaMon.Text = MockDataService.Instance.SinhMaMonTuDong(cfg.Prefix);
            }
        }

        private void CapNhatAnhMacDinhNeuChuaChon()
        {
            if (_daChonAnhThuCong && _anhTuyChinh != null)
            {
                picAnhMon.Image = _anhTuyChinh;
                return;
            }

            if (cboDanhMuc.SelectedItem is LoaiMonConfig cfg)
            {
                string ma = string.IsNullOrWhiteSpace(txtMaMon.Text) ? cfg.Prefix : txtMaMon.Text.Trim();
                string ten = string.IsNullOrWhiteSpace(txtTenMon.Text) ? cfg.TenDanhMuc : txtTenMon.Text.Trim();

                Image img = MockDataService.Instance.TaoHinhMinhHoa(ma, ten, cfg.MauSacMinhHoa, Color.White);
                picAnhMon.Image = img;
            }
        }

        private void BtnChonAnh_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh đại diện cho món";
                ofd.Filter = "Tệp hình ảnh (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        // Đọc file thông qua MemoryStream để không lock file trên ổ cứng
                        byte[] bytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            _anhTuyChinh = new Bitmap(Image.FromStream(ms));
                        }
                        _daChonAnhThuCong = true;
                        picAnhMon.Image = _anhTuyChinh;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể mở hình ảnh: {ex.Message}", "Lỗi hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            string maMon = txtMaMon.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(maMon))
            {
                MessageBox.Show("Mã món không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMon.Focus();
                return;
            }

            // Kiểm tra trùng mã món với danh sách hiện có
            bool daTonTai = MockDataService.Instance.DanhSachMon.Any(m => m.MaMon.Equals(maMon, StringComparison.OrdinalIgnoreCase));
            if (daTonTai)
            {
                MessageBox.Show($"Mã món '{maMon}' đã tồn tại trong thực đơn quán!\nVui lòng sửa lại mã hoặc nhấn nút [🔄 Sinh mã].", 
                    "Trùng mã món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMon.Focus();
                txtMaMon.SelectAll();
                return;
            }

            string tenMon = txtTenMon.Text.Trim();
            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Vui lòng nhập tên món!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMon.Focus();
                return;
            }

            if (cboDanhMuc.SelectedItem is not LoaiMonConfig cfg)
            {
                MessageBox.Show("Vui lòng chọn loại danh mục cho món!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image anhFinal = _daChonAnhThuCong && _anhTuyChinh != null 
                ? _anhTuyChinh 
                : MockDataService.Instance.TaoHinhMinhHoa(maMon, tenMon, cfg.MauSacMinhHoa, Color.White);

            MonMoi = new Mon
            {
                MaMon = maMon,
                TenMon = tenMon,
                MaDanhMuc = cfg.MaDanhMuc,
                TenDanhMuc = cfg.TenDanhMuc,
                GiaBan = numGiaBan.Value,
                GiaVonBOM = 0,
                MoTa = txtMoTa.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang bán",
                CoDinhLuong = chkCoDinhLuong.Checked,
                HinhAnh = anhFinal
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
