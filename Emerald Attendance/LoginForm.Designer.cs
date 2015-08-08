namespace Emerald_Attendance
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.connectionPictureBox = new System.Windows.Forms.PictureBox();
            this.connectionTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickStartGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.userTextBox.Location = new System.Drawing.Point(456, 249);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(352, 20);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.Text = "Username ";
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.userTextBox, "Enter User Name");
            this.userTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTextBox_KeyDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.passwordTextBox.Location = new System.Drawing.Point(456, 316);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(352, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.passwordTextBox, "Enter Password [Case-Sensitive]");
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPictureBox.Location = new System.Drawing.Point(825, 302);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(55, 56);
            this.loginPictureBox.TabIndex = 2;
            this.loginPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.loginPictureBox, "Login Button");
            this.loginPictureBox.Click += new System.EventHandler(this.loginPictureBox_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.copyrightLabel.Location = new System.Drawing.Point(525, 368);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(231, 13);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "All Rights Reserved Infinity Computing Inc 2014";
            this.toolTip1.SetToolTip(this.copyrightLabel, "All Rights Reserved Infinity Computing Inc 2014");
            // 
            // connectionPictureBox
            // 
            this.connectionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.connectionPictureBox.Image = global::Emerald_Attendance.Properties.Resources.serverconnect;
            this.connectionPictureBox.Location = new System.Drawing.Point(456, 130);
            this.connectionPictureBox.Name = "connectionPictureBox";
            this.connectionPictureBox.Size = new System.Drawing.Size(395, 180);
            this.connectionPictureBox.TabIndex = 4;
            this.connectionPictureBox.TabStop = false;
            // 
            // connectionTimer
            // 
            this.connectionTimer.Enabled = true;
            this.connectionTimer.Interval = 1000;
            this.connectionTimer.Tick += new System.EventHandler(this.connectionTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickStartGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quickStartGuideToolStripMenuItem
            // 
            this.quickStartGuideToolStripMenuItem.Name = "quickStartGuideToolStripMenuItem";
            this.quickStartGuideToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.quickStartGuideToolStripMenuItem.Text = "Quick Start Guide";
            this.quickStartGuideToolStripMenuItem.Click += new System.EventHandler(this.quickStartGuideToolStripMenuItem_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emerald_Attendance.Properties.Resources.Login_Screen;
            this.ClientSize = new System.Drawing.Size(1264, 400);
            this.Controls.Add(this.connectionPictureBox);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emerald Attendance : Login   ";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox connectionPictureBox;
        private System.Windows.Forms.Timer connectionTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickStartGuideToolStripMenuItem;
    }
}

