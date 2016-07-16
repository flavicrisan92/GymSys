namespace GymSys
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
            this.panelLastOneScanned = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSDLastSub = new System.Windows.Forms.Label();
            this.lblEDLastS = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.panelBirthDates = new System.Windows.Forms.Panel();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblLastScans = new System.Windows.Forms.Label();
            this.lblLastUser = new System.Windows.Forms.Label();
            this.lblBirthdates = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.txtTopDays = new System.Windows.Forms.TextBox();
            this.lblDaysn = new System.Windows.Forms.Label();
            this.dataGridViewBirthdays = new System.Windows.Forms.DataGridView();
            this.dataGridViewTopUsers = new System.Windows.Forms.DataGridView();
            this.panelTopUser = new System.Windows.Forms.Panel();
            this.LblBarCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelLastOneScanned.SuspendLayout();
            this.panelBirthDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUsers)).BeginInit();
            this.panelTopUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScanedCode
            // 
            this.txtScanedCode.Location = new System.Drawing.Point(21, 153);
            this.txtScanedCode.Name = "txtScanedCode";
            this.txtScanedCode.Size = new System.Drawing.Size(264, 20);
            this.txtScanedCode.TabIndex = 0;
            this.txtScanedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanedCode_KeyDown);
            // 
            // dataGridViewScans
            // 
            this.dataGridViewScans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScans.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScans.Location = new System.Drawing.Point(3, 312);
            this.dataGridViewScans.Name = "dataGridViewScans";
            this.dataGridViewScans.ReadOnly = true;
            this.dataGridViewScans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScans.Size = new System.Drawing.Size(889, 397);
            this.dataGridViewScans.TabIndex = 1;
            this.dataGridViewScans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewScans_MouseClick);
            // 
            // lblTotalToday
            // 
            this.lblTotalToday.AutoSize = true;
            this.lblTotalToday.Location = new System.Drawing.Point(18, 13);
            this.lblTotalToday.Name = "lblTotalToday";
            this.lblTotalToday.Size = new System.Drawing.Size(83, 15);
            this.lblTotalToday.TabIndex = 2;
            this.lblTotalToday.Text = "Abonati astazi";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Location = new System.Drawing.Point(107, 13);
            this.lblTodayCount.Name = "lblTodayCount";
            this.lblTodayCount.Size = new System.Drawing.Size(14, 15);
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
            this.panelDashboard.Location = new System.Drawing.Point(0, -14);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1382, 770);
            this.panelDashboard.TabIndex = 4;
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
            this.panelLastOneScanned.Location = new System.Drawing.Point(918, 34);
            this.panelLastOneScanned.Name = "panelLastOneScanned";
            this.panelLastOneScanned.Size = new System.Drawing.Size(386, 254);
            this.panelLastOneScanned.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(33, 74);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 15);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prenume";
            // 
            // lblSDLastSub
            // 
            this.lblSDLastSub.AutoSize = true;
            this.lblSDLastSub.Location = new System.Drawing.Point(33, 144);
            this.lblSDLastSub.Name = "lblSDLastSub";
            this.lblSDLastSub.Size = new System.Drawing.Size(76, 15);
            this.lblSDLastSub.TabIndex = 2;
            this.lblSDLastSub.Text = "Data inceput";
            // 
            // lblEDLastS
            // 
            this.lblEDLastS.AutoSize = true;
            this.lblEDLastS.Location = new System.Drawing.Point(33, 181);
            this.lblEDLastS.Name = "lblEDLastS";
            this.lblEDLastS.Size = new System.Drawing.Size(68, 15);
            this.lblEDLastS.TabIndex = 3;
            this.lblEDLastS.Text = "Data sfarsit";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(122, 71);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(261, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(122, 141);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(261, 20);
            this.lblDays.TabIndex = 6;
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(122, 181);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(261, 20);
            this.txtToDate.TabIndex = 7;
            // 
            // panelBirthDates
            // 
            this.panelBirthDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBirthDates.BackColor = System.Drawing.Color.DarkRed;
            this.panelBirthDates.Controls.Add(this.dataGridViewBirthdays);
            this.panelBirthDates.Controls.Add(this.lblBirthdates);
            this.panelBirthDates.Location = new System.Drawing.Point(918, 312);
            this.panelBirthDates.Name = "panelBirthDates";
            this.panelBirthDates.Size = new System.Drawing.Size(461, 190);
            this.panelBirthDates.TabIndex = 5;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(122, 222);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(261, 20);
            this.txtBirthdate.TabIndex = 11;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(33, 222);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(77, 15);
            this.lblBirthdate.TabIndex = 10;
            this.lblBirthdate.Text = "Data nastere";
            // 
            // lblLastScans
            // 
            this.lblLastScans.AutoSize = true;
            this.lblLastScans.Location = new System.Drawing.Point(3, 281);
            this.lblLastScans.Name = "lblLastScans";
            this.lblLastScans.Size = new System.Drawing.Size(90, 15);
            this.lblLastScans.TabIndex = 6;
            this.lblLastScans.Text = "Abonati scanati";
            // 
            // lblLastUser
            // 
            this.lblLastUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUser.AutoSize = true;
            this.lblLastUser.Location = new System.Drawing.Point(8, 9);
            this.lblLastUser.Name = "lblLastUser";
            this.lblLastUser.Size = new System.Drawing.Size(83, 15);
            this.lblLastUser.TabIndex = 7;
            this.lblLastUser.Text = "Detalii abonat";
            // 
            // lblBirthdates
            // 
            this.lblBirthdates.AutoSize = true;
            this.lblBirthdates.Location = new System.Drawing.Point(3, 12);
            this.lblBirthdates.Name = "lblBirthdates";
            this.lblBirthdates.Size = new System.Drawing.Size(88, 15);
            this.lblBirthdates.TabIndex = 7;
            this.lblBirthdates.Text = "Zile de nastere";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(122, 105);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(261, 20);
            this.txtCode.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(33, 108);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 15);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Cod";
            // 
            // lblTop
            // 
            this.lblTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(15, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(72, 15);
            this.lblTop.TabIndex = 8;
            this.lblTop.Text = "Top abonati";
            // 
            // txtTopDays
            // 
            this.txtTopDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopDays.Location = new System.Drawing.Point(90, 0);
            this.txtTopDays.Name = "txtTopDays";
            this.txtTopDays.Size = new System.Drawing.Size(39, 20);
            this.txtTopDays.TabIndex = 9;
            // 
            // lblDaysn
            // 
            this.lblDaysn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysn.AutoSize = true;
            this.lblDaysn.Location = new System.Drawing.Point(135, 3);
            this.lblDaysn.Name = "lblDaysn";
            this.lblDaysn.Size = new System.Drawing.Size(26, 15);
            this.lblDaysn.TabIndex = 10;
            this.lblDaysn.Text = "zile";
            // 
            // dataGridViewBirthdays
            // 
            this.dataGridViewBirthdays.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirthdays.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewBirthdays.Name = "dataGridViewBirthdays";
            this.dataGridViewBirthdays.ReadOnly = true;
            this.dataGridViewBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBirthdays.Size = new System.Drawing.Size(461, 157);
            this.dataGridViewBirthdays.TabIndex = 11;
            // 
            // dataGridViewTopUsers
            // 
            this.dataGridViewTopUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTopUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTopUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopUsers.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewTopUsers.Name = "dataGridViewTopUsers";
            this.dataGridViewTopUsers.ReadOnly = true;
            this.dataGridViewTopUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTopUsers.Size = new System.Drawing.Size(461, 157);
            this.dataGridViewTopUsers.TabIndex = 13;
            // 
            // panelTopUser
            // 
            this.panelTopUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopUser.BackColor = System.Drawing.Color.DarkRed;
            this.panelTopUser.Controls.Add(this.dataGridViewTopUsers);
            this.panelTopUser.Controls.Add(this.lblTop);
            this.panelTopUser.Controls.Add(this.lblDaysn);
            this.panelTopUser.Controls.Add(this.txtTopDays);
            this.panelTopUser.Location = new System.Drawing.Point(918, 527);
            this.panelTopUser.Name = "panelTopUser";
            this.panelTopUser.Size = new System.Drawing.Size(461, 190);
            this.panelTopUser.TabIndex = 12;
            // 
            // LblBarCode
            // 
            this.LblBarCode.AutoSize = true;
            this.LblBarCode.Location = new System.Drawing.Point(18, 118);
            this.LblBarCode.Name = "LblBarCode";
            this.LblBarCode.Size = new System.Drawing.Size(142, 15);
            this.LblBarCode.TabIndex = 13;
            this.LblBarCode.Text = "Scanati codul abonatului";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panelDashboard);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1385, 759);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelLastOneScanned.ResumeLayout(false);
            this.panelLastOneScanned.PerformLayout();
            this.panelBirthDates.ResumeLayout(false);
            this.panelBirthDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUsers)).EndInit();
            this.panelTopUser.ResumeLayout(false);
            this.panelTopUser.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTopDays;
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
    }
}
