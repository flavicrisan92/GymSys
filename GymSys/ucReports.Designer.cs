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
            this.RptAbPage = new System.Windows.Forms.TabPage();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.lblTotalActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberMembershipR = new System.Windows.Forms.TextBox();
            this.lblTotalMembership = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.cbMembershipType = new System.Windows.Forms.ComboBox();
            this.btnResetMembershipR = new System.Windows.Forms.Button();
            this.btnGenerateMembershipR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTDMembershipR = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFDMembershipR = new System.Windows.Forms.DateTimePicker();
            this.lblMembershipFrom = new System.Windows.Forms.Label();
            this.dataGridViewMembershipR = new System.Windows.Forms.DataGridView();
            this.panelReports = new System.Windows.Forms.Panel();
            this.lblInactiveCount = new System.Windows.Forms.Label();
            this.lblInactive = new System.Windows.Forms.Label();
            this.lblCountActiveMembers = new System.Windows.Forms.Label();
            this.lblActiveMembers = new System.Windows.Forms.Label();
            this.dataGridViewMembershipGroupByMonthR = new System.Windows.Forms.DataGridView();
            this.dataGridViewScandGBM = new System.Windows.Forms.DataGridView();
            this.dataGridViewScansR = new System.Windows.Forms.DataGridView();
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
            this.tabControlReports.SuspendLayout();
            this.tabPage1MembersReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).BeginInit();
            this.tabPageScans.SuspendLayout();
            this.RptAbPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipR)).BeginInit();
            this.panelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipGroupByMonthR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScandGBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansR)).BeginInit();
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
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1300, 747);
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
            this.tabPage1MembersReport.Location = new System.Drawing.Point(4, 22);
            this.tabPage1MembersReport.Name = "tabPage1MembersReport";
            this.tabPage1MembersReport.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1MembersReport.Size = new System.Drawing.Size(1292, 721);
            this.tabPage1MembersReport.TabIndex = 0;
            this.tabPage1MembersReport.Text = "Raport abonati noi";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(770, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSearchBoxName
            // 
            this.lblSearchBoxName.Location = new System.Drawing.Point(6, 70);
            this.lblSearchBoxName.Name = "lblSearchBoxName";
            this.lblSearchBoxName.Size = new System.Drawing.Size(84, 13);
            this.lblSearchBoxName.TabIndex = 16;
            this.lblSearchBoxName.Text = "Cauta abonat";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(113, 63);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(226, 20);
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
            this.dataGridViewCountByMonth.Location = new System.Drawing.Point(946, 112);
            this.dataGridViewCountByMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCountByMonth.Name = "dataGridViewCountByMonth";
            this.dataGridViewCountByMonth.ReadOnly = true;
            this.dataGridViewCountByMonth.RowTemplate.Height = 24;
            this.dataGridViewCountByMonth.Size = new System.Drawing.Size(341, 604);
            this.dataGridViewCountByMonth.TabIndex = 15;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(680, 24);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generare";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(903, 88);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCount.TabIndex = 11;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(825, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total abonati:";
            // 
            // lblToDateMembers
            // 
            this.lblToDateMembers.AutoSize = true;
            this.lblToDateMembers.Location = new System.Drawing.Point(368, 29);
            this.lblToDateMembers.Name = "lblToDateMembers";
            this.lblToDateMembers.Size = new System.Drawing.Size(39, 13);
            this.lblToDateMembers.TabIndex = 8;
            this.lblToDateMembers.Text = "la data";
            // 
            // dateTimePickerToDateTime
            // 
            this.dateTimePickerToDateTime.Location = new System.Drawing.Point(424, 25);
            this.dateTimePickerToDateTime.Name = "dateTimePickerToDateTime";
            this.dateTimePickerToDateTime.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerToDateTime.TabIndex = 4;
            // 
            // dateTimePickerFromDateTime
            // 
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(110, 25);
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerFromDateTime.TabIndex = 2;
            // 
            // lblMembershipDate
            // 
            this.lblMembershipDate.AutoSize = true;
            this.lblMembershipDate.Location = new System.Drawing.Point(6, 25);
            this.lblMembershipDate.Name = "lblMembershipDate";
            this.lblMembershipDate.Size = new System.Drawing.Size(82, 13);
            this.lblMembershipDate.TabIndex = 1;
            this.lblMembershipDate.Text = "Membri din data";
            // 
            // dataGridViewMembersRep
            // 
            this.dataGridViewMembersRep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMembersRep.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMembersRep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMembersRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembersRep.Location = new System.Drawing.Point(4, 112);
            this.dataGridViewMembersRep.Name = "dataGridViewMembersRep";
            this.dataGridViewMembersRep.Size = new System.Drawing.Size(937, 603);
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
            this.tabPageScans.Location = new System.Drawing.Point(4, 22);
            this.tabPageScans.Name = "tabPageScans";
            this.tabPageScans.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageScans.Size = new System.Drawing.Size(1292, 721);
            this.tabPageScans.TabIndex = 1;
            this.tabPageScans.Text = "Raport scanri";
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
            this.RptAbPage.Controls.Add(this.lblMembershipType);
            this.RptAbPage.Controls.Add(this.cbMembershipType);
            this.RptAbPage.Controls.Add(this.btnResetMembershipR);
            this.RptAbPage.Controls.Add(this.btnGenerateMembershipR);
            this.RptAbPage.Controls.Add(this.label1);
            this.RptAbPage.Controls.Add(this.dateTimePickerTDMembershipR);
            this.RptAbPage.Controls.Add(this.dateTimePickerFDMembershipR);
            this.RptAbPage.Controls.Add(this.lblMembershipFrom);
            this.RptAbPage.Controls.Add(this.dataGridViewMembershipR);
            this.RptAbPage.Location = new System.Drawing.Point(4, 22);
            this.RptAbPage.Name = "RptAbPage";
            this.RptAbPage.Size = new System.Drawing.Size(1292, 721);
            this.RptAbPage.TabIndex = 2;
            this.RptAbPage.Text = "Raport abonamente";
            // 
            // lblActiveCount
            // 
            this.lblActiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Location = new System.Drawing.Point(606, 87);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(13, 13);
            this.lblActiveCount.TabIndex = 28;
            this.lblActiveCount.Text = "0";
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(498, 87);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(102, 13);
            this.lblTotalActive.TabIndex = 27;
            this.lblTotalActive.Text = "Abonamente active:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cauta abonat";
            // 
            // txtMemberMembershipR
            // 
            this.txtMemberMembershipR.Location = new System.Drawing.Point(113, 63);
            this.txtMemberMembershipR.Name = "txtMemberMembershipR";
            this.txtMemberMembershipR.Size = new System.Drawing.Size(226, 20);
            this.txtMemberMembershipR.TabIndex = 26;
            this.txtMemberMembershipR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberMembershipR_KeyPress);
            this.txtMemberMembershipR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemberMembershipR_KeyUp);
            // 
            // lblTotalMembership
            // 
            this.lblTotalMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMembership.AutoSize = true;
            this.lblTotalMembership.Location = new System.Drawing.Point(826, 87);
            this.lblTotalMembership.Name = "lblTotalMembership";
            this.lblTotalMembership.Size = new System.Drawing.Size(13, 13);
            this.lblTotalMembership.TabIndex = 24;
            this.lblTotalMembership.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total:";
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(344, 64);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(78, 13);
            this.lblMembershipType.TabIndex = 22;
            this.lblMembershipType.Text = "Tip abonament";
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Location = new System.Drawing.Point(424, 64);
            this.cbMembershipType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(230, 21);
            this.cbMembershipType.TabIndex = 21;
            // 
            // btnResetMembershipR
            // 
            this.btnResetMembershipR.Location = new System.Drawing.Point(770, 25);
            this.btnResetMembershipR.Name = "btnResetMembershipR";
            this.btnResetMembershipR.Size = new System.Drawing.Size(75, 23);
            this.btnResetMembershipR.TabIndex = 20;
            this.btnResetMembershipR.Text = "Reset";
            this.btnResetMembershipR.UseVisualStyleBackColor = true;
            this.btnResetMembershipR.Click += new System.EventHandler(this.btnResetMembershipR_Click);
            // 
            // btnGenerateMembershipR
            // 
            this.btnGenerateMembershipR.Location = new System.Drawing.Point(680, 24);
            this.btnGenerateMembershipR.Name = "btnGenerateMembershipR";
            this.btnGenerateMembershipR.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateMembershipR.TabIndex = 19;
            this.btnGenerateMembershipR.Text = "Generare";
            this.btnGenerateMembershipR.UseVisualStyleBackColor = true;
            this.btnGenerateMembershipR.Click += new System.EventHandler(this.btnGenerateMembershipR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "la data";
            // 
            // dateTimePickerTDMembershipR
            // 
            this.dateTimePickerTDMembershipR.Location = new System.Drawing.Point(424, 25);
            this.dateTimePickerTDMembershipR.Name = "dateTimePickerTDMembershipR";
            this.dateTimePickerTDMembershipR.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerTDMembershipR.TabIndex = 11;
            // 
            // dateTimePickerFDMembershipR
            // 
            this.dateTimePickerFDMembershipR.Location = new System.Drawing.Point(110, 25);
            this.dateTimePickerFDMembershipR.Name = "dateTimePickerFDMembershipR";
            this.dateTimePickerFDMembershipR.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerFDMembershipR.TabIndex = 10;
            // 
            // lblMembershipFrom
            // 
            this.lblMembershipFrom.AutoSize = true;
            this.lblMembershipFrom.Location = new System.Drawing.Point(6, 25);
            this.lblMembershipFrom.Name = "lblMembershipFrom";
            this.lblMembershipFrom.Size = new System.Drawing.Size(84, 13);
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
            this.dataGridViewMembershipR.Location = new System.Drawing.Point(4, 112);
            this.dataGridViewMembershipR.Name = "dataGridViewMembershipR";
            this.dataGridViewMembershipR.Size = new System.Drawing.Size(937, 603);
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
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(1300, 747);
            this.panelReports.TabIndex = 1;
            // 
            // lblInactiveCount
            // 
            this.lblInactiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInactiveCount.AutoSize = true;
            this.lblInactiveCount.Location = new System.Drawing.Point(756, 87);
            this.lblInactiveCount.Name = "lblInactiveCount";
            this.lblInactiveCount.Size = new System.Drawing.Size(13, 13);
            this.lblInactiveCount.TabIndex = 30;
            this.lblInactiveCount.Text = "0";
            // 
            // lblInactive
            // 
            this.lblInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInactive.AutoSize = true;
            this.lblInactive.Location = new System.Drawing.Point(640, 87);
            this.lblInactive.Name = "lblInactive";
            this.lblInactive.Size = new System.Drawing.Size(110, 13);
            this.lblInactive.TabIndex = 29;
            this.lblInactive.Text = "Abonamente inactive:";
            // 
            // lblCountActiveMembers
            // 
            this.lblCountActiveMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountActiveMembers.AutoSize = true;
            this.lblCountActiveMembers.Location = new System.Drawing.Point(790, 88);
            this.lblCountActiveMembers.Name = "lblCountActiveMembers";
            this.lblCountActiveMembers.Size = new System.Drawing.Size(13, 13);
            this.lblCountActiveMembers.TabIndex = 20;
            this.lblCountActiveMembers.Text = "0";
            // 
            // lblActiveMembers
            // 
            this.lblActiveMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveMembers.AutoSize = true;
            this.lblActiveMembers.Location = new System.Drawing.Point(712, 88);
            this.lblActiveMembers.Name = "lblActiveMembers";
            this.lblActiveMembers.Size = new System.Drawing.Size(74, 13);
            this.lblActiveMembers.TabIndex = 19;
            this.lblActiveMembers.Text = "Abonati activi:";
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
            this.dataGridViewMembershipGroupByMonthR.Location = new System.Drawing.Point(946, 112);
            this.dataGridViewMembershipGroupByMonthR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMembershipGroupByMonthR.Name = "dataGridViewMembershipGroupByMonthR";
            this.dataGridViewMembershipGroupByMonthR.ReadOnly = true;
            this.dataGridViewMembershipGroupByMonthR.RowTemplate.Height = 24;
            this.dataGridViewMembershipGroupByMonthR.Size = new System.Drawing.Size(341, 604);
            this.dataGridViewMembershipGroupByMonthR.TabIndex = 31;
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
            this.dataGridViewScandGBM.Location = new System.Drawing.Point(946, 112);
            this.dataGridViewScandGBM.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewScandGBM.Name = "dataGridViewScandGBM";
            this.dataGridViewScandGBM.ReadOnly = true;
            this.dataGridViewScandGBM.RowTemplate.Height = 24;
            this.dataGridViewScandGBM.Size = new System.Drawing.Size(341, 604);
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
            this.dataGridViewScansR.Location = new System.Drawing.Point(4, 112);
            this.dataGridViewScansR.Name = "dataGridViewScansR";
            this.dataGridViewScansR.Size = new System.Drawing.Size(937, 603);
            this.dataGridViewScansR.TabIndex = 21;
            // 
            // btnResetGenerate
            // 
            this.btnResetGenerate.Location = new System.Drawing.Point(770, 25);
            this.btnResetGenerate.Name = "btnResetGenerate";
            this.btnResetGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnResetGenerate.TabIndex = 34;
            this.btnResetGenerate.Text = "Reset";
            this.btnResetGenerate.UseVisualStyleBackColor = true;
            // 
            // lblSearcScan
            // 
            this.lblSearcScan.Location = new System.Drawing.Point(6, 70);
            this.lblSearcScan.Name = "lblSearcScan";
            this.lblSearcScan.Size = new System.Drawing.Size(84, 13);
            this.lblSearcScan.TabIndex = 32;
            this.lblSearcScan.Text = "Cauta abonat";
            // 
            // txtScanMember
            // 
            this.txtScanMember.Location = new System.Drawing.Point(113, 63);
            this.txtScanMember.Name = "txtScanMember";
            this.txtScanMember.Size = new System.Drawing.Size(226, 20);
            this.txtScanMember.TabIndex = 33;
            this.txtScanMember.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanMember_KeyPress);
            this.txtScanMember.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtScanMember_KeyUp);
            // 
            // btnScansGenerate
            // 
            this.btnScansGenerate.Location = new System.Drawing.Point(680, 24);
            this.btnScansGenerate.Name = "btnScansGenerate";
            this.btnScansGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnScansGenerate.TabIndex = 31;
            this.btnScansGenerate.Text = "Generare";
            this.btnScansGenerate.UseVisualStyleBackColor = true;
            // 
            // lblTotalScansCount
            // 
            this.lblTotalScansCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalScansCount.AutoSize = true;
            this.lblTotalScansCount.Location = new System.Drawing.Point(903, 88);
            this.lblTotalScansCount.Name = "lblTotalScansCount";
            this.lblTotalScansCount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalScansCount.TabIndex = 30;
            this.lblTotalScansCount.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(825, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total scanari:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "la data";
            // 
            // DTPScansTD
            // 
            this.DTPScansTD.Location = new System.Drawing.Point(424, 25);
            this.DTPScansTD.Name = "DTPScansTD";
            this.DTPScansTD.Size = new System.Drawing.Size(230, 20);
            this.DTPScansTD.TabIndex = 27;
            // 
            // DTPScansFD
            // 
            this.DTPScansFD.Location = new System.Drawing.Point(110, 25);
            this.DTPScansFD.Name = "DTPScansFD";
            this.DTPScansFD.Size = new System.Drawing.Size(230, 20);
            this.DTPScansFD.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Scanari din data";
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelReports);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1300, 747);
            this.tabControlReports.ResumeLayout(false);
            this.tabPage1MembersReport.ResumeLayout(false);
            this.tabPage1MembersReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).EndInit();
            this.tabPageScans.ResumeLayout(false);
            this.tabPageScans.PerformLayout();
            this.RptAbPage.ResumeLayout(false);
            this.RptAbPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipR)).EndInit();
            this.panelReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipGroupByMonthR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScandGBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansR)).EndInit();
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
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.ComboBox cbMembershipType;
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
