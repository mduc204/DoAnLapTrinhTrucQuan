/*
========================================================================================
ĐỒ ÁN LẬP TRÌNH TRỰC QUAN (IT008) - HỆ THỐNG POS QUÁN CÀ PHÊ "MỘC CAFÉ"
SCRIPT KHỞI TẠO CƠ SỞ DỮ LIỆU CHUẨN THỰC TẾ (KIOTVIET / SAPO FNB / POS365)
----------------------------------------------------------------------------------------
Module phụ trách:
- M01: Quản lý món, Danh mục & Định lượng pha chế (BOM)
- M04: Quản lý Voucher & Khuyến mãi
- M02: Tồn kho, Nhập/Xuất kho & Lịch sử thẻ kho
- M03: Nhập/Xuất Excel nguyên vật liệu
========================================================================================
*/

CREATE DATABASE MocCafeDB;
GO

USE MocCafeDB;
GO

-- =====================================================================================
-- 1. BẢNG DANH MỤC THỰC ĐƠN
-- =====================================================================================
CREATE TABLE DanhMuc (
    MaDanhMuc VARCHAR(20) PRIMARY KEY,
    TenDanhMuc NVARCHAR(100) NOT NULL,
    ThuTuHienThi INT DEFAULT 0,
    TrangThai NVARCHAR(30) DEFAULT N'Đang kinh doanh'
);
GO

-- =====================================================================================
-- 2. BẢNG THỰC ĐƠN MÓN ĂN / THỨC UỐNG (M01)
-- =====================================================================================
CREATE TABLE Mon (
    MaMon VARCHAR(20) PRIMARY KEY,
    TenMon NVARCHAR(150) NOT NULL,
    MaDanhMuc VARCHAR(20) NOT NULL,
    GiaBan DECIMAL(18, 0) NOT NULL,
    GiaVonBOM DECIMAL(18, 0) DEFAULT 0,
    MoTa NVARCHAR(500),
    HinhAnhPath NVARCHAR(255),
    TrangThai NVARCHAR(30) DEFAULT N'Đang bán', -- 'Đang bán', 'Tạm ngưng'
    CoDinhLuong BIT DEFAULT 1,
    NgayTao DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Mon_DanhMuc FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc)
);
GO

-- =====================================================================================
-- 3. BẢNG NGUYÊN VẬT LIỆU KHO (M02, M03)
-- =====================================================================================
CREATE TABLE NguyenLieu (
    MaNL VARCHAR(20) PRIMARY KEY,
    TenNL NVARCHAR(150) NOT NULL,
    DVT NVARCHAR(30) NOT NULL, -- 'gram (g)', 'mililit (ml)', 'cái (set)'
    DonGiaNhap DECIMAL(18, 2) NOT NULL,
    TonKhoHienTai DECIMAL(18, 3) DEFAULT 0,
    DinhMucToiThieu DECIMAL(18, 3) DEFAULT 0,
    ViTriKho NVARCHAR(100) DEFAULT N'Kho mát quầy Bar',
    TrangThaiTonKho NVARCHAR(30) DEFAULT N'An toàn' -- 'An toàn', 'Sắp hết', 'Hết hàng'
);
GO

-- =====================================================================================
-- 4. BẢNG ĐỊNH LƯỢNG PHA CHẾ - BOM (Bill of Materials) (M01)
-- Một ly nước cấu thành từ nhiều nguyên vật liệu với tỷ lệ xác định
-- =====================================================================================
CREATE TABLE DinhLuongBOM (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaMon VARCHAR(20) NOT NULL,
    MaNL VARCHAR(20) NOT NULL,
    DinhLuong DECIMAL(18, 3) NOT NULL, -- Số lượng cần dùng cho 1 ly
    DVT NVARCHAR(30) NOT NULL,
    DonGiaQuyDoi DECIMAL(18, 2) NOT NULL,
    ThanhTienGiaVon AS (ROUND(DinhLuong * DonGiaQuyDoi, 0)),
    GhiChu NVARCHAR(255),
    CONSTRAINT FK_BOM_Mon FOREIGN KEY (MaMon) REFERENCES Mon(MaMon) ON DELETE CASCADE,
    CONSTRAINT FK_BOM_NguyenLieu FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL)
);
GO

