using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class FormChonNguyenLieu : Form
    {
        public DinhLuongBOM? KetQuaDinhLuong { get; private set; }
        private readonly string _maMonHienTai;
        private List<NguyenLieu> _dsNguyenLieu;

        public FormChonNguyenLieu(string maMonHienTai)
        {
            InitializeComponent();
            _maMonHienTai = maMonHienTai;
            _dsNguyenLieu = MockDataService.Instance.DanhSachNguyenLieu;

            LoadData();
            btnXacNhan.Click += BtnXacNhan_Click;
            btnHuy.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            cboNguyenLieu.SelectedIndexChanged += CboNguyenLieu_SelectedIndexChanged;
            numDinhLuong.ValueChanged += (s, e) => CapNhatTamTinh();
        }

        private void LoadData()
        {
            cboNguyenLieu.Items.Clear();
            foreach (var nl in _dsNguyenLieu)
            {
                cboNguyenLieu.Items.Add($"{nl.MaNL} - {nl.TenNL} ({nl.ViTriKho})");
            }
            if (cboNguyenLieu.Items.Count > 0)
            {
                cboNguyenLieu.SelectedIndex = 0;
            }
        }

        private void CboNguyenLieu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboNguyenLieu.SelectedIndex < 0 || cboNguyenLieu.SelectedIndex >= _dsNguyenLieu.Count) return;
            var nl = _dsNguyenLieu[cboNguyenLieu.SelectedIndex];
            lblDVT.Text = nl.DVT;
            lblDonGia.Text = $"Đơn giá quy đổi vốn: {UIHelper.FormatVND(nl.DonGiaNhap)} / {nl.DVT}";
            CapNhatTamTinh();
        }

        private void CapNhatTamTinh()
        {
            if (cboNguyenLieu.SelectedIndex < 0 || cboNguyenLieu.SelectedIndex >= _dsNguyenLieu.Count) return;
            var nl = _dsNguyenLieu[cboNguyenLieu.SelectedIndex];
            decimal thanhTien = Math.Round(numDinhLuong.Value * nl.DonGiaNhap, 0);
            lblThanhTienTamTinh.Text = $"Thành tiền giá vốn dự kiến: {UIHelper.FormatVND(thanhTien)}";
        }

        private void BtnXacNhan_Click(object? sender, EventArgs e)
        {
            if (cboNguyenLieu.SelectedIndex < 0 || cboNguyenLieu.SelectedIndex >= _dsNguyenLieu.Count)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nl = _dsNguyenLieu[cboNguyenLieu.SelectedIndex];
            KetQuaDinhLuong = new DinhLuongBOM
            {
                MaMon = _maMonHienTai,
                MaNL = nl.MaNL,
                TenNL = nl.TenNL,
                ViTriKho = nl.ViTriKho,
                DinhLuong = numDinhLuong.Value,
                DVT = nl.DVT,
                DonGiaQuyDoi = nl.DonGiaNhap
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
