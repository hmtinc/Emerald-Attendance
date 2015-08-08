namespace Emerald_Attendance
{
    partial class ModifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.periodListBox = new System.Windows.Forms.ListBox();
            this.optionListBox = new System.Windows.Forms.ListBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.optionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(204, 198);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(166, 39);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(23, 198);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(166, 39);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // periodListBox
            // 
            this.periodListBox.FormattingEnabled = true;
            this.periodListBox.Location = new System.Drawing.Point(24, 45);
            this.periodListBox.Name = "periodListBox";
            this.periodListBox.Size = new System.Drawing.Size(165, 147);
            this.periodListBox.TabIndex = 2;
            // 
            // optionListBox
            // 
            this.optionListBox.FormattingEnabled = true;
            this.optionListBox.Items.AddRange(new object[] {
            "Present",
            "Absent ",
            "Late",
            "School Trip "});
            this.optionListBox.Location = new System.Drawing.Point(205, 45);
            this.optionListBox.Name = "optionListBox";
            this.optionListBox.Size = new System.Drawing.Size(165, 147);
            this.optionListBox.TabIndex = 3;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.periodLabel.Location = new System.Drawing.Point(24, 29);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(85, 13);
            this.periodLabel.TabIndex = 4;
            this.periodLabel.Text = "Select a Period :";
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.optionLabel.Location = new System.Drawing.Point(205, 29);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(117, 13);
            this.optionLabel.TabIndex = 5;
            this.optionLabel.Text = "Select  a New Option : ";
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emerald_Attendance.Properties.Resources.modifyPanel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 259);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.optionListBox);
            this.Controls.Add(this.periodListBox);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Entry ";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.Activated += new System.EventHandler(this.ModifyForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ListBox periodListBox;
        private System.Windows.Forms.ListBox optionListBox;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label optionLabel;
    }
}