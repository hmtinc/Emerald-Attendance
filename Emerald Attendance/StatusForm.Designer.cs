namespace Emerald_Attendance
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.enterLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterTextBox
            // 
            this.enterTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.enterTextBox.Location = new System.Drawing.Point(19, 34);
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(297, 20);
            this.enterTextBox.TabIndex = 0;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterLabel.Location = new System.Drawing.Point(21, 18);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(295, 13);
            this.enterLabel.TabIndex = 1;
            this.enterLabel.Text = "Enter new status (Leave blank if student is a full time student)";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(19, 57);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(297, 32);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emerald_Attendance.Properties.Resources.modifyPanel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 103);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.enterTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Status ";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.Activated += new System.EventHandler(this.StatusForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterTextBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Button changeButton;
    }
}