using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace Onyx.Forms
{
    public partial class Settings : Form
    {
        #region ExternalLib
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion
   
        public Settings()
        {
            
            InitializeComponent();
            themeCheckBox.Checked = Properties.Settings.Default.darkMode;
            startupCheckBox.Checked = Properties.Settings.Default.setStartup;
            ChangeTheme();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 3;

            Color borderColor = themeCheckBox.Checked? Color.FromArgb(0, 188, 212): Color.FromArgb(74, 44, 120);

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
            bool dark = themeCheckBox.Checked;

            Color backColor = dark ? Color.FromArgb(26, 28, 32) : Color.FromArgb(228, 228, 228);
            Color foreColor = dark ? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

            this.BackColor = backColor;

            foreach (Control c in this.Controls)
            {
                c.BackColor = backColor;
                c.ForeColor = foreColor;
            }

            homeBtn.BackColor = backColor;
            homeBtn.ForeColor = foreColor;
            homeBtn.FlatAppearance.MouseDownBackColor = backColor;
            homeBtn.FlatAppearance.MouseOverBackColor = backColor;
            homeBtn.IconColor = foreColor;

            this.Invalidate();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void clickMeLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is free and open source, so if someone sold it to you, you've been scammed.");
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void startupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.setStartup = startupCheckBox.Checked;
            Properties.Settings.Default.Save();
            SetStartup(startupCheckBox.Checked);
        }

        public void SetStartup(bool enable)
        {
            string appName = "Onyx";
            string appPath = Application.ExecutablePath;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (enable)
                rk.SetValue(appName, appPath);
            else
                rk.DeleteValue(appName, false);

        }

        private void themeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.darkMode = themeCheckBox.Checked;
            Properties.Settings.Default.Save();
            ChangeTheme();
        }
    }
}
