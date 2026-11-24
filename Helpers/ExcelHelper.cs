using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Helpers
{
    /// <summary>
    /// Tiện ích đọc và ghi tệp Excel chuẩn (.xlsx) sử dụng thư viện ClosedXML
    /// </summary>
    public static class ExcelHelper
    {
        /// <summary>
        /// Xuất danh sách nguyên liệu ra tệp Excel (.xlsx) với định dạng bảng Mộc Café chuyên nghiệp
        /// </summary>
        public static bool ExportIngredientsToExcel(string filePath, IEnumerable<Ingredient> ingredients, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("NguyenLieu_MocCafe");
                    ws.ShowGridLines = true;

                    // Tiêu đề lớn
                    ws.Cell("A1").Value = "BẢNG THỐNG KÊ TỒN KHO NGUYÊN LIỆU - MỘC CAFÉ";
                    ws.Range("A1:I1").Merge();
                    ws.Cell("A1").Style.Font.Bold = true;
                    ws.Cell("A1").Style.Font.FontSize = 14;
                    ws.Cell("A1").Style.Font.FontColor = XLColor.FromArgb(111, 78, 55);
                    ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Row(1).Height = 35;

                    ws.Cell("A2").Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm} | Người lập: Nguyễn Văn Hưng (Quản lý ca)";
                    ws.Range("A2:I2").Merge();
                    ws.Cell("A2").Style.Font.Italic = true;
                    ws.Cell("A2").Style.Font.FontSize = 9.5;
                    ws.Cell("A2").Style.Font.FontColor = XLColor.FromArgb(126, 110, 101);
                    ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Row(2).Height = 20;

                    // Header cột
                    string[] headers = {
                        "MÃ NL", "TÊN NGUYÊN LIỆU", "NHÓM", "ĐƠN VỊ TÍNH",
                        "TỒN KHO", "MỨC TỐI THIỂU", "ĐƠN GIÁ NHẬP", "VỊ TRÍ KHO", "TRẠNG THÁI"
                    };

                    int headerRow = 4;
                    ws.Row(headerRow).Height = 28;

                    for (int c = 0; c < headers.Length; c++)
                    {
                        var cell = ws.Cell(headerRow, c + 1);
                        cell.Value = headers[c];
                        cell.Style.Font.Bold = true;
                        cell.Style.Font.FontSize = 10;
                        cell.Style.Font.FontColor = XLColor.White;
                        cell.Style.Fill.BackgroundColor = XLColor.FromArgb(111, 78, 55); // Nâu cà phê
                        cell.Style.Alignment.Horizontal = (c == 0 || c == 3 || c == 8)
                            ? XLAlignmentHorizontalValues.Center
                            : (c == 4 || c == 5 || c == 6)
                                ? XLAlignmentHorizontalValues.Right
                                : XLAlignmentHorizontalValues.Left;
                        cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(85, 55, 34);
                    }

                    // Dữ liệu
                    int currentRow = headerRow + 1;
                    foreach (var ing in ingredients)
                    {
                        ws.Row(currentRow).Height = 22;

                        ws.Cell(currentRow, 1).Value = ing.IngredientId;
                        ws.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        ws.Cell(currentRow, 1).Style.Font.Bold = true;

                        ws.Cell(currentRow, 2).Value = ing.IngredientName;
                        ws.Cell(currentRow, 3).Value = ing.GroupName;

                        ws.Cell(currentRow, 4).Value = ing.Unit;
                        ws.Cell(currentRow, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        ws.Cell(currentRow, 5).Value = (double)ing.StockQuantity;
                        ws.Cell(currentRow, 5).Style.NumberFormat.Format = "#,##0";
                        ws.Cell(currentRow, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                        if (ing.StockQuantity <= 0)
                        {
                            ws.Cell(currentRow, 5).Style.Font.FontColor = XLColor.FromArgb(211, 47, 47);
                            ws.Cell(currentRow, 5).Style.Font.Bold = true;
                        }
                        else if (ing.StockQuantity <= ing.MinStock)
                        {
                            ws.Cell(currentRow, 5).Style.Font.FontColor = XLColor.FromArgb(217, 119, 6);
                            ws.Cell(currentRow, 5).Style.Font.Bold = true;
                        }

                        ws.Cell(currentRow, 6).Value = (double)ing.MinStock;
                        ws.Cell(currentRow, 6).Style.NumberFormat.Format = "#,##0";
                        ws.Cell(currentRow, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        ws.Cell(currentRow, 7).Value = (double)ing.ImportPrice;
                        ws.Cell(currentRow, 7).Style.NumberFormat.Format = "#,##0 \"đ\"";
                        ws.Cell(currentRow, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        ws.Cell(currentRow, 8).Value = ing.WarehouseLocation;

                        ws.Cell(currentRow, 9).Value = ing.StockStatus;
                        ws.Cell(currentRow, 9).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Tô màu dòng so le
                        var rowRange = ws.Range(currentRow, 1, currentRow, 9);
                        if (currentRow % 2 == 1)
                        {
                            rowRange.Style.Fill.BackgroundColor = XLColor.FromArgb(253, 250, 246);
                        }
                        rowRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        rowRange.Style.Border.InsideBorderColor = XLColor.FromArgb(240, 235, 230);
                        rowRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        rowRange.Style.Border.OutsideBorderColor = XLColor.FromArgb(232, 223, 213);
                        rowRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        currentRow++;
                    }

                    // Tự động căn chỉnh độ rộng các cột
                    ws.Columns().AdjustToContents();
                    for (int i = 1; i <= 9; i++)
                    {
                        ws.Column(i).Width = Math.Max(ws.Column(i).Width + 4, 12);
                    }

                    workbook.SaveAs(filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Tạo tệp mẫu Excel (.xlsx) chuẩn để người dùng nhập liệu danh sách nguyên liệu
        /// </summary>
        public static bool GenerateTemplateExcel(string filePath, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Mau_Nhap_NguyenLieu");
                    ws.ShowGridLines = true;

                    // Tiêu đề mẫu
                    ws.Cell("A1").Value = "MẪU NHẬP DANH SÁCH NGUYÊN LIỆU - MỘC CAFÉ";
                    ws.Range("A1:G1").Merge();
                    ws.Cell("A1").Style.Font.Bold = true;
                    ws.Cell("A1").Style.Font.FontSize = 13;
                    ws.Cell("A1").Style.Font.FontColor = XLColor.FromArgb(111, 78, 55);
                    ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Row(1).Height = 30;

                    ws.Cell("A2").Value = "Lưu ý: Các cột đánh dấu (*) là bắt buộc. Mã nguyên liệu để trống sẽ được hệ thống tự động sinh tiếp theo.";
                    ws.Range("A2:G2").Merge();
                    ws.Cell("A2").Style.Font.Italic = true;
                    ws.Cell("A2").Style.Font.FontSize = 9;
                    ws.Cell("A2").Style.Font.FontColor = XLColor.FromArgb(180, 83, 9);
                    ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Row(2).Height = 20;

                    // Header cột
                    string[] headers = {
                        "MÃ NL", "TÊN NGUYÊN LIỆU (*)", "NHÓM (*)", "ĐƠN VỊ TÍNH (*)",
                        "TỒN BAN ĐẦU (*)", "MỨC TỐI THIỂU (*)", "GIÁ VỐN / ĐƠN VỊ (*)"
                    };

                    int headerRow = 4;
                    ws.Row(headerRow).Height = 26;

                    for (int c = 0; c < headers.Length; c++)
                    {
                        var cell = ws.Cell(headerRow, c + 1);
                        cell.Value = headers[c];
                        cell.Style.Font.Bold = true;
                        cell.Style.Font.FontSize = 9.5;
                        cell.Style.Font.FontColor = XLColor.White;
                        cell.Style.Fill.BackgroundColor = XLColor.FromArgb(111, 78, 55);
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(85, 55, 34);
                    }

                    // 3 Dòng dữ liệu mẫu
                    var sampleData = new[]
                    {
                        new { Ma = "NL040", Ten = "Hạt Macca sấy nứt vỏ Đắk Lắk", Nhom = "Topping", DVT = "gram (g)", Ton = 500, Min = 200, Gia = 280 },
                        new { Ma = "NL041", Ten = "Bột Matcha Uji Shizuoka", Nhom = "Bột", DVT = "gram (g)", Ton = 1000, Min = 300, Gia = 450 },
                        new { Ma = "NL042", Ten = "Syrup Monin Vani Pháp chai 700ml", Nhom = "Syrup", DVT = "chai", Ton = 6, Min = 2, Gia = 195000 }
                    };

                    int r = headerRow + 1;
                    foreach (var s in sampleData)
                    {
                        ws.Row(r).Height = 22;
                        ws.Cell(r, 1).Value = s.Ma;
                        ws.Cell(r, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        ws.Cell(r, 2).Value = s.Ten;
                        ws.Cell(r, 3).Value = s.Nhom;

                        ws.Cell(r, 4).Value = s.DVT;
                        ws.Cell(r, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        ws.Cell(r, 5).Value = s.Ton;
                        ws.Cell(r, 5).Style.NumberFormat.Format = "#,##0";
                        ws.Cell(r, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        ws.Cell(r, 6).Value = s.Min;
                        ws.Cell(r, 6).Style.NumberFormat.Format = "#,##0";
                        ws.Cell(r, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        ws.Cell(r, 7).Value = s.Gia;
                        ws.Cell(r, 7).Style.NumberFormat.Format = "#,##0";
                        ws.Cell(r, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                        var rowRange = ws.Range(r, 1, r, 7);
                        rowRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        rowRange.Style.Border.InsideBorderColor = XLColor.FromArgb(240, 235, 230);
                        rowRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        rowRange.Style.Border.OutsideBorderColor = XLColor.FromArgb(232, 223, 213);

                        r++;
                    }

                    ws.Columns().AdjustToContents();
                    for (int i = 1; i <= 7; i++)
                    {
                        ws.Column(i).Width = Math.Max(ws.Column(i).Width + 4, 15);
                    }

                    workbook.SaveAs(filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Đọc và chuyển đổi danh sách nguyên liệu từ tệp Excel (.xlsx)
        /// </summary>
        public static bool ImportIngredientsFromExcel(string filePath, out List<Ingredient> importedList, out string errorMessage)
        {
            importedList = new List<Ingredient>();
            errorMessage = string.Empty;

            if (!File.Exists(filePath))
            {
                errorMessage = "Tệp không tồn tại!";
                return false;
            }

            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheets.FirstOrDefault();
                    if (ws == null)
                    {
                        errorMessage = "Tệp Excel không chứa sheet dữ liệu nào!";
                        return false;
                    }

                    // Tìm dòng Header (chứa 'TÊN' hoặc 'NGUYÊN LIỆU')
                    int headerRow = -1;
                    for (int r = 1; r <= 10; r++)
                    {
                        for (int c = 1; c <= 10; c++)
                        {
                            string val = ws.Cell(r, c).GetString().Trim().ToUpper();
                            if (val.Contains("TÊN") || val.Contains("NGUYÊN LIỆU") || val.Contains("MÃ"))
                            {
                                headerRow = r;
                                break;
                            }
                        }
                        if (headerRow != -1) break;
                    }

                    if (headerRow == -1) headerRow = 1;

                    // Xác định vị trí các cột
                    int colMa = -1, colTen = -1, colNhom = -1, colDVT = -1, colTon = -1, colMin = -1, colGia = -1;

                    for (int c = 1; c <= 15; c++)
                    {
                        string headerText = ws.Cell(headerRow, c).GetString().Trim().ToUpper();
                        if (headerText.Contains("MÃ")) colMa = c;
                        else if (headerText.Contains("TÊN")) colTen = c;
                        else if (headerText.Contains("NHÓM")) colNhom = c;
                        else if (headerText.Contains("ĐƠN VỊ") || headerText.Contains("ĐVT")) colDVT = c;
                        else if (headerText.Contains("TỒN")) colTon = c;
                        else if (headerText.Contains("TỐI THIỂU") || headerText.Contains("ĐỊNH MỨC")) colMin = c;
                        else if (headerText.Contains("GIÁ") || headerText.Contains("VỐN")) colGia = c;
                    }

                    // Nếu không nhận diện được tên cột, dùng vị trí mặc định
                    if (colTen == -1) colTen = 2;
                    if (colNhom == -1) colNhom = 3;
                    if (colDVT == -1) colDVT = 4;
                    if (colTon == -1) colTon = 5;
                    if (colMin == -1) colMin = 6;
                    if (colGia == -1) colGia = 7;

                    int lastRow = ws.LastRowUsed()?.RowNumber() ?? headerRow;
                    for (int r = headerRow + 1; r <= lastRow; r++)
                    {
                        string tenNL = ws.Cell(r, colTen).GetString().Trim();
                        if (string.IsNullOrWhiteSpace(tenNL)) continue; // Bỏ qua dòng trống

                        string maNL = colMa > 0 ? ws.Cell(r, colMa).GetString().Trim() : string.Empty;
                        string nhom = colNhom > 0 ? ws.Cell(r, colNhom).GetString().Trim() : "Khác";
                        string dvt = colDVT > 0 ? ws.Cell(r, colDVT).GetString().Trim() : "gram (g)";

                        decimal tonKho = 0;
                        if (colTon > 0 && decimal.TryParse(ws.Cell(r, colTon).GetString().Replace(",", "").Replace(".", "").Trim(), out decimal tVal))
                        {
                            tonKho = tVal;
                        }

                        decimal minStock = 10;
                        if (colMin > 0 && decimal.TryParse(ws.Cell(r, colMin).GetString().Replace(",", "").Replace(".", "").Trim(), out decimal mVal))
                        {
                            minStock = mVal;
                        }

                        decimal giaVon = 0;
                        if (colGia > 0 && decimal.TryParse(ws.Cell(r, colGia).GetString().Replace(",", "").Replace(".", "").Replace("đ", "").Trim(), out decimal gVal))
                        {
                            giaVon = gVal;
                        }

                        if (string.IsNullOrWhiteSpace(nhom)) nhom = "Khác";
                        if (string.IsNullOrWhiteSpace(dvt)) dvt = "gram (g)";

                        var ing = new Ingredient
                        {
                            IngredientId = maNL,
                            IngredientName = tenNL,
                            GroupName = nhom,
                            Unit = dvt,
                            StockQuantity = tonKho,
                            MinStock = minStock,
                            ImportPrice = giaVon,
                            WarehouseLocation = "Kho quầy Bar",
                            IsActive = true
                        };

                        importedList.Add(ing);
                    }

                    if (importedList.Count == 0)
                    {
                        errorMessage = "Không tìm thấy dòng nguyên liệu hợp lệ nào trong tệp Excel!";
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
