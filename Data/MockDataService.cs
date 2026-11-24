using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Data
{
    /// <summary>
    /// Service quản lý Dữ liệu Mẫu (Mock Data) và Mẫu truy vấn ADO.NET kết nối SQL Server
    /// </summary>
    public class MockDataService
    {
        private static MockDataService? _instance;
        public static MockDataService Instance => _instance ??= new MockDataService();

        public List<Mon> DanhSachMon { get; set; } = new List<Mon>();
        public List<DanhMuc> DanhSachDanhMuc { get; set; } = new List<DanhMuc>();
        public List<NguyenLieu> DanhSachNguyenLieu { get; set; } = new List<NguyenLieu>();
        public List<InventoryTransaction> DanhSachLichSuKho { get; set; } = new List<InventoryTransaction>();
        public Dictionary<string, List<DinhLuongBOM>> DinhLuongMap { get; set; } = new Dictionary<string, List<DinhLuongBOM>>();
        public List<Voucher> DanhSachVoucher { get; set; } = new List<Voucher>();

        public void SapXepDanhSachMon()
        {
            DanhSachMon = DanhSachMon.OrderBy(m => m.MaDanhMuc).ThenBy(m => m.MaMon).ToList();
        }

        private readonly string _assetsDir;

        public MockDataService()
        {
            _assetsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Images");
            if (!Directory.Exists(_assetsDir))
            {
                Directory.CreateDirectory(_assetsDir);
            }

            KhoiTaoDuLieuDanhMuc();
            KhoiTaoDuLieuNguyenLieu();
            KhoiTaoDuLieuLichSuKho();
            KhoiTaoDuLieuMonVaBOM();
            KhoiTaoDuLieuVoucher();
        }

        #region 1. Khởi tạo Danh mục
        private void KhoiTaoDuLieuDanhMuc()
        {
            DanhSachDanhMuc = new List<DanhMuc>
            {
                new DanhMuc { MaDanhMuc = "DM01", TenDanhMuc = "Cà phê truyền thống", SoLuongMon = 6 },
                new DanhMuc { MaDanhMuc = "DM02", TenDanhMuc = "Cà phê pha máy", SoLuongMon = 5 },
                new DanhMuc { MaDanhMuc = "DM03", TenDanhMuc = "Trà trái cây nhiệt đới", SoLuongMon = 5 },
                new DanhMuc { MaDanhMuc = "DM04", TenDanhMuc = "Trà sữa & Macchiato", SoLuongMon = 0 },
                new DanhMuc { MaDanhMuc = "DM05", TenDanhMuc = "Đá xay & Sinh tố", SoLuongMon = 0 },
                new DanhMuc { MaDanhMuc = "DM06", TenDanhMuc = "Bánh tươi & Ăn nhẹ", SoLuongMon = 2 }
            };
        }
        #endregion

        #region 2. Khởi tạo Danh sách Nguyên vật liệu Kho (M02, M03)
        private void KhoiTaoDuLieuNguyenLieu()
        {
            DanhSachNguyenLieu = new List<NguyenLieu>
            {
                // Đúng 100% Mockup M02 (6 dòng hiển thị trang đầu)
                new NguyenLieu { MaNL = "NL001", TenNL = "Cà phê hạt Cầu Đất Arabica", NhomNL = "Cà phê", DVT = "gram (g)", DonGiaNhap = 320m, TonKhoHienTai = 1200, DinhMucToiThieu = 2000, ViTriKho = "Kho mát quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL014", TenNL = "Sữa đặc Ngôi Sao Phương Nam", NhomNL = "Sữa", DVT = "lon", DonGiaNhap = 24000m, TonKhoHienTai = 4, DinhMucToiThieu = 10, ViTriKho = "Tủ trữ sữa quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL022", TenNL = "Trà đen Phúc Long Hảo Hạng", NhomNL = "Trà", DVT = "gram (g)", DonGiaNhap = 450m, TonKhoHienTai = 300, DinhMucToiThieu = 500, ViTriKho = "Kệ trà & syrup", DangSuDung = true },
                new NguyenLieu { MaNL = "NL005", TenNL = "Sữa tươi thanh trùng Barista", NhomNL = "Sữa", DVT = "hộp", DonGiaNhap = 35000m, TonKhoHienTai = 0, DinhMucToiThieu = 6, ViTriKho = "Tủ trữ sữa quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL008", TenNL = "Đường mía Biên Hòa", NhomNL = "Đường", DVT = "kg", DonGiaNhap = 26000m, TonKhoHienTai = 15, DinhMucToiThieu = 5, ViTriKho = "Kho khô", DangSuDung = true },
                new NguyenLieu { MaNL = "NL018", TenNL = "Trái đào ngâm Kronos", NhomNL = "Topping", DVT = "hộp", DonGiaNhap = 42000m, TonKhoHienTai = 8, DinhMucToiThieu = 3, ViTriKho = "Kệ nguyên liệu Bar", DangSuDung = true },

                // Các nguyên liệu khác để đủ 28 nguyên liệu (3 sắp hết, 1 hết hàng, 24 an toàn)
                new NguyenLieu { MaNL = "NL002", TenNL = "Hạt Cà Phê Robusta Buôn Ma Thuột", NhomNL = "Cà phê", DVT = "gram (g)", DonGiaNhap = 240m, TonKhoHienTai = 8500, DinhMucToiThieu = 2000, ViTriKho = "Kho mát quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL003", TenNL = "Hạt Cà Phê Mộc Blend Signature", NhomNL = "Cà phê", DVT = "gram (g)", DonGiaNhap = 380m, TonKhoHienTai = 5200, DinhMucToiThieu = 1500, ViTriKho = "Kho mát quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL004", TenNL = "Bột Cacao Đắk Lắk nguyên chất", NhomNL = "Bột", DVT = "gram (g)", DonGiaNhap = 280m, TonKhoHienTai = 4000, DinhMucToiThieu = 1000, ViTriKho = "Kệ bột & sốt", DangSuDung = true },
                new NguyenLieu { MaNL = "NL006", TenNL = "Sữa tươi tiệt trùng Vinamilk", NhomNL = "Sữa", DVT = "hộp", DonGiaNhap = 32000m, TonKhoHienTai = 18, DinhMucToiThieu = 8, ViTriKho = "Tủ trữ sữa quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL007", TenNL = "Kem béo thực vật Rich's", NhomNL = "Sữa", DVT = "hộp", DonGiaNhap = 41000m, TonKhoHienTai = 12, DinhMucToiThieu = 4, ViTriKho = "Tủ đông quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL009", TenNL = "Đường phèn Quảng Ngãi", NhomNL = "Đường", DVT = "kg", DonGiaNhap = 34000m, TonKhoHienTai = 20, DinhMucToiThieu = 5, ViTriKho = "Kho khô", DangSuDung = true },
                new NguyenLieu { MaNL = "NL010", TenNL = "Siro Vani Monin", NhomNL = "Syrup", DVT = "chai (ml)", DonGiaNhap = 240000m, TonKhoHienTai = 3500, DinhMucToiThieu = 1000, ViTriKho = "Kệ siro", DangSuDung = true },
                new NguyenLieu { MaNL = "NL011", TenNL = "Siro Caramel Torani", NhomNL = "Syrup", DVT = "chai (ml)", DonGiaNhap = 220000m, TonKhoHienTai = 2800, DinhMucToiThieu = 1000, ViTriKho = "Kệ siro", DangSuDung = true },
                new NguyenLieu { MaNL = "NL012", TenNL = "Siro Hạt Dẻ Hazelnut", NhomNL = "Syrup", DVT = "chai (ml)", DonGiaNhap = 235000m, TonKhoHienTai = 2100, DinhMucToiThieu = 800, ViTriKho = "Kệ siro", DangSuDung = true },
                new NguyenLieu { MaNL = "NL013", TenNL = "Bột Matcha Uji Nhật Bản", NhomNL = "Bột", DVT = "gram (g)", DonGiaNhap = 650m, TonKhoHienTai = 1800, DinhMucToiThieu = 500, ViTriKho = "Tủ mát trà", DangSuDung = true },
                new NguyenLieu { MaNL = "NL015", TenNL = "Nước cốt dừa tươi Bến Tre", NhomNL = "Sữa", DVT = "mililit (ml)", DonGiaNhap = 75m, TonKhoHienTai = 5000, DinhMucToiThieu = 2000, ViTriKho = "Tủ mát quầy Bar", DangSuDung = true },
                new NguyenLieu { MaNL = "NL016", TenNL = "Đá viên tinh khiết lọc RO", NhomNL = "Đá", DVT = "kg", DonGiaNhap = 3300m, TonKhoHienTai = 120, DinhMucToiThieu = 30, ViTriKho = "Thùng đá Barista", DangSuDung = true },
                new NguyenLieu { MaNL = "NL017", TenNL = "Trân châu đen hoàng kim", NhomNL = "Topping", DVT = "kg", DonGiaNhap = 65000m, TonKhoHienTai = 15, DinhMucToiThieu = 4, ViTriKho = "Kệ topping", DangSuDung = true },
                new NguyenLieu { MaNL = "NL019", TenNL = "Thạch dừa nha đam giòn", NhomNL = "Topping", DVT = "hộp", DonGiaNhap = 38000m, TonKhoHienTai = 9, DinhMucToiThieu = 3, ViTriKho = "Kệ topping", DangSuDung = true },
                new NguyenLieu { MaNL = "NL020", TenNL = "Hạt chia hữu cơ Úc sấy", NhomNL = "Topping", DVT = "gram (g)", DonGiaNhap = 130m, TonKhoHienTai = 3000, DinhMucToiThieu = 500, ViTriKho = "Kệ topping", DangSuDung = true },
                new NguyenLieu { MaNL = "NL021", TenNL = "Trà Oolong Cao Sơn Mộc Châu", NhomNL = "Trà", DVT = "gram (g)", DonGiaNhap = 520m, TonKhoHienTai = 2500, DinhMucToiThieu = 600, ViTriKho = "Kệ trà", DangSuDung = true },
                new NguyenLieu { MaNL = "NL023", TenNL = "Trà lài hoa sen tự nhiên", NhomNL = "Trà", DVT = "gram (g)", DonGiaNhap = 390m, TonKhoHienTai = 3200, DinhMucToiThieu = 800, ViTriKho = "Kệ trà", DangSuDung = true },
                new NguyenLieu { MaNL = "NL024", TenNL = "Cam vàng Navel tươi mọng", NhomNL = "Trái cây", DVT = "kg", DonGiaNhap = 55000m, TonKhoHienTai = 22, DinhMucToiThieu = 5, ViTriKho = "Tủ mát trái cây", DangSuDung = true },
                new NguyenLieu { MaNL = "NL025", TenNL = "Sả cây tươi Tây Ninh", NhomNL = "Trái cây", DVT = "kg", DonGiaNhap = 25000m, TonKhoHienTai = 8, DinhMucToiThieu = 2, ViTriKho = "Tủ mát trái cây", DangSuDung = true },
                new NguyenLieu { MaNL = "NL026", TenNL = "Ly giấy 500ml kèm nắp nón", NhomNL = "Bao bì", DVT = "cái", DonGiaNhap = 1800m, TonKhoHienTai = 1200, DinhMucToiThieu = 300, ViTriKho = "Kho bao bì", DangSuDung = true },
                new NguyenLieu { MaNL = "NL027", TenNL = "Ống hút giấy bọc màng", NhomNL = "Bao bì", DVT = "cái", DonGiaNhap = 350m, TonKhoHienTai = 3500, DinhMucToiThieu = 500, ViTriKho = "Kho bao bì", DangSuDung = true },
                new NguyenLieu { MaNL = "NL028", TenNL = "Túi đựng mang đi 1 ly tự hủy", NhomNL = "Bao bì", DVT = "cái", DonGiaNhap = 450m, TonKhoHienTai = 2800, DinhMucToiThieu = 400, ViTriKho = "Kho bao bì", DangSuDung = true }
            };
        }

        private void KhoiTaoDuLieuLichSuKho()
        {
            DanhSachLichSuKho = new List<InventoryTransaction>
            {
                new InventoryTransaction { TransactionId = "TX001", IngredientId = "NL001", DisplayTime = "10:38 hôm nay", TransactionType = "Bán hàng", Quantity = -40, BalanceAfter = 1200, PerformedBy = "POS", Note = "Trừ kho tự động theo hóa đơn HD0042" },
                new InventoryTransaction { TransactionId = "TX002", IngredientId = "NL001", DisplayTime = "09:20 hôm nay", TransactionType = "Bán hàng", Quantity = -40, BalanceAfter = 1240, PerformedBy = "POS", Note = "Trừ kho tự động theo hóa đơn HD0039" },
                new InventoryTransaction { TransactionId = "TX003", IngredientId = "NL001", DisplayTime = "22/10 16:30", TransactionType = "Xuất hủy (ẩm mốc)", Quantity = -500, BalanceAfter = 1280, PerformedBy = "Nguyễn Văn Hưng", Note = "Hạt cà phê bị ẩm mốc do túi thủng" },
                new InventoryTransaction { TransactionId = "TX004", IngredientId = "NL001", DisplayTime = "22/10 09:00", TransactionType = "Nhập kho", Quantity = 1500, BalanceAfter = 1780, PerformedBy = "Nguyễn Văn Hưng", Note = "Nhập hàng định kỳ NCC Cầu Đất Farm" },

                new InventoryTransaction { TransactionId = "TX005", IngredientId = "NL014", DisplayTime = "11:15 hôm nay", TransactionType = "Bán hàng", Quantity = -1, BalanceAfter = 4, PerformedBy = "POS", Note = "Trừ kho quầy Bar" },
                new InventoryTransaction { TransactionId = "TX006", IngredientId = "NL014", DisplayTime = "20/10 10:00", TransactionType = "Nhập kho", Quantity = 12, BalanceAfter = 16, PerformedBy = "Nguyễn Văn Hưng", Note = "Nhập từ NPP Vinamilk" },

                new InventoryTransaction { TransactionId = "TX007", IngredientId = "NL022", DisplayTime = "10:00 hôm nay", TransactionType = "Bán hàng", Quantity = -50, BalanceAfter = 300, PerformedBy = "POS", Note = "Pha trà Phúc Long" },

                new InventoryTransaction { TransactionId = "TX008", IngredientId = "NL005", DisplayTime = "Hôm qua 18:00", TransactionType = "Bán hàng", Quantity = -2, BalanceAfter = 0, PerformedBy = "POS", Note = "Đã hết sữa tươi Barista" },

                new InventoryTransaction { TransactionId = "TX009", IngredientId = "NL008", DisplayTime = "21/10 14:00", TransactionType = "Bán hàng", Quantity = -2, BalanceAfter = 15, PerformedBy = "POS", Note = "Pha chế siro đường" },

                new InventoryTransaction { TransactionId = "TX010", IngredientId = "NL018", DisplayTime = "19/10 09:30", TransactionType = "Nhập kho", Quantity = 10, BalanceAfter = 10, PerformedBy = "Nguyễn Văn Hưng", Note = "Nhập đào Kronos" }
            };
        }
        #endregion

        #region 3. Khởi tạo Món & Công thức BOM (Đúng 100% Mockup M01 & Quy chuẩn mã mới)
        private void KhoiTaoDuLieuMonVaBOM()
        {
            // Nhóm DM01 - Cà phê truyền thống (CF01 - CF06)
            Image imgCF01 = TaoHinhMinhHoa("CF01", "Cà Phê Đen", ColorTranslator.FromHtml("#4A3222"), Color.White);
            Image imgCF02 = TaoHinhMinhHoa("CF02", "Cà Phê Sữa", ColorTranslator.FromHtml("#6F4E37"), ColorTranslator.FromHtml("#F5ECE4"));
            Image imgCF03 = TaoHinhMinhHoa("CF03", "Bạc Xỉu Dừa", ColorTranslator.FromHtml("#D4A373"), Color.White);
            Image imgCF04 = TaoHinhMinhHoa("CF04", "Cà Phê Muối", ColorTranslator.FromHtml("#8C6239"), Color.White);
            Image imgCF05 = TaoHinhMinhHoa("CF05", "Cà Phê Trứng", ColorTranslator.FromHtml("#C8963E"), Color.White);
            Image imgCF06 = TaoHinhMinhHoa("CF06", "Cà Phê Dừa", ColorTranslator.FromHtml("#6F4E37"), Color.White);

            // Nhóm DM02 - Cà phê pha máy (PM01 - PM05)
            Image imgPM01 = TaoHinhMinhHoa("PM01", "Espresso", ColorTranslator.FromHtml("#382213"), ColorTranslator.FromHtml("#E9C46A"));

            // Nhóm DM03 - Trà trái cây nhiệt đới (TE01 - TE05)
            Image imgTE01 = TaoHinhMinhHoa("TE01", "Trà Đào Cam Sả", ColorTranslator.FromHtml("#E76F51"), ColorTranslator.FromHtml("#FFF3E0"));

            // Nhóm DM06 - Bánh tươi & Ăn nhẹ (BK01 - BK02)
            Image imgBK01 = TaoHinhMinhHoa("BK01", "Croissant Bơ", ColorTranslator.FromHtml("#E09F3E"), ColorTranslator.FromHtml("#FFF9E6"));
            Image imgBK02 = TaoHinhMinhHoa("BK02", "Cheesecake", ColorTranslator.FromHtml("#8338EC"), ColorTranslator.FromHtml("#EDE0D4"));

            // 1. CF01 - Cà phê đen đá phin truyền thống
            Mon monCF01 = new Mon
            {
                MaMon = "CF01",
                TenMon = "Cà phê đen đá phin truyền thống",
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                GiaBan = 29000,
                GiaVonBOM = 8500,
                MoTa = "Cà phê Robusta nguyên chất pha phin giọt chậm, đậm đà sánh quyện hương vị mộc mạc nguyên bản.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgCF01
            };
            List<DinhLuongBOM> bomCF01 = new List<DinhLuongBOM>
            {
                new DinhLuongBOM { MaMon = "CF01", MaNL = "NL001", TenNL = "Hạt Cà Phê LTTQ Blend Robusta/Arabica", ViTriKho = "Kho mát quầy Bar", DinhLuong = 25, DVT = "gram (g)", DonGiaQuyDoi = 260m },
                new DinhLuongBOM { MaMon = "CF01", MaNL = "NL008", TenNL = "Đá viên tinh khiết lọc RO", ViTriKho = "Thùng đá Barista", DinhLuong = 150, DVT = "gram (g)", DonGiaQuyDoi = 3.333m },
                new DinhLuongBOM { MaMon = "CF01", MaNL = "NL020", TenNL = "Ly giấy / Ly nhựa nắp cầu LTTQ Cafe kèm ống hút", ViTriKho = "Kệ bao bì mang về", DinhLuong = 1, DVT = "cái (set)", DonGiaQuyDoi = 2000m }
            };

            // 2. CF02 - Cà phê sữa phin truyền thống (Món tiêu điểm trong mockup)
            Mon monCF02 = new Mon
            {
                MaMon = "CF02",
                TenMon = "Cà phê sữa phin truyền thống",
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                GiaBan = 35000,
                GiaVonBOM = 11200,
                MoTa = "Cà phê Robusta Đắk Lắk nguyên chất pha phin thủ công, hòa quyện sữa đặc thơm béo ngậy. Định lượng đá chuẩn 150g.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgCF02
            };
            List<DinhLuongBOM> bomCF02 = new List<DinhLuongBOM>
            {
                new DinhLuongBOM { MaMon = "CF02", MaNL = "NL001", TenNL = "Hạt Cà Phê LTTQ Blend Robusta/Arabica", ViTriKho = "Kho mát quầy Bar", DinhLuong = 20, DVT = "gram (g)", DonGiaQuyDoi = 260m },
                new DinhLuongBOM { MaMon = "CF02", MaNL = "NL014", TenNL = "Sữa đặc có đường Phương Nam (Hộp xanh)", ViTriKho = "Tủ trữ sữa quầy Bar", DinhLuong = 30, DVT = "mililit (ml)", DonGiaQuyDoi = 116.67m },
                new DinhLuongBOM { MaMon = "CF02", MaNL = "NL008", TenNL = "Đá viên tinh khiết lọc RO", ViTriKho = "Thùng đá Barista", DinhLuong = 150, DVT = "gram (g)", DonGiaQuyDoi = 3.333m },
                new DinhLuongBOM { MaMon = "CF02", MaNL = "NL020", TenNL = "Ly giấy / Ly nhựa nắp cầu LTTQ Cafe kèm ống hút", ViTriKho = "Kệ bao bì mang về", DinhLuong = 1, DVT = "cái (set)", DonGiaQuyDoi = 2000m }
            };

            // 3. CF03 - Bạc xỉu LTTQ cốt dừa thơm
            Mon monCF03 = new Mon
            {
                MaMon = "CF03",
                TenMon = "Bạc xỉu LTTQ cốt dừa thơm",
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                GiaBan = 39000,
                GiaVonBOM = 12500,
                MoTa = "Cà phê phin thơm lừng kết hợp sữa đặc, sữa tươi Dalat Milk và lớp cốt dừa tươi béo ngậy chuẩn vị Sài Gòn.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgCF03
            };
            List<DinhLuongBOM> bomCF03 = new List<DinhLuongBOM>
            {
                new DinhLuongBOM { MaMon = "CF03", MaNL = "NL001", TenNL = "Hạt Cà Phê LTTQ Blend Robusta/Arabica", ViTriKho = "Kho mát quầy Bar", DinhLuong = 15, DVT = "gram (g)", DonGiaQuyDoi = 260m },
                new DinhLuongBOM { MaMon = "CF03", MaNL = "NL014", TenNL = "Sữa đặc có đường Phương Nam (Hộp xanh)", ViTriKho = "Tủ trữ sữa quầy Bar", DinhLuong = 25, DVT = "mililit (ml)", DonGiaQuyDoi = 116.67m },
                new DinhLuongBOM { MaMon = "CF03", MaNL = "NL015", TenNL = "Sữa tươi thanh trùng Dalat Milk không đường", ViTriKho = "Tủ trữ sữa quầy Bar", DinhLuong = 60, DVT = "mililit (ml)", DonGiaQuyDoi = 36.67m },
                new DinhLuongBOM { MaMon = "CF03", MaNL = "NL016", TenNL = "Nước cốt dừa tươi nguyên chất Bến Tre", ViTriKho = "Tủ mát quầy Bar", DinhLuong = 20, DVT = "mililit (ml)", DonGiaQuyDoi = 75m },
                new DinhLuongBOM { MaMon = "CF03", MaNL = "NL020", TenNL = "Ly giấy / Ly nhựa nắp cầu LTTQ Cafe kèm ống hút", ViTriKho = "Kệ bao bì mang về", DinhLuong = 1, DVT = "cái (set)", DonGiaQuyDoi = 2000m }
            };

            // 4. CF04 - Cà phê muối kem béo Cố Đô
            Mon monCF04 = new Mon
            {
                MaMon = "CF04",
                TenMon = "Cà phê muối kem béo Cố Đô",
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                GiaBan = 38000,
                GiaVonBOM = 12000,
                MoTa = "Lớp kem muối béo nhẹ mặn mà hòa quyện cùng cốt cà phê Robusta đậm đặc.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgCF04
            };

            // 5. CF05 - Cà phê trứng béo ngậy Hà Nội
            Mon monCF05 = new Mon
            {
                MaMon = "CF05",
                TenMon = "Cà phê trứng béo ngậy Hà Nội",
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                GiaBan = 45000,
                GiaVonBOM = 14500,
                MoTa = "Kem trứng bông mịn đánh tươi mịn màng quyện cùng vị đắng dịu của phin cà phê nóng.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgCF05
            };

            // 6. CF06 - Cà phê dừa xay tuyết mát lạnh
            Mon monCF06 = new Mon
            {
                MaMon = "CF06",
                TenMon = "Cà phê dừa xay tuyết mát lạnh",
                MaDanhMuc = "DM01",
                TenDanhMuc = "Cà phê truyền thống",
                GiaBan = 42000,
                GiaVonBOM = 13000,
                MoTa = "Cốt dừa Bến Tre xay nhuyễn mát lạnh cùng đá tuyết RO rưới đều shot cà phê thơm lừng.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgCF06
            };

            // 7. PM01 - Espresso đúp (Double Shot) (Mã mới PM01 - Cà phê pha máy)
            Mon monPM01 = new Mon
            {
                MaMon = "PM01",
                TenMon = "Espresso đúp (Double Shot)",
                MaDanhMuc = "DM02",
                TenDanhMuc = "Cà phê pha máy",
                GiaBan = 35000,
                GiaVonBOM = 8500,
                MoTa = "2 shot Espresso chiết xuất từ hạt Arabica Cầu Đất nguyên chất, lớp Crema vàng óng dày dặn.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgPM01
            };
            List<DinhLuongBOM> bomPM01 = new List<DinhLuongBOM>
            {
                new DinhLuongBOM { MaMon = "PM01", MaNL = "NL002", TenNL = "Hạt Cà Phê Arabica Cầu Đất Typica", ViTriKho = "Kho mát quầy Bar", DinhLuong = 18, DVT = "gram (g)", DonGiaQuyDoi = 420m },
                new DinhLuongBOM { MaMon = "PM01", MaNL = "NL020", TenNL = "Ly giấy / Ly nhựa nắp cầu LTTQ Cafe kèm ống hút", ViTriKho = "Kệ bao bì mang về", DinhLuong = 1, DVT = "cái (set)", DonGiaQuyDoi = 2000m }
            };

            // 8. TE01 - Trà đào cam sả hạt chia
            Mon monTE01 = new Mon
            {
                MaMon = "TE01",
                TenMon = "Trà đào cam sả hạt chia",
                MaDanhMuc = "DM03",
                TenDanhMuc = "Trà trái cây nhiệt đới",
                GiaBan = 42000,
                GiaVonBOM = 13800,
                MoTa = "Trà đào thanh ngọt kết hợp vị chua dịu của cam tươi, hương thơm nồng nàn từ sả và giòn bùi của hạt chia.",
                TrangThai = "Đang bán",
                CoDinhLuong = true,
                HinhAnh = imgTE01
            };
            List<DinhLuongBOM> bomTE01 = new List<DinhLuongBOM>
            {
                new DinhLuongBOM { MaMon = "TE01", MaNL = "NL026", TenNL = "Trà túi lọc Ceylon Earl Grey cao cấp", ViTriKho = "Kệ trà & syrup", DinhLuong = 1, DVT = "gói", DonGiaQuyDoi = 3200m },
                new DinhLuongBOM { MaMon = "TE01", MaNL = "NL025", TenNL = "Đào ngâm Kronos miếng giòn", ViTriKho = "Kệ nguyên liệu Bar", DinhLuong = 2, DVT = "miếng", DonGiaQuyDoi = 2500m },
                new DinhLuongBOM { MaMon = "TE01", MaNL = "NL027", TenNL = "Cam vàng Navel tươi mọng nước", ViTriKho = "Tủ mát trái cây", DinhLuong = 2, DVT = "lát", DonGiaQuyDoi = 1800m },
                new DinhLuongBOM { MaMon = "TE01", MaNL = "NL028", TenNL = "Hạt chia hữu cơ Úc sấy thăng hoa", ViTriKho = "Kệ topping", DinhLuong = 15, DVT = "gram (g)", DonGiaQuyDoi = 130m },
                new DinhLuongBOM { MaMon = "TE01", MaNL = "NL020", TenNL = "Ly giấy / Ly nhựa nắp cầu LTTQ Cafe kèm ống hút", ViTriKho = "Kệ bao bì mang về", DinhLuong = 1, DVT = "cái (set)", DonGiaQuyDoi = 2000m }
            };

            // 9. BK01 - Bánh sừng bò Croissant bơ tỏi
            Mon monBK01 = new Mon
            {
                MaMon = "BK01",
                TenMon = "Bánh sừng bò Croissant bơ tỏi",
                MaDanhMuc = "DM06",
                TenDanhMuc = "Bánh tươi & Ăn nhẹ",
                GiaBan = 32000,
                GiaVonBOM = 0,
                MoTa = "Bánh nướng nóng giòn vỏ ngàn lớp xốp rụm, quyện mùi bơ Pháp thơm lừng và sốt tỏi thảo mộc.",
                TrangThai = "Đang bán",
                CoDinhLuong = false,
                HinhAnh = imgBK01
            };

            // 10. BK02 - Bánh phô mai việt quất New York (Trạng thái: Tạm ngưng)
            Mon monBK02 = new Mon
            {
                MaMon = "BK02",
                TenMon = "Bánh phô mai việt quất New York",
                MaDanhMuc = "DM06",
                TenDanhMuc = "Bánh tươi & Ăn nhẹ",
                GiaBan = 42000,
                GiaVonBOM = 15000,
                MoTa = "Cheesecake phong cách New York béo ngậy, phủ mứt việt quất chua ngọt đậm đà hảo hạng.",
                TrangThai = "Tạm ngưng",
                CoDinhLuong = true,
                HinhAnh = imgBK02
            };
            List<DinhLuongBOM> bomBK02 = new List<DinhLuongBOM>
            {
                new DinhLuongBOM { MaMon = "BK02", MaNL = "NL035", TenNL = "Bột phô mai New York Cream Cheese", ViTriKho = "Tủ mát bánh", DinhLuong = 50, DVT = "gram (g)", DonGiaQuyDoi = 300m }
            };

            // Thêm vào danh sách chính
            DanhSachMon = new List<Mon>
            {
                monCF01, monCF02, monCF03, monCF04, monCF05, monCF06,
                monPM01,
                monTE01,
                monBK01, monBK02
            };

            // Thêm các món phụ nhóm PM (PM02..PM05) và TE (TE02..TE05)
            ThemCacMonMauPhu();

            // Sắp xếp danh sách mặc định theo thứ tự danh mục và mã món
            DanhSachMon = DanhSachMon.OrderBy(m => m.MaDanhMuc).ThenBy(m => m.MaMon).ToList();

            // Lưu mapping BOM
            DinhLuongMap["CF01"] = bomCF01;
            DinhLuongMap["CF02"] = bomCF02;
            DinhLuongMap["CF03"] = bomCF03;
            DinhLuongMap["CF04"] = new List<DinhLuongBOM>();
            DinhLuongMap["CF05"] = new List<DinhLuongBOM>();
            DinhLuongMap["CF06"] = new List<DinhLuongBOM>();
            DinhLuongMap["PM01"] = bomPM01;
            DinhLuongMap["TE01"] = bomTE01;
            DinhLuongMap["BK01"] = new List<DinhLuongBOM>();
            DinhLuongMap["BK02"] = bomBK02;
        }

        private void ThemCacMonMauPhu()
        {
            // Nhóm Cà phê pha máy: PM02 -> PM05
            string[] tenMonPhaMay = { "Cappuccino Ý hạt dẻ", "Latte Vani ngọt dịu", "Americano đá mát lạnh", "Caramel Macchiato" };
            for (int i = 0; i < tenMonPhaMay.Length; i++)
            {
                string ma = $"PM{2 + i:D2}";
                Image img = TaoHinhMinhHoa(ma, tenMonPhaMay[i], ColorTranslator.FromHtml("#4A3222"), Color.White);
                DanhSachMon.Add(new Mon
                {
                    MaMon = ma,
                    TenMon = tenMonPhaMay[i],
                    MaDanhMuc = "DM02",
                    TenDanhMuc = "Cà phê pha máy",
                    GiaBan = 38000 + i * 4000,
                    GiaVonBOM = 12000 + i * 1500,
                    MoTa = "Hương vị cà phê chuẩn gu quốc tế chiết xuất từ máy Espresso cao cấp.",
                    TrangThai = i == 2 ? "Tạm ngưng" : "Đang bán",
                    CoDinhLuong = true,
                    HinhAnh = img
                });
                DinhLuongMap[ma] = new List<DinhLuongBOM>();
            }

            // Nhóm Trà trái cây nhiệt đới: TE02 -> TE05
            string[] tenTra = { "Trà vải hoa hồng tuyết", "Trà dưa lưới nha đam", "Trà mãng cầu xiêm", "Trà ổi hồng muối ớt" };
            for (int i = 0; i < tenTra.Length; i++)
            {
                string ma = $"TE{2 + i:D2}";
                Image img = TaoHinhMinhHoa(ma, tenTra[i], ColorTranslator.FromHtml("#E76F51"), Color.White);
                DanhSachMon.Add(new Mon
                {
                    MaMon = ma,
                    TenMon = tenTra[i],
                    MaDanhMuc = "DM03",
                    TenDanhMuc = "Trà trái cây nhiệt đới",
                    GiaBan = 40000 + i * 2000,
                    GiaVonBOM = 13000 + i * 1000,
                    MoTa = "Trái cây tươi ngâm trong ngày, giàu vitamin, thanh nhiệt sảng khoái.",
                    TrangThai = i == 1 ? "Tạm ngưng" : "Đang bán",
                    CoDinhLuong = true,
                    HinhAnh = img
                });
                DinhLuongMap[ma] = new List<DinhLuongBOM>();
            }
        }

        /// <summary>
        /// Tự sắp số mã sản phẩm theo thứ tự chuẩn POS:
        /// - Khi chưa có món nào của tiền tố prefix -> xx01
        /// - Khi đã có sẵn 6 món -> xx07 (hoặc số lớn nhất + 1)
        /// </summary>
        public string SinhMaMonTuDong(string prefix)
        {
            int maxSo = 0;
            int count = 0;
            foreach (var mon in DanhSachMon)
            {
                if (mon.MaMon.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                    string soStr = mon.MaMon.Substring(prefix.Length);
                    if (int.TryParse(soStr, out int so) && so > maxSo)
                    {
                        maxSo = so;
                    }
                }
            }

            int tiepTheo = Math.Max(count, maxSo) + 1;
            return $"{prefix}{tiepTheo:D2}";
        }
        #endregion

        #region 4. Helper Tạo Ảnh Minh Họa GDI+ Chuyên Nghiệp
        public Image TaoHinhMinhHoa(string maMon, string tenMon, Color mauNen, Color mauChu)
        {
            int size = 200;
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // Nền gradient
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    new Rectangle(0, 0, size, size),
                    mauNen,
                    Color.FromArgb(220, mauNen),
                    LinearGradientMode.ForwardDiagonal))
                {
                    g.FillRectangle(brush, 0, 0, size, size);
                }

                // Vẽ vòng tròn trang trí
                using (Pen circlePen = new Pen(Color.FromArgb(40, Color.White), 2f))
                {
                    g.DrawEllipse(circlePen, 15, 15, size - 30, size - 30);
                    g.DrawEllipse(circlePen, 35, 35, size - 70, size - 70);
                }

                // Vẽ icon tách cà phê
                using (SolidBrush iconBrush = new SolidBrush(Color.FromArgb(200, Color.White)))
                {
                    // Thân tách
                    g.FillRectangle(iconBrush, 70, 75, 60, 45);
                    // Quai tách
                    using (Pen quaiPen = new Pen(Color.FromArgb(200, Color.White), 4f))
                    {
                        g.DrawArc(quaiPen, 115, 80, 26, 30, 270, 180);
                    }
                    // Đĩa lót
                    g.FillRectangle(iconBrush, 60, 122, 80, 6);
                }

                // Vẽ Mã món & Tên món vắn tắt
                using (Font fontCode = new Font("Segoe UI", 12f, FontStyle.Bold))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString(maMon, fontCode, textBrush, new RectangleF(0, 135, size, 30), sf);
                }
            }
            return bmp;
        }
        #endregion

        #region 5. Mẫu Code Truy Vấn SQL Server ADO.NET (Sẵn sàng gắn DB thực tế)
        /*
        ========================================================================================
        HƯỚNG DẪN KẾT NỐI DATABASE SQL SERVER BẰNG ADO.NET CHO ĐỒ ÁN IT008
        ----------------------------------------------------------------------------------------
        1. Chuỗi kết nối mẫu (Connection String):
           private readonly string _connectionString = 
               @"Data Source=localhost;Initial Catalog=DoAnLapTrinhTrucQuanDB;Integrated Security=True;TrustServerCertificate=True;";

        2. Lấy danh sách Món kèm Danh mục (M01):
           public DataTable LayDanhSachMonTuDatabase()
           {
               DataTable dt = new DataTable();
               string query = @"
                   SELECT m.MaMon, m.TenMon, m.MaDanhMuc, dm.TenDanhMuc, m.GiaBan, m.GiaVonBOM, 
                          m.MoTa, m.TrangThai, m.CoDinhLuong, m.HinhAnhPath
                   FROM Mon m
                   INNER JOIN DanhMuc dm ON m.MaDanhMuc = dm.MaDanhMuc
                   ORDER BY m.MaMon ASC";

               using (SqlConnection conn = new SqlConnection(_connectionString))
               using (SqlCommand cmd = new SqlCommand(query, conn))
               using (SqlDataAdapter da = new SqlDataAdapter(cmd))
               {
                   conn.Open();
                   da.Fill(dt);
               }
               return dt;
           }

        3. Lấy Bảng Định Lượng (BOM) theo Mã món (M01):
           public DataTable LayDinhLuongBOMTuDatabase(string maMon)
           {
               DataTable dt = new DataTable();
               string query = @"
                   SELECT b.MaNL, nl.TenNL, nl.ViTriKho, b.DinhLuong, b.DVT, 
                          b.DonGiaQuyDoi, (b.DinhLuong * b.DonGiaQuyDoi) AS ThanhTienGiaVon
                   FROM DinhLuongBOM b
                   INNER JOIN NguyenLieu nl ON b.MaNL = nl.MaNL
                   WHERE b.MaMon = @MaMon";

               using (SqlConnection conn = new SqlConnection(_connectionString))
               using (SqlCommand cmd = new SqlCommand(query, conn))
               {
                   cmd.Parameters.AddWithValue("@MaMon", maMon);
                   using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                   {
                       conn.Open();
                       da.Fill(dt);
                   }
               }
               return dt;
           }

        4. Cập nhật thông tin món & Giá vốn BOM (M01):
           public bool CapNhatThongTinMon(Mon mon)
           {
               string query = @"
                   UPDATE Mon 
                   SET TenMon = @TenMon, MaDanhMuc = @MaDanhMuc, GiaBan = @GiaBan, 
                       GiaVonBOM = @GiaVonBOM, MoTa = @MoTa, TrangThai = @TrangThai
                   WHERE MaMon = @MaMon";

               using (SqlConnection conn = new SqlConnection(_connectionString))
               using (SqlCommand cmd = new SqlCommand(query, conn))
               {
                   cmd.Parameters.AddWithValue("@MaMon", mon.MaMon);
                   cmd.Parameters.AddWithValue("@TenMon", mon.TenMon);
                   cmd.Parameters.AddWithValue("@MaDanhMuc", mon.MaDanhMuc);
                   cmd.Parameters.AddWithValue("@GiaBan", mon.GiaBan);
                   cmd.Parameters.AddWithValue("@GiaVonBOM", mon.GiaVonBOM);
                   cmd.Parameters.AddWithValue("@MoTa", mon.MoTa);
                   cmd.Parameters.AddWithValue("@TrangThai", mon.TrangThai);

                   conn.Open();
                   return cmd.ExecuteNonQuery() > 0;
               }
           }

        5. Lưu danh sách Định lượng BOM khi người dùng sửa định lượng:
           public void LuuDinhLuongBOM(string maMon, List<DinhLuongBOM> bomList)
           {
               using (SqlConnection conn = new SqlConnection(_connectionString))
               {
                   conn.Open();
                   using (SqlTransaction trans = conn.BeginTransaction())
                   {
                       try
                       {
                           // Xóa định lượng cũ
                           using (SqlCommand cmdDel = new SqlCommand("DELETE FROM DinhLuongBOM WHERE MaMon = @MaMon", conn, trans))
                           {
                               cmdDel.Parameters.AddWithValue("@MaMon", maMon);
                               cmdDel.ExecuteNonQuery();
                           }

                           // Chèn định lượng mới
                           string sqlInsert = @"
                               INSERT INTO DinhLuongBOM (MaMon, MaNL, DinhLuong, DVT, DonGiaQuyDoi) 
                               VALUES (@MaMon, @MaNL, @DinhLuong, @DVT, @DonGiaQuyDoi)";

                           foreach (var item in bomList)
                           {
                               using (SqlCommand cmdIns = new SqlCommand(sqlInsert, conn, trans))
                               {
                                   cmdIns.Parameters.AddWithValue("@MaMon", maMon);
                                   cmdIns.Parameters.AddWithValue("@MaNL", item.MaNL);
                                   cmdIns.Parameters.AddWithValue("@DinhLuong", item.DinhLuong);
                                   cmdIns.Parameters.AddWithValue("@DVT", item.DVT);
                                   cmdIns.Parameters.AddWithValue("@DonGiaQuyDoi", item.DonGiaQuyDoi);
                                   cmdIns.ExecuteNonQuery();
                               }
                           }

                           trans.Commit();
                       }
                       catch
                       {
                           trans.Rollback();
                           throw;
                       }
                   }
               }
           }
        ========================================================================================
        */
        #endregion

        #region 5. Khởi tạo Dữ liệu Voucher & Khuyến mãi (Module M04)
        private void KhoiTaoDuLieuVoucher()
        {
            DanhSachVoucher = new List<Voucher>
            {
                // 1. MOC10 - Đang hiệu lực
                new Voucher
                {
                    MaVoucher = "MOC10",
                    TenChuongTrinh = "Ưu đãi giờ vàng Mộc Café - Giảm 10%",
                    LichTrinhText = "01/10 - 31/10/2024",
                    LoaiGiamGia = "PhanTram",
                    GiaTriGiam = 10,
                    GiamToiDa = 30000,
                    DonToiThieu = 100000,
                    PhamVi = "Tất cả",
                    NgayBatDau = new DateTime(2024, 10, 1, 7, 0, 0),
                    NgayKetThuc = new DateTime(2024, 10, 31, 23, 59, 0),
                    TongLuotPhatHanh = 200,
                    DaDung = 68,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Đang hiệu lực",
                    KichHoat = true,
                    GhiChu = "Áp dụng cho mọi hóa đơn ăn uống đạt từ 100.000đ. Không áp dụng đồng thời với các combo giảm giá khác."
                },

                // 2. CHAOBANMOI - Đang hiệu lực
                new Voucher
                {
                    MaVoucher = "CHAOBANMOI",
                    TenChuongTrinh = "Tặng khách hàng mới",
                    LichTrinhText = "01/09 - 31/12/2024",
                    LoaiGiamGia = "TienMat",
                    GiaTriGiam = 20000,
                    GiamToiDa = 0,
                    DonToiThieu = 60000,
                    PhamVi = "Tại quán",
                    NgayBatDau = new DateTime(2024, 9, 1, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 12, 31, 23, 59, 0),
                    TongLuotPhatHanh = 500,
                    DaDung = 142,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Đang hiệu lực",
                    KichHoat = true,
                    GhiChu = "Ưu đãi dành riêng cho khách hàng lần đầu tạo tài khoản thành viên Mộc Café."
                },

                // 3. HAPPYHOUR - Đang hiệu lực (Không giới hạn lượt)
                new Voucher
                {
                    MaVoucher = "HAPPYHOUR",
                    TenChuongTrinh = "Giảm 15% khung 14h-17h",
                    LichTrinhText = "Thứ 2 - Thứ 6 hàng tuần",
                    LoaiGiamGia = "PhanTram",
                    GiaTriGiam = 15,
                    GiamToiDa = 40000,
                    DonToiThieu = 80000,
                    PhamVi = "Tất cả",
                    NgayBatDau = new DateTime(2024, 1, 1, 14, 0, 0),
                    NgayKetThuc = new DateTime(2025, 12, 31, 17, 0, 0),
                    TongLuotPhatHanh = 0,
                    DaDung = 312,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Đang hiệu lực",
                    KichHoat = true,
                    GhiChu = "Chương trình tự động áp dụng trong khung giờ chiều từ 14:00 đến 17:00 các ngày làm việc trong tuần."
                },

                // 4. TRIANKHACHVIP - Sắp diễn ra
                new Voucher
                {
                    MaVoucher = "TRIANKHACHVIP",
                    TenChuongTrinh = "Tri ân khách hàng thân thiết VIP",
                    LichTrinhText = "Bắt đầu từ 20/10/2024",
                    LoaiGiamGia = "TienMat",
                    GiaTriGiam = 25000,
                    GiamToiDa = 0,
                    DonToiThieu = 150000,
                    PhamVi = "Tại quán",
                    NgayBatDau = new DateTime(2024, 10, 20, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 11, 20, 23, 59, 0),
                    TongLuotPhatHanh = 100,
                    DaDung = 0,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Sắp diễn ra",
                    KichHoat = true,
                    GhiChu = "Quà tặng tri ân đặc quyền dành riêng cho khách hàng thân thiết nhân ngày Phụ nữ Việt Nam 20/10."
                },

                // 5. COMBOANTRUA - Hết lượt
                new Voucher
                {
                    MaVoucher = "COMBOANTRUA",
                    TenChuongTrinh = "Ưu đãi Combo Cơm trưa & Nước",
                    LichTrinhText = "Đã kết thúc: 30/09/2024",
                    LoaiGiamGia = "TienMat",
                    GiaTriGiam = 15000,
                    GiamToiDa = 0,
                    DonToiThieu = 75000,
                    PhamVi = "Mang về",
                    NgayBatDau = new DateTime(2024, 9, 1, 11, 0, 0),
                    NgayKetThuc = new DateTime(2024, 9, 30, 13, 30, 0),
                    TongLuotPhatHanh = 100,
                    DaDung = 100,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Hết lượt",
                    KichHoat = false,
                    GhiChu = "Chương trình khuyến mãi combo trưa văn phòng tháng 9 đã phát hết 100/100 lượt."
                },

                // 6. KHUVUC20K - Tạm dừng
                new Voucher
                {
                    MaVoucher = "KHUVUC20K",
                    TenChuongTrinh = "Khai trương khu vườn tầng 2",
                    LichTrinhText = "Đã tạm ngưng bởi Admin",
                    LoaiGiamGia = "TienMat",
                    GiaTriGiam = 20000,
                    GiamToiDa = 0,
                    DonToiThieu = 90000,
                    PhamVi = "Tại quán",
                    NgayBatDau = new DateTime(2024, 10, 5, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 10, 25, 23, 59, 0),
                    TongLuotPhatHanh = 150,
                    DaDung = 24,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Tạm dừng",
                    KichHoat = false,
                    GhiChu = "Tạm ngưng phục vụ do tầng 2 bảo trì hệ thống điều hòa và cây cảnh."
                },

                // 7. FREESHIP5K - Đang hiệu lực
                new Voucher
                {
                    MaVoucher = "FREESHIP5K",
                    TenChuongTrinh = "Trợ giá ship đơn bán kính 3km",
                    LichTrinhText = "01/10 - 15/11/2024",
                    LoaiGiamGia = "TienMat",
                    GiaTriGiam = 15000,
                    GiamToiDa = 0,
                    DonToiThieu = 50000,
                    PhamVi = "Mang về",
                    NgayBatDau = new DateTime(2024, 10, 1, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 11, 15, 23, 59, 0),
                    TongLuotPhatHanh = 200,
                    DaDung = 85,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Đang hiệu lực",
                    KichHoat = true,
                    GhiChu = "Hỗ trợ phí vận chuyển cho khách đặt món mang về qua hotline quán."
                },

                // 8. CUOITUAN20 - Đang hiệu lực
                new Voucher
                {
                    MaVoucher = "CUOITUAN20",
                    TenChuongTrinh = "Bùng nổ tiệc cà phê cuối tuần",
                    LichTrinhText = "Thứ 7 & Chủ nhật hàng tuần",
                    LoaiGiamGia = "PhanTram",
                    GiaTriGiam = 20,
                    GiamToiDa = 50000,
                    DonToiThieu = 120000,
                    PhamVi = "Tất cả",
                    NgayBatDau = new DateTime(2024, 10, 1, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 12, 31, 23, 59, 0),
                    TongLuotPhatHanh = 300,
                    DaDung = 110,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Đang hiệu lực",
                    KichHoat = true,
                    GhiChu = "Áp dụng cho mọi hóa đơn vào các ngày cuối tuần Thứ 7 và Chủ Nhật."
                },

                // 9. HALLOWEEN30 - Sắp diễn ra
                new Voucher
                {
                    MaVoucher = "HALLOWEEN30",
                    TenChuongTrinh = "Lễ hội hóa trang Halloween",
                    LichTrinhText = "Bắt đầu từ 28/10/2024",
                    LoaiGiamGia = "PhanTram",
                    GiaTriGiam = 20,
                    GiamToiDa = 40000,
                    DonToiThieu = 100000,
                    PhamVi = "Tại quán",
                    NgayBatDau = new DateTime(2024, 10, 28, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 11, 2, 23, 59, 0),
                    TongLuotPhatHanh = 250,
                    DaDung = 0,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Sắp diễn ra",
                    KichHoat = true,
                    GhiChu = "Khách hàng diện trang phục hóa trang khi đến quán sẽ được giảm giá trực tiếp."
                },

                // 10. GIANGSINH2024 - Sắp diễn ra
                new Voucher
                {
                    MaVoucher = "GIANGSINH2024",
                    TenChuongTrinh = "Mùa Giáng Sinh an lành",
                    LichTrinhText = "Bắt đầu từ 15/12/2024",
                    LoaiGiamGia = "PhanTram",
                    GiaTriGiam = 15,
                    GiamToiDa = 35000,
                    DonToiThieu = 120000,
                    PhamVi = "Tất cả",
                    NgayBatDau = new DateTime(2024, 12, 15, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 12, 26, 23, 59, 0),
                    TongLuotPhatHanh = 300,
                    DaDung = 0,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Sắp diễn ra",
                    KichHoat = true,
                    GhiChu = "Tặng bánh gừng noel và ưu đãi cho nhóm khách từ 3 người."
                },

                // 11. CHAOMUNG92 - Hết lượt
                new Voucher
                {
                    MaVoucher = "CHAOMUNG92",
                    TenChuongTrinh = "Mừng Đại lễ Quốc Khánh 2/9",
                    LichTrinhText = "Đã kết thúc: 05/09/2024",
                    LoaiGiamGia = "PhanTram",
                    GiaTriGiam = 20,
                    GiamToiDa = 50000,
                    DonToiThieu = 100000,
                    PhamVi = "Tất cả",
                    NgayBatDau = new DateTime(2024, 8, 30, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 9, 5, 23, 59, 0),
                    TongLuotPhatHanh = 300,
                    DaDung = 300,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Hết lượt",
                    KichHoat = false,
                    GhiChu = "Chương trình chào mừng đại lễ 2/9 đã hết 300 lượt sử dụng."
                },

                // 12. TRASUATHU4 - Tạm dừng
                new Voucher
                {
                    MaVoucher = "TRASUATHU4",
                    TenChuongTrinh = "Ngày hội Trà sữa Thứ Tư",
                    LichTrinhText = "Đã tạm ngưng bởi Admin",
                    LoaiGiamGia = "TienMat",
                    GiaTriGiam = 10000,
                    GiamToiDa = 0,
                    DonToiThieu = 40000,
                    PhamVi = "Tất cả",
                    NgayBatDau = new DateTime(2024, 9, 1, 0, 0, 0),
                    NgayKetThuc = new DateTime(2024, 10, 15, 23, 59, 0),
                    TongLuotPhatHanh = 200,
                    DaDung = 45,
                    GioiHanMoiHoaDon = 1,
                    TrangThai = "Tạm dừng",
                    KichHoat = false,
                    GhiChu = "Tạm ngưng chương trình để điều chỉnh công thức pha chế nhóm trà sữa."
                }
            };
        }

        public string SinhMaVoucherTuDong()
        {
            string prefix = "KM";
            int maxSo = 0;
            foreach (var v in DanhSachVoucher)
            {
                if (v.MaVoucher.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    string soStr = v.MaVoucher.Substring(prefix.Length);
                    if (int.TryParse(soStr, out int so) && so > maxSo)
                    {
                        maxSo = so;
                    }
                }
            }
            return $"{prefix}{maxSo + 1:D2}";
        }
        #endregion

        #region 6. Thao tác Quản lý Kho & Lịch sử Nhập / Xuất (Thẻ kho M02)
        public List<Ingredient> LayTatCaNguyenLieu()
        {
            return DanhSachNguyenLieu.Cast<Ingredient>().ToList();
        }

        public List<InventoryTransaction> LayLichSuTheoMaNL(string maNL)
        {
            return DanhSachLichSuKho
                .Where(x => x.IngredientId.Equals(maNL, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void GhiNhanNhapKho(string maNL, decimal soLuong, decimal donGia, string ghiChu, string nguoiThucHien)
        {
            var item = DanhSachNguyenLieu.FirstOrDefault(x => x.MaNL.Equals(maNL, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.TonKhoHienTai += soLuong;
                if (donGia > 0) item.DonGiaNhap = donGia;

                string timeDisplay = DateTime.Now.ToString("HH:mm") + " hôm nay";
                var tx = new InventoryTransaction
                {
                    TransactionId = "TX" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    IngredientId = maNL,
                    TransactionTime = DateTime.Now,
                    DisplayTime = timeDisplay,
                    TransactionType = "Nhập kho",
                    Quantity = soLuong,
                    BalanceAfter = item.TonKhoHienTai,
                    PerformedBy = string.IsNullOrWhiteSpace(nguoiThucHien) ? "Nguyễn Văn Hưng" : nguoiThucHien,
                    Note = ghiChu
                };
                DanhSachLichSuKho.Insert(0, tx);
            }
        }

        public void GhiNhanXuatKho(string maNL, decimal soLuong, string lyDo, string nguoiThucHien, string ghiChu = "")
        {
            var item = DanhSachNguyenLieu.FirstOrDefault(x => x.MaNL.Equals(maNL, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.TonKhoHienTai -= soLuong;
                if (item.TonKhoHienTai < 0) item.TonKhoHienTai = 0;

                string timeDisplay = DateTime.Now.ToString("HH:mm") + " hôm nay";
                var tx = new InventoryTransaction
                {
                    TransactionId = "TX" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    IngredientId = maNL,
                    TransactionTime = DateTime.Now,
                    DisplayTime = timeDisplay,
                    TransactionType = string.IsNullOrWhiteSpace(lyDo) ? "Xuất hủy" : lyDo,
                    Quantity = -soLuong,
                    BalanceAfter = item.TonKhoHienTai,
                    PerformedBy = string.IsNullOrWhiteSpace(nguoiThucHien) ? "Nguyễn Văn Hưng" : nguoiThucHien,
                    Note = ghiChu
                };
                DanhSachLichSuKho.Insert(0, tx);
            }
        }

        public void CapNhatNguyenLieu(Ingredient updated)
        {
            var item = DanhSachNguyenLieu.FirstOrDefault(x => x.MaNL.Equals(updated.MaNL, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.TenNL = updated.TenNL;
                item.NhomNL = updated.NhomNL;
                item.DVT = updated.DVT;
                item.DonGiaNhap = updated.DonGiaNhap;
                item.DinhMucToiThieu = updated.DinhMucToiThieu;
                item.DangSuDung = updated.DangSuDung;
            }
        }
        #endregion
    }
}


