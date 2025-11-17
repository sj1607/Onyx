namespace Onyx
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            settingsBtn = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            exitBtn = new FontAwesome.Sharp.IconButton();
            minimizeBtn = new FontAwesome.Sharp.IconButton();
            ww2PictureBox = new PictureBox();
            iwPictureBox = new PictureBox();
            sourceLabel = new LinkLabel();
            logoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ww2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iwPictureBox).BeginInit();
            SuspendLayout();
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 28, 32);
            settingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 28, 32);
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.ForeColor = Color.FromArgb(26, 28, 32);
            settingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            settingsBtn.IconColor = Color.FromArgb(0, 188, 212);
            settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsBtn.Location = new Point(12, 12);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(57, 48);
            settingsBtn.TabIndex = 0;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 188, 212);
            label1.Location = new Point(418, 138);
            label1.Name = "label1";
            label1.Size = new Size(145, 22);
            label1.TabIndex = 1;
            label1.Text = "Select a game";
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
            exitBtn.Location = new Point(951, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(57, 48);
            exitBtn.TabIndex = 2;
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
            minimizeBtn.Location = new Point(887, 11);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(57, 48);
            minimizeBtn.TabIndex = 3;
            minimizeBtn.Text = "_";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // ww2PictureBox
            // 
            ww2PictureBox.Cursor = Cursors.Hand;
            ww2PictureBox.ErrorImage = null;
            ww2PictureBox.Image = Properties.Resources.ww2;
            ww2PictureBox.InitialImage = Properties.Resources.ww2;
            ww2PictureBox.Location = new Point(163, 196);
            ww2PictureBox.Name = "ww2PictureBox";
            ww2PictureBox.Size = new Size(231, 314);
            ww2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ww2PictureBox.TabIndex = 4;
            ww2PictureBox.TabStop = false;
            ww2PictureBox.Click += ww2PictureBox_Click;
            // 
            // iwPictureBox
            // 
            iwPictureBox.Cursor = Cursors.Hand;
            iwPictureBox.ErrorImage = null;
            iwPictureBox.Image = Properties.Resources.iw;
            iwPictureBox.InitialImage = Properties.Resources.ww2;
            iwPictureBox.Location = new Point(551, 196);
            iwPictureBox.Name = "iwPictureBox";
            iwPictureBox.Size = new Size(231, 314);
            iwPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            iwPictureBox.TabIndex = 6;
            iwPictureBox.TabStop = false;
            iwPictureBox.Click += iwPictureBox_Click;
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Cursor = Cursors.Hand;
            sourceLabel.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sourceLabel.LinkColor = Color.FromArgb(0, 188, 212);
            sourceLabel.Location = new Point(878, 522);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(133, 22);
            sourceLabel.TabIndex = 7;
            sourceLabel.TabStop = true;
            sourceLabel.Text = "Source Code";
            sourceLabel.VisitedLinkColor = Color.FromArgb(0, 192, 0);
            sourceLabel.LinkClicked += sourceLabel_LinkClicked;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Valken", 59.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.FromArgb(0, 188, 212);
            logoLabel.Location = new Point(352, 11);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(268, 98);
            logoLabel.TabIndex = 8;
            logoLabel.Text = "ONYX";
            logoLabel.MouseDown += Move_Form;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 32);
            ClientSize = new Size(1020, 553);
            Controls.Add(logoLabel);
            Controls.Add(sourceLabel);
            Controls.Add(iwPictureBox);
            Controls.Add(ww2PictureBox);
            Controls.Add(minimizeBtn);
            Controls.Add(exitBtn);
            Controls.Add(label1);
            Controls.Add(settingsBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Onyx";
            Load += Main_Load;
            MouseDown += Move_Form;
            ((System.ComponentModel.ISupportInitialize)ww2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)iwPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton settingsBtn;
        private Label label1;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private PictureBox ww2PictureBox;
        private PictureBox iwPictureBox;
        private LinkLabel sourceLabel;
        private Label logoLabel;
    }
}
