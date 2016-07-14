namespace GymSys
{
    partial class ucAdministration
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
            this.tabControlAdministration = new System.Windows.Forms.TabControl();
            this.tabPageMembershipType = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMembershipType = new System.Windows.Forms.Button();
            this.dataGridViewMembershipTypes = new System.Windows.Forms.DataGridView();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.tabControlAdministration.SuspendLayout();
            this.tabPageMembershipType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipTypes)).BeginInit();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdministration
            // 
            this.tabControlAdministration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdministration.Controls.Add(this.tabPageMembershipType);
            this.tabControlAdministration.Controls.Add(this.tabPageUsers);
            this.tabControlAdministration.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdministration.Name = "tabControlAdministration";
            this.tabControlAdministration.SelectedIndex = 0;
            this.tabControlAdministration.Size = new System.Drawing.Size(1295, 730);
            this.tabControlAdministration.TabIndex = 1;
            // 
            // tabPageMembershipType
            // 
            this.tabPageMembershipType.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPageMembershipType.Controls.Add(this.label1);
            this.tabPageMembershipType.Controls.Add(this.btnNewMembershipType);
            this.tabPageMembershipType.Controls.Add(this.dataGridViewMembershipTypes);
            this.tabPageMembershipType.Location = new System.Drawing.Point(4, 22);
            this.tabPageMembershipType.Name = "tabPageMembershipType";
            this.tabPageMembershipType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembershipType.Size = new System.Drawing.Size(1287, 704);
            this.tabPageMembershipType.TabIndex = 0;
            this.tabPageMembershipType.Text = "Tipuri abonament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista abonamente";
            // 
            // btnNewMembershipType
            // 
            this.btnNewMembershipType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMembershipType.Location = new System.Drawing.Point(1129, 83);
            this.btnNewMembershipType.Name = "btnNewMembershipType";
            this.btnNewMembershipType.Size = new System.Drawing.Size(152, 23);
            this.btnNewMembershipType.TabIndex = 1;
            this.btnNewMembershipType.Text = "Adauga tip abonament";
            this.btnNewMembershipType.UseVisualStyleBackColor = true;
            this.btnNewMembershipType.Click += new System.EventHandler(this.btnNewMembershipType_Click);
            // 
            // dataGridViewMembershipTypes
            // 
            this.dataGridViewMembershipTypes.AllowUserToAddRows = false;
            this.dataGridViewMembershipTypes.AllowUserToDeleteRows = false;
            this.dataGridViewMembershipTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMembershipTypes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMembershipTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembershipTypes.Location = new System.Drawing.Point(0, 112);
            this.dataGridViewMembershipTypes.MultiSelect = false;
            this.dataGridViewMembershipTypes.Name = "dataGridViewMembershipTypes";
            this.dataGridViewMembershipTypes.ReadOnly = true;
            this.dataGridViewMembershipTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembershipTypes.Size = new System.Drawing.Size(1287, 592);
            this.dataGridViewMembershipTypes.TabIndex = 0;
            this.dataGridViewMembershipTypes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMembershipTypes_MouseClick);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPageUsers.Controls.Add(this.lblUsers);
            this.tabPageUsers.Controls.Add(this.btnAddNewUser);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1287, 704);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Utilizatori aplicatie";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(6, 16);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(91, 13);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "Utilizatori aplicatie";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewUser.Location = new System.Drawing.Point(1129, 83);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(152, 23);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "Adauga utilizator nou";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 112);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1287, 592);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUsers_MouseClick);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdmin.BackColor = System.Drawing.Color.White;
            this.panelAdmin.Controls.Add(this.tabControlAdministration);
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1297, 740);
            this.panelAdmin.TabIndex = 2;
            // 
            // ucAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAdmin);
            this.Name = "ucAdministration";
            this.Size = new System.Drawing.Size(1300, 747);
            this.tabControlAdministration.ResumeLayout(false);
            this.tabPageMembershipType.ResumeLayout(false);
            this.tabPageMembershipType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipTypes)).EndInit();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdministration;
        private System.Windows.Forms.TabPage tabPageMembershipType;
        private System.Windows.Forms.DataGridView dataGridViewMembershipTypes;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Button btnNewMembershipType;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label lblUsers;
    }
}
