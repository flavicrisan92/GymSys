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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewToExpire = new System.Windows.Forms.DataGridView();
            this.lblExpires = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLastUser = new System.Windows.Forms.Label();
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEDLastS = new System.Windows.Forms.Label();
            this.lblSDLastSub = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToExpire)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lblTotalToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalToday.AutoSize = true;
            this.lblTotalToday.Location = new System.Drawing.Point(774, 289);
            this.lblTotalToday.Name = "lblTotalToday";
            this.lblTotalToday.Size = new System.Drawing.Size(78, 15);
            this.lblTotalToday.TabIndex = 2;
            this.lblTotalToday.Text = "Total abonati";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Location = new System.Drawing.Point(877, 289);
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
            this.panelDashboard.Controls.Add(this.panel2);
            this.panelDashboard.Controls.Add(this.panel1);
            this.panelDashboard.Controls.Add(this.LblBarCode);
            this.panelDashboard.Controls.Add(this.panelTopUser);
            this.panelDashboard.Controls.Add(this.lblLastScans);
            this.panelDashboard.Controls.Add(this.panelBirthDates);
            this.panelDashboard.Controls.Add(this.panelLastOneScanned);
            this.panelDashboard.Controls.Add(this.txtScanedCode);
            this.panelDashboard.Controls.Add(this.dataGridViewScans);
            this.panelDashboard.Controls.Add(this.lblTodayCount);
            this.panelDashboard.Controls.Add(this.lblTotalToday);
            this.panelDashboard.Location = new System.Drawing.Point(0, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1382, 770);
            this.panelDashboard.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewToExpire);
            this.panel2.Controls.Add(this.lblExpires);
            this.panel2.Location = new System.Drawing.Point(918, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 261);
            this.panel2.TabIndex = 12;
            // 
            // dataGridViewToExpire
            // 
            this.dataGridViewToExpire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewToExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToExpire.Location = new System.Drawing.Point(-1, 30);
            this.dataGridViewToExpire.Name = "dataGridViewToExpire";
            this.dataGridViewToExpire.ReadOnly = true;
            this.dataGridViewToExpire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToExpire.Size = new System.Drawing.Size(461, 230);
            this.dataGridViewToExpire.TabIndex = 11;
            this.dataGridViewToExpire.Click += new System.EventHandler(this.dataGridViewToExpire_Click);
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Location = new System.Drawing.Point(3, 8);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(252, 15);
            this.lblExpires.TabIndex = 7;
            this.lblExpires.Text = "Abonamente care expira saptamana aceasta";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLastUser);
            this.panel1.Location = new System.Drawing.Point(430, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 34);
            this.panel1.TabIndex = 14;
            // 
            // lblLastUser
            // 
            this.lblLastUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUser.AutoSize = true;
            this.lblLastUser.Location = new System.Drawing.Point(2, 9);
            this.lblLastUser.Name = "lblLastUser";
            this.lblLastUser.Size = new System.Drawing.Size(126, 15);
            this.lblLastUser.TabIndex = 7;
            this.lblLastUser.Text = "Ultimul abonat scanat";
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
            // panelTopUser
            // 
            this.panelTopUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTopUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopUser.Controls.Add(this.numericUpDownTopDays);
            this.panelTopUser.Controls.Add(this.dataGridViewTopUsers);
            this.panelTopUser.Controls.Add(this.lblTop);
            this.panelTopUser.Controls.Add(this.lblDaysn);
            this.panelTopUser.Location = new System.Drawing.Point(918, 527);
            this.panelTopUser.Name = "panelTopUser";
            this.panelTopUser.Size = new System.Drawing.Size(462, 190);
            this.panelTopUser.TabIndex = 12;
            // 
            // numericUpDownTopDays
            // 
            this.numericUpDownTopDays.Location = new System.Drawing.Point(96, 9);
            this.numericUpDownTopDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownTopDays.Name = "numericUpDownTopDays";
            this.numericUpDownTopDays.ReadOnly = true;
            this.numericUpDownTopDays.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownTopDays.TabIndex = 14;
            this.numericUpDownTopDays.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTopDays.ValueChanged += new System.EventHandler(this.numericUpDownTopDays_ValueChanged);
            // 
            // dataGridViewTopUsers
            // 
            this.dataGridViewTopUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTopUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTopUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopUsers.Location = new System.Drawing.Point(-1, 33);
            this.dataGridViewTopUsers.Name = "dataGridViewTopUsers";
            this.dataGridViewTopUsers.ReadOnly = true;
            this.dataGridViewTopUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTopUsers.Size = new System.Drawing.Size(461, 157);
            this.dataGridViewTopUsers.TabIndex = 13;
            this.dataGridViewTopUsers.Click += new System.EventHandler(this.dataGridViewTopUsers_Click);
            // 
            // lblTop
            // 
            this.lblTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(2, 11);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(89, 15);
            this.lblTop.TabIndex = 8;
            this.lblTop.Text = "Top 15 abonati";
            // 
            // lblDaysn
            // 
            this.lblDaysn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysn.AutoSize = true;
            this.lblDaysn.Location = new System.Drawing.Point(140, 11);
            this.lblDaysn.Name = "lblDaysn";
            this.lblDaysn.Size = new System.Drawing.Size(26, 15);
            this.lblDaysn.TabIndex = 10;
            this.lblDaysn.Text = "zile";
            // 
            // lblLastScans
            // 
            this.lblLastScans.AutoSize = true;
            this.lblLastScans.Location = new System.Drawing.Point(3, 281);
            this.lblLastScans.Name = "lblLastScans";
            this.lblLastScans.Size = new System.Drawing.Size(125, 15);
            this.lblLastScans.TabIndex = 6;
            this.lblLastScans.Text = "Abonati scanati astazi";
            // 
            // panelBirthDates
            // 
            this.panelBirthDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBirthDates.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBirthDates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBirthDates.Controls.Add(this.dataGridViewBirthdays);
            this.panelBirthDates.Controls.Add(this.lblBirthdates);
            this.panelBirthDates.Location = new System.Drawing.Point(918, 312);
            this.panelBirthDates.Name = "panelBirthDates";
            this.panelBirthDates.Size = new System.Drawing.Size(462, 190);
            this.panelBirthDates.TabIndex = 5;
            // 
            // dataGridViewBirthdays
            // 
            this.dataGridViewBirthdays.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirthdays.Location = new System.Drawing.Point(-1, 30);
            this.dataGridViewBirthdays.Name = "dataGridViewBirthdays";
            this.dataGridViewBirthdays.ReadOnly = true;
            this.dataGridViewBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBirthdays.Size = new System.Drawing.Size(461, 160);
            this.dataGridViewBirthdays.TabIndex = 11;
            this.dataGridViewBirthdays.Click += new System.EventHandler(this.dataGridViewBirthdays_Click);
            // 
            // lblBirthdates
            // 
            this.lblBirthdates.AutoSize = true;
            this.lblBirthdates.Location = new System.Drawing.Point(3, 8);
            this.lblBirthdates.Name = "lblBirthdates";
            this.lblBirthdates.Size = new System.Drawing.Size(176, 15);
            this.lblBirthdates.TabIndex = 7;
            this.lblBirthdates.Text = "Urmatoarele 15 zile de nastere";
            // 
            // panelLastOneScanned
            // 
            this.panelLastOneScanned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLastOneScanned.BackColor = System.Drawing.Color.Snow;
            this.panelLastOneScanned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLastOneScanned.Controls.Add(this.txtCode);
            this.panelLastOneScanned.Controls.Add(this.lblCode);
            this.panelLastOneScanned.Controls.Add(this.txtBirthdate);
            this.panelLastOneScanned.Controls.Add(this.lblBirthdate);
            this.panelLastOneScanned.Controls.Add(this.txtToDate);
            this.panelLastOneScanned.Controls.Add(this.txtFromDate);
            this.panelLastOneScanned.Controls.Add(this.txtSurname);
            this.panelLastOneScanned.Controls.Add(this.txtName);
            this.panelLastOneScanned.Controls.Add(this.lblEDLastS);
            this.panelLastOneScanned.Controls.Add(this.lblSDLastSub);
            this.panelLastOneScanned.Controls.Add(this.lblSurname);
            this.panelLastOneScanned.Controls.Add(this.lblName);
            this.panelLastOneScanned.Location = new System.Drawing.Point(430, 23);
            this.panelLastOneScanned.Name = "panelLastOneScanned";
            this.panelLastOneScanned.Size = new System.Drawing.Size(462, 261);
            this.panelLastOneScanned.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(109, 108);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(330, 20);
            this.txtCode.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(10, 111);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 15);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Cod";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthdate.Enabled = false;
            this.txtBirthdate.Location = new System.Drawing.Point(109, 225);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.ReadOnly = true;
            this.txtBirthdate.Size = new System.Drawing.Size(330, 20);
            this.txtBirthdate.TabIndex = 11;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(10, 225);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(77, 15);
            this.lblBirthdate.TabIndex = 10;
            this.lblBirthdate.Text = "Data nastere";
            // 
            // txtToDate
            // 
            this.txtToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDate.Enabled = false;
            this.txtToDate.Location = new System.Drawing.Point(109, 184);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.ReadOnly = true;
            this.txtToDate.Size = new System.Drawing.Size(330, 20);
            this.txtToDate.TabIndex = 7;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromDate.Enabled = false;
            this.txtFromDate.Location = new System.Drawing.Point(109, 145);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.ReadOnly = true;
            this.txtFromDate.Size = new System.Drawing.Size(330, 20);
            this.txtFromDate.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(109, 74);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(330, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(109, 38);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(330, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblEDLastS
            // 
            this.lblEDLastS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEDLastS.AutoSize = true;
            this.lblEDLastS.Location = new System.Drawing.Point(10, 184);
            this.lblEDLastS.Name = "lblEDLastS";
            this.lblEDLastS.Size = new System.Drawing.Size(68, 15);
            this.lblEDLastS.TabIndex = 3;
            this.lblEDLastS.Text = "Data sfarsit";
            // 
            // lblSDLastSub
            // 
            this.lblSDLastSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSDLastSub.AutoSize = true;
            this.lblSDLastSub.Location = new System.Drawing.Point(10, 147);
            this.lblSDLastSub.Name = "lblSDLastSub";
            this.lblSDLastSub.Size = new System.Drawing.Size(76, 15);
            this.lblSDLastSub.TabIndex = 2;
            this.lblSDLastSub.Text = "Data inceput";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(10, 77);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 15);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prenume";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToExpire)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEDLastS;
        private System.Windows.Forms.Label lblSDLastSub;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblBarCode;
        private System.Windows.Forms.NumericUpDown numericUpDownTopDays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewToExpire;
        private System.Windows.Forms.Label lblExpires;
    }
}
