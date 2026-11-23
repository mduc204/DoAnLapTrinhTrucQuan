/*
========================================================================================
ĐỒ ÁN LẬP TRÌNH TRỰC QUAN (IT008) - HỆ THỐNG POS QUÁN CÀ PHÊ "MỘC CAFÉ"
QUY ƯỚC CODE - LTTQ MANAGEMENT:
- Tên bảng: Số nhiều (Categories, Products, Ingredients, RecipeBOMs, Vouchers, Orders...)
- Tên cột: PascalCase (ProductId, ProductName, CategoryId, Price...)
- Thuộc tính Model trùng tên cột DB
========================================================================================
*/

CREATE DATABASE MocCafeDB;
GO

USE MocCafeDB;
GO

-- =====================================================================================
-- 1. BẢNG DANH MỤC THỰC ĐƠN (Categories)
-- =====================================================================================
CREATE TABLE Categories (
    CategoryId VARCHAR(20) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL,
    DisplayOrder INT DEFAULT 0,
    Status NVARCHAR(30) DEFAULT N'Đang kinh doanh'
);
GO

-- =====================================================================================
-- 2. BẢNG SẢN PHẨM / THỰC ĐƠN MÓN (Products)
-- =====================================================================================
CREATE TABLE Products (
    ProductId VARCHAR(20) PRIMARY KEY,
    ProductName NVARCHAR(150) NOT NULL,
    CategoryId VARCHAR(20) NOT NULL,
    Price DECIMAL(18, 0) NOT NULL,
    CostPrice DECIMAL(18, 0) DEFAULT 0,
    Description NVARCHAR(500),
    ImagePath NVARCHAR(255),
    Status NVARCHAR(30) DEFAULT N'Đang bán',
    HasRecipe BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Products_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);
GO

-- =====================================================================================
-- 3. BẢNG NGUYÊN VẬT LIỆU KHO (Ingredients)
-- =====================================================================================
CREATE TABLE Ingredients (
    IngredientId VARCHAR(20) PRIMARY KEY,
    IngredientName NVARCHAR(150) NOT NULL,
    Unit NVARCHAR(30) NOT NULL,
    ImportPrice DECIMAL(18, 2) NOT NULL,
    StockQuantity DECIMAL(18, 3) DEFAULT 0,
    MinStock DECIMAL(18, 3) DEFAULT 0,
    WarehouseLocation NVARCHAR(100) DEFAULT N'Kho mát quầy Bar',
    StockStatus NVARCHAR(30) DEFAULT N'An toàn'
);
GO

-- =====================================================================================
-- 4. BẢNG ĐỊNH LƯỢNG PHA CHẾ - BOM (RecipeBOMs)
-- =====================================================================================
CREATE TABLE RecipeBOMs (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductId VARCHAR(20) NOT NULL,
    IngredientId VARCHAR(20) NOT NULL,
    Quantity DECIMAL(18, 3) NOT NULL,
    Unit NVARCHAR(30) NOT NULL,
    UnitPrice DECIMAL(18, 2) NOT NULL,
    CostPrice AS (ROUND(Quantity * UnitPrice, 0)),
    Note NVARCHAR(255),
    CONSTRAINT FK_BOM_Products FOREIGN KEY (ProductId) REFERENCES Products(ProductId) ON DELETE CASCADE,
    CONSTRAINT FK_BOM_Ingredients FOREIGN KEY (IngredientId) REFERENCES Ingredients(IngredientId)
);
GO

-- =====================================================================================
-- 5. BẢNG THẺ KHO - BIẾN ĐỘNG NGUYÊN LIỆU (Inventories)
-- =====================================================================================
CREATE TABLE Inventories (
    TransactionId VARCHAR(30) PRIMARY KEY,
    TransactionDate DATETIME DEFAULT GETDATE(),
    IngredientId VARCHAR(20) NOT NULL,
    TransactionType NVARCHAR(50) NOT NULL,
    ChangedQuantity DECIMAL(18, 3) NOT NULL,
    PreviousStock DECIMAL(18, 3) NOT NULL,
    CurrentStock DECIMAL(18, 3) NOT NULL,
    UnitPrice DECIMAL(18, 2) DEFAULT 0,
    TotalAmount DECIMAL(18, 0) DEFAULT 0,
    ReferenceCode VARCHAR(50),
    CreatedBy NVARCHAR(100) DEFAULT N'Nguyễn Văn Hưng',
    Note NVARCHAR(255),
    CONSTRAINT FK_Inventories_Ingredients FOREIGN KEY (IngredientId) REFERENCES Ingredients(IngredientId)
);
GO

-- =====================================================================================
-- 6. BẢNG VOUCHER & CHƯƠNG TRÌNH KHUYẾN MÃI (Vouchers)
-- =====================================================================================
CREATE TABLE Vouchers (
    VoucherCode VARCHAR(30) PRIMARY KEY,
    ProgramName NVARCHAR(150) NOT NULL,
    DiscountType NVARCHAR(30) NOT NULL, -- 'PhanTram' hoặc 'TienMat'
    DiscountValue DECIMAL(18, 2) NOT NULL,
    MaxDiscount DECIMAL(18, 0) DEFAULT 0,
    MinOrder DECIMAL(18, 0) DEFAULT 0,
    Scope NVARCHAR(50) DEFAULT N'Tất cả',
    TotalUsage INT DEFAULT 100,
    UsedCount INT DEFAULT 0,
    LimitPerOrder INT DEFAULT 1,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    Status NVARCHAR(30) DEFAULT N'Đang hiệu lực',
    IsActive BIT DEFAULT 1,
    Note NVARCHAR(500)
);
GO

