using Newtonsoft.Json;
using Onyx.Classes;

using System.IO;
using System.Runtime.InteropServices;


namespace Onyx.Forms
{
    public partial class WW2Form : Form
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

        private List<GSC>? _allGSCData;

        public WW2Form()
        {
            InitializeComponent();
            functionsCheckBox.Checked = Properties.Settings.Default.ww2LoadFunctions;
            methodsCheckBox.Checked = Properties.Settings.Default.ww2LoadMethods;
            variablesCheckBox.Checked = Properties.Settings.Default.ww2LoadVariables;
            ChangeTheme();
            LoadJsonToGrid();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 3;

            Color borderColor = dark? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

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
            Theme.GetTheme(this);

            Color backColor = dark ? Color.FromArgb(26, 28, 32) : Color.FromArgb(228, 228, 228);
            Color foreColor = dark ? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

            homeBtn.BackColor = backColor;
            homeBtn.ForeColor = foreColor;
            homeBtn.FlatAppearance.MouseDownBackColor = backColor;
            homeBtn.FlatAppearance.MouseOverBackColor = backColor;
            homeBtn.IconColor = foreColor;

            ww2SearchIconButton.BackColor = backColor;
            ww2SearchIconButton.IconColor = foreColor;
            ww2SearchIconButton.BackColor = backColor;
            ww2SearchIconButton.FlatAppearance.MouseOverBackColor = backColor;
            ww2SearchIconButton.FlatAppearance.MouseDownBackColor = backColor;

            loadIconButton.BackColor = backColor;
            loadIconButton.IconColor = foreColor;
            loadIconButton.BackColor = backColor;
            loadIconButton.FlatAppearance.MouseOverBackColor = backColor;
            loadIconButton.FlatAppearance.MouseDownBackColor = backColor;


            this.Invalidate();
        }

        private void LoadJsonToGrid()
        {

            _allGSCData = JSON.LoadData<GSC>("ww2.json");
            LoadFilteredData();

        }

        private void LoadFilteredData()
        {
            if (_allGSCData == null) return;

            List<string> allowedTypes = new List<string>();

            if (functionsCheckBox.Checked)
            {
                allowedTypes.Add("function");
            }

            if (methodsCheckBox.Checked)
            {
                allowedTypes.Add("method");
            }

            if (variablesCheckBox.Checked)
            {
                allowedTypes.Add("variable");
            }


            var filteredData = _allGSCData.Where(gsc => gsc.Type != null && allowedTypes.Contains(gsc.Type)).ToList();


            ww2DataGridView.DataSource = filteredData;

            if (ww2DataGridView.Columns.Contains("ParamsText"))
            {
                ww2DataGridView.Columns["ParamsText"].HeaderText = "Params";
                ww2DataGridView.Columns["ParamsText"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            if (ww2DataGridView.Columns.Contains("Unhash"))
            {
                ww2DataGridView.Columns["Unhash"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // I decided to remove the path because it was too complicated to implement if a variable is present in 50 files, for example. 
            if (ww2DataGridView.Columns.Contains("Path"))
            {
                ww2DataGridView.Columns["Path"].Visible = false;
                //ww2DataGridView.Columns["Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SearchFilteredData(string searchTerm = "") 
        {
            if (_allGSCData == null) return;

            List<string> allowedTypes = new List<string>();

            if (functionsCheckBox.Checked)
            {
                allowedTypes.Add("function");
            }

            if (methodsCheckBox.Checked)
            {
                allowedTypes.Add("method");
            }
            if (variablesCheckBox.Checked)
            {
                allowedTypes.Add("variable");
            }

            var query = _allGSCData.Where(gsc => gsc.Type != null && allowedTypes.Contains(gsc.Type));

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string lowerSearchTerm = searchTerm.ToLower();

                query = query.Where(gsc =>(gsc.Hash != null && gsc.Hash.ToLower().Contains(lowerSearchTerm)) ||(gsc.Unhash != null && gsc.Unhash.ToLower().Contains(lowerSearchTerm)));
            }

            var filteredData = query.ToList();
            ww2DataGridView.DataSource = filteredData;

            if (ww2DataGridView.Columns.Contains("ParamsText"))
            {
                ww2DataGridView.Columns["ParamsText"].HeaderText = "Params";
                ww2DataGridView.Columns["ParamsText"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if(ww2DataGridView.Columns.Contains("Unhash"))
            {
                ww2DataGridView.Columns["Unhash"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (ww2DataGridView.Columns.Contains("Path"))
            {
                ww2DataGridView.Columns["Path"].Visible = false;
                //ww2DataGridView.Columns["Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void WW2Form_Load(object sender, EventArgs e)
        {

        }

        private void loadIconButton_Click(object sender, EventArgs e)
        {
            _allGSCData = JSON.LoadData<GSC>("ww2.json");
            LoadFilteredData();
        }

        private void functionsCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.ww2LoadFunctions = functionsCheckBox.Checked;
            Properties.Settings.Default.Save();
            LoadFilteredData();
        }

        private void methodsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ww2LoadMethods = methodsCheckBox.Checked;
            Properties.Settings.Default.Save();
            LoadFilteredData();
        }

        private void variablesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ww2LoadVariables = variablesCheckBox.Checked;
            Properties.Settings.Default.Save();
            LoadFilteredData();
        }

        private void ww2SearchIconButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ww2SearchTextBox.Text))
                Notify.NotifyToast("Warning", "Please write something.", ToolTipIcon.Warning);
            else
                SearchFilteredData(ww2SearchTextBox.Text);
        }
    }
}
