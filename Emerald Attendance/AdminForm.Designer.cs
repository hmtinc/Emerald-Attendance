namespace Emerald_Attendance
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.period1Label = new System.Windows.Forms.Label();
            this.period2Label = new System.Windows.Forms.Label();
            this.period4Label = new System.Windows.Forms.Label();
            this.period3Label = new System.Windows.Forms.Label();
            this.modifyPictureBox = new System.Windows.Forms.PictureBox();
            this.emailPictureBox = new System.Windows.Forms.PictureBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.printPictureBox = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.statusPictureBox = new System.Windows.Forms.PictureBox();
            this.lateLabel = new System.Windows.Forms.Label();
            this.absentLabel = new System.Windows.Forms.Label();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.classPictureBox = new System.Windows.Forms.PictureBox();
            this.student2ListBox = new System.Windows.Forms.ListBox();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.periodStatusLabel = new System.Windows.Forms.Label();
            this.modify2PictureBox = new System.Windows.Forms.PictureBox();
            this.studentPictureBox = new System.Windows.Forms.PictureBox();
            this.periodPictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.reportPictureBox = new System.Windows.Forms.PictureBox();
            this.previousReportButton = new System.Windows.Forms.PictureBox();
            this.saveReportButton = new System.Windows.Forms.PictureBox();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.aboutPictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousReportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveReportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListBox
            // 
            this.studentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(33, 135);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.ScrollAlwaysVisible = true;
            this.studentListBox.Size = new System.Drawing.Size(300, 481);
            this.studentListBox.Sorted = true;
            this.studentListBox.TabIndex = 0;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(738, 14);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(110, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "You are logged in as :";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(738, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "-";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchTextBox.Location = new System.Drawing.Point(34, 85);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(257, 16);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(688, 316);
            this.monthCalendar1.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // period1Label
            // 
            this.period1Label.AutoSize = true;
            this.period1Label.BackColor = System.Drawing.Color.Maroon;
            this.period1Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period1Label.Location = new System.Drawing.Point(424, 176);
            this.period1Label.Name = "period1Label";
            this.period1Label.Size = new System.Drawing.Size(0, 13);
            this.period1Label.TabIndex = 6;
            // 
            // period2Label
            // 
            this.period2Label.AutoSize = true;
            this.period2Label.BackColor = System.Drawing.Color.Black;
            this.period2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period2Label.Location = new System.Drawing.Point(424, 310);
            this.period2Label.Name = "period2Label";
            this.period2Label.Size = new System.Drawing.Size(0, 13);
            this.period2Label.TabIndex = 7;
            // 
            // period4Label
            // 
            this.period4Label.AutoSize = true;
            this.period4Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.period4Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period4Label.Location = new System.Drawing.Point(424, 571);
            this.period4Label.Name = "period4Label";
            this.period4Label.Size = new System.Drawing.Size(0, 13);
            this.period4Label.TabIndex = 8;
            // 
            // period3Label
            // 
            this.period3Label.AutoSize = true;
            this.period3Label.BackColor = System.Drawing.Color.RoyalBlue;
            this.period3Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period3Label.Location = new System.Drawing.Point(424, 441);
            this.period3Label.Name = "period3Label";
            this.period3Label.Size = new System.Drawing.Size(0, 13);
            this.period3Label.TabIndex = 9;
            // 
            // modifyPictureBox
            // 
            this.modifyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.modifyPictureBox.Location = new System.Drawing.Point(538, 93);
            this.modifyPictureBox.Name = "modifyPictureBox";
            this.modifyPictureBox.Size = new System.Drawing.Size(109, 31);
            this.modifyPictureBox.TabIndex = 10;
            this.modifyPictureBox.TabStop = false;
            this.modifyPictureBox.Click += new System.EventHandler(this.modifyPictureBox_Click);
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.emailPictureBox.Location = new System.Drawing.Point(539, 137);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Size = new System.Drawing.Size(107, 30);
            this.emailPictureBox.TabIndex = 11;
            this.emailPictureBox.TabStop = false;
            this.emailPictureBox.Click += new System.EventHandler(this.emailPictureBox_Click);
            // 
            // studentLabel
            // 
            this.studentLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentLabel.Location = new System.Drawing.Point(704, 224);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(192, 25);
            this.studentLabel.TabIndex = 12;
            this.studentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusLabel.Location = new System.Drawing.Point(845, 283);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 24);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printPictureBox
            // 
            this.printPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.printPictureBox.Location = new System.Drawing.Point(539, 228);
            this.printPictureBox.Name = "printPictureBox";
            this.printPictureBox.Size = new System.Drawing.Size(105, 33);
            this.printPictureBox.TabIndex = 14;
            this.printPictureBox.TabStop = false;
            this.printPictureBox.Click += new System.EventHandler(this.printPictureBox_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // statusPictureBox
            // 
            this.statusPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.statusPictureBox.Location = new System.Drawing.Point(538, 183);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.Size = new System.Drawing.Size(106, 35);
            this.statusPictureBox.TabIndex = 15;
            this.statusPictureBox.TabStop = false;
            this.statusPictureBox.Click += new System.EventHandler(this.statusPictureBox_Click);
            // 
            // lateLabel
            // 
            this.lateLabel.AutoSize = true;
            this.lateLabel.BackColor = System.Drawing.Color.Transparent;
            this.lateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lateLabel.Location = new System.Drawing.Point(722, 289);
            this.lateLabel.Name = "lateLabel";
            this.lateLabel.Size = new System.Drawing.Size(13, 13);
            this.lateLabel.TabIndex = 16;
            this.lateLabel.Text = "0";
            // 
            // absentLabel
            // 
            this.absentLabel.AutoSize = true;
            this.absentLabel.BackColor = System.Drawing.Color.Transparent;
            this.absentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.absentLabel.Location = new System.Drawing.Point(792, 289);
            this.absentLabel.Name = "absentLabel";
            this.absentLabel.Size = new System.Drawing.Size(13, 13);
            this.absentLabel.TabIndex = 17;
            this.absentLabel.Text = "0";
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.refreshPictureBox.Location = new System.Drawing.Point(300, 76);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(38, 34);
            this.refreshPictureBox.TabIndex = 18;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // classPictureBox
            // 
            this.classPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.classPictureBox.Location = new System.Drawing.Point(352, -5);
            this.classPictureBox.Name = "classPictureBox";
            this.classPictureBox.Size = new System.Drawing.Size(72, 57);
            this.classPictureBox.TabIndex = 19;
            this.classPictureBox.TabStop = false;
            this.classPictureBox.Click += new System.EventHandler(this.classPictureBox_Click);
            // 
            // student2ListBox
            // 
            this.student2ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.student2ListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.student2ListBox.FormattingEnabled = true;
            this.student2ListBox.Location = new System.Drawing.Point(363, 127);
            this.student2ListBox.Name = "student2ListBox";
            this.student2ListBox.ScrollAlwaysVisible = true;
            this.student2ListBox.Size = new System.Drawing.Size(306, 416);
            this.student2ListBox.Sorted = true;
            this.student2ListBox.TabIndex = 20;
            this.student2ListBox.Visible = false;
            this.student2ListBox.SelectedIndexChanged += new System.EventHandler(this.student2ListBox_SelectedIndexChanged);
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.ForeColor = System.Drawing.Color.White;
            this.teacherLabel.Location = new System.Drawing.Point(364, 90);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(0, 13);
            this.teacherLabel.TabIndex = 21;
            this.teacherLabel.Visible = false;
            // 
            // periodStatusLabel
            // 
            this.periodStatusLabel.AutoSize = true;
            this.periodStatusLabel.ForeColor = System.Drawing.Color.White;
            this.periodStatusLabel.Location = new System.Drawing.Point(511, 89);
            this.periodStatusLabel.Name = "periodStatusLabel";
            this.periodStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.periodStatusLabel.TabIndex = 22;
            this.periodStatusLabel.Visible = false;
            // 
            // modify2PictureBox
            // 
            this.modify2PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.modify2PictureBox.Location = new System.Drawing.Point(464, 559);
            this.modify2PictureBox.Name = "modify2PictureBox";
            this.modify2PictureBox.Size = new System.Drawing.Size(108, 39);
            this.modify2PictureBox.TabIndex = 23;
            this.modify2PictureBox.TabStop = false;
            this.modify2PictureBox.Visible = false;
            this.modify2PictureBox.Click += new System.EventHandler(this.modify2PictureBox_Click);
            // 
            // studentPictureBox
            // 
            this.studentPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.studentPictureBox.Location = new System.Drawing.Point(277, -5);
            this.studentPictureBox.Name = "studentPictureBox";
            this.studentPictureBox.Size = new System.Drawing.Size(69, 57);
            this.studentPictureBox.TabIndex = 24;
            this.studentPictureBox.TabStop = false;
            this.studentPictureBox.Click += new System.EventHandler(this.studentPictureBox_Click);
            // 
            // periodPictureBox
            // 
            this.periodPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.periodPictureBox.Location = new System.Drawing.Point(427, -5);
            this.periodPictureBox.Name = "periodPictureBox";
            this.periodPictureBox.Size = new System.Drawing.Size(72, 59);
            this.periodPictureBox.TabIndex = 25;
            this.periodPictureBox.TabStop = false;
            this.periodPictureBox.Click += new System.EventHandler(this.periodPictureBox_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoLabel.Location = new System.Drawing.Point(364, 87);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(304, 36);
            this.infoLabel.TabIndex = 26;
            this.infoLabel.Text = "Lates And Absences ";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Visible = false;
            // 
            // reportPictureBox
            // 
            this.reportPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.reportPictureBox.Location = new System.Drawing.Point(500, -5);
            this.reportPictureBox.Name = "reportPictureBox";
            this.reportPictureBox.Size = new System.Drawing.Size(71, 56);
            this.reportPictureBox.TabIndex = 27;
            this.reportPictureBox.TabStop = false;
            this.reportPictureBox.Click += new System.EventHandler(this.reportPictureBox_Click);
            // 
            // previousReportButton
            // 
            this.previousReportButton.BackColor = System.Drawing.Color.Transparent;
            this.previousReportButton.Location = new System.Drawing.Point(348, 425);
            this.previousReportButton.Name = "previousReportButton";
            this.previousReportButton.Size = new System.Drawing.Size(106, 28);
            this.previousReportButton.TabIndex = 28;
            this.previousReportButton.TabStop = false;
            this.previousReportButton.Visible = false;
            this.previousReportButton.Click += new System.EventHandler(this.previousReportButton_Click);
            // 
            // saveReportButton
            // 
            this.saveReportButton.BackColor = System.Drawing.Color.Transparent;
            this.saveReportButton.Location = new System.Drawing.Point(460, 425);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(106, 28);
            this.saveReportButton.TabIndex = 29;
            this.saveReportButton.TabStop = false;
            this.saveReportButton.Visible = false;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // addPictureBox
            // 
            this.addPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.addPictureBox.Location = new System.Drawing.Point(586, 15);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(33, 28);
            this.addPictureBox.TabIndex = 30;
            this.addPictureBox.TabStop = false;
            this.addPictureBox.Click += new System.EventHandler(this.addPictureBox_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Location = new System.Drawing.Point(625, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(33, 28);
            this.profilePictureBox.TabIndex = 31;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // aboutPictureBox
            // 
            this.aboutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aboutPictureBox.Location = new System.Drawing.Point(664, 12);
            this.aboutPictureBox.Name = "aboutPictureBox";
            this.aboutPictureBox.Size = new System.Drawing.Size(33, 28);
            this.aboutPictureBox.TabIndex = 32;
            this.aboutPictureBox.TabStop = false;
            this.aboutPictureBox.Click += new System.EventHandler(this.aboutPictureBox_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.closePictureBox.Image = global::Emerald_Attendance.Properties.Resources.upload_final;
            this.closePictureBox.Location = new System.Drawing.Point(274, 228);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(392, 180);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closePictureBox.TabIndex = 33;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Visible = false;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoutPictureBox.Location = new System.Drawing.Point(858, 11);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(56, 40);
            this.logoutPictureBox.TabIndex = 34;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emerald_Attendance.Properties.Resources.Admin_Panel___students___gui___final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 634);
            this.Controls.Add(this.logoutPictureBox);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.aboutPictureBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.addPictureBox);
            this.Controls.Add(this.saveReportButton);
            this.Controls.Add(this.previousReportButton);
            this.Controls.Add(this.reportPictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.periodPictureBox);
            this.Controls.Add(this.studentPictureBox);
            this.Controls.Add(this.modify2PictureBox);
            this.Controls.Add(this.periodStatusLabel);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.student2ListBox);
            this.Controls.Add(this.classPictureBox);
            this.Controls.Add(this.refreshPictureBox);
            this.Controls.Add(this.absentLabel);
            this.Controls.Add(this.lateLabel);
            this.Controls.Add(this.statusPictureBox);
            this.Controls.Add(this.printPictureBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.emailPictureBox);
            this.Controls.Add(this.modifyPictureBox);
            this.Controls.Add(this.period3Label);
            this.Controls.Add(this.period4Label);
            this.Controls.Add(this.period2Label);
            this.Controls.Add(this.period1Label);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.studentListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.modifyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousReportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveReportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label period1Label;
        private System.Windows.Forms.Label period2Label;
        private System.Windows.Forms.Label period4Label;
        private System.Windows.Forms.Label period3Label;
        private System.Windows.Forms.PictureBox modifyPictureBox;
        private System.Windows.Forms.PictureBox emailPictureBox;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox printPictureBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox statusPictureBox;
        private System.Windows.Forms.Label lateLabel;
        private System.Windows.Forms.Label absentLabel;
        private System.Windows.Forms.PictureBox refreshPictureBox;
        private System.Windows.Forms.PictureBox classPictureBox;
        private System.Windows.Forms.ListBox student2ListBox;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label periodStatusLabel;
        private System.Windows.Forms.PictureBox modify2PictureBox;
        private System.Windows.Forms.PictureBox studentPictureBox;
        private System.Windows.Forms.PictureBox periodPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox reportPictureBox;
        private System.Windows.Forms.PictureBox previousReportButton;
        private System.Windows.Forms.PictureBox saveReportButton;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.PictureBox aboutPictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox logoutPictureBox;
    }
}