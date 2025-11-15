using Onyx.Classes;
using Onyx.Forms;
using Onyx.Forms.IW;
using System.Runtime.InteropServices;

namespace Onyx
{
    public partial class Main : Form
    {
        #region ExternalLib
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        private bool dark = Properties.Settings.Default.darkMode;

        public Main()
        {
            InitializeComponent();

            ChangeTheme();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 3;
            Color borderColor = dark ? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

            using (Pen pen = new Pen(borderColor, borderWidth))
            {

                e.Graphics.DrawRectangle(pen, new Rectangle(borderWidth / 2, borderWidth / 2, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth));
            }
        }

        private void Move_Form(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ChangeTheme()
        {
            //Idk why it doesn't change automatically, maybe because of the pictureBoxes let's do it manually
            Theme.GetTheme(this);

            Color backColor = dark ? Color.FromArgb(26, 28, 32) : Color.FromArgb(228, 228, 228);
            Color foreColor = dark ? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

            settingsBtn.BackColor = backColor;
            settingsBtn.ForeColor = foreColor;
            settingsBtn.FlatAppearance.MouseDownBackColor = backColor;
            settingsBtn.FlatAppearance.MouseOverBackColor = backColor;
            settingsBtn.IconColor = foreColor;

            exitBtn.BackColor = backColor;
            exitBtn.ForeColor = foreColor;
            exitBtn.IconColor = foreColor;

            minimizeBtn.BackColor = backColor;
            minimizeBtn.ForeColor = foreColor;
            minimizeBtn.IconColor = foreColor;


            sourceLabel.LinkColor = foreColor;
            sourceLabel.BackColor = backColor;

            this.BackColor = backColor;

            label1.ForeColor = foreColor;
            label1.BackColor = backColor;

            logoLabel.ForeColor = foreColor;
            logoLabel.BackColor = backColor;

            this.Invalidate();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void ww2PictureBox_Click(object sender, EventArgs e)
        {
            WW2Form wW2Form = new WW2Form();
            wW2Form.Show();
            this.Hide();
        }

        private void iwPictureBox_Click(object sender, EventArgs e)
        {
            IWForm iwForm = new IWForm();
            iwForm.Show();
            this.Hide();
        }

        private void mwrPictureBox_Click(object sender, EventArgs e)
        {
            //not supported yet
            Notify.NotifyToast("Error", "Not supported yet!", ToolTipIcon.Error);

            /* MWRForm mwrForm = new MWRForm();
                 mwrForm.Show();
                 this.Hide();
            */
        }

        private void sourceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
