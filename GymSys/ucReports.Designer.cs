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
            this.btnGenerateScansR = new System.Windows.Forms.Button();
            this.lblToDateScans = new System.Windows.Forms.Label();
            this.dateTimePickerScansToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerScandFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblScanDate = new System.Windows.Forms.Label();
            this.dataGridViewScansReport = new System.Windows.Forms.DataGridView();
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMembershipR = new System.Windows.Forms.DataGridView();
            this.panelReports = new System.Windows.Forms.Panel();
            this.tabControlReports.SuspendLayout();
            this.tabPage1MembersReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).BeginInit();
            this.tabPageScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansReport)).BeginInit();
            this.RptAbPage.SuspendLayout();
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
            this.tabControlReports.Size = new System.Drawing.Size(1500, 725);
            this.tabControlReports.TabIndex = 0;
            // 
            // tabPage1MembersReport
            // 
            this.tabPage1MembersReport.BackColor = System.Drawing.Color.AliceBlue;
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
            this.tabPage1MembersReport.Size = new System.Drawing.Size(1492, 696);
            this.tabPage1MembersReport.TabIndex = 0;
            this.tabPage1MembersReport.Text = "Raport abonati noi";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1002, 32);
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
            this.lblSearchBoxName.Location = new System.Drawing.Point(8, 87);
            this.lblSearchBoxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBoxName.Name = "lblSearchBoxName";
            this.lblSearchBoxName.Size = new System.Drawing.Size(88, 16);
            this.lblSearchBoxName.TabIndex = 16;
            this.lblSearchBoxName.Text = "Cauta abonat";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(151, 85);
            this.txtMember.Margin = new System.Windows.Forms.Padding(4);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(277, 22);
            this.txtMember.TabIndex = 17;
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
            this.dataGridViewCountByMonth.Location = new System.Drawing.Point(1002, 138);
            this.dataGridViewCountByMonth.Name = "dataGridViewCountByMonth";
            this.dataGridViewCountByMonth.ReadOnly = true;
            this.dataGridViewCountByMonth.RowTemplate.Height = 24;
            this.dataGridViewCountByMonth.Size = new System.Drawing.Size(461, 551);
            this.dataGridViewCountByMonth.TabIndex = 15;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(883, 31);
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
            this.lblTotalCount.Location = new System.Drawing.Point(970, 108);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 16);
            this.lblTotalCount.TabIndex = 11;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(912, 107);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblToDateMembers
            // 
            this.lblToDateMembers.AutoSize = true;
            this.lblToDateMembers.Location = new System.Drawing.Point(475, 32);
            this.lblToDateMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDateMembers.Name = "lblToDateMembers";
            this.lblToDateMembers.Size = new System.Drawing.Size(49, 16);
            this.lblToDateMembers.TabIndex = 8;
            this.lblToDateMembers.Text = "la data";
            // 
            // dateTimePickerToDateTime
            // 
            this.dateTimePickerToDateTime.Location = new System.Drawing.Point(541, 32);
            this.dateTimePickerToDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerToDateTime.Name = "dateTimePickerToDateTime";
            this.dateTimePickerToDateTime.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerToDateTime.TabIndex = 4;
            // 
            // dateTimePickerFromDateTime
            // 
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(151, 31);
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
            this.lblMembershipDate.Size = new System.Drawing.Size(107, 16);
            this.lblMembershipDate.TabIndex = 1;
            this.lblMembershipDate.Text = "Membrii din data";
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
            this.dataGridViewMembersRep.Size = new System.Drawing.Size(990, 551);
            this.dataGridViewMembersRep.TabIndex = 0;
            // 
            // tabPageScans
            // 
            this.tabPageScans.Controls.Add(this.btnGenerateScansR);
            this.tabPageScans.Controls.Add(this.lblToDateScans);
            this.tabPageScans.Controls.Add(this.dateTimePickerScansToDate);
            this.tabPageScans.Controls.Add(this.dateTimePickerScandFromDate);
            this.tabPageScans.Controls.Add(this.lblScanDate);
            this.tabPageScans.Controls.Add(this.dataGridViewScansReport);
            this.tabPageScans.Location = new System.Drawing.Point(4, 25);
            this.tabPageScans.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageScans.Name = "tabPageScans";
            this.tabPageScans.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageScans.Size = new System.Drawing.Size(1492, 696);
            this.tabPageScans.TabIndex = 1;
            this.tabPageScans.Text = "Raport scanri";
            this.tabPageScans.UseVisualStyleBackColor = true;
            // 
            // btnGenerateScansR
            // 
            this.btnGenerateScansR.Location = new System.Drawing.Point(852, 60);
            this.btnGenerateScansR.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateScansR.Name = "btnGenerateScansR";
            this.btnGenerateScansR.Size = new System.Drawing.Size(100, 28);
            this.btnGenerateScansR.TabIndex = 14;
            this.btnGenerateScansR.Text = "Generare";
            this.btnGenerateScansR.UseVisualStyleBackColor = true;
            // 
            // lblToDateScans
            // 
            this.lblToDateScans.AutoSize = true;
            this.lblToDateScans.Location = new System.Drawing.Point(457, 60);
            this.lblToDateScans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDateScans.Name = "lblToDateScans";
            this.lblToDateScans.Size = new System.Drawing.Size(49, 16);
            this.lblToDateScans.TabIndex = 13;
            this.lblToDateScans.Text = "la data";
            // 
            // dateTimePickerScansToDate
            // 
            this.dateTimePickerScansToDate.Location = new System.Drawing.Point(524, 60);
            this.dateTimePickerScansToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerScansToDate.Name = "dateTimePickerScansToDate";
            this.dateTimePickerScansToDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerScansToDate.TabIndex = 12;
            // 
            // dateTimePickerScandFromDate
            // 
            this.dateTimePickerScandFromDate.Location = new System.Drawing.Point(160, 60);
            this.dateTimePickerScandFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerScandFromDate.Name = "dateTimePickerScandFromDate";
            this.dateTimePickerScandFromDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerScandFromDate.TabIndex = 11;
            // 
            // lblScanDate
            // 
            this.lblScanDate.AutoSize = true;
            this.lblScanDate.Location = new System.Drawing.Point(24, 60);
            this.lblScanDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanDate.Name = "lblScanDate";
            this.lblScanDate.Size = new System.Drawing.Size(105, 16);
            this.lblScanDate.TabIndex = 10;
            this.lblScanDate.Text = "Scanari din data";
            // 
            // dataGridViewScansReport
            // 
            this.dataGridViewScansReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScansReport.Location = new System.Drawing.Point(9, 194);
            this.dataGridViewScansReport.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewScansReport.Name = "dataGridViewScansReport";
            this.dataGridViewScansReport.Size = new System.Drawing.Size(1415, 494);
            this.dataGridViewScansReport.TabIndex = 0;
            // 
            // RptAbPage
            // 
            this.RptAbPage.BackColor = System.Drawing.Color.AliceBlue;
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
            this.RptAbPage.Controls.Add(this.label2);
            this.RptAbPage.Controls.Add(this.dataGridViewMembershipR);
            this.RptAbPage.Location = new System.Drawing.Point(4, 25);
            this.RptAbPage.Margin = new System.Windows.Forms.Padding(4);
            this.RptAbPage.Name = "RptAbPage";
            this.RptAbPage.Size = new System.Drawing.Size(1492, 696);
            this.RptAbPage.TabIndex = 2;
            this.RptAbPage.Text = "Raport abonamente";
            // 
            // lblActiveCount
            // 
            this.lblActiveCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveCount.AutoSize = true;
            this.lblActiveCount.Location = new System.Drawing.Point(886, 110);
            this.lblActiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(15, 16);
            this.lblActiveCount.TabIndex = 28;
            this.lblActiveCount.Text = "0";
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.Location = new System.Drawing.Point(828, 109);
            this.lblTotalActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(48, 16);
            this.lblTotalActive.TabIndex = 27;
            this.lblTotalActive.Text = "Active:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cauta abonat";
            // 
            // txtMemberMembershipR
            // 
            this.txtMemberMembershipR.Location = new System.Drawing.Point(151, 77);
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
            this.lblTotalMembership.Location = new System.Drawing.Point(976, 111);
            this.lblTotalMembership.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMembership.Name = "lblTotalMembership";
            this.lblTotalMembership.Size = new System.Drawing.Size(15, 16);
            this.lblTotalMembership.TabIndex = 24;
            this.lblTotalMembership.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(918, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total:";
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(459, 79);
            this.lblMembershipType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(99, 16);
            this.lblMembershipType.TabIndex = 22;
            this.lblMembershipType.Text = "Tip abonament";
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Location = new System.Drawing.Point(565, 79);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(305, 24);
            this.cbMembershipType.TabIndex = 21;
            // 
            // btnResetMembershipR
            // 
            this.btnResetMembershipR.Location = new System.Drawing.Point(1026, 31);
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
            this.label1.Location = new System.Drawing.Point(492, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
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
            this.dateTimePickerFDMembershipR.Location = new System.Drawing.Point(146, 31);
            this.dateTimePickerFDMembershipR.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFDMembershipR.Name = "dateTimePickerFDMembershipR";
            this.dateTimePickerFDMembershipR.Size = new System.Drawing.Size(305, 22);
            this.dateTimePickerFDMembershipR.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Membrii din data";
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
            this.dataGridViewMembershipR.Size = new System.Drawing.Size(990, 551);
            this.dataGridViewMembershipR.TabIndex = 1;
            // 
            // panelReports
            // 
            this.panelReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReports.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelReports.Controls.Add(this.tabControlReports);
            this.panelReports.Location = new System.Drawing.Point(3, 0);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(1508, 729);
            this.panelReports.TabIndex = 1;
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1514, 732);
            this.tabControlReports.ResumeLayout(false);
            this.tabPage1MembersReport.ResumeLayout(false);
            this.tabPage1MembersReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).EndInit();
            this.tabPageScans.ResumeLayout(false);
            this.tabPageScans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansReport)).EndInit();
            this.RptAbPage.ResumeLayout(false);
            this.RptAbPage.PerformLayout();
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
        private System.Windows.Forms.Label lblToDateScans;
        private System.Windows.Forms.DateTimePicker dateTimePickerScansToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerScandFromDate;
        private System.Windows.Forms.Label lblScanDate;
        private System.Windows.Forms.DataGridView dataGridViewScansReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGenerateScansR;
        private System.Windows.Forms.TabPage RptAbPage;
        private System.Windows.Forms.DataGridView dataGridViewCountByMonth;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Label lblSearchBoxName;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTDMembershipR;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDMembershipR;
        private System.Windows.Forms.Label label2;
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
    }
}
