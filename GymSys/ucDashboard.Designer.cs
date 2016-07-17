﻿namespace GymSys
{
    partial class ucDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScanedCode = new System.Windows.Forms.TextBox();
            this.dataGridViewScans = new System.Windows.Forms.DataGridView();
            this.lblTotalToday = new System.Windows.Forms.Label();
            this.lblTodayCount = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.LblBarCode = new System.Windows.Forms.Label();
            this.panelTopUser = new System.Windows.Forms.Panel();
            this.numericUpDownTopDays = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTopUsers = new System.Windows.Forms.DataGridView();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblDaysn = new System.Windows.Forms.Label();
            this.lblLastScans = new System.Windows.Forms.Label();
            this.panelBirthDates = new System.Windows.Forms.Panel();
            this.dataGridViewBirthdays = new System.Windows.Forms.DataGridView();
            this.lblBirthdates = new System.Windows.Forms.Label();
            this.panelLastOneScanned = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblLastUser = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEDLastS = new System.Windows.Forms.Label();
            this.lblSDLastSub = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelTopUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUsers)).BeginInit();
            this.panelBirthDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirthdays)).BeginInit();
            this.panelLastOneScanned.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScanedCode
            // 
            this.txtScanedCode.Location = new System.Drawing.Point(28, 188);
            this.txtScanedCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanedCode.Name = "txtScanedCode";
            this.txtScanedCode.Size = new System.Drawing.Size(351, 22);
            this.txtScanedCode.TabIndex = 0;
            this.txtScanedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanedCode_KeyDown);
            // 
            // dataGridViewScans
            // 
            this.dataGridViewScans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScans.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScans.Location = new System.Drawing.Point(4, 384);
            this.dataGridViewScans.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewScans.Name = "dataGridViewScans";
            this.dataGridViewScans.ReadOnly = true;
            this.dataGridViewScans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScans.Size = new System.Drawing.Size(1185, 489);
            this.dataGridViewScans.TabIndex = 1;
            this.dataGridViewScans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewScans_MouseClick);
            // 
            // lblTotalToday
            // 
            this.lblTotalToday.AutoSize = true;
            this.lblTotalToday.Location = new System.Drawing.Point(24, 16);
            this.lblTotalToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalToday.Name = "lblTotalToday";
            this.lblTotalToday.Size = new System.Drawing.Size(97, 17);
            this.lblTotalToday.TabIndex = 2;
            this.lblTotalToday.Text = "Abonati astazi";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Location = new System.Drawing.Point(143, 16);
            this.lblTodayCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayCount.Name = "lblTodayCount";
            this.lblTodayCount.Size = new System.Drawing.Size(16, 17);
            this.lblTodayCount.TabIndex = 3;
            this.lblTodayCount.Text = "0";
            // 
            // panelDashboard
            // 
            this.panelDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashboard.Controls.Add(this.LblBarCode);
            this.panelDashboard.Controls.Add(this.panelTopUser);
            this.panelDashboard.Controls.Add(this.lblLastScans);
            this.panelDashboard.Controls.Add(this.panelBirthDates);
            this.panelDashboard.Controls.Add(this.panelLastOneScanned);
            this.panelDashboard.Controls.Add(this.txtScanedCode);
            this.panelDashboard.Controls.Add(this.dataGridViewScans);
            this.panelDashboard.Controls.Add(this.lblTodayCount);
            this.panelDashboard.Controls.Add(this.lblTotalToday);
            this.panelDashboard.Location = new System.Drawing.Point(0, -17);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1843, 948);
            this.panelDashboard.TabIndex = 4;
            // 
            // LblBarCode
            // 
            this.LblBarCode.AutoSize = true;
            this.LblBarCode.Location = new System.Drawing.Point(24, 145);
            this.LblBarCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBarCode.Name = "LblBarCode";
            this.LblBarCode.Size = new System.Drawing.Size(163, 17);
            this.LblBarCode.TabIndex = 13;
            this.LblBarCode.Text = "Scanati codul abonatului";
            // 
            // panelTopUser
            // 
            this.panelTopUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopUser.BackColor = System.Drawing.Color.DarkRed;
            this.panelTopUser.Controls.Add(this.numericUpDownTopDays);
            this.panelTopUser.Controls.Add(this.dataGridViewTopUsers);
            this.panelTopUser.Controls.Add(this.lblTop);
            this.panelTopUser.Controls.Add(this.lblDaysn);
            this.panelTopUser.Location = new System.Drawing.Point(1224, 649);
            this.panelTopUser.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopUser.Name = "panelTopUser";
            this.panelTopUser.Size = new System.Drawing.Size(615, 234);
            this.panelTopUser.TabIndex = 12;
            // 
            // numericUpDownTopDays
            // 
            this.numericUpDownTopDays.Location = new System.Drawing.Point(111, 4);
            this.numericUpDownTopDays.Name = "numericUpDownTopDays";
            this.numericUpDownTopDays.ReadOnly = true;
            this.numericUpDownTopDays.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownTopDays.TabIndex = 14;
            this.numericUpDownTopDays.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // dataGridViewTopUsers
            // 
            this.dataGridViewTopUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTopUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTopUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopUsers.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewTopUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTopUsers.Name = "dataGridViewTopUsers";
            this.dataGridViewTopUsers.ReadOnly = true;
            this.dataGridViewTopUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTopUsers.Size = new System.Drawing.Size(615, 193);
            this.dataGridViewTopUsers.TabIndex = 13;
            // 
            // lblTop
            // 
            this.lblTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(20, 4);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(84, 17);
            this.lblTop.TabIndex = 8;
            this.lblTop.Text = "Top abonati";
            // 
            // lblDaysn
            // 
            this.lblDaysn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysn.AutoSize = true;
            this.lblDaysn.Location = new System.Drawing.Point(167, 6);
            this.lblDaysn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaysn.Name = "lblDaysn";
            this.lblDaysn.Size = new System.Drawing.Size(29, 17);
            this.lblDaysn.TabIndex = 10;
            this.lblDaysn.Text = "zile";
            // 
            // lblLastScans
            // 
            this.lblLastScans.AutoSize = true;
            this.lblLastScans.Location = new System.Drawing.Point(4, 346);
            this.lblLastScans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastScans.Name = "lblLastScans";
            this.lblLastScans.Size = new System.Drawing.Size(105, 17);
            this.lblLastScans.TabIndex = 6;
            this.lblLastScans.Text = "Abonati scanati";
            // 
            // panelBirthDates
            // 
            this.panelBirthDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBirthDates.BackColor = System.Drawing.Color.DarkRed;
            this.panelBirthDates.Controls.Add(this.dataGridViewBirthdays);
            this.panelBirthDates.Controls.Add(this.lblBirthdates);
            this.panelBirthDates.Location = new System.Drawing.Point(1224, 384);
            this.panelBirthDates.Margin = new System.Windows.Forms.Padding(4);
            this.panelBirthDates.Name = "panelBirthDates";
            this.panelBirthDates.Size = new System.Drawing.Size(615, 234);
            this.panelBirthDates.TabIndex = 5;
            // 
            // dataGridViewBirthdays
            // 
            this.dataGridViewBirthdays.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirthdays.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewBirthdays.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBirthdays.Name = "dataGridViewBirthdays";
            this.dataGridViewBirthdays.ReadOnly = true;
            this.dataGridViewBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBirthdays.Size = new System.Drawing.Size(615, 193);
            this.dataGridViewBirthdays.TabIndex = 11;
            // 
            // lblBirthdates
            // 
            this.lblBirthdates.AutoSize = true;
            this.lblBirthdates.Location = new System.Drawing.Point(4, 15);
            this.lblBirthdates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdates.Name = "lblBirthdates";
            this.lblBirthdates.Size = new System.Drawing.Size(203, 17);
            this.lblBirthdates.TabIndex = 7;
            this.lblBirthdates.Text = "Urmatoarele 10 zile de nastere";
            // 
            // panelLastOneScanned
            // 
            this.panelLastOneScanned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLastOneScanned.BackColor = System.Drawing.Color.DarkGray;
            this.panelLastOneScanned.Controls.Add(this.txtCode);
            this.panelLastOneScanned.Controls.Add(this.lblLastUser);
            this.panelLastOneScanned.Controls.Add(this.lblCode);
            this.panelLastOneScanned.Controls.Add(this.txtBirthdate);
            this.panelLastOneScanned.Controls.Add(this.lblBirthdate);
            this.panelLastOneScanned.Controls.Add(this.txtToDate);
            this.panelLastOneScanned.Controls.Add(this.lblDays);
            this.panelLastOneScanned.Controls.Add(this.txtSurname);
            this.panelLastOneScanned.Controls.Add(this.txtName);
            this.panelLastOneScanned.Controls.Add(this.lblEDLastS);
            this.panelLastOneScanned.Controls.Add(this.lblSDLastSub);
            this.panelLastOneScanned.Controls.Add(this.lblSurname);
            this.panelLastOneScanned.Controls.Add(this.lblName);
            this.panelLastOneScanned.Location = new System.Drawing.Point(1224, 42);
            this.panelLastOneScanned.Margin = new System.Windows.Forms.Padding(4);
            this.panelLastOneScanned.Name = "panelLastOneScanned";
            this.panelLastOneScanned.Size = new System.Drawing.Size(515, 313);
            this.panelLastOneScanned.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(163, 129);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(347, 22);
            this.txtCode.TabIndex = 13;
            // 
            // lblLastUser
            // 
            this.lblLastUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUser.AutoSize = true;
            this.lblLastUser.Location = new System.Drawing.Point(11, 11);
            this.lblLastUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUser.Name = "lblLastUser";
            this.lblLastUser.Size = new System.Drawing.Size(95, 17);
            this.lblLastUser.TabIndex = 7;
            this.lblLastUser.Text = "Detalii abonat";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(44, 133);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(33, 17);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Cod";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(163, 273);
            this.txtBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(347, 22);
            this.txtBirthdate.TabIndex = 11;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(44, 273);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(90, 17);
            this.lblBirthdate.TabIndex = 10;
            this.lblBirthdate.Text = "Data nastere";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(163, 223);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(347, 22);
            this.txtToDate.TabIndex = 7;
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(163, 174);
            this.lblDays.Margin = new System.Windows.Forms.Padding(4);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(347, 22);
            this.lblDays.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(163, 87);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(347, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblEDLastS
            // 
            this.lblEDLastS.AutoSize = true;
            this.lblEDLastS.Location = new System.Drawing.Point(44, 223);
            this.lblEDLastS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEDLastS.Name = "lblEDLastS";
            this.lblEDLastS.Size = new System.Drawing.Size(80, 17);
            this.lblEDLastS.TabIndex = 3;
            this.lblEDLastS.Text = "Data sfarsit";
            // 
            // lblSDLastSub
            // 
            this.lblSDLastSub.AutoSize = true;
            this.lblSDLastSub.Location = new System.Drawing.Point(44, 177);
            this.lblSDLastSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDLastSub.Name = "lblSDLastSub";
            this.lblSDLastSub.Size = new System.Drawing.Size(88, 17);
            this.lblSDLastSub.TabIndex = 2;
            this.lblSDLastSub.Text = "Data inceput";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(44, 91);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prenume";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panelDashboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1847, 934);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelTopUser.ResumeLayout(false);
            this.panelTopUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUsers)).EndInit();
            this.panelBirthDates.ResumeLayout(false);
            this.panelBirthDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirthdays)).EndInit();
            this.panelLastOneScanned.ResumeLayout(false);
            this.panelLastOneScanned.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtScanedCode;
        private System.Windows.Forms.DataGridView dataGridViewScans;
        private System.Windows.Forms.Label lblTotalToday;
        private System.Windows.Forms.Label lblTodayCount;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.DataGridView dataGridViewTopUsers;
        private System.Windows.Forms.Panel panelTopUser;
        private System.Windows.Forms.DataGridView dataGridViewBirthdays;
        private System.Windows.Forms.Label lblDaysn;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBirthdates;
        private System.Windows.Forms.Label lblLastUser;
        private System.Windows.Forms.Label lblLastScans;
        private System.Windows.Forms.Panel panelBirthDates;
        private System.Windows.Forms.Panel panelLastOneScanned;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.TextBox lblDays;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEDLastS;
        private System.Windows.Forms.Label lblSDLastSub;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblBarCode;
        private System.Windows.Forms.NumericUpDown numericUpDownTopDays;
    }
}
