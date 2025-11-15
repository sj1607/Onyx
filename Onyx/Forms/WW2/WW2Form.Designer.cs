
namespace Onyx.Forms
{
    partial class WW2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WW2Form));
            homeBtn = new FontAwesome.Sharp.IconButton();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            ww2Label = new Label();
            ww2DataGridView = new DataGridView();
            panelDataGrid = new Panel();
            ww2SearchTextBox = new TextBox();
            ww2SearchIconButton = new FontAwesome.Sharp.IconButton();
            loadIconButton = new FontAwesome.Sharp.IconButton();
            functionsCheckBox = new CheckBox();
            methodsCheckBox = new CheckBox();
            variablesCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ww2DataGridView).BeginInit();
            panelDataGrid.SuspendLayout();
            SuspendLayout();
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
            homeBtn.Location = new Point(12, 12);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(64, 50);
            homeBtn.TabIndex = 1;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
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
            minimizeBtn.Location = new Point(749, 12);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(57, 48);
            minimizeBtn.TabIndex = 4;
            minimizeBtn.Text = "_";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
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
            exitBtn.Location = new Point(812, 14);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(57, 48);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // ww2Label
            // 
            ww2Label.AutoSize = true;
            ww2Label.Font = new Font("Valken", 59.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ww2Label.ForeColor = Color.FromArgb(0, 188, 212);
            ww2Label.Location = new Point(303, 12);
            ww2Label.Name = "ww2Label";
            ww2Label.Size = new Size(258, 98);
            ww2Label.TabIndex = 9;
            ww2Label.Text = "WW2";
            ww2Label.MouseDown += Move_Form;
            // 
            // ww2DataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ww2DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ww2DataGridView.BackgroundColor = Color.FromArgb(26, 28, 32);
            ww2DataGridView.BorderStyle = BorderStyle.None;
            ww2DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 188, 212);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 188, 212);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ww2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ww2DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ww2DataGridView.Dock = DockStyle.Fill;
            ww2DataGridView.Location = new Point(0, 0);
            ww2DataGridView.Name = "ww2DataGridView";
            ww2DataGridView.ReadOnly = true;
            ww2DataGridView.Size = new Size(830, 412);
            ww2DataGridView.TabIndex = 10;
            ww2DataGridView.CellContentClick += ww2DataGridView_CellContentClick_2;
            ww2DataGridView.MouseDown += Move_Form;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(ww2DataGridView);
            panelDataGrid.Location = new Point(23, 204);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(830, 412);
            panelDataGrid.TabIndex = 11;
            // 
            // ww2SearchTextBox
            // 
            ww2SearchTextBox.BackColor = Color.FromArgb(26, 28, 32);
            ww2SearchTextBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ww2SearchTextBox.ForeColor = Color.FromArgb(0, 188, 212);
            ww2SearchTextBox.Location = new Point(36, 153);
            ww2SearchTextBox.Name = "ww2SearchTextBox";
            ww2SearchTextBox.PlaceholderText = "Write a function/method/variable, hashed or unhashed as you wish.";
            ww2SearchTextBox.Size = new Size(598, 25);
            ww2SearchTextBox.TabIndex = 12;
            // 
            // ww2SearchIconButton
            // 
            ww2SearchIconButton.Cursor = Cursors.Hand;
            ww2SearchIconButton.FlatAppearance.BorderSize = 0;
            ww2SearchIconButton.FlatStyle = FlatStyle.Flat;
            ww2SearchIconButton.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ww2SearchIconButton.ForeColor = Color.FromArgb(0, 188, 212);
            ww2SearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            ww2SearchIconButton.IconColor = Color.FromArgb(0, 188, 212);
            ww2SearchIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ww2SearchIconButton.IconSize = 30;
            ww2SearchIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            ww2SearchIconButton.Location = new Point(700, 146);
            ww2SearchIconButton.Name = "ww2SearchIconButton";
            ww2SearchIconButton.Size = new Size(153, 31);
            ww2SearchIconButton.TabIndex = 13;
            ww2SearchIconButton.Text = "Search";
            ww2SearchIconButton.UseVisualStyleBackColor = true;
            ww2SearchIconButton.Click += ww2SearchIconButton_Click;
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
            loadIconButton.Location = new Point(36, 622);
            loadIconButton.Name = "loadIconButton";
            loadIconButton.Size = new Size(153, 31);
            loadIconButton.TabIndex = 14;
            loadIconButton.Text = "Load";
            loadIconButton.UseVisualStyleBackColor = true;
            loadIconButton.Click += loadIconButton_Click;
            // 
            // functionsCheckBox
            // 
            functionsCheckBox.AutoSize = true;
            functionsCheckBox.Cursor = Cursors.Hand;
            functionsCheckBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold);
            functionsCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            functionsCheckBox.Location = new Point(345, 630);
            functionsCheckBox.Name = "functionsCheckBox";
            functionsCheckBox.Size = new Size(147, 21);
            functionsCheckBox.TabIndex = 15;
            functionsCheckBox.Text = "Load Functions";
            functionsCheckBox.UseVisualStyleBackColor = true;
            functionsCheckBox.CheckedChanged += functionsCheckBox_CheckedChanged_1;
            // 
            // methodsCheckBox
            // 
            methodsCheckBox.AutoSize = true;
            methodsCheckBox.Cursor = Cursors.Hand;
            methodsCheckBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold);
            methodsCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            methodsCheckBox.Location = new Point(538, 628);
            methodsCheckBox.Name = "methodsCheckBox";
            methodsCheckBox.Size = new Size(137, 21);
            methodsCheckBox.TabIndex = 16;
            methodsCheckBox.Text = "Load Methods";
            methodsCheckBox.UseVisualStyleBackColor = true;
            methodsCheckBox.CheckedChanged += methodsCheckBox_CheckedChanged;
            // 
            // variablesCheckBox
            // 
            variablesCheckBox.AutoSize = true;
            variablesCheckBox.Cursor = Cursors.Hand;
            variablesCheckBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold);
            variablesCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            variablesCheckBox.Location = new Point(700, 628);
            variablesCheckBox.Name = "variablesCheckBox";
            variablesCheckBox.Size = new Size(143, 21);
            variablesCheckBox.TabIndex = 17;
            variablesCheckBox.Text = "Load Variables";
            variablesCheckBox.UseVisualStyleBackColor = true;
            variablesCheckBox.CheckedChanged += variablesCheckBox_CheckedChanged;
            // 
            // WW2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 32);
            ClientSize = new Size(881, 666);
            Controls.Add(variablesCheckBox);
            Controls.Add(methodsCheckBox);
            Controls.Add(functionsCheckBox);
            Controls.Add(loadIconButton);
            Controls.Add(ww2SearchIconButton);
            Controls.Add(ww2SearchTextBox);
            Controls.Add(panelDataGrid);
            Controls.Add(ww2Label);
            Controls.Add(exitBtn);
            Controls.Add(minimizeBtn);
            Controls.Add(homeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WW2Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WW2";
            Load += WW2Form_Load;
            MouseDown += Move_Form;
            ((System.ComponentModel.ISupportInitialize)ww2DataGridView).EndInit();
            panelDataGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ww2DataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ww2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton exitBtn;
        private Label ww2Label;
        private DataGridView ww2DataGridView;
        private Panel panelDataGrid;
        private TextBox ww2SearchTextBox;
        private FontAwesome.Sharp.IconButton ww2SearchIconButton;
        private FontAwesome.Sharp.IconButton loadIconButton;
        private CheckBox functionsCheckBox;
        private CheckBox methodsCheckBox;
        private CheckBox variablesCheckBox;
    }
}