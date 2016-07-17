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
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEDLastS = new System.Windows.Forms.Label();
            this.lblSDLastSub = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewToExpire = new System.Windows.Forms.DataGridView();
            this.lblExpires = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelTopUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTopDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUsers)).BeginInit();
            this.panelBirthDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirthdays)).BeginInit();
            this.panelLastOneScanned.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToExpire)).BeginInit();
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
            this.lblTotalToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalToday.AutoSize = true;
            this.lblTotalToday.Location = new System.Drawing.Point(1016, 356);
            this.lblTotalToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalToday.Name = "lblTotalToday";
            this.lblTotalToday.Size = new System.Drawing.Size(145, 17);
            this.lblTotalToday.TabIndex = 2;
            this.lblTotalToday.Text = "Total prezente astazi:";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Location = new System.Drawing.Point(1169, 356);
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
            this.panelDashboard.Location = new System.Drawing.Point(0, 4);
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
            this.panelTopUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTopUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.numericUpDownTopDays.Location = new System.Drawing.Point(111, 11);
            this.numericUpDownTopDays.Name = "numericUpDownTopDays";
            this.numericUpDownTopDays.ReadOnly = true;
            this.numericUpDownTopDays.Size = new System.Drawing.Size(49, 22);
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
            this.dataGridViewTopUsers.Location = new System.Drawing.Point(-1, 41);
            this.dataGridViewTopUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTopUsers.Name = "dataGridViewTopUsers";
            this.dataGridViewTopUsers.ReadOnly = true;
            this.dataGridViewTopUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTopUsers.Size = new System.Drawing.Size(615, 193);
            this.dataGridViewTopUsers.TabIndex = 13;
            this.dataGridViewTopUsers.Click += new System.EventHandler(this.dataGridViewTopUsers_Click);
            // 
            // lblTop
            // 
            this.lblTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(2, 13);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(104, 17);
            this.lblTop.TabIndex = 8;
            this.lblTop.Text = "Top 15 abonati";
            // 
            // lblDaysn
            // 
            this.lblDaysn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysn.AutoSize = true;
            this.lblDaysn.Location = new System.Drawing.Point(165, 13);
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
            this.panelBirthDates.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBirthDates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.dataGridViewBirthdays.Location = new System.Drawing.Point(-1, 37);
            this.dataGridViewBirthdays.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBirthdays.Name = "dataGridViewBirthdays";
            this.dataGridViewBirthdays.ReadOnly = true;
            this.dataGridViewBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBirthdays.Size = new System.Drawing.Size(615, 197);
            this.dataGridViewBirthdays.TabIndex = 11;
            this.dataGridViewBirthdays.Click += new System.EventHandler(this.dataGridViewBirthdays_Click);
            // 
            // lblBirthdates
            // 
            this.lblBirthdates.AutoSize = true;
            this.lblBirthdates.Location = new System.Drawing.Point(4, 10);
            this.lblBirthdates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdates.Name = "lblBirthdates";
            this.lblBirthdates.Size = new System.Drawing.Size(203, 17);
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
            this.panelLastOneScanned.Location = new System.Drawing.Point(574, 28);
            this.panelLastOneScanned.Margin = new System.Windows.Forms.Padding(4);
            this.panelLastOneScanned.Name = "panelLastOneScanned";
            this.panelLastOneScanned.Size = new System.Drawing.Size(615, 321);
            this.panelLastOneScanned.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(129, 133);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(439, 22);
            this.txtCode.TabIndex = 13;
            // 
            // lblLastUser
            // 
            this.lblLastUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUser.AutoSize = true;
            this.lblLastUser.Location = new System.Drawing.Point(2, 11);
            this.lblLastUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUser.Name = "lblLastUser";
            this.lblLastUser.Size = new System.Drawing.Size(144, 17);
            this.lblLastUser.TabIndex = 7;
            this.lblLastUser.Text = "Ultimul abonat scanat";
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 137);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(33, 17);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Cod";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthdate.Enabled = false;
            this.txtBirthdate.Location = new System.Drawing.Point(129, 277);
            this.txtBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.ReadOnly = true;
            this.txtBirthdate.Size = new System.Drawing.Size(439, 22);
            this.txtBirthdate.TabIndex = 11;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(13, 277);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(90, 17);
            this.lblBirthdate.TabIndex = 10;
            this.lblBirthdate.Text = "Data nastere";
            // 
            // txtToDate
            // 
            this.txtToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDate.Enabled = false;
            this.txtToDate.Location = new System.Drawing.Point(129, 227);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.ReadOnly = true;
            this.txtToDate.Size = new System.Drawing.Size(439, 22);
            this.txtToDate.TabIndex = 7;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromDate.Enabled = false;
            this.txtFromDate.Location = new System.Drawing.Point(129, 178);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.ReadOnly = true;
            this.txtFromDate.Size = new System.Drawing.Size(439, 22);
            this.txtFromDate.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(129, 91);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(439, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(129, 47);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(439, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblEDLastS
            // 
            this.lblEDLastS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEDLastS.AutoSize = true;
            this.lblEDLastS.Location = new System.Drawing.Point(13, 227);
            this.lblEDLastS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEDLastS.Name = "lblEDLastS";
            this.lblEDLastS.Size = new System.Drawing.Size(80, 17);
            this.lblEDLastS.TabIndex = 3;
            this.lblEDLastS.Text = "Data sfarsit";
            // 
            // lblSDLastSub
            // 
            this.lblSDLastSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSDLastSub.AutoSize = true;
            this.lblSDLastSub.Location = new System.Drawing.Point(13, 181);
            this.lblSDLastSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDLastSub.Name = "lblSDLastSub";
            this.lblSDLastSub.Size = new System.Drawing.Size(88, 17);
            this.lblSDLastSub.TabIndex = 2;
            this.lblSDLastSub.Text = "Data inceput";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(13, 95);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prenume";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 51);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLastUser);
            this.panel1.Location = new System.Drawing.Point(574, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 41);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewToExpire);
            this.panel2.Controls.Add(this.lblExpires);
            this.panel2.Location = new System.Drawing.Point(1224, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 321);
            this.panel2.TabIndex = 12;
            // 
            // dataGridViewToExpire
            // 
            this.dataGridViewToExpire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewToExpire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToExpire.Location = new System.Drawing.Point(-1, 37);
            this.dataGridViewToExpire.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewToExpire.Name = "dataGridViewToExpire";
            this.dataGridViewToExpire.ReadOnly = true;
            this.dataGridViewToExpire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToExpire.Size = new System.Drawing.Size(615, 283);
            this.dataGridViewToExpire.TabIndex = 11;
            this.dataGridViewToExpire.Click += new System.EventHandler(this.dataGridViewToExpire_Click);
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Location = new System.Drawing.Point(4, 10);
            this.lblExpires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(290, 17);
            this.lblExpires.TabIndex = 7;
            this.lblExpires.Text = "Abonamente care expira saptamana aceasta";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToExpire)).EndInit();
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
