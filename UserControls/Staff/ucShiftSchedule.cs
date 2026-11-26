using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class ucShiftSchedule : UserControl
    {
        private readonly DateTime sampleWeekStart;
        private DateTime displayedWeekStart;

        public ucShiftSchedule()
        {
            InitializeComponent();
            label47.Paint += Label47_Paint;
            sampleWeekStart = GetWeekStart(DateTime.Today);
            displayedWeekStart = sampleWeekStart;
            ConfigureTimeLabels();
            ApplyRoundedCorners();
            btnTuantruoc.Click += (_, _) => ChangeDisplayedWeek(-1);
            btnTuansau.Click += (_, _) => ChangeDisplayedWeek(1);
            label1.Click += (_, _) => ShowCurrentWeek();
            label1.Cursor = Cursors.Hand;
            RefreshWeekDisplay();
        }

        private static DateTime GetWeekStart(DateTime date)
        {
            var daysSinceMonday = ((int)date.DayOfWeek + 6) % 7;
            return date.Date.AddDays(-daysSinceMonday);
        }

        private void Label47_Paint(object? sender, PaintEventArgs e)
        {
            const int dotSize = 10;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var brush = new SolidBrush(Color.FromArgb(0, 100, 25));
            e.Graphics.FillEllipse(brush, 22, (label47.Height - dotSize) / 2, dotSize, dotSize);
        }

        private void UpdateWeekLabels()
        {
            var weekEnd = displayedWeekStart.AddDays(6);
            var weekNumber = ISOWeek.GetWeekOfYear(displayedWeekStart);
            lblTuan.Text = $"Tuần {weekNumber}: {displayedWeekStart:dd/MM/yyyy} - {weekEnd:dd/MM/yyyy}";

            var dateLabels = new[] { label19, label21, label23, label25, label27, label29, label31 };
            for (var day = 0; day < dateLabels.Length; day++)
            {
                dateLabels[day].Text = displayedWeekStart.AddDays(day).ToString("dd/MM", CultureInfo.InvariantCulture);
            }
        }

        private void ChangeDisplayedWeek(int weekOffset)
        {
            displayedWeekStart = displayedWeekStart.AddDays(weekOffset * 7);
            RefreshWeekDisplay();
        }

        private void ShowCurrentWeek()
        {
            displayedWeekStart = GetWeekStart(DateTime.Today);
            RefreshWeekDisplay();
        }

        private void RefreshWeekDisplay()
        {
            UpdateWeekLabels();

            var showSampleSchedule = displayedWeekStart == sampleWeekStart;
            foreach (Control control in tlpLich.Controls)
            {
                if (control is Panel && tlpLich.GetColumn(control) > 0 && tlpLich.GetRow(control) > 0)
                    control.Visible = showSampleSchedule;
            }
        }

        private void ConfigureTimeLabels()
        {
            SetUniformRowHeights(tableLayoutPanel1, 5);
            SetUniformRowHeights(tableLayoutPanel2, 5);
            SetUniformRowHeights(tableLayoutPanel3, 6);

            foreach (var label in new[] { label12, label13, label14, label15, label16, label17 })
            {
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        private static void SetUniformRowHeights(TableLayoutPanel table, int rowCount)
        {
            table.RowCount = rowCount;
            table.RowStyles.Clear();

            for (var row = 0; row < rowCount; row++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
            }
        }

        private void ApplyRoundedCorners()
        {
            foreach (var button in new[] { btnXuatexcelnhanvien, btnSaochep, btnCongbo, btnNhap })
            {
                SetRoundedCorners(button, 8);
            }

            SetRoundedCorners(label47, 18);

            foreach (Control control in tlpLich.Controls)
            {
                if (control is Panel panel)
                    SetRoundedCorners(panel, 8);
            }
        }

        private static void SetRoundedCorners(Control control, int radius)
        {
            void UpdateRegion(object? sender, EventArgs e)
            {
                if (control.Width <= 0 || control.Height <= 0)
                    return;

                var diameter = Math.Min(radius * 2, Math.Min(control.Width, control.Height));
                using var path = new GraphicsPath();
                path.AddArc(0, 0, diameter, diameter, 180, 90);
                path.AddArc(control.Width - diameter, 0, diameter, diameter, 270, 90);
                path.AddArc(control.Width - diameter, control.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(0, control.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                var oldRegion = control.Region;
                control.Region = new Region(path);
                oldRegion?.Dispose();
            }

            control.Resize += UpdateRegion;
            UpdateRegion(control, EventArgs.Empty);
        }
    }
}