-- =====================================================================================
-- 5. BẢNG THẺ KHO - LỊCH SỬ BIẾN ĐỘNG NGUYÊN VẬT LIỆU (M02)
-- Ghi nhận mọi giao dịch: Bán hàng POS trừ tự động, Nhập hàng, Xuất hủy
-- =====================================================================================
CREATE TABLE TheKho (
    MaGiaoDich VARCHAR(30) PRIMARY KEY,
    NgayGiaoDich DATETIME DEFAULT GETDATE(),
    MaNL VARCHAR(20) NOT NULL,
    LoaiGiaoDich NVARCHAR(50) NOT NULL, -- 'Bán hàng POS (Trừ tự động)', 'Nhập hàng', 'Xuất hủy', 'Kiểm kê'
    SoLuongThayDoi DECIMAL(18, 3) NOT NULL, -- Số âm (-) nếu xuất/bán, dương (+) nếu nhập
    TonTruoc DECIMAL(18, 3) NOT NULL,
    TonSau DECIMAL(18, 3) NOT NULL,
    DonGia DECIMAL(18, 2) DEFAULT 0,
    ThanhTien DECIMAL(18, 0) DEFAULT 0,
    MaThamChieu VARCHAR(50), -- Mã hóa đơn POS hoặc mã phiếu nhập
    NguoiThucHien NVARCHAR(100) DEFAULT N'Nguyễn Văn Hưng',
    GhiChu NVARCHAR(255),
    CONSTRAINT FK_TheKho_NguyenLieu FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL)
);
GO

-- =====================================================================================
-- 6. BẢNG VOUCHER & CHƯƠNG TRÌNH KHUYẾN MÃI (M04)
-- Hỗ trợ 2 cơ chế: % có trần giảm tối đa hoặc Tiền mặt cố định
-- =====================================================================================
CREATE TABLE Voucher_KhuyenMai (
    MaVoucher VARCHAR(30) PRIMARY KEY,
    TenVoucher NVARCHAR(150) NOT NULL,
    LoaiGiamGia NVARCHAR(30) NOT NULL, -- 'PhanTram' hoặc 'TienMat'
    GiaTriGiam DECIMAL(18, 2) NOT NULL, -- VD: 20 (% ) hoặc 30000 (VND)
    GiamToiDa DECIMAL(18, 0) DEFAULT 0, -- 0 là không giới hạn
    DonToiThieu DECIMAL(18, 0) DEFAULT 0,
    PhamViApDung NVARCHAR(50) DEFAULT N'Tất cả', -- 'Tại quán', 'Mang về', 'Tất cả'
    TongLuotPhatHanh INT DEFAULT 100,
    LuotDaDung INT DEFAULT 0,
    LuotDungMoiDon INT DEFAULT 1,
    NgayBatDau DATETIME NOT NULL,
    NgayKetThuc DATETIME NOT NULL,
    TrangThai NVARCHAR(30) DEFAULT N'Đang kích hoạt' -- 'Đang kích hoạt', 'Hết hạn', 'Tạm ngưng'
);
GO

-- =====================================================================================
-- TRIGGER TỰ ĐỘNG CẬP NHẬT GIÁ VỐN BOM (COGS) TRONG BẢNG MON
-- Khi thêm / sửa / xóa nguyên liệu BOM, bảng Mon tự động cập nhật tổng giá vốn
-- =====================================================================================
CREATE OR ALTER TRIGGER trg_CapNhatGiaVonMon
ON DinhLuongBOM
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Lấy danh sách các món bị ảnh hưởng
    DECLARE @DanhSachMon TABLE (MaMon VARCHAR(20));
    
    INSERT INTO @DanhSachMon
    SELECT DISTINCT MaMon FROM inserted
    UNION
    SELECT DISTINCT MaMon FROM deleted;

    -- Cập nhật tổng COGS vào bảng Mon
    UPDATE m
    SET m.GiaVonBOM = ISNULL((
        SELECT SUM(ROUND(b.DinhLuong * b.DonGiaQuyDoi, 0))
        FROM DinhLuongBOM b
        WHERE b.MaMon = m.MaMon
    ), 0),
    m.CoDinhLuong = CASE WHEN EXISTS (SELECT 1 FROM DinhLuongBOM b WHERE b.MaMon = m.MaMon) THEN 1 ELSE 0 END
    FROM Mon m
    INNER JOIN @DanhSachMon d ON m.MaMon = d.MaMon;
END;
GO

