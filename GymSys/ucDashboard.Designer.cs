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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScanedCode
            // 
            this.txtScanedCode.Location = new System.Drawing.Point(387, 155);
            this.txtScanedCode.Name = "txtScanedCode";
            this.txtScanedCode.Size = new System.Drawing.Size(228, 20);
            this.txtScanedCode.TabIndex = 0;
            this.txtScanedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanedCode_KeyDown);
            // 
            // dataGridViewScans
            // 
            this.dataGridViewScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScans.Location = new System.Drawing.Point(146, 263);
            this.dataGridViewScans.Name = "dataGridViewScans";
            this.dataGridViewScans.ReadOnly = true;
            this.dataGridViewScans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScans.Size = new System.Drawing.Size(809, 150);
            this.dataGridViewScans.TabIndex = 1;
            this.dataGridViewScans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewScans_MouseClick);
            // 
            // lblTotalToday
            // 
            this.lblTotalToday.AutoSize = true;
            this.lblTotalToday.Location = new System.Drawing.Point(693, 36);
            this.lblTotalToday.Name = "lblTotalToday";
            this.lblTotalToday.Size = new System.Drawing.Size(83, 15);
            this.lblTotalToday.TabIndex = 2;
            this.lblTotalToday.Text = "Abonati astazi";
            // 
            // lblTodayCount
            // 
            this.lblTodayCount.AutoSize = true;
            this.lblTodayCount.Location = new System.Drawing.Point(782, 36);
            this.lblTodayCount.Name = "lblTodayCount";
            this.lblTodayCount.Size = new System.Drawing.Size(14, 15);
            this.lblTodayCount.TabIndex = 3;
            this.lblTodayCount.Text = "0";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTodayCount);
            this.Controls.Add(this.lblTotalToday);
            this.Controls.Add(this.dataGridViewScans);
            this.Controls.Add(this.txtScanedCode);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1043, 451);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScanedCode;
        private System.Windows.Forms.DataGridView dataGridViewScans;
        private System.Windows.Forms.Label lblTotalToday;
        private System.Windows.Forms.Label lblTodayCount;
    }
}
