namespace Emerald_Attendance
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.absentLabel = new System.Windows.Forms.Label();
            this.lateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.period1Label = new System.Windows.Forms.Label();
            this.period2Label = new System.Windows.Forms.Label();
            this.period3Label = new System.Windows.Forms.Label();
            this.period4Label = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.periodStatusLabel = new System.Windows.Forms.Label();
            this.absentPictureBox = new System.Windows.Forms.PictureBox();
            this.LatePictureBox = new System.Windows.Forms.PictureBox();
            this.schoolPictureBox = new System.Windows.Forms.PictureBox();
            this.SubmitPictureBox = new System.Windows.Forms.PictureBox();
            this.presentPictureBox = new System.Windows.Forms.PictureBox();
            this.connectionPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.absentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // absentLabel
            // 
            this.absentLabel.AutoSize = true;
            this.absentLabel.BackColor = System.Drawing.Color.Transparent;
            this.absentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.absentLabel.Location = new System.Drawing.Point(791, 290);
            this.absentLabel.Name = "absentLabel";
            this.absentLabel.Size = new System.Drawing.Size(13, 13);
            this.absentLabel.TabIndex = 21;
            this.absentLabel.Text = "0";
            // 
            // lateLabel
            // 
            this.lateLabel.AutoSize = true;
            this.lateLabel.BackColor = System.Drawing.Color.Transparent;
            this.lateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lateLabel.Location = new System.Drawing.Point(721, 290);
            this.lateLabel.Name = "lateLabel";
            this.lateLabel.Size = new System.Drawing.Size(13, 13);
            this.lateLabel.TabIndex = 20;
            this.lateLabel.Text = "0";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Location = new System.Drawing.Point(844, 284);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 24);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentLabel
            // 
            this.studentLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentLabel.Location = new System.Drawing.Point(703, 225);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(192, 25);
            this.studentLabel.TabIndex = 18;
            this.studentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(689, 317);
            this.monthCalendar1.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 22;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // period1Label
            // 
            this.period1Label.BackColor = System.Drawing.Color.Transparent;
            this.period1Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.period1Label.Location = new System.Drawing.Point(40, 133);
            this.period1Label.Name = "period1Label";
            this.period1Label.Size = new System.Drawing.Size(287, 32);
            this.period1Label.TabIndex = 23;
            this.period1Label.Text = "---";
            this.period1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.period1Label.Click += new System.EventHandler(this.period1Label_Click);
            // 
            // period2Label
            // 
            this.period2Label.BackColor = System.Drawing.Color.Transparent;
            this.period2Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.period2Label.Location = new System.Drawing.Point(40, 177);
            this.period2Label.Name = "period2Label";
            this.period2Label.Size = new System.Drawing.Size(287, 32);
            this.period2Label.TabIndex = 24;
            this.period2Label.Text = "---";
            this.period2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.period2Label.Click += new System.EventHandler(this.period2Label_Click);
            // 
            // period3Label
            // 
            this.period3Label.BackColor = System.Drawing.Color.Transparent;
            this.period3Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.period3Label.Location = new System.Drawing.Point(40, 225);
            this.period3Label.Name = "period3Label";
            this.period3Label.Size = new System.Drawing.Size(287, 32);
            this.period3Label.TabIndex = 25;
            this.period3Label.Text = "---";
            this.period3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.period3Label.Click += new System.EventHandler(this.period3Label_Click);
            // 
            // period4Label
            // 
            this.period4Label.BackColor = System.Drawing.Color.Transparent;
            this.period4Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.period4Label.Location = new System.Drawing.Point(40, 271);
            this.period4Label.Name = "period4Label";
            this.period4Label.Size = new System.Drawing.Size(287, 32);
            this.period4Label.TabIndex = 26;
            this.period4Label.Text = "---";
            this.period4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.period4Label.Click += new System.EventHandler(this.period4Label_Click);
            // 
            // studentListBox
            // 
            this.studentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListBox.ForeColor = System.Drawing.Color.White;
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(365, 107);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(179, 494);
            this.studentListBox.Sorted = true;
            this.studentListBox.TabIndex = 27;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            this.studentListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.studentListBox_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(738, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 13);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "-";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(738, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(110, 13);
            this.userLabel.TabIndex = 28;
            this.userLabel.Text = "You are logged in as :";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // periodStatusLabel
            // 
            this.periodStatusLabel.AutoSize = true;
            this.periodStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.periodStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.periodStatusLabel.Location = new System.Drawing.Point(366, 86);
            this.periodStatusLabel.Name = "periodStatusLabel";
            this.periodStatusLabel.Size = new System.Drawing.Size(131, 13);
            this.periodStatusLabel.TabIndex = 30;
            this.periodStatusLabel.Text = "Status for Current Period : ";
            // 
            // absentPictureBox
            // 
            this.absentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.absentPictureBox.Location = new System.Drawing.Point(559, 112);
            this.absentPictureBox.Name = "absentPictureBox";
            this.absentPictureBox.Size = new System.Drawing.Size(105, 36);
            this.absentPictureBox.TabIndex = 31;
            this.absentPictureBox.TabStop = false;
            this.absentPictureBox.Click += new System.EventHandler(this.absentPictureBox_Click);
            // 
            // LatePictureBox
            // 
            this.LatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LatePictureBox.Location = new System.Drawing.Point(559, 154);
            this.LatePictureBox.Name = "LatePictureBox";
            this.LatePictureBox.Size = new System.Drawing.Size(105, 36);
            this.LatePictureBox.TabIndex = 32;
            this.LatePictureBox.TabStop = false;
            this.LatePictureBox.Click += new System.EventHandler(this.LatePictureBox_Click);
            // 
            // schoolPictureBox
            // 
            this.schoolPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.schoolPictureBox.Location = new System.Drawing.Point(559, 196);
            this.schoolPictureBox.Name = "schoolPictureBox";
            this.schoolPictureBox.Size = new System.Drawing.Size(105, 36);
            this.schoolPictureBox.TabIndex = 33;
            this.schoolPictureBox.TabStop = false;
            this.schoolPictureBox.Click += new System.EventHandler(this.schoolPictureBox_Click);
            // 
            // SubmitPictureBox
            // 
            this.SubmitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SubmitPictureBox.Location = new System.Drawing.Point(559, 375);
            this.SubmitPictureBox.Name = "SubmitPictureBox";
            this.SubmitPictureBox.Size = new System.Drawing.Size(105, 36);
            this.SubmitPictureBox.TabIndex = 34;
            this.SubmitPictureBox.TabStop = false;
            this.SubmitPictureBox.Click += new System.EventHandler(this.SubmitPictureBox_Click);
            // 
            // presentPictureBox
            // 
            this.presentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.presentPictureBox.Location = new System.Drawing.Point(559, 330);
            this.presentPictureBox.Name = "presentPictureBox";
            this.presentPictureBox.Size = new System.Drawing.Size(105, 36);
            this.presentPictureBox.TabIndex = 35;
            this.presentPictureBox.TabStop = false;
            this.presentPictureBox.Click += new System.EventHandler(this.presentPictureBox_Click);
            // 
            // connectionPictureBox
            // 
            this.connectionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.connectionPictureBox.Image = global::Emerald_Attendance.Properties.Resources.upload_final;
            this.connectionPictureBox.Location = new System.Drawing.Point(265, 227);
            this.connectionPictureBox.Name = "connectionPictureBox";
            this.connectionPictureBox.Size = new System.Drawing.Size(395, 180);
            this.connectionPictureBox.TabIndex = 36;
            this.connectionPictureBox.TabStop = false;
            this.connectionPictureBox.Visible = false;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoutPictureBox.Location = new System.Drawing.Point(857, 10);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(58, 33);
            this.logoutPictureBox.TabIndex = 37;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emerald_Attendance.Properties.Resources.Teacher_Panel_Attendance_gui_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 634);
            this.Controls.Add(this.logoutPictureBox);
            this.Controls.Add(this.connectionPictureBox);
            this.Controls.Add(this.presentPictureBox);
            this.Controls.Add(this.SubmitPictureBox);
            this.Controls.Add(this.schoolPictureBox);
            this.Controls.Add(this.LatePictureBox);
            this.Controls.Add(this.absentPictureBox);
            this.Controls.Add(this.periodStatusLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.period4Label);
            this.Controls.Add(this.period3Label);
            this.Controls.Add(this.period2Label);
            this.Controls.Add(this.period1Label);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.absentLabel);
            this.Controls.Add(this.lateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.studentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Panel";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeacherForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.absentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label absentLabel;
        private System.Windows.Forms.Label lateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label period1Label;
        private System.Windows.Forms.Label period2Label;
        private System.Windows.Forms.Label period3Label;
        private System.Windows.Forms.Label period4Label;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label periodStatusLabel;
        private System.Windows.Forms.PictureBox absentPictureBox;
        private System.Windows.Forms.PictureBox LatePictureBox;
        private System.Windows.Forms.PictureBox schoolPictureBox;
        private System.Windows.Forms.PictureBox SubmitPictureBox;
        private System.Windows.Forms.PictureBox presentPictureBox;
        private System.Windows.Forms.PictureBox connectionPictureBox;
        private System.Windows.Forms.PictureBox logoutPictureBox;
    }
}