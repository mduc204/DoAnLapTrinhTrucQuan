using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan.Helpers
{
    /// <summary>
    /// Bảng màu chuẩn & Các hàm tiện ích đồ họa GDI+ cho Hệ thống POS Quán Cà phê
    /// </summary>
    public static class UIHelper
    {
        #region Palette Màu chuẩn quán Cà Phê Mộc
        public static readonly Color BgMain = ColorTranslator.FromHtml("#FAF6F0");          // Nền chính kem ấm
        public static readonly Color CardWhite = ColorTranslator.FromHtml("#FFFFFF");       // Nền Card / Panel trắng
        public static readonly Color PrimaryCoffee = ColorTranslator.FromHtml("#6F4E37");    // Nâu cà phê chủ đạo
        public static readonly Color PrimaryHover = ColorTranslator.FromHtml("#5B3F2B");     // Nâu đậm khi hover
        public static readonly Color PrimaryDown = ColorTranslator.FromHtml("#4A3222");      // Nâu nhấn
        public static readonly Color TextMain = ColorTranslator.FromHtml("#2C1E14");         // Chữ chính (espresso)
        public static readonly Color TextMuted = ColorTranslator.FromHtml("#7E6E65");        // Chữ phụ / mô tả xám ấm
        public static readonly Color BorderColor = ColorTranslator.FromHtml("#E8DFD5");      // Viền card chuẩn
        public static readonly Color HeaderBg = ColorTranslator.FromHtml("#F3EAE0");         // Header bảng
        public static readonly Color RowSelected = ColorTranslator.FromHtml("#F7EFE7");      // Hàng đang chọn
        public static readonly Color AccentOrange = ColorTranslator.FromHtml("#D35400");     // Cam nhấn mạnh
        public static readonly Color AccentHighlight = ColorTranslator.FromHtml("#C06A2B");  // Cam cà phê

        // Badge trạng thái & Cảnh báo
        public static readonly Color BadgeGreenBg = ColorTranslator.FromHtml("#E2F8E8");
        public static readonly Color BadgeGreenText = ColorTranslator.FromHtml("#1B7C3F");
        public static readonly Color BadgeRedBg = ColorTranslator.FromHtml("#FDE8E8");
        public static readonly Color BadgeRedText = ColorTranslator.FromHtml("#C0392B");
        public static readonly Color DangerRed = ColorTranslator.FromHtml("#C0392B");
        public static readonly Color DangerBg = ColorTranslator.FromHtml("#FDE8E8");
        public static readonly Color BadgeOrangeBg = ColorTranslator.FromHtml("#FEF3EB");
        public static readonly Color BadgeOrangeText = ColorTranslator.FromHtml("#C06A2B");
        public static readonly Color BadgeGrayBg = ColorTranslator.FromHtml("#EFECE9");
        public static readonly Color BadgeGrayText = ColorTranslator.FromHtml("#8D837B");

        // Sidebar
        public static readonly Color SidebarDark = ColorTranslator.FromHtml("#24170E");
        public static readonly Color SidebarHover = ColorTranslator.FromHtml("#38271B");
        public static readonly Color SidebarActive = ColorTranslator.FromHtml("#6F4E37");
        public static readonly Color SidebarText = ColorTranslator.FromHtml("#D9CEC5");
        #endregion

        #region Fonts
        public static readonly Font FontTitleLarge = new Font("Segoe UI", 16f, FontStyle.Bold);
        public static readonly Font FontTitleMedium = new Font("Segoe UI", 12f, FontStyle.Bold);
        public static readonly Font FontBold = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        public static readonly Font FontRegular = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font FontSmall = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        public static readonly Font FontSmallBold = new Font("Segoe UI", 8.5f, FontStyle.Bold);
        #endregion

        #region Helper GDI+ Paths
        /// <summary>
        /// Tạo GraphicsPath hình chữ nhật bo 4 góc
        /// </summary>
        public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

            // Góc trên-trái
            path.AddArc(arc, 180, 90);

            // Góc trên-phải
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Góc dưới-phải
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Góc dưới-trái
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Tạo GraphicsPath dạng con nhộng (Pill / Capsule)
        /// </summary>
        public static GraphicsPath GetCapsulePath(Rectangle rect)
        {
            int radius = rect.Height / 2;
            if (radius <= 0) radius = 1;
            return GetRoundedPath(rect, radius);
        }

        /// <summary>
        /// Định dạng tiền tệ VND (VD: 35.000 đ)
        /// </summary>
        public static string FormatVND(decimal amount)
        {
            return string.Format("{0:N0} đ", amount).Replace(",", ".");
        }

        /// <summary>
        /// Cấu hình DataGridView theo phong cách chuẩn Mộc POS
        /// </summary>
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = ColorTranslator.FromHtml("#EFE8E0");
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;
            dgv.ShowCellToolTips = true;

            // Header Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = HeaderBg;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextMain;
            dgv.ColumnHeadersDefaultCellStyle.Font = FontBold;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderBg;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = TextMain;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Row Style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = TextMain;
            dgv.DefaultCellStyle.Font = FontRegular;
            dgv.DefaultCellStyle.SelectionBackColor = RowSelected;
            dgv.DefaultCellStyle.SelectionForeColor = TextMain;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.RowTemplate.Height = 48;
        }
        #endregion
    }

    #region 1. Custom Control: RoundedPanel
    /// <summary>
    /// Card Panel bo góc 12px, viền #E8DFD5 dùng GDI+ mượt mà không vỡ hạt
    /// </summary>
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 12;
        private Color _borderColor = ColorTranslator.FromHtml("#E8DFD5");
        private int _borderWidth = 1;
        private Color _fillColor = Color.White;

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = value; Invalidate(); }
        }

        public Color FillColor
        {
            get => _fillColor;
            set { _fillColor = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            Padding = new Padding(12);
        }

        private Color GetParentEffectiveColor()
        {
            Control? p = Parent;
            while (p != null)
            {
                if (p is RoundedPanel rp && rp.FillColor != Color.Transparent)
                    return rp.FillColor;
                if (p.BackColor != Color.Transparent)
                    return p.BackColor;
                p = p.Parent;
            }
            return Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color parentBg = GetParentEffectiveColor();
            g.Clear(parentBg);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (GraphicsPath path = UIHelper.GetRoundedPath(rect, _borderRadius))
            {
                // Đổ nền
                using (SolidBrush brush = new SolidBrush(_fillColor))
                {
                    g.FillPath(brush, path);
                }

                // Vẽ viền
                if (_borderWidth > 0 && _borderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(_borderColor, _borderWidth))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawPath(pen, path);
                    }
                }
            }
        }
    }
    #endregion

    #region 2. Custom Control: RoundedButton
    /// <summary>
    /// Nút bo góc 8px với hiệu ứng Hover/Down và hỗ trợ dạng Outlined
    /// </summary>
    public class RoundedButton : Button
    {
        private int _borderRadius = 8;
        private Color _normalBackColor = Color.Empty;
        private Color _hoverBackColor = Color.Empty;
        private Color _downBackColor = Color.Empty;
        private Color _borderColor = Color.Transparent;
        private int _borderWidth = 0;
        private bool _isOutlined = false;
        private bool _isHovered = false;
        private bool _isPressed = false;
        private Image? _customIcon = null;

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public Color NormalBackColor
        {
            get
            {
                if (_normalBackColor != Color.Empty) return _normalBackColor;
                if (BackColor != Color.Transparent && BackColor != Color.Empty) return BackColor;
                return UIHelper.PrimaryCoffee;
            }
            set { _normalBackColor = value; Invalidate(); }
        }

        public Color HoverBackColor
        {
            get
            {
                if (_hoverBackColor != Color.Empty) return _hoverBackColor;
                Color baseBg = NormalBackColor;
                if (baseBg.GetBrightness() > 0.65f)
                {
                    return Color.FromArgb(238, 230, 220);
                }
                return UIHelper.PrimaryHover;
            }
            set { _hoverBackColor = value; Invalidate(); }
        }

        public Color HoverColor
        {
            get => HoverBackColor;
            set => HoverBackColor = value;
        }

        public Color DownBackColor
        {
            get
            {
                if (_downBackColor != Color.Empty) return _downBackColor;
                Color baseBg = NormalBackColor;
                if (baseBg.GetBrightness() > 0.65f)
                {
                    return Color.FromArgb(225, 215, 203);
                }
                return UIHelper.PrimaryDown;
            }
            set { _downBackColor = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = value; Invalidate(); }
        }

        public bool IsOutlined
        {
            get => _isOutlined;
            set
            {
                _isOutlined = value;
                if (_isOutlined)
                {
                    _normalBackColor = Color.White;
                    _hoverBackColor = ColorTranslator.FromHtml("#F7EFE7");
                    _downBackColor = ColorTranslator.FromHtml("#EFE5DB");
                    _borderColor = ColorTranslator.FromHtml("#D0C5B8");
                    _borderWidth = 1;
                    ForeColor = UIHelper.PrimaryCoffee;
                }
                Invalidate();
            }
        }

        public Image? CustomIcon
        {
            get => _customIcon;
            set { _customIcon = value; Invalidate(); }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                Invalidate();
            }
        }

        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Font = UIHelper.FontBold;
            Cursor = Cursors.Hand;
            Size = new Size(110, 36);
        }

        private Color GetParentEffectiveColor()
        {
            Control? p = Parent;
            while (p != null)
            {
                if (p is RoundedPanel rp && rp.FillColor != Color.Transparent)
                    return rp.FillColor;
                if (p.BackColor != Color.Transparent)
                    return p.BackColor;
                p = p.Parent;
            }
            return Color.White;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            _isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isPressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Color parentBg = GetParentEffectiveColor();
            g.Clear(parentBg);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            Color normalBg = NormalBackColor;
            Color currentBg = _isPressed ? DownBackColor : (_isHovered ? HoverBackColor : normalBg);
            if (currentBg == Color.Transparent)
            {
                currentBg = parentBg;
            }

            using (GraphicsPath path = UIHelper.GetRoundedPath(rect, _borderRadius))
            {
                // Nền
                using (SolidBrush brush = new SolidBrush(currentBg))
                {
                    g.FillPath(brush, path);
                }

                // Viền
                if (_borderWidth > 0 && _borderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(_borderColor, _borderWidth))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawPath(pen, path);
                    }
                }
            }

            // Vẽ Icon + Chữ
            if (_customIcon == null)
            {
                TextRenderer.DrawText(g, Text, Font,
                    new Rectangle(0, 0, Width, Height),
                    ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                int iconSize = 16;
                int spacing = 6;
                int totalWidth = (int)g.MeasureString(Text, Font).Width + iconSize + spacing;
                int startX = Math.Max(0, (Width - totalWidth) / 2);
                int startY = (Height - iconSize) / 2;
                g.DrawImage(_customIcon, new Rectangle(startX, startY, iconSize, iconSize));
                startX += iconSize + spacing;
                TextRenderer.DrawText(g, Text, Font,
                    new Rectangle(startX, 0, Width - startX, Height),
                    ForeColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
    }
    #endregion

    #region 3. Custom Control: RoundedTextBox
    /// <summary>
    /// TextBox bọc trong viền bo góc mượt, hỗ trợ icon tìm kiếm và placeholder
    /// </summary>
    public class RoundedTextBox : UserControl
    {
        private TextBox innerTextBox;
        private int _borderRadius = 8;
        private Color _borderColor = ColorTranslator.FromHtml("#E8DFD5");
        private Color _focusBorderColor = UIHelper.PrimaryCoffee;
        private Color _textBgColor = Color.White;
        private Color _placeholderColor = ColorTranslator.FromHtml("#A59990");
        private Image? _prefixIcon = null;
        private bool _isFocused = false;

        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set { _placeholderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public Color FocusBorderColor
        {
            get => _focusBorderColor;
            set { _focusBorderColor = value; Invalidate(); }
        }

        public Color TextBackgroundColor
        {
            get => _textBgColor;
            set
            {
                _textBgColor = value;
                innerTextBox.BackColor = value;
                Invalidate();
            }
        }

        public Image? PrefixIcon
        {
            get => _prefixIcon;
            set
            {
                _prefixIcon = value;
                UpdateInnerTextBoxPosition();
                Invalidate();
            }
        }

        public string PlaceholderText
        {
            get => innerTextBox.PlaceholderText;
            set => innerTextBox.PlaceholderText = value;
        }

        [System.Diagnostics.CodeAnalysis.AllowNull]
        public override string Text
        {
            get => innerTextBox.Text;
            set => innerTextBox.Text = value ?? string.Empty;
        }

        public bool ReadOnly
        {
            get => innerTextBox.ReadOnly;
            set => innerTextBox.ReadOnly = value;
        }

        public HorizontalAlignment TextAlign
        {
            get => innerTextBox.TextAlign;
            set => innerTextBox.TextAlign = value;
        }

        public new event EventHandler? TextChanged
        {
            add => innerTextBox.TextChanged += value;
            remove => innerTextBox.TextChanged -= value;
        }

        public RoundedTextBox()
        {
            SetStyle(ControlStyles.UserPaint |
             ControlStyles.AllPaintingInWmPaint |
             ControlStyles.OptimizedDoubleBuffer |
             ControlStyles.ResizeRedraw |
             ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;

            // 1. Khởi tạo innerTextBox TRƯỚC
            innerTextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = UIHelper.FontRegular,
                ForeColor = UIHelper.TextMain,
                BackColor = _textBgColor
            };

            innerTextBox.GotFocus += (s, e) => { _isFocused = true; Invalidate(); };
            innerTextBox.LostFocus += (s, e) => { _isFocused = false; Invalidate(); };

            Controls.Add(innerTextBox);

            // 2. Gán Size SAU (lúc này OnResize chạy sẽ cập nhật luôn vị trí của innerTextBox)
            Size = new Size(200, 38);
            UpdateInnerTextBoxPosition();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateInnerTextBoxPosition();
        }

        private void UpdateInnerTextBoxPosition()
        {
            if (innerTextBox == null) return; // <-- THÊM DÒNG NÀY VÀO ĐẦU HÀM

            int leftPadding = _prefixIcon != null ? 34 : 10;
            int rightPadding = 10;
            int top = (Height - innerTextBox.PreferredHeight) / 2;
            innerTextBox.Location = new Point(leftPadding, top);
            innerTextBox.Width = Math.Max(0, Width - leftPadding - rightPadding);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            Color currentBorder = _isFocused ? _focusBorderColor : _borderColor;

            using (GraphicsPath path = UIHelper.GetRoundedPath(rect, _borderRadius))
            {
                // Đổ nền
                using (SolidBrush brush = new SolidBrush(_textBgColor))
                {
                    g.FillPath(brush, path);
                }

                // Vẽ viền
                using (Pen pen = new Pen(currentBorder, _isFocused ? 1.5f : 1f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    g.DrawPath(pen, path);
                }
            }

            // Vẽ Icon nếu có
            if (_prefixIcon != null)
            {
                int iconSize = 16;
                int iconY = (Height - iconSize) / 2;
                g.DrawImage(_prefixIcon, new Rectangle(10, iconY, iconSize, iconSize));
            }
        }
    }
    #endregion

    #region 4. Custom Control: StatusBadge
    public enum BadgeStyle
    {
        Success, // Xanh lá: Đang bán / OK
        Danger,  // Đỏ: Tạm ngưng / Hết hàng
        Warning, // Cam: Sắp hết
        Info,    // Xanh dương: Thông tin
        Custom   // Tùy chỉnh màu theo thuộc tính
    }

    /// <summary>
    /// Huy hiệu bo tròn con nhộng (Pill Badge) thể hiện trạng thái / tỷ suất lãi
    /// </summary>
    public class StatusBadge : Control
    {
        private BadgeStyle _style = BadgeStyle.Success;
        private Color _badgeColor = UIHelper.BadgeGreenBg;
        private Color _badgeTextColor = UIHelper.BadgeGreenText;
        private bool _showDot = false;

        public BadgeStyle Style
        {
            get => _style;
            set
            {
                _style = value;
                ApplyStyleColors();
                Invalidate();
            }
        }

        public Color BadgeColor
        {
            get => _badgeColor;
            set { _badgeColor = value; Invalidate(); }
        }

        public Color BadgeTextColor
        {
            get => _badgeTextColor;
            set { _badgeTextColor = value; Invalidate(); }
        }

        public bool ShowDot
        {
            get => _showDot;
            set { _showDot = value; Invalidate(); }
        }

        public StatusBadge()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
            Font = UIHelper.FontSmallBold;
            Size = new Size(86, 24);
            ApplyStyleColors();
        }

        private void ApplyStyleColors()
        {
            switch (_style)
            {
                case BadgeStyle.Success:
                    _badgeColor = UIHelper.BadgeGreenBg;
                    _badgeTextColor = UIHelper.BadgeGreenText;
                    break;
                case BadgeStyle.Danger:
                    _badgeColor = UIHelper.BadgeRedBg;
                    _badgeTextColor = UIHelper.BadgeRedText;
                    break;
                case BadgeStyle.Warning:
                    _badgeColor = UIHelper.BadgeOrangeBg;
                    _badgeTextColor = UIHelper.BadgeOrangeText;
                    break;
                case BadgeStyle.Info:
                    _badgeColor = UIHelper.BadgeGrayBg;
                    _badgeTextColor = UIHelper.BadgeGrayText;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (GraphicsPath path = UIHelper.GetCapsulePath(rect))
            {
                using (SolidBrush brush = new SolidBrush(_badgeColor))
                {
                    g.FillPath(brush, path);
                }
            }

            int textX = 0;
            int textWidth = Width;

            if (_showDot)
            {
                int dotSize = 6;
                int dotX = 10;
                int dotY = (Height - dotSize) / 2;
                using (SolidBrush dotBrush = new SolidBrush(_badgeTextColor))
                {
                    g.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
                }
                textX = 18;
                textWidth = Width - 20;
            }

            TextRenderer.DrawText(g, Text, Font,
                new Rectangle(textX, 0, textWidth, Height),
                _badgeTextColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
    #endregion

    #region 5. Custom Control: ToggleSwitch (Kích hoạt Voucher M04)
    /// <summary>
    /// Nút công tắc bật/tắt (Toggle Switch) dạng con nhộng chuẩn UI hiện đại
    /// </summary>
    public class ToggleSwitch : Control
    {
        private bool _checked = true;
        private Color _onColor = ColorTranslator.FromHtml("#2C1E14");
        private Color _offColor = ColorTranslator.FromHtml("#D0C5B8");
        private Color _knobColor = Color.White;

        public bool Checked
        {
            get => _checked;
            set
            {
                if (_checked != value)
                {
                    _checked = value;
                    Invalidate();
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public Color OnColor
        {
            get => _onColor;
            set { _onColor = value; Invalidate(); }
        }

        public Color OffColor
        {
            get => _offColor;
            set { _offColor = value; Invalidate(); }
        }

        public event EventHandler? CheckedChanged;

        public ToggleSwitch()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(46, 24);
            Cursor = Cursors.Hand;
            BackColor = Color.Transparent;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Checked = !Checked;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (GraphicsPath path = UIHelper.GetCapsulePath(rect))
            using (SolidBrush bgBrush = new SolidBrush(_checked ? _onColor : _offColor))
            {
                g.FillPath(bgBrush, path);
            }

            int knobMargin = 3;
            int knobDiameter = Height - knobMargin * 2;
            int knobX = _checked ? Width - knobDiameter - knobMargin : knobMargin;
            Rectangle knobRect = new Rectangle(knobX, knobMargin, knobDiameter, knobDiameter);

            using (SolidBrush knobBrush = new SolidBrush(_knobColor))
            {
                g.FillEllipse(knobBrush, knobRect);
            }
        }
    }
    #endregion
}
