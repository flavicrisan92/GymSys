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
            this.tabPageScans = new System.Windows.Forms.TabPage();
            this.dataGridViewMembersRep = new System.Windows.Forms.DataGridView();
            this.lblMembershipDate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblToDateMembers = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.dataGridViewScansReport = new System.Windows.Forms.DataGridView();
            this.lblToDateScans = new System.Windows.Forms.Label();
            this.dateTimePickerScansToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerScandFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblScanDate = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerateScansR = new System.Windows.Forms.Button();
            this.tabPageReportMemberships = new System.Windows.Forms.TabPage();
            this.tabControlReports.SuspendLayout();
            this.tabPage1MembersReport.SuspendLayout();
            this.tabPageScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabPage1MembersReport);
            this.tabControlReports.Controls.Add(this.tabPageScans);
            this.tabControlReports.Controls.Add(this.tabPageReportMemberships);
            this.tabControlReports.Location = new System.Drawing.Point(3, 4);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1082, 588);
            this.tabControlReports.TabIndex = 0;
            // 
            // tabPage1MembersReport
            // 
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
            this.tabPage1MembersReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1MembersReport.Size = new System.Drawing.Size(1074, 562);
            this.tabPage1MembersReport.TabIndex = 0;
            this.tabPage1MembersReport.Text = "Raport abonati noi";
            this.tabPage1MembersReport.UseVisualStyleBackColor = true;
            // 
            // tabPageScans
            // 
            this.tabPageScans.Controls.Add(this.btnGenerateScansR);
            this.tabPageScans.Controls.Add(this.lblToDateScans);
            this.tabPageScans.Controls.Add(this.dateTimePickerScansToDate);
            this.tabPageScans.Controls.Add(this.dateTimePickerScandFromDate);
            this.tabPageScans.Controls.Add(this.lblScanDate);
            this.tabPageScans.Controls.Add(this.dataGridViewScansReport);
            this.tabPageScans.Location = new System.Drawing.Point(4, 22);
            this.tabPageScans.Name = "tabPageScans";
            this.tabPageScans.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScans.Size = new System.Drawing.Size(1074, 562);
            this.tabPageScans.TabIndex = 1;
            this.tabPageScans.Text = "Raport scanri";
            this.tabPageScans.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMembersRep
            // 
            this.dataGridViewMembersRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembersRep.Location = new System.Drawing.Point(4, 99);
            this.dataGridViewMembersRep.Name = "dataGridViewMembersRep";
            this.dataGridViewMembersRep.Size = new System.Drawing.Size(1064, 457);
            this.dataGridViewMembersRep.TabIndex = 0;
            // 
            // lblMembershipDate
            // 
            this.lblMembershipDate.AutoSize = true;
            this.lblMembershipDate.Location = new System.Drawing.Point(6, 25);
            this.lblMembershipDate.Name = "lblMembershipDate";
            this.lblMembershipDate.Size = new System.Drawing.Size(100, 15);
            this.lblMembershipDate.TabIndex = 1;
            this.lblMembershipDate.Text = "Membrii din data";
            // 
            // dateTimePickerFromDateTime
            // 
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(113, 25);
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerFromDateTime.TabIndex = 2;
            // 
            // dateTimePickerToDateTime
            // 
            this.dateTimePickerToDateTime.Location = new System.Drawing.Point(406, 26);
            this.dateTimePickerToDateTime.Name = "dateTimePickerToDateTime";
            this.dateTimePickerToDateTime.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerToDateTime.TabIndex = 4;
            // 
            // lblToDateMembers
            // 
            this.lblToDateMembers.AutoSize = true;
            this.lblToDateMembers.Location = new System.Drawing.Point(356, 26);
            this.lblToDateMembers.Name = "lblToDateMembers";
            this.lblToDateMembers.Size = new System.Drawing.Size(44, 15);
            this.lblToDateMembers.TabIndex = 8;
            this.lblToDateMembers.Text = "la data";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1003, 73);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(1046, 74);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(14, 15);
            this.lblTotalCount.TabIndex = 11;
            this.lblTotalCount.Text = "0";
            // 
            // dataGridViewScansReport
            // 
            this.dataGridViewScansReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScansReport.Location = new System.Drawing.Point(7, 158);
            this.dataGridViewScansReport.Name = "dataGridViewScansReport";
            this.dataGridViewScansReport.Size = new System.Drawing.Size(1061, 401);
            this.dataGridViewScansReport.TabIndex = 0;
            // 
            // lblToDateScans
            // 
            this.lblToDateScans.AutoSize = true;
            this.lblToDateScans.Location = new System.Drawing.Point(343, 49);
            this.lblToDateScans.Name = "lblToDateScans";
            this.lblToDateScans.Size = new System.Drawing.Size(44, 15);
            this.lblToDateScans.TabIndex = 13;
            this.lblToDateScans.Text = "la data";
            // 
            // dateTimePickerScansToDate
            // 
            this.dateTimePickerScansToDate.Location = new System.Drawing.Point(393, 49);
            this.dateTimePickerScansToDate.Name = "dateTimePickerScansToDate";
            this.dateTimePickerScansToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerScansToDate.TabIndex = 12;
            // 
            // dateTimePickerScandFromDate
            // 
            this.dateTimePickerScandFromDate.Location = new System.Drawing.Point(120, 49);
            this.dateTimePickerScandFromDate.Name = "dateTimePickerScandFromDate";
            this.dateTimePickerScandFromDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerScandFromDate.TabIndex = 11;
            // 
            // lblScanDate
            // 
            this.lblScanDate.AutoSize = true;
            this.lblScanDate.Location = new System.Drawing.Point(18, 49);
            this.lblScanDate.Name = "lblScanDate";
            this.lblScanDate.Size = new System.Drawing.Size(96, 15);
            this.lblScanDate.TabIndex = 10;
            this.lblScanDate.Text = "Scanari din data";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(662, 25);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generare";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnGenerateScansR
            // 
            this.btnGenerateScansR.Location = new System.Drawing.Point(639, 49);
            this.btnGenerateScansR.Name = "btnGenerateScansR";
            this.btnGenerateScansR.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateScansR.TabIndex = 14;
            this.btnGenerateScansR.Text = "Generare";
            this.btnGenerateScansR.UseVisualStyleBackColor = true;
            // 
            // tabPageReportMemberships
            // 
            this.tabPageReportMemberships.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportMemberships.Name = "tabPageReportMemberships";
            this.tabPageReportMemberships.Size = new System.Drawing.Size(1074, 562);
            this.tabPageReportMemberships.TabIndex = 2;
            this.tabPageReportMemberships.Text = "Raport abonamente";
            this.tabPageReportMemberships.UseVisualStyleBackColor = true;
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlReports);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1089, 595);
            this.tabControlReports.ResumeLayout(false);
            this.tabPage1MembersReport.ResumeLayout(false);
            this.tabPage1MembersReport.PerformLayout();
            this.tabPageScans.ResumeLayout(false);
            this.tabPageScans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembersRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScansReport)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageReportMemberships;
    }
}
