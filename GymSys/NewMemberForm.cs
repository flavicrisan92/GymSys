using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GymSys
{
    public partial class NewMemberForm : Form
    {
        LocalDBEntities db = new LocalDBEntities();
        private Actions.Operations _operation;
        public NewMemberForm(Members member, Actions.Operations operation)
        {
            _operation = operation;
            
            InitializeComponent();
            CheckOperation(operation, member);
            SetUpDatetimeFields();
            SetUpComboBoxMembershipTypeSource();
            SetUpPeriod("1");
        }

        private void CheckOperation(Actions.Operations operation, Members member)
        {
            switch (operation)
            {
                case Actions.Operations.AddMember:
                    break;
                case Actions.Operations.EditMember:
                    break;
                case Actions.Operations.AddSubscription:
                    SetUpMember(member);
                    SetupFrameAddSubscription();
                    break;
                case Actions.Operations.EditSubscription:
                    break;

            }
        }

        private void SetupFrameAddSubscription()
        {
            this.Text = "Abonament nou";
            
            //Set readonly
            txtCode.ReadOnly = true;
            txtName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            dateTimePickerBirthDate.Enabled = false;
        }
        private void SetupFrameAddAddMember()
        {
            this.Text = "Abonat nou";
        }

        private void SetUpMember(Members member)
        {
            txtCode.Text = member.Code.ToString();
            txtName.Text = member.Name;
            txtSurname.Text = member.Surname;
            if (member.Birthdate != null) dateTimePickerBirthDate.Value = member.Birthdate.Value;
        }

        private void SetUpPeriod(string number)
        {
            List<string> periodList = new List<string>();
            if (number != "1")
            {
                periodList.Add("Luni");
                periodList.Add("Zile");
                periodList.Add("Saptamani");
            }
            else
            {
                periodList.Add("Luna");
                periodList.Add("Zi");
                periodList.Add("Saptamana");
            }
            comboBoxPeriod.DataSource = periodList;
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
            dateTimePickerStartMembership.CustomFormat = "dd/MM/yyyy";

            dateTimePickerEndDateMembership.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDateMembership.CustomFormat = "dd/MM/yyyy";
            dateTimePickerEndDateMembership.Value = dateTimePickerStartMembership.Value.AddMonths(1);

            dateTimePickerBirthDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Utils.ValidateNewUserAndMembership(txtName.Text,txtSurname.Text, txtCode.Text, numericUpDownPeriod.Text, comboBoxMembershipType.SelectedIndex))
            {
                int code;
                int.TryParse(txtCode.Text, out code);
                Members member = null;
                if (_operation == Actions.Operations.AddMember)
                {
                    member = new Members
                    {
                        Code = code,
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Birthdate = DateTime.Parse(dateTimePickerBirthDate.Text),
                        Created = DateTime.Now,
                        IsActive = true
                    };
                    db.Members.Add(member);
                }
                else if(_operation == Actions.Operations.AddSubscription)
                {
                    member = db.Members.FirstOrDefault(m => m.Code == code);
                }
                if (member != null)
                {
                    Memberships memberships = new Memberships
                    {
                        IdMember = member.Id,
                        IdMembershipType =
                            db.MembershipType.Where(m => m.Type == comboBoxMembershipType.Text)
                                .Select(m => m.Id)
                                .FirstOrDefault(),
                        StartDate = Utils.GetDateTimeParsed(dateTimePickerStartMembership.Text),
                        EndDate = Utils.GetDateTimeParsed(dateTimePickerEndDateMembership.Text + " 23:59:59"),
                        IsActive = true
                    };

                    db.Memberships.Add(memberships);
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    // ignored
                }
                Close();
                ucMembers.Instance.LoadMembers();
                //ucMembers.Instance.LoadSubscription();
            }
        }

        private void numericUpDownPeriod_ValueChanged(object sender, EventArgs e)
        {
            GetNumbericDropdownNumber();
        }

        private void GetNumbericDropdownNumber()
        {
            var selectedcomboPeriodValue = comboBoxPeriod.SelectedIndex;
            SetUpPeriod(numericUpDownPeriod.Value.ToString(CultureInfo.InvariantCulture));
            comboBoxPeriod.SelectedIndex = selectedcomboPeriodValue;
            SetEndDate();
        }

        private void SetEndDate()
        {
            var startDate = Utils.GetDateTimeParsed(dateTimePickerStartMembership.Text);
            if (comboBoxPeriod.Text.StartsWith("Lun"))
            {
                dateTimePickerEndDateMembership.Value =
                    startDate.AddMonths(
                        int.Parse(numericUpDownPeriod.Value.ToString(CultureInfo.InvariantCulture)));
            }
            else if (comboBoxPeriod.Text.StartsWith("Zi"))
            {
                dateTimePickerEndDateMembership.Value =
                   startDate.AddDays(
                        int.Parse(numericUpDownPeriod.Value.ToString(CultureInfo.InvariantCulture)));
            }
            else if (comboBoxPeriod.Text.StartsWith("Sapt"))
            {
                dateTimePickerEndDateMembership.Value =
                    startDate.AddDays(7 *
                                                  int.Parse(
                                                      numericUpDownPeriod.Value.ToString(
                                                          CultureInfo.InvariantCulture)));
            }
        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEndDate();
        }
    }
}