-- =====================================================================================
-- STORED PROCEDURE: TRỪ KHO NGUYÊN VẬT LIỆU KHI THU NGÂN BÁN HÀNG TẠI MÀN HÌNH POS
-- Tự động bóc tách công thức BOM của món và trừ đúng số lượng trong kho
-- =====================================================================================
CREATE OR ALTER PROCEDURE sp_TruKhoKhiBanHangPOS
    @MaMon VARCHAR(20),
    @SoLuongLy INT,
    @MaHoaDon VARCHAR(50),
    @NguoiBan NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    TRY
        -- Duyệt qua từng nguyên liệu trong công thức BOM của món
        DECLARE @MaNL VARCHAR(20), @DinhLuongMotLy DECIMAL(18,3), @TongCanTru DECIMAL(18,3);
        DECLARE @TonHienTai DECIMAL(18,3), @TonMoi DECIMAL(18,3), @DonGia DECIMAL(18,2);

        DECLARE curBOM CURSOR LOCAL FOR
        SELECT b.MaNL, b.DinhLuong, nl.DonGiaNhap, nl.TonKhoHienTai
        FROM DinhLuongBOM b
        INNER JOIN NguyenLieu nl ON b.MaNL = nl.MaNL
        WHERE b.MaMon = @MaMon;

        OPEN curBOM;
        FETCH NEXT FROM curBOM INTO @MaNL, @DinhLuongMotLy, @DonGia, @TonHienTai;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            SET @TongCanTru = @DinhLuongMotLy * @SoLuongLy;
            SET @TonMoi = @TonHienTai - @TongCanTru;

            -- 1. Trừ kho nguyên liệu
            UPDATE NguyenLieu
            SET TonKhoHienTai = @TonMoi,
                TrangThaiTonKho = CASE 
                    WHEN @TonMoi <= 0 THEN N'Hết hàng'
                    WHEN @TonMoi <= DinhMucToiThieu THEN N'Sắp hết'
                    ELSE N'An toàn'
                END
            WHERE MaNL = @MaNL;

            -- 2. Ghi nhật ký vào Thẻ kho
            DECLARE @MaGiaoDich VARCHAR(30) = 'TK' + CONVERT(VARCHAR(8), GETDATE(), 112) + RIGHT(REPLACE(CONVERT(VARCHAR(12), GETDATE(), 114), ':', ''), 6) + @MaNL;
            INSERT INTO TheKho (MaGiaoDich, NgayGiaoDich, MaNL, LoaiGiaoDich, SoLuongThayDoi, TonTruoc, TonSau, DonGia, ThanhTien, MaThamChieu, NguoiThucHien)
            VALUES (@MaGiaoDich, GETDATE(), @MaNL, N'Bán hàng POS (Trừ tự động)', -@TongCanTru, @TonHienTai, @TonMoi, @DonGia, @TongCanTru * @DonGia, @MaHoaDon, @NguoiBan);

            FETCH NEXT FROM curBOM INTO @MaNL, @DinhLuongMotLy, @DonGia, @TonHienTai;
        END

        CLOSE curBOM;
        DEALLOCATE curBOM;

        COMMIT TRANSACTION;
    CATCH
        IF CURSOR_STATUS('local', 'curBOM') >= 0
        BEGIN
            CLOSE curBOM;
            DEALLOCATE curBOM;
        END
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- =====================================================================================
-- DỮ LIỆU MẪU BAN ĐẦU (SEED DATA ĐÚNG 100% GIAO DIỆN MOCKUP)
-- =====================================================================================
-- 1. Danh mục
INSERT INTO DanhMuc (MaDanhMuc, TenDanhMuc, ThuTuHienThi) VALUES
('DM01', N'Cà phê truyền thống', 1),
('DM02', N'Cà phê pha máy', 2),
('DM03', N'Trà trái cây nhiệt đới', 3),
('DM04', N'Trà sữa & Macchiato', 4),
('DM05', N'Đá xay & Sinh tố', 5),
('DM06', N'Bánh tươi & Ăn nhẹ', 6);