-- =====================================================================================
-- VIEWS TƯƠNG THÍCH NGƯỢC VỚI TÊN TIẾNG VIỆT
-- =====================================================================================
CREATE OR ALTER VIEW DanhMuc AS
SELECT CategoryId AS MaDanhMuc, CategoryName AS TenDanhMuc, DisplayOrder AS ThuTuHienThi, Status AS TrangThai
FROM Categories;
GO

CREATE OR ALTER VIEW Mon AS
SELECT ProductId AS MaMon, ProductName AS TenMon, CategoryId AS MaDanhMuc, Price AS GiaBan,
       CostPrice AS GiaVonBOM, Description AS MoTa, ImagePath AS HinhAnhPath, Status AS TrangThai,
       HasRecipe AS CoDinhLuong, CreatedAt AS NgayTao
FROM Products;
GO

CREATE OR ALTER VIEW NguyenLieu AS
SELECT IngredientId AS MaNL, IngredientName AS TenNL, Unit AS DVT, ImportPrice AS DonGiaNhap,
       StockQuantity AS TonKhoHienTai, MinStock AS DinhMucToiThieu, WarehouseLocation AS ViTriKho,
       StockStatus AS TrangThaiTonKho
FROM Ingredients;
GO

CREATE OR ALTER VIEW DinhLuongBOM AS
SELECT Id, ProductId AS MaMon, IngredientId AS MaNL, Quantity AS DinhLuong, Unit AS DVT,
       UnitPrice AS DonGiaQuyDoi, CostPrice AS ThanhTienGiaVon, Note AS GhiChu
FROM RecipeBOMs;
GO

CREATE OR ALTER VIEW Voucher_KhuyenMai AS
SELECT VoucherCode AS MaVoucher, ProgramName AS TenVoucher, DiscountType AS LoaiGiamGia,
       DiscountValue AS GiaTriGiam, MaxDiscount AS GiamToiDa, MinOrder AS DonToiThieu,
       Scope AS PhamViApDung, TotalUsage AS TongLuotPhatHanh, UsedCount AS LuotDaDung,
       LimitPerOrder AS LuotDungMoiDon, StartDate AS NgayBatDau, EndDate AS NgayKetThuc,
       Status AS TrangThai
FROM Vouchers;
GO

-- =====================================================================================
-- SEED DATA
-- =====================================================================================
INSERT INTO Categories (CategoryId, CategoryName, DisplayOrder) VALUES
('DM01', N'Cà phê truyền thống', 1),
('DM02', N'Cà phê pha máy', 2),
('DM03', N'Trà trái cây nhiệt đới', 3),
('DM04', N'Trà sữa & Macchiato', 4),
('DM05', N'Đá xay & Sinh tố', 5),
('DM06', N'Bánh tươi & Ăn nhẹ', 6);
GO

INSERT INTO Ingredients (IngredientId, IngredientName, Unit, ImportPrice, StockQuantity, MinStock, WarehouseLocation) VALUES
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
GO

INSERT INTO Products (ProductId, ProductName, CategoryId, Price, CostPrice, Description, Status, HasRecipe) VALUES
('CF02', N'Cà phê sữa phin truyền thống', 'DM01', 35000, 11200, N'Cà phê Robusta Đắk Lắk nguyên chất pha phin thủ công, hòa quyện sữa đặc thơm béo ngậy. Định lượng đá chuẩn 150g.', N'Đang bán', 1),
('CF03', N'Bạc xỉu Mộc cốt dừa thơm', 'DM01', 39000, 12500, N'Cà phê phin thơm lừng kết hợp sữa đặc, sữa tươi và lớp cốt dừa tươi béo ngậy chuẩn vị Sài Gòn.', N'Đang bán', 1),
('TE01', N'Trà đào cam sả hạt chia', 'DM03', 42000, 13800, N'Trà đào thanh ngọt kết hợp vị chua dịu của cam tươi, hương thơm nồng nàn từ sả và giòn bùi của hạt chia.', N'Đang bán', 1),
('CF05', N'Espresso đúp (Double Shot)', 'DM02', 35000, 8500, N'2 shot Espresso chiết xuất từ hạt Arabica Cầu Đất nguyên chất, lớp Crema vàng óng dày dặn.', N'Đang bán', 1),
('BK01', N'Bánh sừng bò Croissant bơ tỏi', 'DM06', 32000, 0, N'Bánh nướng nóng giòn vỏ ngàn lớp xốp rụm, quyện mùi bơ Pháp thơm lừng và sốt tỏi thảo mộc.', N'Đang bán', 0),
('BK02', N'Bánh phô mai việt quất New York', 'DM06', 42000, 15000, N'Cheesecake phong cách New York béo ngậy, phủ mứt việt quất chua ngọt đậm đà.', N'Tạm ngưng', 1);
GO

INSERT INTO RecipeBOMs (ProductId, IngredientId, Quantity, Unit, UnitPrice) VALUES
('CF02', 'NL001', 20, 'gram (g)', 260.00),
('CF02', 'NL014', 30, 'mililit (ml)', 116.67),
('CF02', 'NL008', 150, 'gram (g)', 3.333),
('CF02', 'NL020', 1, 'cái (set)', 2000.00);
GO

INSERT INTO Vouchers (VoucherCode, ProgramName, DiscountType, DiscountValue, MaxDiscount, MinOrder, Scope, TotalUsage, UsedCount, StartDate, EndDate) VALUES
('MOCBANMOI', N'Chào bạn mới - Giảm 20% tối đa 30K', 'PhanTram', 20, 30000, 50000, N'Tất cả', 500, 142, GETDATE(), DATEADD(month, 1, GETDATE())),
('FREESHIP20K', N'Giảm 20K cho đơn mang về từ 80K', 'TienMat', 20000, 0, 80000, N'Mang về', 300, 85, GETDATE(), DATEADD(month, 1, GETDATE()));
GO
