namespace Onyx.Forms.IW
{
    partial class IWForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IWForm));
            variablesCheckBox = new CheckBox();
            methodsCheckBox = new CheckBox();
            functionsCheckBox = new CheckBox();
            loadIconButton = new FontAwesome.Sharp.IconButton();
            iwSearchIconButton = new FontAwesome.Sharp.IconButton();
            iwSearchTextBox = new TextBox();
            panelDataGrid = new Panel();
            iwDataGridView = new DataGridView();
            iwLabel = new Label();
            exitBtn = new FontAwesome.Sharp.IconButton();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iwDataGridView).BeginInit();
            SuspendLayout();
            // 
            // variablesCheckBox
            // 
            variablesCheckBox.AutoSize = true;
            variablesCheckBox.Cursor = Cursors.Hand;
            variablesCheckBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold);
            variablesCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            variablesCheckBox.Location = new Point(700, 629);
            variablesCheckBox.Name = "variablesCheckBox";
            variablesCheckBox.Size = new Size(143, 21);
            variablesCheckBox.TabIndex = 39;
            variablesCheckBox.Text = "Load Variables";
            variablesCheckBox.UseVisualStyleBackColor = true;
            variablesCheckBox.CheckedChanged += variablesCheckBox_CheckedChanged;
            // 
            // methodsCheckBox
            // 
            methodsCheckBox.AutoSize = true;
            methodsCheckBox.Cursor = Cursors.Hand;
            methodsCheckBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold);
            methodsCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            methodsCheckBox.Location = new Point(538, 629);
            methodsCheckBox.Name = "methodsCheckBox";
            methodsCheckBox.Size = new Size(137, 21);
            methodsCheckBox.TabIndex = 38;
            methodsCheckBox.Text = "Load Methods";
            methodsCheckBox.UseVisualStyleBackColor = true;
            methodsCheckBox.CheckedChanged += methodsCheckBox_CheckedChanged;
            // 
            // functionsCheckBox
            // 
            functionsCheckBox.AutoSize = true;
            functionsCheckBox.Cursor = Cursors.Hand;
            functionsCheckBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold);
            functionsCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            functionsCheckBox.Location = new Point(345, 631);
            functionsCheckBox.Name = "functionsCheckBox";
            functionsCheckBox.Size = new Size(147, 21);
            functionsCheckBox.TabIndex = 37;
            functionsCheckBox.Text = "Load Functions";
            functionsCheckBox.UseVisualStyleBackColor = true;
            functionsCheckBox.CheckedChanged += functionsCheckBox_CheckedChanged;
            // 
            // loadIconButton
            // 
            loadIconButton.Cursor = Cursors.Hand;
            loadIconButton.FlatAppearance.BorderSize = 0;
            loadIconButton.FlatStyle = FlatStyle.Flat;
            loadIconButton.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadIconButton.ForeColor = Color.FromArgb(0, 188, 212);
            loadIconButton.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            loadIconButton.IconColor = Color.FromArgb(0, 188, 212);
            loadIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            loadIconButton.IconSize = 30;
            loadIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            loadIconButton.Location = new Point(36, 623);
            loadIconButton.Name = "loadIconButton";
            loadIconButton.Size = new Size(153, 31);
            loadIconButton.TabIndex = 36;
            loadIconButton.Text = "Load";
            loadIconButton.UseVisualStyleBackColor = true;
            loadIconButton.Click += loadIconButton_Click;
            // 
            // iwSearchIconButton
            // 
            iwSearchIconButton.Cursor = Cursors.Hand;
            iwSearchIconButton.FlatAppearance.BorderSize = 0;
            iwSearchIconButton.FlatStyle = FlatStyle.Flat;
            iwSearchIconButton.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iwSearchIconButton.ForeColor = Color.FromArgb(0, 188, 212);
            iwSearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            iwSearchIconButton.IconColor = Color.FromArgb(0, 188, 212);
            iwSearchIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iwSearchIconButton.IconSize = 30;
            iwSearchIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            iwSearchIconButton.Location = new Point(700, 147);
            iwSearchIconButton.Name = "iwSearchIconButton";
            iwSearchIconButton.Size = new Size(153, 31);
            iwSearchIconButton.TabIndex = 35;
            iwSearchIconButton.Text = "Search";
            iwSearchIconButton.UseVisualStyleBackColor = true;
            iwSearchIconButton.Click += iwSearchIconButton_Click;
            // 
            // iwSearchTextBox
            // 
            iwSearchTextBox.BackColor = Color.FromArgb(26, 28, 32);
            iwSearchTextBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iwSearchTextBox.ForeColor = Color.FromArgb(0, 188, 212);
            iwSearchTextBox.Location = new Point(36, 154);
            iwSearchTextBox.Name = "iwSearchTextBox";
            iwSearchTextBox.PlaceholderText = "Write a function/method/variable, hashed or unhashed as you wish.";
            iwSearchTextBox.Size = new Size(598, 25);
            iwSearchTextBox.TabIndex = 34;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(iwDataGridView);
            panelDataGrid.Location = new Point(23, 205);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(830, 412);
            panelDataGrid.TabIndex = 33;
            // 
            // iwDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            iwDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            iwDataGridView.BackgroundColor = Color.FromArgb(26, 28, 32);
            iwDataGridView.BorderStyle = BorderStyle.None;
            iwDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 188, 212);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 188, 212);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            iwDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            iwDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iwDataGridView.Dock = DockStyle.Fill;
            iwDataGridView.Location = new Point(0, 0);
            iwDataGridView.Name = "iwDataGridView";
            iwDataGridView.ReadOnly = true;
            iwDataGridView.Size = new Size(830, 412);
            iwDataGridView.TabIndex = 10;
            // 
            // iwLabel
            // 
            iwLabel.AutoSize = true;
            iwLabel.Font = new Font("Valken", 59.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iwLabel.ForeColor = Color.FromArgb(0, 188, 212);
            iwLabel.Location = new Point(346, 15);
            iwLabel.Name = "iwLabel";
            iwLabel.Size = new Size(146, 98);
            iwLabel.TabIndex = 32;
            iwLabel.Text = "IW";
            iwLabel.MouseDown += Move_Form;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 28, 32);
            exitBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            exitBtn.IconColor = Color.FromArgb(0, 188, 212);
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.IconSize = 40;
            exitBtn.Location = new Point(812, 15);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(57, 48);
            exitBtn.TabIndex = 31;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.Cursor = Cursors.Hand;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 28, 32);
            minimizeBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            minimizeBtn.IconColor = Color.FromArgb(0, 188, 212);
            minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeBtn.IconSize = 40;
            minimizeBtn.Location = new Point(749, 13);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(57, 48);
            minimizeBtn.TabIndex = 30;
            minimizeBtn.Text = "_";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 28, 32);
            homeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 28, 32);
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Lucida Fax", 14.25F);
            homeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            homeBtn.IconColor = Color.FromArgb(0, 188, 212);
            homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeBtn.Location = new Point(12, 13);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(64, 50);
            homeBtn.TabIndex = 29;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // IWForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 32);
            ClientSize = new Size(881, 666);
            Controls.Add(variablesCheckBox);
            Controls.Add(methodsCheckBox);
            Controls.Add(functionsCheckBox);
            Controls.Add(loadIconButton);
            Controls.Add(iwSearchIconButton);
            Controls.Add(iwSearchTextBox);
            Controls.Add(panelDataGrid);
            Controls.Add(iwLabel);
            Controls.Add(exitBtn);
            Controls.Add(minimizeBtn);
            Controls.Add(homeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IWForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IW";
            Load += IWForm_Load;
            MouseDown += Move_Form;
            panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iwDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox variablesCheckBox;
        private CheckBox methodsCheckBox;
        private CheckBox functionsCheckBox;
        private FontAwesome.Sharp.IconButton loadIconButton;
        private FontAwesome.Sharp.IconButton iwSearchIconButton;
        private TextBox iwSearchTextBox;
        private Panel panelDataGrid;
        private DataGridView iwDataGridView;
        private Label iwLabel;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
    }
}