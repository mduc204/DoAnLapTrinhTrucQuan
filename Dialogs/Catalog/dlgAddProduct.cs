using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Dialogs
{
    /// <summary>
    /// Dialog Thêm món mới vào thực đơn (dlgAddProduct)
    /// </summary>
    public partial class dlgAddProduct : Form
    {
        public Product? NewProduct { get; private set; }
        public Mon? MonMoi => NewProduct != null ? new Mon
        {
            ProductId = NewProduct.ProductId,
            ProductName = NewProduct.ProductName,
            CategoryId = NewProduct.CategoryId,
            CategoryName = NewProduct.CategoryName,
            Price = NewProduct.Price,
            CostPrice = NewProduct.CostPrice,
            Description = NewProduct.Description,
            Status = NewProduct.Status,
            HasRecipe = NewProduct.HasRecipe,
            Image = NewProduct.Image,
            ImagePath = NewProduct.ImagePath
        } : null;

        private class CategoryConfig
        {
            public string CategoryId { get; set; } = string.Empty;
            public string CategoryName { get; set; } = string.Empty;
            public string Prefix { get; set; } = string.Empty;
            public Color PreviewColor { get; set; }
            public string DefaultProductName { get; set; } = string.Empty;
            public string DefaultDescription { get; set; } = string.Empty;
            public decimal DefaultPrice { get; set; } = 35000;

            public override string ToString() => $"{CategoryName} (Tiền tố: {Prefix})";
        }

        private readonly List<CategoryConfig> _categoryConfigs = new List<CategoryConfig>
        {
            new CategoryConfig
            {
                CategoryId = "DM01",
                CategoryName = "Cà phê truyền thống",
                Prefix = "CF",
                PreviewColor = ColorTranslator.FromHtml("#6F4E37"),
                DefaultProductName = "Cà phê muối xứ Huế",
                DefaultDescription = "Cà phê phin truyền thống thơm nồng kết hợp lớp kem muối béo nhẹ mặn ngọt cân bằng.",
                DefaultPrice = 35000
            },
            new CategoryConfig
            {
                CategoryId = "DM02",
                CategoryName = "Cà phê pha máy",
                Prefix = "PM",
                PreviewColor = ColorTranslator.FromHtml("#4A3222"),
                DefaultProductName = "Espresso Con Panna",
                DefaultDescription = "Chiết xuất cà phê áp suất cao tiêu chuẩn Ý phủ bông kem tươi tuyết trắng mịn béo ngậy.",
                DefaultPrice = 42000
            },
            new CategoryConfig
            {
                CategoryId = "DM03",
                CategoryName = "Trà trái cây nhiệt đới",
                Prefix = "TE",
                PreviewColor = ColorTranslator.FromHtml("#D35400"),
                DefaultProductName = "Trà ổi hồng phúc bồn tử",
                DefaultDescription = "Trà hoa quả chua ngọt thanh mát, đượm vị ổi xá lị tươi và phúc bồn tử bổ sung vitamin.",
                DefaultPrice = 45000
            },
            new CategoryConfig
            {
                CategoryId = "DM04",
                CategoryName = "Trà sữa & Macchiato",
                Prefix = "TS",
                PreviewColor = ColorTranslator.FromHtml("#8B5A2B"),
                DefaultProductName = "Trà sữa Oolong nướng Trân châu",
                DefaultDescription = "Trà Oolong đậm đà quyện sữa béo bùi, hương đường caramel nướng thơm ngậy kèm trân châu hoàng kim.",
                DefaultPrice = 48000
            },
            new CategoryConfig
            {
                CategoryId = "DM05",
                CategoryName = "Đá xay & Sinh tố",
                Prefix = "FR",
                PreviewColor = ColorTranslator.FromHtml("#27AE60"),
                DefaultProductName = "Matcha Freeze Hạt sen",
                DefaultDescription = "Matcha Uji Nhật Bản xay nhuyễn mát lạnh cùng hạt sen dẻo mềm bùi ngọt tự nhiên.",
                DefaultPrice = 52000
            },
            new CategoryConfig
            {
                CategoryId = "DM06",
                CategoryName = "Bánh tươi & Ăn nhẹ",
                Prefix = "BK",
                PreviewColor = ColorTranslator.FromHtml("#D4AC0D"),
                DefaultProductName = "Bánh Mousse Chanh leo phô mai",
                DefaultDescription = "Bánh mousse nhiều lớp béo ngậy vị cream cheese và chua thanh mượt mà của cốt chanh leo tươi.",
                DefaultPrice = 38000
            }
        };

        private Image? _customImage;
        private bool _hasCustomImage = false;

        public dlgAddProduct()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            cboCategory.DataSource = _categoryConfigs;
            cboCategory.DisplayMember = "CategoryName";

            cboStatus.Items.Clear();
            cboStatus.Items.Add("Đang bán");
            cboStatus.Items.Add("Tạm ngưng");
            cboStatus.SelectedIndex = 0;

            cboCategory.SelectedIndexChanged += (s, e) => ApplySelectedCategory(autoFillInfo: true);
            btnAutoGenerateCode.Click += (s, e) => GenerateAutoCode();
            btnChooseImage.Click += BtnChooseImage_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            txtProductName.TextChanged += (s, e) => UpdateDefaultImage();

            ApplySelectedCategory(autoFillInfo: true);
        }

        private void ApplySelectedCategory(bool autoFillInfo)
        {
            if (cboCategory.SelectedItem is CategoryConfig cfg)
            {
                GenerateAutoCode();

                if (autoFillInfo)
                {
                    txtProductName.Text = cfg.DefaultProductName;
                    txtDescription.Text = cfg.DefaultDescription;
                    nudPrice.Value = cfg.DefaultPrice;
                }

                UpdateDefaultImage();
            }
        }

        private void GenerateAutoCode()
        {
            if (cboCategory.SelectedItem is CategoryConfig cfg)
            {
                txtProductId.Text = MockDataService.Instance.SinhMaMonTuDong(cfg.Prefix);
            }
        }

        private void UpdateDefaultImage()
        {
            if (_hasCustomImage && _customImage != null)
            {
                picProductImage.Image = _customImage;
                return;
            }

            if (cboCategory.SelectedItem is CategoryConfig cfg)
            {
                string code = string.IsNullOrWhiteSpace(txtProductId.Text) ? cfg.Prefix : txtProductId.Text.Trim();
                string name = string.IsNullOrWhiteSpace(txtProductName.Text) ? cfg.CategoryName : txtProductName.Text.Trim();

                Image img = MockDataService.Instance.TaoHinhMinhHoa(code, name, cfg.PreviewColor, Color.White);
                picProductImage.Image = img;
            }
        }

        private void BtnChooseImage_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh đại diện cho món";
                ofd.Filter = "Tệp hình ảnh (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            _customImage = new Bitmap(Image.FromStream(ms));
                        }
                        _hasCustomImage = true;
                        picProductImage.Image = _customImage;
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowError($"Không thể mở hình ảnh: {ex.Message}", "Lỗi hình ảnh");
                    }
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string productId = txtProductId.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(productId))
            {
                MessageHelper.ShowWarning("Mã món không được để trống!", "Thiếu thông tin");
                txtProductId.Focus();
                return;
            }

            bool exists = MockDataService.Instance.DanhSachMon.Any(m => m.ProductId.Equals(productId, StringComparison.OrdinalIgnoreCase));
            if (exists)
            {
                MessageHelper.ShowWarning($"Mã món '{productId}' đã tồn tại trong thực đơn quán!\nVui lòng sửa lại mã hoặc nhấn nút [🔄 Sinh mã].", "Trùng mã món");
                txtProductId.Focus();
                txtProductId.SelectAll();
                return;
            }

            string productName = txtProductName.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageHelper.ShowWarning("Vui lòng nhập tên món!", "Thiếu thông tin");
                txtProductName.Focus();
                return;
            }

            if (cboCategory.SelectedItem is not CategoryConfig cfg)
            {
                MessageHelper.ShowWarning("Vui lòng chọn loại danh mục cho món!", "Thiếu thông tin");
                return;
            }

            Image finalImage = _hasCustomImage && _customImage != null
                ? _customImage
                : MockDataService.Instance.TaoHinhMinhHoa(productId, productName, cfg.PreviewColor, Color.White);

            NewProduct = new Product
            {
                ProductId = productId,
                ProductName = productName,
                CategoryId = cfg.CategoryId,
                CategoryName = cfg.CategoryName,
                Price = nudPrice.Value,
                CostPrice = 0,
                Description = txtDescription.Text.Trim(),
                Status = cboStatus.SelectedItem?.ToString() ?? "Đang bán",
                HasRecipe = chkHasRecipe.Checked,
                Image = finalImage
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
