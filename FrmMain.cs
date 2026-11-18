namespace DoAnLapTrinhTrucQuan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnQuanlynhanvien_Click(object sender, EventArgs e)
        {
            LoadControl(new UcM05());
        }
    }
}
