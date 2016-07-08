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
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dataGvMembershipHist = new System.Windows.Forms.DataGridView();
            this.lblUserMembership = new System.Windows.Forms.Label();
            this.lblSearchBoxName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvMembershipHist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVMembers
            // 
            this.dataGVMembers.AllowUserToAddRows = false;
            this.dataGVMembers.AllowUserToDeleteRows = false;
            this.dataGVMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVMembers.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGVMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMembers.Location = new System.Drawing.Point(8, 82);
            this.dataGVMembers.Name = "dataGVMembers";
            this.dataGVMembers.ReadOnly = true;
            this.dataGVMembers.Size = new System.Drawing.Size(938, 516);
            this.dataGVMembers.TabIndex = 0;
          
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-5, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnNewMember);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearchBoxName);
            this.splitContainer1.Panel1.Controls.Add(this.dataGVMembers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.lblUserMembership);
            this.splitContainer1.Panel2.Controls.Add(this.dataGvMembershipHist);
            this.splitContainer1.Panel2.Controls.Add(this.txtSurname);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.txtCode);
            this.splitContainer1.Panel2.Controls.Add(this.btnCode);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.lblBirthDate);
            this.splitContainer1.Panel2.Controls.Add(this.lblSurname);
            this.splitContainer1.Panel2.Controls.Add(this.lblName);
            this.splitContainer1.Size = new System.Drawing.Size(1387, 601);
            this.splitContainer1.SplitterDistance = 949;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(71, 162);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 15);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prenume";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(73, 194);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(77, 15);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Data nastere";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(183, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizati datele";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCode
            // 
            this.btnCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCode.AutoSize = true;
            this.btnCode.Location = new System.Drawing.Point(71, 87);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(56, 15);
            this.btnCode.TabIndex = 4;
            this.btnCode.Text = "Cod card";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(183, 82);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(209, 20);
            this.txtCode.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(183, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Location = new System.Drawing.Point(183, 157);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(209, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // dataGvMembershipHist
            // 
            this.dataGvMembershipHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGvMembershipHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvMembershipHist.Location = new System.Drawing.Point(3, 354);
            this.dataGvMembershipHist.Name = "dataGvMembershipHist";
            this.dataGvMembershipHist.Size = new System.Drawing.Size(411, 242);
            this.dataGvMembershipHist.TabIndex = 9;
            // 
            // lblUserMembership
            // 
            this.lblUserMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserMembership.AutoSize = true;
            this.lblUserMembership.Location = new System.Drawing.Point(57, 318);
            this.lblUserMembership.Name = "lblUserMembership";
            this.lblUserMembership.Size = new System.Drawing.Size(112, 15);
            this.lblUserMembership.TabIndex = 10;
            this.lblUserMembership.Text = "Istoric abonamente";
            // 
            // lblSearchBoxName
            // 
            this.lblSearchBoxName.AutoSize = true;
            this.lblSearchBoxName.Location = new System.Drawing.Point(9, 25);
            this.lblSearchBoxName.Name = "lblSearchBoxName";
            this.lblSearchBoxName.Size = new System.Drawing.Size(80, 15);
            this.lblSearchBoxName.TabIndex = 1;
            this.lblSearchBoxName.Text = "Cauta abonat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(823, 38);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(123, 23);
            this.btnNewMember.TabIndex = 12;
            this.btnNewMember.Text = "Abonat nou";
            this.btnNewMember.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // ucMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucMembers";
            this.Size = new System.Drawing.Size(1385, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvMembershipHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVMembers;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label btnCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserMembership;
        private System.Windows.Forms.DataGridView dataGvMembershipHist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearchBoxName;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
