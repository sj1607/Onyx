
namespace Onyx.Forms
{
    partial class MWRForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MWRForm));
            variablesCheckBox = new CheckBox();
            methodsCheckBox = new CheckBox();
            functionsCheckBox = new CheckBox();
            loadIconButton = new FontAwesome.Sharp.IconButton();
            mwrSearchIconButton = new FontAwesome.Sharp.IconButton();
            mwrSearchTextBox = new TextBox();
            panelDataGrid = new Panel();
            mwrDataGridView = new DataGridView();
            mwrLabel = new Label();
            exitBtn = new FontAwesome.Sharp.IconButton();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mwrDataGridView).BeginInit();
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
            variablesCheckBox.TabIndex = 28;
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
            methodsCheckBox.TabIndex = 27;
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
            functionsCheckBox.TabIndex = 26;
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
            loadIconButton.TabIndex = 25;
            loadIconButton.Text = "Load";
            loadIconButton.UseVisualStyleBackColor = true;
            loadIconButton.Click += loadIconButton_Click;
            // 
            // mwrSearchIconButton
            // 
            mwrSearchIconButton.Cursor = Cursors.Hand;
            mwrSearchIconButton.FlatAppearance.BorderSize = 0;
            mwrSearchIconButton.FlatStyle = FlatStyle.Flat;
            mwrSearchIconButton.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mwrSearchIconButton.ForeColor = Color.FromArgb(0, 188, 212);
            mwrSearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            mwrSearchIconButton.IconColor = Color.FromArgb(0, 188, 212);
            mwrSearchIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            mwrSearchIconButton.IconSize = 30;
            mwrSearchIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            mwrSearchIconButton.Location = new Point(700, 147);
            mwrSearchIconButton.Name = "mwrSearchIconButton";
            mwrSearchIconButton.Size = new Size(153, 31);
            mwrSearchIconButton.TabIndex = 24;
            mwrSearchIconButton.Text = "Search";
            mwrSearchIconButton.UseVisualStyleBackColor = true;
            mwrSearchIconButton.Click += mwrSearchIconButton_Click;
            // 
            // mwrSearchTextBox
            // 
            mwrSearchTextBox.BackColor = Color.FromArgb(26, 28, 32);
            mwrSearchTextBox.Font = new Font("Lucida Fax", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mwrSearchTextBox.ForeColor = Color.FromArgb(0, 188, 212);
            mwrSearchTextBox.Location = new Point(36, 154);
            mwrSearchTextBox.Name = "mwrSearchTextBox";
            mwrSearchTextBox.PlaceholderText = "Write a function/method/variable, hashed or unhashed as you wish.";
            mwrSearchTextBox.Size = new Size(598, 25);
            mwrSearchTextBox.TabIndex = 23;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(mwrDataGridView);
            panelDataGrid.Location = new Point(23, 205);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(830, 412);
            panelDataGrid.TabIndex = 22;
            // 
            // mwrDataGridView
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            mwrDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            mwrDataGridView.BackgroundColor = Color.FromArgb(26, 28, 32);
            mwrDataGridView.BorderStyle = BorderStyle.None;
            mwrDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 188, 212);
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 188, 212);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            mwrDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            mwrDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mwrDataGridView.Dock = DockStyle.Fill;
            mwrDataGridView.Location = new Point(0, 0);
            mwrDataGridView.Name = "mwrDataGridView";
            mwrDataGridView.ReadOnly = true;
            mwrDataGridView.Size = new Size(830, 412);
            mwrDataGridView.TabIndex = 10;
            mwrDataGridView.CellContentClick += mwrDataGridView_CellContentClick;
            // 
            // mwrLabel
            // 
            mwrLabel.AutoSize = true;
            mwrLabel.Font = new Font("Valken", 59.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mwrLabel.ForeColor = Color.FromArgb(0, 188, 212);
            mwrLabel.Location = new Point(303, 13);
            mwrLabel.Name = "mwrLabel";
            mwrLabel.Size = new Size(249, 98);
            mwrLabel.TabIndex = 21;
            mwrLabel.Text = "MWR";
            mwrLabel.MouseDown += Move_Form;
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
            exitBtn.TabIndex = 20;
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
            minimizeBtn.TabIndex = 19;
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
            homeBtn.TabIndex = 18;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // MWRForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 32);
            ClientSize = new Size(881, 666);
            Controls.Add(variablesCheckBox);
            Controls.Add(methodsCheckBox);
            Controls.Add(functionsCheckBox);
            Controls.Add(loadIconButton);
            Controls.Add(mwrSearchIconButton);
            Controls.Add(mwrSearchTextBox);
            Controls.Add(panelDataGrid);
            Controls.Add(mwrLabel);
            Controls.Add(exitBtn);
            Controls.Add(minimizeBtn);
            Controls.Add(homeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MWRForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MWR";
            Load += MWRForm_Load;
            MouseDown += Move_Form;
            panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mwrDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private CheckBox variablesCheckBox;
        private CheckBox methodsCheckBox;
        private CheckBox functionsCheckBox;
        private FontAwesome.Sharp.IconButton loadIconButton;
        private FontAwesome.Sharp.IconButton mwrSearchIconButton;
        private TextBox mwrSearchTextBox;
        private Panel panelDataGrid;
        private DataGridView mwrDataGridView;
        private Label mwrLabel;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
    }
}