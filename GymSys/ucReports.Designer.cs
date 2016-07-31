namespace GymSys
{
    partial class ucReports
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
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabPage1MembersReport = new System.Windows.Forms.TabPage();
            this.lblCountActiveMembers = new System.Windows.Forms.Label();
            this.lblActiveMembers = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSearchBoxName = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.dataGridViewCountByMonth = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblToDateMembers = new System.Windows.Forms.Label();
            this.dateTimePickerToDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblMembershipDate = new System.Windows.Forms.Label();
            this.dataGridViewMembersRep = new System.Windows.Forms.DataGridView();
            this.tabPageScans = new System.Windows.Forms.TabPage();
            this.btnResetGenerate = new System.Windows.Forms.Button();
            this.lblSearcScan = new System.Windows.Forms.Label();
            this.txtScanMember = new System.Windows.Forms.TextBox();
            this.btnScansGenerate = new System.Windows.Forms.Button();
            this.lblTotalScansCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DTPScansTD = new System.Windows.Forms.DateTimePicker();
            this.DTPScansFD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewScandGBM = new System.Windows.Forms.DataGridView();
            this.dataGridViewScansR = new System.Windows.Forms.DataGridView();
            this.RptAbPage = new System.Windows.Forms.TabPage();
            this.dataGridViewMembershipGroupByMonthR = new System.Windows.Forms.DataGridView();
            this.lblInactiveCount = new System.Windows.Forms.Label();
            this.lblInactive = new System.Windows.Forms.Label();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.lblTotalActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberMembershipR = new System.Windows.Forms.TextBox();
            this.lblTotalMembership = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetMembershipR = new System.Windows.Forms.Button();
            this.btnGenerateMembershipR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTDMembershipR = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFDMembershipR = new System.Windows.Forms.DateTimePicker();
            this.lblMembershipFrom = new System.Windows.Forms.Label();
            this.dataGridViewMembershipR = new System.Windows.Forms.DataGridView();
            this.panelReports = new System.Windows.Forms.Panel();
            this.tabControlReports.SuspendLayout();
            this.tabPage1MembersReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).BeginInit();
            this.tabPageScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScandGBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansR)).BeginInit();
            this.RptAbPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipGroupByMonthR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipR)).BeginInit();
            this.panelReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReports
            // 
            this.tabControlReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlReports.Controls.Add(this.tabPage1MembersReport);
            this.tabControlReports.Controls.Add(this.tabPageScans);
            this.tabControlReports.Controls.Add(this.RptAbPage);
            this.tabControlReports.Location = new System.Drawing.Point(0, 0);
            this.tabControlReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1733, 919);
            this.tabControlReports.TabIndex = 0;
            // 
            // tabPage1MembersReport
            // 
            this.tabPage1MembersReport.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1MembersReport.Controls.Add(this.lblCountActiveMembers);
            this.tabPage1MembersReport.Controls.Add(this.lblActiveMembers);
            this.tabPage1MembersReport.Controls.Add(this.btnReset);
            this.tabPage1MembersReport.Controls.Add(this.lblSearchBoxName);
            this.tabPage1MembersReport.Controls.Add(this.txtMember);
            this.tabPage1MembersReport.Controls.Add(this.dataGridViewCountByMonth);
            this.tabPage1MembersReport.Controls.Add(this.btnGenerate);
            this.tabPage1MembersReport.Controls.Add(this.lblTotalCount);
            this.tabPage1MembersReport.Controls.Add(this.lblTotal);
            this.tabPage1MembersReport.Controls.Add(this.lblToDateMembers);
            this.tabPage1MembersReport.Controls.Add(this.dateTimePickerToDateTime);
            this.tabPage1MembersReport.Controls.Add(this.dateTimePickerFromDateTime);
            this.tabPage1MembersReport.Controls.Add(this.lblMembershipDate);
            this.tabPage1MembersReport.Controls.Add(this.dataGridViewMembersRep);
            this.tabPage1MembersReport.Location = new System.Drawing.Point(4, 25);
            this.tabPage1MembersReport.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1MembersReport.Name = "tabPage1MembersReport";
            this.tabPage1MembersReport.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1MembersReport.Size = new System.Drawing.Size(1725, 890);
            this.tabPage1MembersReport.TabIndex = 0;
            this.tabPage1MembersReport.Text = "Raport abonati noi";
            // 
            // lblCountActiveMembers
            // 
            this.lblCountActiveMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountActiveMembers.AutoSize = true;
            this.lblCountActiveMembers.Location = new System.Drawing.Point(1053, 110);
            this.lblCountActiveMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountActiveMembers.Name = "lblCountActiveMembers";
            this.lblCountActiveMembers.Size = new System.Drawing.Size(16, 17);
            this.lblCountActiveMembers.TabIndex = 20;
            this.lblCountActiveMembers.Text = "0";
            // 
            // lblActiveMembers
            // 
            this.lblActiveMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveMembers.AutoSize = true;
            this.lblActiveMembers.Location = new System.Drawing.Point(949, 110);
            this.lblActiveMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveMembers.Name = "lblActiveMembers";
            this.lblActiveMembers.Size = new System.Drawing.Size(96, 17);
            this.lblActiveMembers.TabIndex = 19;
            this.lblActiveMembers.Text = "Abonati activi:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1027, 31);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSearchBoxName
            // 
            this.lblSearchBoxName.Location = new System.Drawing.Point(8, 81);
            this.lblSearchBoxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBoxName.Name = "lblSearchBoxName";
            this.lblSearchBoxName.Size = new System.Drawing.Size(112, 16);
            this.lblSearchBoxName.TabIndex = 16;
            this.lblSearchBoxName.Text = "Cauta abonat";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(151, 78);
            this.txtMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(300, 22);
            this.txtMember.TabIndex = 17;
            this.txtMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMember_KeyPress);
            this.txtMember.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMember_KeyUp);
            // 
            // dataGridViewCountByMonth
            // 
            this.dataGridViewCountByMonth.AllowUserToAddRows = false;
            this.dataGridViewCountByMonth.AllowUserToDeleteRows = false;
            this.dataGridViewCountByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCountByMonth.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCountByMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCountByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountByMonth.Location = new System.Drawing.Point(1261, 138);
            this.dataGridViewCountByMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCountByMonth.Name = "dataGridViewCountByMonth";
            this.dataGridViewCountByMonth.ReadOnly = true;
            this.dataGridViewCountByMonth.RowTemplate.Height = 24;
            this.dataGridViewCountByMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountByMonth.Size = new System.Drawing.Size(455, 743);
            this.dataGridViewCountByMonth.TabIndex = 15;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(907, 30);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 28);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generare";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(1204, 110);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(16, 17);
            this.lblTotalCount.TabIndex = 11;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1100, 110);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 17);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total abonati:";
            // 
            // lblToDateMembers
            // 
            this.lblToDateMembers.AutoSize = true;
            this.lblToDateMembers.Location = new System.Drawing.Point(493, 30);
            this.lblToDateMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDateMembers.Name = "lblToDateMembers";
            this.lblToDateMembers.Size = new System.Drawing.Size(51, 17);
            this.lblToDateMembers.TabIndex = 8;
            this.lblToDateMembers.Text = "la data";
            // 
            // dateTimePickerToDateTime
            // 
            this.dateTimePickerToDateTime.Location = new System.Drawing.Point(565, 31);
            this.dateTimePickerToDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerToDateTime.Name = "dateTimePickerToDateTime";
            this.dateTimePickerToDateTime.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerToDateTime.TabIndex = 4;
            // 
            // dateTimePickerFromDateTime
            // 
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(147, 31);
            this.dateTimePickerFromDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerFromDateTime.TabIndex = 2;
            // 
            // lblMembershipDate
            // 
            this.lblMembershipDate.AutoSize = true;
            this.lblMembershipDate.Location = new System.Drawing.Point(8, 31);
            this.lblMembershipDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembershipDate.Name = "lblMembershipDate";
            this.lblMembershipDate.Size = new System.Drawing.Size(132, 17);
            this.lblMembershipDate.TabIndex = 1;
            this.lblMembershipDate.Text = "Membri noi din data";
            // 
            // dataGridViewMembersRep
            // 
            this.dataGridViewMembersRep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMembersRep.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMembersRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMembersRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembersRep.Location = new System.Drawing.Point(5, 138);
            this.dataGridViewMembersRep.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMembersRep.Name = "dataGridViewMembersRep";
            this.dataGridViewMembersRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembersRep.Size = new System.Drawing.Size(1249, 742);
            this.dataGridViewMembersRep.TabIndex = 0;
            // 
            // tabPageScans
            // 
            this.tabPageScans.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPageScans.Controls.Add(this.btnResetGenerate);
            this.tabPageScans.Controls.Add(this.lblSearcScan);
            this.tabPageScans.Controls.Add(this.txtScanMember);
            this.tabPageScans.Controls.Add(this.btnScansGenerate);
            this.tabPageScans.Controls.Add(this.lblTotalScansCount);
            this.tabPageScans.Controls.Add(this.label8);
            this.tabPageScans.Controls.Add(this.label9);
            this.tabPageScans.Controls.Add(this.DTPScansTD);
            this.tabPageScans.Controls.Add(this.DTPScansFD);
            this.tabPageScans.Controls.Add(this.label10);
            this.tabPageScans.Controls.Add(this.dataGridViewScandGBM);
            this.tabPageScans.Controls.Add(this.dataGridViewScansR);
            this.tabPageScans.Location = new System.Drawing.Point(4, 25);
            this.tabPageScans.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageScans.Name = "tabPageScans";
            this.tabPageScans.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageScans.Size = new System.Drawing.Size(1725, 890);
            this.tabPageScans.TabIndex = 1;
            this.tabPageScans.Text = "Raport scanari";
            // 
            // btnResetGenerate
            // 
            this.btnResetGenerate.Location = new System.Drawing.Point(1027, 31);
            this.btnResetGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetGenerate.Name = "btnResetGenerate";
            this.btnResetGenerate.Size = new System.Drawing.Size(100, 28);
            this.btnResetGenerate.TabIndex = 34;
            this.btnResetGenerate.Text = "Reset";
            this.btnResetGenerate.UseVisualStyleBackColor = true;
            this.btnResetGenerate.Click += new System.EventHandler(this.btnResetGenerate_Click);
            // 
            // lblSearcScan
            // 
            this.lblSearcScan.Location = new System.Drawing.Point(8, 81);
            this.lblSearcScan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearcScan.Name = "lblSearcScan";
            this.lblSearcScan.Size = new System.Drawing.Size(112, 16);
            this.lblSearcScan.TabIndex = 32;
            this.lblSearcScan.Text = "Cauta abonat";
            // 
            // txtScanMember
            // 
            this.txtScanMember.Location = new System.Drawing.Point(151, 78);
            this.txtScanMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanMember.Name = "txtScanMember";
            this.txtScanMember.Size = new System.Drawing.Size(300, 22);
            this.txtScanMember.TabIndex = 33;
            this.txtScanMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanMember_KeyPress);
            this.txtScanMember.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtScanMember_KeyUp);
            // 
            // btnScansGenerate
            // 
            this.btnScansGenerate.Location = new System.Drawing.Point(907, 30);
            this.btnScansGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnScansGenerate.Name = "btnScansGenerate";
            this.btnScansGenerate.Size = new System.Drawing.Size(100, 28);
            this.btnScansGenerate.TabIndex = 31;
            this.btnScansGenerate.Text = "Generare";
            this.btnScansGenerate.UseVisualStyleBackColor = true;
            this.btnScansGenerate.Click += new System.EventHandler(this.btnScansGenerate_Click);
            // 
            // lblTotalScansCount
            // 
            this.lblTotalScansCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalScansCount.AutoSize = true;
            this.lblTotalScansCount.Location = new System.Drawing.Point(1202, 110);
            this.lblTotalScansCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalScansCount.Name = "lblTotalScansCount";
            this.lblTotalScansCount.Size = new System.Drawing.Size(16, 17);
            this.lblTotalScansCount.TabIndex = 30;
            this.lblTotalScansCount.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1100, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total scanari:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "la data";
            // 
            // DTPScansTD
            // 
            this.DTPScansTD.Location = new System.Drawing.Point(565, 31);
            this.DTPScansTD.Margin = new System.Windows.Forms.Padding(4);
            this.DTPScansTD.Name = "DTPScansTD";
            this.DTPScansTD.Size = new System.Drawing.Size(305, 22);
            this.DTPScansTD.TabIndex = 27;
            // 
            // DTPScansFD
            // 
            this.DTPScansFD.Location = new System.Drawing.Point(147, 31);
            this.DTPScansFD.Margin = new System.Windows.Forms.Padding(4);
            this.DTPScansFD.Name = "DTPScansFD";
            this.DTPScansFD.Size = new System.Drawing.Size(305, 22);
            this.DTPScansFD.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Scanari din data";
            // 
            // dataGridViewScandGBM
            // 
            this.dataGridViewScandGBM.AllowUserToAddRows = false;
            this.dataGridViewScandGBM.AllowUserToDeleteRows = false;
            this.dataGridViewScandGBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScandGBM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewScandGBM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewScandGBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScandGBM.Location = new System.Drawing.Point(1261, 138);
            this.dataGridViewScandGBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewScandGBM.Name = "dataGridViewScandGBM";
            this.dataGridViewScandGBM.ReadOnly = true;
            this.dataGridViewScandGBM.RowTemplate.Height = 24;
            this.dataGridViewScandGBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScandGBM.Size = new System.Drawing.Size(455, 743);
            this.dataGridViewScandGBM.TabIndex = 24;
            // 
            // dataGridViewScansR
            // 
            this.dataGridViewScansR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScansR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewScansR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewScansR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScansR.Location = new System.Drawing.Point(5, 138);
            this.dataGridViewScansR.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewScansR.Name = "dataGridViewScansR";
            this.dataGridViewScansR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScansR.Size = new System.Drawing.Size(1249, 742);
            this.dataGridViewScansR.TabIndex = 21;
            // 
            // RptAbPage
            // 
            this.RptAbPage.BackColor = System.Drawing.Color.AliceBlue;
            this.RptAbPage.Controls.Add(this.dataGridViewMembershipGroupByMonthR);
            this.RptAbPage.Controls.Add(this.lblInactiveCount);
            this.RptAbPage.Controls.Add(this.lblInactive);
            this.RptAbPage.Controls.Add(this.lblActiveCount);
            this.RptAbPage.Controls.Add(this.lblTotalActive);
            this.RptAbPage.Controls.Add(this.label5);
            this.RptAbPage.Controls.Add(this.txtMemberMembershipR);
            this.RptAbPage.Controls.Add(this.lblTotalMembership);
            this.RptAbPage.Controls.Add(this.label4);
            this.RptAbPage.Controls.Add(this.btnResetMembershipR);
            this.RptAbPage.Controls.Add(this.btnGenerateMembershipR);
            this.RptAbPage.Controls.Add(this.label1);
            this.RptAbPage.Controls.Add(this.dateTimePickerTDMembershipR);
            this.RptAbPage.Controls.Add(this.dateTimePickerFDMembershipR);
            this.RptAbPage.Controls.Add(this.lblMembershipFrom);
            this.RptAbPage.Controls.Add(this.dataGridViewMembershipR);
            this.RptAbPage.Location = new System.Drawing.Point(4, 25);
            this.RptAbPage.Margin = new System.Windows.Forms.Padding(4);
            this.RptAbPage.Name = "RptAbPage";
            this.RptAbPage.Size = new System.Drawing.Size(1725, 890);
            this.RptAbPage.TabIndex = 2;
            this.RptAbPage.Text = "Raport abonamente";
            // 
            // dataGridViewMembershipGroupByMonthR
            // 
            this.dataGridViewMembershipGroupByMonthR.AllowUserToAddRows = false;
            this.dataGridViewMembershipGroupByMonthR.AllowUserToDeleteRows = false;
            this.dataGridViewMembershipGroupByMonthR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMembershipGroupByMonthR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMembershipGroupByMonthR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMembershipGroupByMonthR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembershipGroupByMonthR.Location = new System.Drawing.Point(1261, 138);
            this.dataGridViewMembershipGroupByMonthR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMembershipGroupByMonthR.Name = "dataGridViewMembershipGroupByMonthR";
            this.dataGridViewMembershipGroupByMonthR.ReadOnly = true;
            this.dataGridViewMembershipGroupByMonthR.RowTemplate.Height = 24;
            this.dataGridViewMembershipGroupByMonthR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembershipGroupByMonthR.Size = new System.Drawing.Size(455, 743);
            this.dataGridViewMembershipGroupByMonthR.TabIndex = 31;
            // 
            // lblInactiveCount
            // 
            this.lblInactiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInactiveCount.AutoSize = true;
            this.lblInactiveCount.Location = new System.Drawing.Point(1055, 110);
            this.lblInactiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactiveCount.Name = "lblInactiveCount";
            this.lblInactiveCount.Size = new System.Drawing.Size(16, 17);
            this.lblInactiveCount.TabIndex = 30;
            this.lblInactiveCount.Text = "0";
            // 
            // lblInactive
            // 
            this.lblInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInactive.AutoSize = true;
            this.lblInactive.Location = new System.Drawing.Point(900, 110);
            this.lblInactive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInactive.Name = "lblInactive";
            this.lblInactive.Size = new System.Drawing.Size(144, 17);
            this.lblInactive.TabIndex = 29;
            this.lblInactive.Text = "Abonamente inactive:";
            // 
            // lblActiveCount
            // 
            this.lblActiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Location = new System.Drawing.Point(855, 110);
            this.lblActiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(16, 17);
            this.lblActiveCount.TabIndex = 28;
            this.lblActiveCount.Text = "0";
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(711, 110);
            this.lblTotalActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(133, 17);
            this.lblTotalActive.TabIndex = 27;
            this.lblTotalActive.Text = "Abonamente active:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cauta abonat";
            // 
            // txtMemberMembershipR
            // 
            this.txtMemberMembershipR.Location = new System.Drawing.Point(151, 78);
            this.txtMemberMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberMembershipR.Name = "txtMemberMembershipR";
            this.txtMemberMembershipR.Size = new System.Drawing.Size(300, 22);
            this.txtMemberMembershipR.TabIndex = 26;
            this.txtMemberMembershipR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberMembershipR_KeyPress);
            this.txtMemberMembershipR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemberMembershipR_KeyUp);
            // 
            // lblTotalMembership
            // 
            this.lblTotalMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMembership.AutoSize = true;
            this.lblTotalMembership.Location = new System.Drawing.Point(1226, 110);
            this.lblTotalMembership.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMembership.Name = "lblTotalMembership";
            this.lblTotalMembership.Size = new System.Drawing.Size(16, 17);
            this.lblTotalMembership.TabIndex = 24;
            this.lblTotalMembership.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1091, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total abonamente:";
            // 
            // btnResetMembershipR
            // 
            this.btnResetMembershipR.Location = new System.Drawing.Point(1027, 31);
            this.btnResetMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetMembershipR.Name = "btnResetMembershipR";
            this.btnResetMembershipR.Size = new System.Drawing.Size(100, 28);
            this.btnResetMembershipR.TabIndex = 20;
            this.btnResetMembershipR.Text = "Reset";
            this.btnResetMembershipR.UseVisualStyleBackColor = true;
            this.btnResetMembershipR.Click += new System.EventHandler(this.btnResetMembershipR_Click);
            // 
            // btnGenerateMembershipR
            // 
            this.btnGenerateMembershipR.Location = new System.Drawing.Point(907, 30);
            this.btnGenerateMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateMembershipR.Name = "btnGenerateMembershipR";
            this.btnGenerateMembershipR.Size = new System.Drawing.Size(100, 28);
            this.btnGenerateMembershipR.TabIndex = 19;
            this.btnGenerateMembershipR.Text = "Generare";
            this.btnGenerateMembershipR.UseVisualStyleBackColor = true;
            this.btnGenerateMembershipR.Click += new System.EventHandler(this.btnGenerateMembershipR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "la data";
            // 
            // dateTimePickerTDMembershipR
            // 
            this.dateTimePickerTDMembershipR.Location = new System.Drawing.Point(565, 31);
            this.dateTimePickerTDMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTDMembershipR.Name = "dateTimePickerTDMembershipR";
            this.dateTimePickerTDMembershipR.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerTDMembershipR.TabIndex = 11;
            // 
            // dateTimePickerFDMembershipR
            // 
            this.dateTimePickerFDMembershipR.Location = new System.Drawing.Point(147, 31);
            this.dateTimePickerFDMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFDMembershipR.Name = "dateTimePickerFDMembershipR";
            this.dateTimePickerFDMembershipR.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerFDMembershipR.TabIndex = 10;
            // 
            // lblMembershipFrom
            // 
            this.lblMembershipFrom.AutoSize = true;
            this.lblMembershipFrom.Location = new System.Drawing.Point(8, 31);
            this.lblMembershipFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembershipFrom.Name = "lblMembershipFrom";
            this.lblMembershipFrom.Size = new System.Drawing.Size(111, 17);
            this.lblMembershipFrom.TabIndex = 9;
            this.lblMembershipFrom.Text = "Abonati din data";
            // 
            // dataGridViewMembershipR
            // 
            this.dataGridViewMembershipR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMembershipR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMembershipR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMembershipR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembershipR.Location = new System.Drawing.Point(5, 138);
            this.dataGridViewMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMembershipR.Name = "dataGridViewMembershipR";
            this.dataGridViewMembershipR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembershipR.Size = new System.Drawing.Size(1249, 742);
            this.dataGridViewMembershipR.TabIndex = 1;
            // 
            // panelReports
            // 
            this.panelReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReports.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelReports.Controls.Add(this.tabControlReports);
            this.panelReports.Location = new System.Drawing.Point(0, 0);
            this.panelReports.Margin = new System.Windows.Forms.Padding(4);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(1733, 919);
            this.panelReports.TabIndex = 1;
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1733, 919);
            this.tabControlReports.ResumeLayout(false);
            this.tabPage1MembersReport.ResumeLayout(false);
            this.tabPage1MembersReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).EndInit();
            this.tabPageScans.ResumeLayout(false);
            this.tabPageScans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScandGBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansR)).EndInit();
            this.RptAbPage.ResumeLayout(false);
            this.RptAbPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipGroupByMonthR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipR)).EndInit();
            this.panelReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabPage1MembersReport;
        private System.Windows.Forms.TabPage tabPageScans;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblToDateMembers;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        private System.Windows.Forms.Label lblMembershipDate;
        private System.Windows.Forms.DataGridView dataGridViewMembersRep;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabPage RptAbPage;
        private System.Windows.Forms.DataGridView dataGridViewCountByMonth;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Label lblSearchBoxName;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTDMembershipR;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDMembershipR;
        private System.Windows.Forms.Label lblMembershipFrom;
        private System.Windows.Forms.DataGridView dataGridViewMembershipR;
        private System.Windows.Forms.Button btnResetMembershipR;
        private System.Windows.Forms.Button btnGenerateMembershipR;
        private System.Windows.Forms.Label lblTotalMembership;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberMembershipR;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.Label lblTotalActive;
        private System.Windows.Forms.Label lblInactiveCount;
        private System.Windows.Forms.Label lblInactive;
        private System.Windows.Forms.Label lblCountActiveMembers;
        private System.Windows.Forms.Label lblActiveMembers;
        private System.Windows.Forms.DataGridView dataGridViewMembershipGroupByMonthR;
        private System.Windows.Forms.DataGridView dataGridViewScandGBM;
        private System.Windows.Forms.DataGridView dataGridViewScansR;
        private System.Windows.Forms.Button btnResetGenerate;
        private System.Windows.Forms.Label lblSearcScan;
        private System.Windows.Forms.TextBox txtScanMember;
        private System.Windows.Forms.Button btnScansGenerate;
        private System.Windows.Forms.Label lblTotalScansCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTPScansTD;
        private System.Windows.Forms.DateTimePicker DTPScansFD;
        private System.Windows.Forms.Label label10;
    }
}
