Hoàn thiện chức năng Quản lý món (Module M01):
- Giao diện danh sách món: tìm kiếm theo tên/mã, lọc theo danh mục và trạng thái (đang bán / tạm ngưng).
- Thêm món mới và chỉnh sửa thông tin món (FormThemMon).
- Chức năng tạm ngưng bán và mở bán lại món.
- Định lượng nguyên liệu cho món (BOM), tính giá vốn và phần trăm lãi.
- Xuất danh sách món ra file Excel/CSV.
- Đã thêm dữ liệu mẫu (MockDataService) và file Database_Schema.sql để test.

  
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

