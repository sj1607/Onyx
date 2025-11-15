namespace Onyx.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            homeBtn = new FontAwesome.Sharp.IconButton();
            startupCheckBox = new CheckBox();
            themeCheckBox = new CheckBox();
            clickMeLabel = new Label();
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
            homeBtn.TabIndex = 0;
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // startupCheckBox
            // 
            startupCheckBox.AutoSize = true;
            startupCheckBox.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startupCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            startupCheckBox.Location = new Point(81, 114);
            startupCheckBox.Name = "startupCheckBox";
            startupCheckBox.Size = new Size(184, 26);
            startupCheckBox.TabIndex = 1;
            startupCheckBox.Text = "Startup on boot";
            startupCheckBox.UseVisualStyleBackColor = true;
            startupCheckBox.CheckedChanged += startupCheckBox_CheckedChanged;
            // 
            // themeCheckBox
            // 
            themeCheckBox.AutoSize = true;
            themeCheckBox.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            themeCheckBox.ForeColor = Color.FromArgb(0, 188, 212);
            themeCheckBox.Location = new Point(81, 208);
            themeCheckBox.Name = "themeCheckBox";
            themeCheckBox.Size = new Size(135, 26);
            themeCheckBox.TabIndex = 2;
            themeCheckBox.Text = "Dark Mode";
            themeCheckBox.UseVisualStyleBackColor = true;
            themeCheckBox.CheckedChanged += themeCheckBox_CheckedChanged;
            // 
            // clickMeLabel
            // 
            clickMeLabel.AutoSize = true;
            clickMeLabel.Cursor = Cursors.Hand;
            clickMeLabel.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickMeLabel.ForeColor = Color.FromArgb(0, 188, 212);
            clickMeLabel.Location = new Point(105, 407);
            clickMeLabel.Name = "clickMeLabel";
            clickMeLabel.Size = new Size(107, 22);
            clickMeLabel.TabIndex = 3;
            clickMeLabel.Text = "Click Me !";
            clickMeLabel.Click += clickMeLabel_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 32);
            ClientSize = new Size(336, 458);
            Controls.Add(clickMeLabel);
            Controls.Add(themeCheckBox);
            Controls.Add(startupCheckBox);
            Controls.Add(homeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            MouseDown += Move_Form;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton homeBtn;
        private CheckBox startupCheckBox;
        private CheckBox themeCheckBox;
        private Label clickMeLabel;
    }
}