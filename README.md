# ĐỒ ÁN LẬP TRÌNH TRỰC QUAN (IT008)
## HỆ THỐNG POS & QUẢN LÝ QUÁN CAFE (LTTQ CAFE)

> **Nhánh phát triển:** `feature/m01-quanlymon`  
> **Phân hệ (Module M01):** Quản lý Thực đơn (Món) & Định lượng nguyên liệu (BOM - Bill of Materials)  
> **Nền tảng:** C# / .NET 10.0 Windows Forms  

---

## 📌 1. Giới thiệu tổng quan
Hệ thống quản lý quán Cafe **LTTQ Cafe** là ứng dụng desktop Windows Forms được xây dựng phục vụ việc vận hành, bán hàng tại quầy (POS), quản trị kho, thực đơn và khuyến mãi cho quán cafe.

Nhánh **`feature/m01-quanlymon`** tập trung hoàn thiện toàn bộ phân hệ **Quản lý Thực đơn (Món) & Định lượng nguyên liệu (BOM)**, đóng vai trò cốt lõi kết nối giữa khâu Bán hàng (Menu/POS) và Quản lý Kho nguyên liệu.

---

## ✨ 2. Các chức năng chi tiết của Module M01 (`ucQuanLyMon`)

### 📋 2.1. Quản lý danh sách thực đơn
- **Hiển thị trực quan:** Danh sách toàn bộ các món ăn, đồ uống kèm hình ảnh, mã món, danh mục, giá bán niêm yết, giá vốn (COGS) và trạng thái kinh doanh.
- **Tìm kiếm thông minh:** Tìm kiếm nhanh theo tên món hoặc mã món theo thời gian thực.
- **Bộ lọc đa tiêu chí:**
  - Lọc theo **Danh mục** (Cà phê truyền thống, Cà phê pha máy, Trà trái cây nhiệt đới, Bánh tươi & Ăn nhẹ,...).
  - Lọc theo **Trạng thái kinh doanh** (Tất cả, Đang bán, Tạm ngưng).
- **Thống kê tổng quan:** Widget hiển thị tổng số món, số lượng món đang kinh doanh và số món tạm ngưng bán.

### ➕ 2.2. Thêm mới & Chỉnh sửa món (`FormThemMon`)
- Thêm mới món ăn/thức uống với đầy đủ thông tin: Mã món, tên món, nhóm danh mục, đơn vị tính (Ly, Chai, Đĩa,...), giá bán lẻ.
- Tùy chọn tải lên hình ảnh đại diện của món.
- Chỉnh sửa thông tin món và cập nhật thay đổi trực tiếp vào hệ thống.
- Kiểm tra hợp lệ dữ liệu (validation): Ràng buộc giá bán, kiểm tra trùng mã món, trường bắt buộc.

### 🛑 2.3. Quản lý trạng thái kinh doanh
- Bật/tắt trạng thái **Đang bán** hoặc **Tạm ngưng phục vụ** chỉ bằng một cú nhấp (`btnTamNgung`).
- Giao diện tự động thay đổi màu sắc nút bấm và badge trạng thái để nhân viên/quản lý nhận biết tức thì.

### ⚖️ 2.4. Quản lý Định lượng nguyên liệu (BOM - Bill of Materials)
- **Thiết lập công thức chế biến:** Cho phép gắn các thành phần nguyên liệu trong kho vào từng món (`FormChonNguyenLieu`).
- **Định mức thành phần:** Nhập định lượng chi tiết cho từng nguyên liệu (gam cà phê, ml sữa đặc, ml syrup, lát chanh,...).
- **Tự động tính Giá vốn (COGS - Cost of Goods Sold):** Hệ thống lấy đơn giá nhập kho của từng nguyên liệu nhân với định lượng để tính ra giá vốn chính xác của 1 suất/ly.
- **Tính toán Tỷ lệ lãi gộp (% Margin):** Tự động hiển thị tỷ lệ lãi suất dựa trên giá bán và giá vốn BOM, cảnh báo nếu chi phí nguyên liệu vượt ngưỡng.

