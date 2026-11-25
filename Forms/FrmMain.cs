using DoAnLapTrinhTrucQuan.UserControls.Sales;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class FrmMain : Form
    {
        private Button _activeMenuButton;

        public FrmMain()
        {
            InitializeComponent();

            pnlContent.Controls.Add(new ucTableMap { Dock = DockStyle.Fill });
            _activeMenuButton = btnMenuTableMap;
            using var iconFont = new Font("Segoe MDL2 Assets", 14, FontStyle.Regular, GraphicsUnit.Pixel);

            ConfigureMenuButton(btnMenuDashboard, "\uE80F", iconFont);
            ConfigureMenuButton(btnMenuTableMap, "\uE80A", iconFont);
            ConfigureMenuButton(btnMenuPos, "\uE719", iconFont);
            ConfigureMenuButton(btnMenuOrders, "\uE8A5", iconFont);
            ConfigureMenuButton(btnMenuInvoices, "\uE8A1", iconFont);
            ConfigureMenuButton(btnMenuProducts, "\uE70F", iconFont);
            ConfigureMenuButton(btnMenuCategories, "\uECA5", iconFont);
            ConfigureMenuButton(btnMenuInventory, "\uE7B8", iconFont);
            ConfigureMenuButton(btnMenuVouchers, "\uE8EC", iconFont);
            ConfigureMenuButton(btnMenuStaff, "\uE716", iconFont);
            ConfigureMenuButton(btnMenuSchedule, "\uE787", iconFont);
            ConfigureMenuButton(btnMenuMyShifts, "\uE823", iconFont);
            ConfigureMenuButton(btnMenuTables, "\uE713", iconFont);
            ConfigureMenuButton(btnMenuReports, "\uE9D9", iconFont);
            AddButtonIcon(btnSignOut, "\uE8AC", iconFont);
        }

        private void ConfigureMenuButton(Button button, string glyph, Font iconFont)
        {
            AddButtonIcon(button, glyph, iconFont);
            button.Click += (_, _) => SelectMenuButton(button);
        }

        private static void AddButtonIcon(Button button, string glyph, Font iconFont)
        {
            var icon = new Bitmap(24, 18);
            using var graphics = Graphics.FromImage(icon);
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            using var brush = new SolidBrush(button.ForeColor);
            using var format = StringFormat.GenericTypographic;
            graphics.DrawString(glyph, iconFont, brush, PointF.Empty, format);
            button.Image = icon;
            button.Disposed += (_, _) => icon.Dispose();
        }

        private void SelectMenuButton(Button button)
        {
            Color selectedColor = _activeMenuButton.BackColor;
            _activeMenuButton.BackColor = pnlMenu.BackColor;
            button.BackColor = selectedColor;
            _activeMenuButton = button;
        }

        private void btnMenuPos_Click(object sender, EventArgs e)
        {

        }
    }
}
