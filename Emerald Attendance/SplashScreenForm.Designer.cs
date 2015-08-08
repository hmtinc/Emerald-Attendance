namespace Emerald_Attendance
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.splashPictureBox = new System.Windows.Forms.PictureBox();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashPictureBox
            // 
            this.splashPictureBox.Image = global::Emerald_Attendance.Properties.Resources.splash_copy;
            this.splashPictureBox.Location = new System.Drawing.Point(8, 12);
            this.splashPictureBox.Name = "splashPictureBox";
            this.splashPictureBox.Size = new System.Drawing.Size(563, 476);
            this.splashPictureBox.TabIndex = 0;
            this.splashPictureBox.TabStop = false;
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Interval = 2000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 499);
            this.Controls.Add(this.splashPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emerald Attendance";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashPictureBox;
        private System.Windows.Forms.Timer splashTimer;
    }
}