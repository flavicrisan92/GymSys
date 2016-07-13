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
            this.panelMembers = new System.Windows.Forms.Panel();
            this.lblTotalAbonati = new System.Windows.Forms.Label();
            this.lblMembersList = new System.Windows.Forms.Label();
            this.btnMembership = new System.Windows.Forms.Button();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvMembershipHist)).BeginInit();
            this.panelMembers.SuspendLayout();
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
            this.dataGVMembers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGVMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMembers.Location = new System.Drawing.Point(4, 127);
            this.dataGVMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGVMembers.MultiSelect = false;
            this.dataGVMembers.Name = "dataGVMembers";
            this.dataGVMembers.ReadOnly = true;
            this.dataGVMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVMembers.Size = new System.Drawing.Size(785, 576);
            this.dataGVMembers.TabIndex = 0;
            this.dataGVMembers.SelectionChanged += new System.EventHandler(this.dataGVMembers_SelectionChanged);
            this.dataGVMembers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGVMembers_MouseClick);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMember.Location = new System.Drawing.Point(625, 87);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(164, 28);
            this.btnNewMember.TabIndex = 12;
            this.btnNewMember.Text = "Abonat nou";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lblSearchBoxName
            // 
            this.lblSearchBoxName.Location = new System.Drawing.Point(14, 20);
            this.lblSearchBoxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBoxName.Name = "lblSearchBoxName";
            this.lblSearchBoxName.Size = new System.Drawing.Size(88, 16);
            this.lblSearchBoxName.TabIndex = 1;
            this.lblSearchBoxName.Text = "Cauta abonat";
            // 
            // lblUserMembership
            // 
            this.lblUserMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserMembership.Location = new System.Drawing.Point(797, 93);
            this.lblUserMembership.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserMembership.Name = "lblUserMembership";
            this.lblUserMembership.Size = new System.Drawing.Size(122, 16);
            this.lblUserMembership.TabIndex = 10;
            this.lblUserMembership.Text = "Istoric abonamente";
            // 
            // dataGvMembershipHist
            // 
            this.dataGvMembershipHist.AllowUserToAddRows = false;
            this.dataGvMembershipHist.AllowUserToDeleteRows = false;
            this.dataGvMembershipHist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGvMembershipHist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGvMembershipHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGvMembershipHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvMembershipHist.Location = new System.Drawing.Point(797, 127);
            this.dataGvMembershipHist.Margin = new System.Windows.Forms.Padding(4);
            this.dataGvMembershipHist.MultiSelect = false;
            this.dataGvMembershipHist.Name = "dataGvMembershipHist";
            this.dataGvMembershipHist.ReadOnly = true;
            this.dataGvMembershipHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGvMembershipHist.Size = new System.Drawing.Size(700, 576);
            this.dataGvMembershipHist.TabIndex = 9;
            this.dataGvMembershipHist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGvMembershipHist_MouseClick);
            // 
            // panelMembers
            // 
            this.panelMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMembers.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMembers.Controls.Add(this.lblTotalAbonati);
            this.panelMembers.Controls.Add(this.lblSearchBoxName);
            this.panelMembers.Controls.Add(this.dataGvMembershipHist);
            this.panelMembers.Controls.Add(this.lblMembersList);
            this.panelMembers.Controls.Add(this.btnNewMember);
            this.panelMembers.Controls.Add(this.textBox1);
            this.panelMembers.Controls.Add(this.lblUserMembership);
            this.panelMembers.Controls.Add(this.btnMembership);
            this.panelMembers.Controls.Add(this.dataGVMembers);
            this.panelMembers.Location = new System.Drawing.Point(0, 4);
            this.panelMembers.Margin = new System.Windows.Forms.Padding(4);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(1508, 729);
            this.panelMembers.TabIndex = 13;
            // 
            // lblTotalAbonati
            // 
            this.lblTotalAbonati.Location = new System.Drawing.Point(4, 93);
            this.lblTotalAbonati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAbonati.Name = "lblTotalAbonati";
            this.lblTotalAbonati.Size = new System.Drawing.Size(87, 16);
            this.lblTotalAbonati.TabIndex = 15;
            this.lblTotalAbonati.Text = "Total abonati";
            // 
            // lblMembersList
            // 
            this.lblMembersList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembersList.AutoSize = true;
            this.lblMembersList.Location = new System.Drawing.Point(-85, 72);
            this.lblMembersList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembersList.Name = "lblMembersList";
            this.lblMembersList.Size = new System.Drawing.Size(84, 16);
            this.lblMembersList.TabIndex = 14;
            this.lblMembersList.Text = "Lista abonati";
            // 
            // btnMembership
            // 
            this.btnMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMembership.Location = new System.Drawing.Point(1302, 87);
            this.btnMembership.Margin = new System.Windows.Forms.Padding(4);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(195, 28);
            this.btnMembership.TabIndex = 13;
            this.btnMembership.Text = "Abonament nou";
            this.btnMembership.UseVisualStyleBackColor = true;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // ucMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMembers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMembers";
            this.Size = new System.Drawing.Size(1514, 732);
            this.Load += new System.EventHandler(this.ucMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvMembershipHist)).EndInit();
            this.panelMembers.ResumeLayout(false);
            this.panelMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVMembers;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.Label lblUserMembership;
        private System.Windows.Forms.DataGridView dataGvMembershipHist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearchBoxName;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Panel panelMembers;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Label lblMembersList;
        private System.Windows.Forms.Label lblTotalAbonati;
    }
}
