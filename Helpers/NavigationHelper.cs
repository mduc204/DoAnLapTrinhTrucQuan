using System.Drawing;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan.Helpers
{
    /// <summary>
    /// Điều hướng nạp UserControl con vào container panel của frmMain
    /// </summary>
    public static class NavigationHelper
    {
        private static Button? _currentActiveButton;

        public static void NavigateTo(Panel container, UserControl uc, Button? navBtn = null)
        {
            if (container == null || uc == null) return;

            container.SuspendLayout();
            container.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            container.Controls.Add(uc);
            container.ResumeLayout();

            if (navBtn != null)
            {
                SetActiveButton(navBtn);
            }
        }

        public static void SetActiveButton(Button btn)
        {
            if (_currentActiveButton != null && _currentActiveButton != btn)
            {
                _currentActiveButton.BackColor = Color.FromArgb(85, 55, 34);
                _currentActiveButton.ForeColor = Color.FromArgb(238, 193, 164);
                _currentActiveButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            }

            _currentActiveButton = btn;
            _currentActiveButton.BackColor = Color.FromArgb(106, 80, 63);
            _currentActiveButton.ForeColor = Color.White;
            _currentActiveButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }
    }
}
