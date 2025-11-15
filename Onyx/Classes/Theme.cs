using System.Drawing;
using System.Windows.Forms;


namespace Onyx.Classes
{
    public static class Theme
    {
        public static bool darkMode = Properties.Settings.Default.darkMode;
        public static void GetTheme(Form form)
        {
            Color backColor = darkMode ? Color.FromArgb(26, 28, 32) : Color.FromArgb(228, 228, 228);
            Color foreColor = darkMode ? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

            form.BackColor = backColor;

            SetTheme(form.Controls, backColor, foreColor);

        }

        public static void SetTheme(Control.ControlCollection controls, Color backColor, Color foreColor)
        {
            foreach (Control c in controls)
            {
                c.BackColor = backColor;
                c.ForeColor = foreColor;

                if (c.HasChildren)
                {
                    SetTheme(c.Controls, backColor, foreColor);
                }
            }
        }
    }
}
