

using Onyx.Classes;
using System.Runtime.InteropServices;

namespace Onyx.Forms
{
    public partial class MWRForm : Form
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

        public MWRForm()
        {
            InitializeComponent();
            functionsCheckBox.Checked = Properties.Settings.Default.mwrLoadFunctions;
            methodsCheckBox.Checked = Properties.Settings.Default.mwrLoadMethods;
            variablesCheckBox.Checked = Properties.Settings.Default.mwrLoadVariables;
            ChangeTheme();
            LoadJsonToGrid();
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
            Theme.GetTheme(this);

            Color backColor = dark ? Color.FromArgb(26, 28, 32) : Color.FromArgb(228, 228, 228);
            Color foreColor = dark ? Color.FromArgb(0, 188, 212) : Color.FromArgb(74, 44, 120);

            homeBtn.BackColor = backColor;
            homeBtn.ForeColor = foreColor;
            homeBtn.FlatAppearance.MouseDownBackColor = backColor;
            homeBtn.FlatAppearance.MouseOverBackColor = backColor;
            homeBtn.IconColor = foreColor;

            mwrSearchIconButton.BackColor = backColor;
            mwrSearchIconButton.IconColor = foreColor;
            mwrSearchIconButton.BackColor = backColor;
            mwrSearchIconButton.FlatAppearance.MouseOverBackColor = backColor;
            mwrSearchIconButton.FlatAppearance.MouseDownBackColor = backColor;

            loadIconButton.BackColor = backColor;
            loadIconButton.IconColor = foreColor;
            loadIconButton.BackColor = backColor;
            loadIconButton.FlatAppearance.MouseOverBackColor = backColor;
            loadIconButton.FlatAppearance.MouseDownBackColor = backColor;
        }

        private void LoadJsonToGrid()
        {

            _allGSCData = JSON.LoadData<GSC>("mwr.json");
            LoadFilteredData();
        }

        private void LoadFilteredData()
        {
            if (_allGSCData == null)
                return;

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


            mwrDataGridView.DataSource = filteredData;

            if (mwrDataGridView.Columns.Contains("ParamsText"))
            {
                mwrDataGridView.Columns["ParamsText"].HeaderText = "Params";
                mwrDataGridView.Columns["ParamsText"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            // I decided to remove the path because it was too complicated to implement if a variable is present in 50 files, for example. 
            if (mwrDataGridView.Columns.Contains("Path"))
            {
                mwrDataGridView.Columns["Path"].Visible = false;
                //mwrDataGridView.Columns["Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

                query = query.Where(gsc => (gsc.Hash != null && gsc.Hash.ToLower().Contains(lowerSearchTerm)) || (gsc.Unhash != null && gsc.Unhash.ToLower().Contains(lowerSearchTerm)));
            }

            var filteredData = query.ToList();
            mwrDataGridView.DataSource = filteredData;

            if (mwrDataGridView.Columns.Contains("ParamsText"))
            {
                mwrDataGridView.Columns["ParamsText"].HeaderText = "Params";
                mwrDataGridView.Columns["ParamsText"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            if (mwrDataGridView.Columns.Contains("Path"))
            {
                mwrDataGridView.Columns["Path"].Visible = false;
                // mwrDataGridView.Columns["Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void loadIconButton_Click(object sender, EventArgs e)
        {
            _allGSCData = JSON.LoadData<GSC>("mwr.json");
            LoadFilteredData();
        }

        private void MWRForm_Load(object sender, EventArgs e)
        {

        }

        private void variablesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mwrLoadVariables = variablesCheckBox.Checked;
            Properties.Settings.Default.Save();
            LoadFilteredData();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void methodsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mwrLoadMethods = methodsCheckBox.Checked;
            Properties.Settings.Default.Save();
            LoadFilteredData();
        }

        private void functionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.mwrLoadFunctions = functionsCheckBox.Checked;
            Properties.Settings.Default.Save();
            LoadFilteredData();
        }

        private void mwrSearchIconButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mwrSearchTextBox.Text))
                Notify.NotifyToast("Warning", "Please write something.", ToolTipIcon.Warning);
            else
                SearchFilteredData(mwrSearchTextBox.Text);
        }

        private void mwrDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