### 📊 2.5. Xuất báo cáo & Dữ liệu mẫu
- **Xuất file Excel / CSV (`btnXuatExcel`):** Xuất toàn bộ danh sách thực đơn kèm số liệu giá bán, giá vốn và trạng thái kinh doanh ra file CSV chuẩn UTF-8.
- **MockDataService:** Cung cấp sẵn tập dữ liệu phong phú để chạy demo và kiểm thử ngay lập tức mà chưa cần cấu hình database máy chủ.
- **Database Schema:** Cung cấp tệp `Database_Schema.sql` chuẩn hóa quan hệ giữa các bảng `Mon`, `DanhMuc`, `NguyenLieu`, `DinhLuongBOM`, `Voucher`.

---

## 🎨 3. Thiết kế Giao diện & Trải nghiệm (UI/UX)
- Giao diện được thiết kế theo gam màu nâu ấm cafe hiện đại, chuyên nghiệp.
- Thư viện `UIHelper.cs` hỗ trợ vẽ bo góc, hiệu ứng hover, căn lề và định dạng tiền tệ Việt Nam (`#,##0 đ`).
- Hỗ trợ bố cục tự co giãn (Responsive Layout) khi phóng to, thu nhỏ cửa sổ.
- Tích hợp đồng hồ thời gian thực và điều hướng đồng bộ trên `FrmMain`.

---

## 📁 4. Cấu trúc thư mục mã nguồn
```text
DoAnLapTrinhTrucQuan/
├── Data/
│   └── MockDataService.cs          # Dữ liệu giả lập mẫu cho Món, BOM, Nguyên liệu, Voucher
├── Forms/
│   ├── FormThemMon.cs              # Form thêm mới / cập nhật món
│   └── FormChonNguyenLieu.cs       # Form chọn nguyên liệu định lượng từ kho
├── Models/
│   ├── DanhMuc.cs                  # Model Danh mục món
│   ├── DinhLuongBOM.cs             # Model Định lượng nguyên liệu theo món
│   ├── Mon.cs                      # Model Món ăn / Đồ uống
│   ├── NguyenLieu.cs               # Model Nguyên liệu trong kho
│   └── Voucher.cs                  # Model Khuyến mãi / Voucher
├── Properties/
│   ├── Resources.resx              # Resource hình ảnh, icon
│   └── Resources.Designer.cs
├── Resources/                      # Các tài nguyên hình ảnh, logo LTTQ Cafe
├── UserControls/
│   ├── ucQuanLyMon.cs              # UserControl chính Module M01 (Quản lý món & BOM)
│   ├── ucKhuyenMai.cs              # UserControl Khuyến mãi / Voucher
│   ├── ucOtherModules.cs           # UserControl giữ chỗ cho các module khác
│   └── UcS01.cs                    # UserControl bán hàng của thành viên nhóm
├── Database_Schema.sql             # Kịch bản tạo cơ sở dữ liệu SQL Server
├── DoAnLapTrinhTrucQuan.csproj     # Cấu hình project .NET 10.0 Windows Forms
├── DoAnLapTrinhTrucQuan.slnx       # Solution file
├── FrmMain.cs                      # Form chính điều hướng toàn bộ hệ thống
├── Program.cs                      # Điểm khởi chạy ứng dụng (Main Entry Point)
├── UIHelper.cs                     # Bộ tiện ích giao diện, styling, bo tròn, màu sắc
├── .gitignore                      # Quy tắc loại trừ file build Visual Studio
└── README.md                       # Tài liệu đồ án và hướng dẫn sử dụng
```

---

## 🚀 5. Hướng dẫn cài đặt và chạy ứng dụng

### Yêu cầu môi trường
- Hệ điều hành: Windows 10 / 11 (64-bit).
- Công cụ phát triển: **Visual Studio 2022** (phiên bản 17.12 trở lên) hoặc **.NET SDK 10.0**.
- Workload yêu cầu trong Visual Studio: **.NET Desktop Development** (bao gồm Windows Forms).

### Các bước chạy
1. Mở terminal hoặc PowerShell tại thư mục đồ án:
   ```powershell
   cd C:\NhapGithub\DoAnLapTrinhTrucQuan
   ```
2. Kiểm tra nhánh hiện tại:
   ```powershell
   git branch
   # Đảm bảo đang ở nhánh: feature/m01-quanlymon
   ```
3. Chạy ứng dụng bằng lệnh .NET CLI:
   ```powershell
   dotnet run
   ```
   *Hoặc mở file `DoAnLapTrinhTrucQuan.slnx` bằng Visual Studio và nhấn `F5` (Start Debugging).*
