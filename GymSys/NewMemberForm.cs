using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class NewMemberForm : Form
    {
        LocalDBEntities db = new LocalDBEntities();
        public NewMemberForm()
        {
            InitializeComponent();
            SetUpDatetimeFields();
            SetUpComboBoxMembershipTypeSource();

        }

        private void SetUpComboBoxMembershipTypeSource()
        {
            comboBoxMembershipType.DataSource = db.MembershipType.ToList();
            comboBoxMembershipType.ValueMember = "id";
            comboBoxMembershipType.DisplayMember = "type";
        }

        private void SetUpDatetimeFields()
        {
            dateTimePickerStartMembership.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartMembership.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            dateTimePickerBirthDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                Members member = new Members();
                member.Code = int.Parse(txtCode.Text);
                member.Name = txtName.Text;
                member.Surname = txtSurname.Text;
                member.Birthdate = DateTime.Parse(dateTimePickerBirthDate.Text);
                member.Created = DateTime.Now;
                member.IsActive = true;

                Memberships memberships = new Memberships();
                memberships.IdMember = memberships.Id;
                memberships.IdMembershipType = db.MembershipType.Where(m=>m.Type == comboBoxMembershipType.Text).Select(m=>m.Id).FirstOrDefault();
                memberships.StartDate = DateTime.Parse(dateTimePickerStartMembership.Text);
                switch (comboBoxPeriod.Text)
                {
                    case "Luni":
                        memberships.EndDate =
                            memberships.StartDate.AddMonths(
                                int.Parse(numericUpDownPeriod.Value.ToString(CultureInfo.InvariantCulture)));
                        break;
                    case "Zile":
                        memberships.EndDate =
                memberships.StartDate.AddDays(
                    int.Parse(numericUpDownPeriod.Value.ToString(CultureInfo.InvariantCulture)));
                        break;
                    case "Saptamani":
                        memberships.EndDate =
                memberships.StartDate.AddDays(7 *
                    int.Parse(numericUpDownPeriod.Value.ToString(CultureInfo.InvariantCulture)));
                        break;
                }
                memberships.IsActive = true;
                db.Members.Add(member);
                db.Memberships.Add(memberships);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    // ignored
                }
                this.Close();
             ucMembers.Instance.LoadMembers();
            }
        }

        private new bool Validate()
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                return false;
            }
            if(string.IsNullOrEmpty(txtName.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                return false;
            }
            if (numericUpDownPeriod.Text == "0")
            {
                return false;
            }
            if (comboBoxMembershipType.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
