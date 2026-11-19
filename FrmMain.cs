namespace DoAnLapTrinhTrucQuan
{
    public partial class FrmMain : Form
    {
        private readonly UcAccount accountControl;

        public FrmMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            WindowState = FormWindowState.Normal;
            ClientSize = new Size(1280, 720);

            flowLayoutPanel1.Dock = DockStyle.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThongtincanhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSidebar.Resize += (_, _) => LayoutSidebar();
            pnlTopbar.Resize += (_, _) => LayoutTopbar();
            LayoutSidebar();
            LayoutTopbar();

            accountControl = new UcAccount();
            accountControl.LoginSucceeded += OnLoginSucceeded;
            accountControl.ProfileUpdated += (name, _) => lbTentopbar.Text = name;
            btnThongtincanhan.Click += (_, _) => ShowProfile();
            btnDangxuatsidebar.Click += (_, _) => ShowLogin();

            pnlSidebar.Visible = false;
            pnlTopbar.Visible = false;
            pnlContent.Visible = false;
            Controls.Add(accountControl);
            accountControl.Dock = DockStyle.Fill;
            accountControl.BringToFront();
        }

        private void OnLoginSucceeded(string email)
        {
            lbTentopbar.Text = accountControl.DisplayName;
            pnlSidebar.Visible = true;
            pnlTopbar.Visible = true;
            pnlContent.Visible = true;
            accountControl.ShowProfile();
            LoadControl(accountControl);
        }

        private void LayoutSidebar()
        {
            const int navigationItemHeight = 51;
            flowLayoutPanel1.Location = new Point(0, pnlLogo.Height);
            flowLayoutPanel1.Size = new Size(
                pnlSidebar.ClientSize.Width,
                Math.Max(0, pnlSidebar.ClientSize.Height - pnlLogo.Height - panel1.Height - btnThongtincanhan.Height));
            btnThongtincanhan.Location = new Point(
                0,
                pnlSidebar.ClientSize.Height - panel1.Height - btnThongtincanhan.Height);
            btnThongtincanhan.Width = pnlSidebar.ClientSize.Width;
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, flowLayoutPanel1.Controls.Count * navigationItemHeight);
        }

        private void LayoutTopbar()
        {
            int rightInset = 16;
            picAvttopbar.Location = new Point(pnlTopbar.ClientSize.Width - picAvttopbar.Width - rightInset, 12);
            lbTentopbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTentopbar.AutoSize = false;
            lbTentopbar.TextAlign = ContentAlignment.MiddleRight;
            lbTentopbar.Size = new Size(160, 26);
            lbTentopbar.Location = new Point(picAvttopbar.Left - lbTentopbar.Width - 12, 6);
            lbRoletopbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbRoletopbar.AutoSize = false;
            lbRoletopbar.TextAlign = ContentAlignment.MiddleRight;
            lbRoletopbar.Size = new Size(160, 26);
            lbRoletopbar.Location = new Point(picAvttopbar.Left - lbRoletopbar.Width - 12, 34);
        }

        private void ShowProfile()
        {
            accountControl.ShowProfile();
            LoadControl(accountControl);
        }

        private void ShowLogin()
        {
            pnlContent.Controls.Clear();
            pnlSidebar.Visible = false;
            pnlTopbar.Visible = false;
            pnlContent.Visible = false;
            accountControl.ShowLogin();
            Controls.Add(accountControl);
            accountControl.Dock = DockStyle.Fill;
            accountControl.BringToFront();
        }

        private void LoadControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {

        }
    }
}
