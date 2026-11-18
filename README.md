# Đồ án Lập trình trực quan - LTTQ Cafe

Hệ thống quản lý quán cafe (Windows Forms .NET 10).

## Nhánh feature/m01-quanlymon

Phân hệ Quản lý món và Định lượng nguyên liệu (M01):
- **Danh sách món:** Xem danh sách, tìm kiếm món theo tên/mã, lọc theo danh mục và trạng thái (đang bán / tạm ngưng).
- **Thao tác món:** Thêm món mới (`FormThemMon`), sửa thông tin món, bật/tắt tạm ngưng bán.
- **Định lượng (BOM):** Chọn nguyên liệu từ kho (`FormChonNguyenLieu`), nhập định lượng, tự tính giá vốn và % lãi.
- **Xuất file:** Xuất danh sách món ra file Excel/CSV.
- **Dữ liệu mẫu:** Có sẵn trong `Data/MockDataService.cs` và file `Database_Schema.sql`.

## Cách chạy dự án
1. Mở file `DoAnLapTrinhTrucQuan.slnx` bằng Visual Studio 2022 (hoặc VS 2025).
2. Nhấn `F5` hoặc gõ lệnh `dotnet run` trong terminal.
