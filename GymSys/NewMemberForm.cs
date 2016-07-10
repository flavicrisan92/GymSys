using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GymSys
{
    public partial class NewMemberForm : Form
    {
        LocalDBEntities db = new LocalDBEntities();
        private Actions.Operations _operation;
        private int _currentMemberOnEdit = 0;

        public NewMemberForm(Members member, Memberships membership, Actions.Operations operation)
        {
            _operation = operation;
            if (operation == Actions.Operations.EditMember)
            {
                _currentMemberOnEdit = member.Id;
            }
            InitializeComponent();
            SetUpComboBoxMembershipTypeSource();
            CheckOperation(operation, member, membership);
            SetUpDatetimeFields(membership, operation);
            SetUpPeriod("1");
        }

        private void CheckOperation(Actions.Operations operation, Members member, Memberships membership)
        {
            switch (operation)
            {
                case Actions.Operations.AddMember:
                    break;
                case Actions.Operations.EditMember:
                    SetUpMember(member);
                    SetupFrameEditMember();
                    break;
                case Actions.Operations.AddSubscription:
                    SetUpMember(member);
                    SetupFrameAddSubscription();
                    break;
                case Actions.Operations.EditSubscription:
                    SetupEditSubscription(membership);
                    break;

            }
        }

        private void SetupEditSubscription(Memberships membership)
        {
            this.Text = "Editare abonament";
            this.Height = 260;
            btnSave.Text = "Salvare";
            //Set readonly
            lblName.Visible = false;
            lblSurname.Visible = false;
            lblBirthDate.Visible = false;
            lblCode.Visible = false;
            txtCode.Visible = false;
            txtName.Visible = false;
            txtSurname.Visible = false;
            dateTimePickerBirthDate.Visible = false;
            comboBoxMembershipType.SelectedValue = membership.IdMembershipType;
            txtIdMembership.Text = membership.Id.ToString();
        }

        private void SetupFrameEditMember()
        {
            this.Text = "Editare abonat";
            btnSave.Text = "Salvare";
            lblMembershipType.Visible = false;
            lblStartDate.Visible = false;
            lblEndDateMembership.Visible = false;
            lblPeriod.Visible = false;
            comboBoxMembershipType.Visible = false;
            dateTimePickerStartMembership.Visible = false;
            dateTimePickerEndDateMembership.Visible = false;
            numericUpDownPeriod.Visible = false;
            comboBoxPeriod.Visible = false;
            this.Height = 260;
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
            var memberUpdated = from item in db.Members
                                    where item.Id == member.Id
                                select new
                                    {
                                        item.Code,
                                        item.Name,
                                        item.Surname,
                                        item.Birthdate
                                    };
            txtIdMember.Text = member.Id.ToString();
            txtCode.Text = memberUpdated.Select(m=>m.Code).FirstOrDefault().ToString();
            txtName.Text = memberUpdated.Select(m => m.Name).FirstOrDefault();
            txtSurname.Text = memberUpdated.Select(m => m.Surname).FirstOrDefault();
            var memberBirthday = memberUpdated.Select(m => m.Birthdate).FirstOrDefault();
            if (memberBirthday != null)
                dateTimePickerBirthDate.Value = memberBirthday.Value;
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

        private void SetUpDatetimeFields(Memberships memberships, Actions.Operations operation)
        {
            if (operation == Actions.Operations.EditSubscription)
            {
                dateTimePickerStartMembership.Format = DateTimePickerFormat.Custom;
                dateTimePickerStartMembership.CustomFormat = "dd/MM/yyyy";
                dateTimePickerStartMembership.Value = memberships.StartDate;

                dateTimePickerEndDateMembership.Format = DateTimePickerFormat.Custom;
                dateTimePickerEndDateMembership.CustomFormat = "dd/MM/yyyy";
                dateTimePickerEndDateMembership.Value = memberships.EndDate;
            }
            else
            {
                dateTimePickerStartMembership.Format = DateTimePickerFormat.Custom;
                dateTimePickerStartMembership.CustomFormat = "dd/MM/yyyy";

                dateTimePickerEndDateMembership.Format = DateTimePickerFormat.Custom;
                dateTimePickerEndDateMembership.CustomFormat = "dd/MM/yyyy";
                dateTimePickerEndDateMembership.Value = dateTimePickerStartMembership.Value.AddMonths(1);
            }
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_operation == Actions.Operations.AddMember)
            {
                ProcessAddMember();
            }
            else if (_operation == Actions.Operations.AddSubscription)
            {
                ProcessAddMembership();
            }
            else if (_operation == Actions.Operations.EditMember)
            {
                ProcessEditMember();
            }
            else if (_operation == Actions.Operations.EditSubscription)
            {
                ProcessEditSubscription();
            }
        }

        private void ProcessEditSubscription()
        {
            int idMembership;
            int.TryParse(txtIdMembership.Text, out idMembership);

            var membership = db.Memberships.FirstOrDefault(m => m.Id == idMembership);
            if (membership != null)
            {
                membership.StartDate = Utils.GetDateTimeParsed(dateTimePickerStartMembership.Text);
                membership.EndDate = Utils.GetDateTimeParsed(dateTimePickerEndDateMembership.Text);
                membership.IdMembershipType =
                    db.MembershipType.Where(m => m.Type == comboBoxMembershipType.Text)
                        .Select(m => m.Id)
                        .FirstOrDefault();
                db.SaveChanges();

                ((IObjectContextAdapter)db).ObjectContext.Refresh(RefreshMode.StoreWins, membership);
                Close();
                ucMembers.Instance.LoadSubscription(Actions.Operations.EditSubscription);
            }
        }

        private void ProcessEditMember()
        {
            int code;
            int.TryParse(txtCode.Text, out code);
            var member = db.Members.FirstOrDefault(m => m.Id == _currentMemberOnEdit);
            if (!db.Members.Any(m => m.Code == code && m.Id != _currentMemberOnEdit))
            {
                if (member != null)
                {
                    member.Name = txtName.Text;
                    member.Surname = txtSurname.Text;
                    member.Code = code;
                    member.Birthdate = Utils.GetDateTimeParsed(dateTimePickerBirthDate.Text);
                }
                db.SaveChanges();
                this.Close();
                ucMembers.Instance.LoadMembers(Actions.Operations.EditMember);
                ucMembers.Instance.LoadSubscription(Actions.Operations.EditMember);
            }
            else
            {
                MessageBox.Show("Acest cod este atasat altui abonat!");
            }
        }

        private void ProcessAddMembership()
        {
            if (Utils.ValidateNewUserAndMembership(_currentMemberOnEdit, txtName.Text, txtSurname.Text, txtCode.Text, numericUpDownPeriod.Text, comboBoxMembershipType.SelectedIndex, Actions.Operations.AddSubscription))
            {
                int code;
                int.TryParse(txtCode.Text, out code);
                Members member = null;
                //Get member
                if (_operation == Actions.Operations.AddSubscription)
                {
                    member = db.Members.FirstOrDefault(m => m.Code == code);
                }
                //Add subscription on add member/subscription
                if (member != null && _operation == Actions.Operations.AddSubscription)
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
                    ((IObjectContextAdapter)db).ObjectContext.Refresh(RefreshMode.StoreWins, member);
                }
                catch (Exception)
                {
                    // ignored
                }
                Close();
                ucMembers.Instance.LoadMembers(Actions.Operations.AddMember);
            }
        }
        
        private void ProcessAddMember()
        {
            if (Utils.ValidateNewUserAndMembership(_currentMemberOnEdit, txtName.Text, txtSurname.Text, txtCode.Text, numericUpDownPeriod.Text, comboBoxMembershipType.SelectedIndex, Actions.Operations.AddMember))
            {
                int code;
                int.TryParse(txtCode.Text, out code);
                Members member = null;

                //Get member
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
                //Add subscription on add member/subscription
                if (member != null && _operation == Actions.Operations.AddMember)
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
                ucMembers.Instance.LoadMembers(Actions.Operations.AddMember);
            }
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

        private void numericUpDownPeriod_ValueChanged(object sender, EventArgs e)
        {
                GetNumbericDropdownNumber();
        }
    }
}
