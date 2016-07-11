namespace GymSys
{
    partial class NewMemberForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.dateTimePickerStartMembership = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.comboBoxMembershipType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEndDateMembership = new System.Windows.Forms.DateTimePicker();
            this.lblEndDateMembership = new System.Windows.Forms.Label();
            this.txtIdMembership = new System.Windows.Forms.TextBox();
            this.txtIdMember = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(185, 139);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerBirthDate.TabIndex = 20;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSurname.Location = new System.Drawing.Point(187, 102);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(209, 20);
            this.txtSurname.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(187, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 18;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(187, 27);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(209, 20);
            this.txtCode.TabIndex = 17;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(28, 27);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 15);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "Cod card";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(185, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Creare";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(28, 139);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(77, 15);
            this.lblBirthDate.TabIndex = 14;
            this.lblBirthDate.Text = "Data nastere";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(28, 102);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(58, 15);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Prenume";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Nume";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(28, 263);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(142, 15);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Data inceput abonament";
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(29, 308);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(57, 15);
            this.lblPeriod.TabIndex = 22;
            this.lblPeriod.Text = "Perioada";
            // 
            // dateTimePickerStartMembership
            // 
            this.dateTimePickerStartMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStartMembership.Location = new System.Drawing.Point(194, 263);
            this.dateTimePickerStartMembership.Name = "dateTimePickerStartMembership";
            this.dateTimePickerStartMembership.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartMembership.TabIndex = 23;
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPeriod.Location = new System.Drawing.Point(194, 308);
            this.numericUpDownPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.ReadOnly = true;
            this.numericUpDownPeriod.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownPeriod.TabIndex = 25;
            this.numericUpDownPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPeriod.ValueChanged += new System.EventHandler(this.numericUpDownPeriod_ValueChanged);
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(275, 307);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriod.TabIndex = 26;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(29, 227);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(90, 15);
            this.lblMembershipType.TabIndex = 27;
            this.lblMembershipType.Text = "Tip abonament";
            // 
            // comboBoxMembershipType
            // 
            this.comboBoxMembershipType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMembershipType.FormattingEnabled = true;
            this.comboBoxMembershipType.Location = new System.Drawing.Point(194, 221);
            this.comboBoxMembershipType.Name = "comboBoxMembershipType";
            this.comboBoxMembershipType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMembershipType.TabIndex = 28;
            // 
            // dateTimePickerEndDateMembership
            // 
            this.dateTimePickerEndDateMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEndDateMembership.Location = new System.Drawing.Point(193, 348);
            this.dateTimePickerEndDateMembership.Name = "dateTimePickerEndDateMembership";
            this.dateTimePickerEndDateMembership.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDateMembership.TabIndex = 30;
            // 
            // lblEndDateMembership
            // 
            this.lblEndDateMembership.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEndDateMembership.AutoSize = true;
            this.lblEndDateMembership.Location = new System.Drawing.Point(27, 348);
            this.lblEndDateMembership.Name = "lblEndDateMembership";
            this.lblEndDateMembership.Size = new System.Drawing.Size(134, 15);
            this.lblEndDateMembership.TabIndex = 29;
            this.lblEndDateMembership.Text = "Data sfarsit abonament";
            // 
            // txtIdMembership
            // 
            this.txtIdMembership.Location = new System.Drawing.Point(30, 177);
            this.txtIdMembership.Name = "txtIdMembership";
            this.txtIdMembership.ReadOnly = true;
            this.txtIdMembership.Size = new System.Drawing.Size(35, 20);
            this.txtIdMembership.TabIndex = 31;
            // 
            // txtIdMember
            // 
            this.txtIdMember.Location = new System.Drawing.Point(126, 27);
            this.txtIdMember.Name = "txtIdMember";
            this.txtIdMember.ReadOnly = true;
            this.txtIdMember.Size = new System.Drawing.Size(44, 20);
            this.txtIdMember.TabIndex = 32;
            // 
            // NewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 430);
            this.Controls.Add(this.txtIdMember);
            this.Controls.Add(this.txtIdMembership);
            this.Controls.Add(this.dateTimePickerEndDateMembership);
            this.Controls.Add(this.lblEndDateMembership);
            this.Controls.Add(this.comboBoxMembershipType);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.dateTimePickerStartMembership);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonat nou";
            this.Load += new System.EventHandler(this.NewMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartMembership;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.ComboBox comboBoxMembershipType;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDateMembership;
        private System.Windows.Forms.Label lblEndDateMembership;
        private System.Windows.Forms.TextBox txtIdMembership;
        private System.Windows.Forms.TextBox txtIdMember;
    }
}