-- 2. Nguyên vật liệu kho
INSERT INTO NguyenLieu (MaNL, TenNL, DVT, DonGiaNhap, TonKhoHienTai, DinhMucToiThieu, ViTriKho) VALUES
('NL001', N'Hạt Cà Phê Mộc Blend Robusta/Arabica', 'gram (g)', 260.00, 15000, 5000, N'Kho mát quầy Bar'),
('NL002', N'Hạt Cà Phê Arabica Cầu Đất Typica', 'gram (g)', 420.00, 8000, 3000, N'Kho mát quầy Bar'),
('NL008', N'Đá viên tinh khiết lọc RO', 'gram (g)', 3.33, 80000, 20000, N'Thùng đá Barista'),
('NL014', N'Sữa đặc có đường Phương Nam (Hộp xanh)', 'mililit (ml)', 116.67, 24000, 6000, N'Tủ trữ sữa quầy Bar'),
('NL015', N'Sữa tươi thanh trùng Dalat Milk', 'mililit (ml)', 36.67, 18000, 4000, N'Tủ trữ sữa quầy Bar'),
('NL016', N'Nước cốt dừa tươi Bến Tre', 'mililit (ml)', 75.00, 5000, 2000, N'Tủ mát quầy Bar'),
('NL020', N'Ly giấy / Ly nhựa nắp cầu Mộc Café kèm ống hút', 'cái (set)', 2000.00, 1200, 300, N'Kệ bao bì mang về'),
('NL025', N'Đào ngâm Kronos miếng giòn', 'miếng', 2500.00, 400, 100, N'Kệ nguyên liệu Bar'),
('NL026', N'Trà túi lọc Ceylon Earl Grey cao cấp', 'gói', 3200.00, 600, 150, N'Kệ trà & syrup'),
('NL027', N'Cam vàng Navel tươi mọng nước', 'lát', 1800.00, 350, 80, N'Tủ mát trái cây'),
('NL028', N'Hạt chia hữu cơ Úc', 'gram (g)', 130.00, 3000, 500, N'Kệ topping'),
('NL035', N'Bột phô mai New York Cream Cheese', 'gram (g)', 300.00, 2500, 600, N'Tủ mát bánh');

-- 3. Món
INSERT INTO Mon (MaMon, TenMon, MaDanhMuc, GiaBan, GiaVonBOM, MoTa, TrangThai, CoDinhLuong) VALUES
('CF02', N'Cà phê sữa phin truyền thống', 'DM01', 35000, 11200, N'Cà phê Robusta Đắk Lắk nguyên chất pha phin thủ công, hòa quyện sữa đặc thơm béo ngậy. Định lượng đá chuẩn 150g.', N'Đang bán', 1),
('CF03', N'Bạc xỉu Mộc cốt dừa thơm', 'DM01', 39000, 12500, N'Cà phê phin thơm lừng kết hợp sữa đặc, sữa tươi và lớp cốt dừa tươi béo ngậy chuẩn vị Sài Gòn.', N'Đang bán', 1),
('TE01', N'Trà đào cam sả hạt chia', 'DM03', 42000, 13800, N'Trà đào thanh ngọt kết hợp vị chua dịu của cam tươi, hương thơm nồng nàn từ sả và giòn bùi của hạt chia.', N'Đang bán', 1),
('CF05', N'Espresso đúp (Double Shot)', 'DM02', 35000, 8500, N'2 shot Espresso chiết xuất từ hạt Arabica Cầu Đất nguyên chất, lớp Crema vàng óng dày dặn.', N'Đang bán', 1),
('BK01', N'Bánh sừng bò Croissant bơ tỏi', 'DM06', 32000, 0, N'Bánh nướng nóng giòn vỏ ngàn lớp xốp rụm, quyện mùi bơ Pháp thơm lừng và sốt tỏi thảo mộc.', N'Đang bán', 0),
('BK02', N'Bánh phô mai việt quất New York', 'DM06', 42000, 15000, N'Cheesecake phong cách New York béo ngậy, phủ mứt việt quất chua ngọt đậm đà.', N'Tạm ngưng', 1);

-- 4. Định lượng BOM (CF02 y hệt mockup)
INSERT INTO DinhLuongBOM (MaMon, MaNL, DinhLuong, DVT, DonGiaQuyDoi) VALUES
('CF02', 'NL001', 20, 'gram (g)', 260.00),     -- 5.200 đ
('CF02', 'NL014', 30, 'mililit (ml)', 116.67), -- 3.500 đ
('CF02', 'NL008', 150, 'gram (g)', 3.333),     --   500 đ
('CF02', 'NL020', 1, 'cái (set)', 2000.00);    -- 2.000 đ
-- Tổng COGS = 5.200 + 3.500 + 500 + 2.000 = 11.200 đ / ly

-- 5. Voucher mẫu (M04)
INSERT INTO Voucher_KhuyenMai (MaVoucher, TenVoucher, LoaiGiamGia, GiaTriGiam, GiamToiDa, DonToiThieu, PhamViApDung, TongLuotPhatHanh, LuotDaDung, NgayBatDau, NgayKetThuc) VALUES
('MOCBANMOI', N'Chào bạn mới - Giảm 20% tối đa 30K', 'PhanTram', 20, 30000, 50000, N'Tất cả', 500, 142, GETDATE(), DATEADD(month, 1, GETDATE())),
('FREESHIP20K', N'Giảm 20K cho đơn mang về từ 80K', 'TienMat', 20000, 0, 80000, N'Mang về', 300, 85, GETDATE(), DATEADD(month, 1, GETDATE()));
GO
