namespace GymSys
{
    partial class ucMembers
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
            this.components = new System.ComponentModel.Container();
            this.dataGVMembers = new System.Windows.Forms.DataGridView();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearchBoxName = new System.Windows.Forms.Label();
            this.lblUserMembership = new System.Windows.Forms.Label();
            this.dataGvMembershipHist = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMembersList = new System.Windows.Forms.Label();
            this.btnMembership = new System.Windows.Forms.Button();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvMembershipHist)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVMembers
            // 
            this.dataGVMembers.AllowUserToAddRows = false;
            this.dataGVMembers.AllowUserToDeleteRows = false;
            this.dataGVMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMembers.Location = new System.Drawing.Point(14, 76);
            this.dataGVMembers.MultiSelect = false;
            this.dataGVMembers.Name = "dataGVMembers";
            this.dataGVMembers.ReadOnly = true;
            this.dataGVMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVMembers.Size = new System.Drawing.Size(919, 596);
            this.dataGVMembers.TabIndex = 0;
            this.dataGVMembers.SelectionChanged += new System.EventHandler(this.dataGVMembers_SelectionChanged);
            this.dataGVMembers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGVMembers_MouseClick);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(810, 20);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(123, 23);
            this.btnNewMember.TabIndex = 12;
            this.btnNewMember.Text = "Abonat nou";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 11;
            // 
            // lblSearchBoxName
            // 
            this.lblSearchBoxName.AutoSize = true;
            this.lblSearchBoxName.Location = new System.Drawing.Point(11, 15);
            this.lblSearchBoxName.Name = "lblSearchBoxName";
            this.lblSearchBoxName.Size = new System.Drawing.Size(80, 15);
            this.lblSearchBoxName.TabIndex = 1;
            this.lblSearchBoxName.Text = "Cauta abonat";
            // 
            // lblUserMembership
            // 
            this.lblUserMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserMembership.AutoSize = true;
            this.lblUserMembership.Location = new System.Drawing.Point(936, 58);
            this.lblUserMembership.Name = "lblUserMembership";
            this.lblUserMembership.Size = new System.Drawing.Size(112, 15);
            this.lblUserMembership.TabIndex = 10;
            this.lblUserMembership.Text = "Istoric abonamente";
            // 
            // dataGvMembershipHist
            // 
            this.dataGvMembershipHist.AllowUserToAddRows = false;
            this.dataGvMembershipHist.AllowUserToDeleteRows = false;
            this.dataGvMembershipHist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGvMembershipHist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGvMembershipHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGvMembershipHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvMembershipHist.Location = new System.Drawing.Point(939, 76);
            this.dataGvMembershipHist.MultiSelect = false;
            this.dataGvMembershipHist.Name = "dataGvMembershipHist";
            this.dataGvMembershipHist.ReadOnly = true;
            this.dataGvMembershipHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGvMembershipHist.Size = new System.Drawing.Size(558, 596);
            this.dataGvMembershipHist.TabIndex = 9;
            this.dataGvMembershipHist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGvMembershipHist_MouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblMembersList);
            this.panel1.Controls.Add(this.btnMembership);
            this.panel1.Controls.Add(this.lblUserMembership);
            this.panel1.Controls.Add(this.dataGvMembershipHist);
            this.panel1.Controls.Add(this.btnNewMember);
            this.panel1.Controls.Add(this.dataGVMembers);
            this.panel1.Controls.Add(this.lblSearchBoxName);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 696);
            this.panel1.TabIndex = 13;
            // 
            // lblMembersList
            // 
            this.lblMembersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembersList.AutoSize = true;
            this.lblMembersList.Location = new System.Drawing.Point(11, 58);
            this.lblMembersList.Name = "lblMembersList";
            this.lblMembersList.Size = new System.Drawing.Size(77, 15);
            this.lblMembersList.TabIndex = 14;
            this.lblMembersList.Text = "Lista abonati";
            // 
            // btnMembership
            // 
            this.btnMembership.Location = new System.Drawing.Point(1351, 20);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(146, 23);
            this.btnMembership.TabIndex = 13;
            this.btnMembership.Text = "Prelungire abonament";
            this.btnMembership.UseVisualStyleBackColor = true;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // ucMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "ucMembers";
            this.Size = new System.Drawing.Size(1521, 701);
            this.Load += new System.EventHandler(this.ucMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvMembershipHist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVMembers;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.Label lblUserMembership;
        private System.Windows.Forms.DataGridView dataGvMembershipHist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearchBoxName;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Label lblMembersList;
    }
}
