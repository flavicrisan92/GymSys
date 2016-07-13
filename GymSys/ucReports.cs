using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class ucReports : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucReports _instanceMembers;

        public ucReports()
        {
            InitializeComponent();
            dateTimePickerFromDateTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerFromDateTime.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFromDateTime.Value = DateTime.Now.Date.AddYears(-1);

            dateTimePickerToDateTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerToDateTime.CustomFormat = "dd/MM/yyyy";

            dateTimePickerFDMembershipR.Format = DateTimePickerFormat.Custom;
            dateTimePickerFDMembershipR.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFDMembershipR.Value = DateTime.Now.Date.AddYears(-1);

            dateTimePickerFDMembershipR.Format = DateTimePickerFormat.Custom;
            dateTimePickerFDMembershipR.CustomFormat = "dd/MM/yyyy";

            LoadMembershipReport(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
            //AddMembers();
            //DeleteMembers();
        }

        private void DeleteMembers()
        {
            var date = DateTime.Now.AddDays(-3);
            foreach (var memberse in db.Members.Where(a => a.Created <= date).ToList())
            {
                db.Members.Remove(memberse);
            }

            db.SaveChanges();
        }

        public void AddMembers()
        {
            for (int i = 0; i < 250; i++)
            {
                Members member = new Members();
                member.Name = "Test";
                member.Surname = "Test1";
                member.Birthdate = DateTime.Now;
                member.Code = "123";
                member.IsActive = true;
                member.Created = RandomDay();
                db.Members.Add(member);
                db.SaveChanges();
            }
        }

        private DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2005, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public static ucReports Instance => _instanceMembers ?? (_instanceMembers = new ucReports());

        public void LoadMembersReport(DateTime fromDateTime, DateTime toDateTime, string searchValue)
        {
            fromDateTime = fromDateTime.Date;
            toDateTime = toDateTime.Date.AddDays(1).AddSeconds(-5);

            var members = from member in db.Members
                          where member.Created >= fromDateTime && member.Created <= toDateTime
                          orderby member.Created descending
                          select new
                          {
                              member.Id,
                              Nume = member.Name,
                              Prenume = member.Surname,
                              Cod = member.Code,
                              Data_Nastere = member.Birthdate,
                              Data_inregistrare = member.Created,
                              Abonament_Activ = member.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                              Ultima_scanare = db.Scans.Where(s => s.IdMember == member.Id).OrderByDescending(s => s.Id).Select(s => s.Date).FirstOrDefault()
                          };
            if (!string.IsNullOrEmpty(searchValue))
            {
                members =
                    members.Where(
                        m =>
                            m.Nume.StartsWith(searchValue) || m.Prenume.StartsWith(searchValue) ||
                            m.Cod.StartsWith(searchValue));
            }
            dataGridViewMembersRep.DataSource = members.ToList();


            var newMembersByMonth = from p in db.Members
                                    group p by new { month = p.Created.Month, year = p.Created.Year } into d
                                    select new { An = d.Key.year, Luna = d.Key.month, Membri = d.Count() };
            dataGridViewCountByMonth.DataSource = newMembersByMonth.OrderByDescending(s => s.An).ThenByDescending(s => s.Luna).ToList();
            dataGridViewCountByMonth.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCountByMonth.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCountByMonth.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //
            lblTotalCount.Text = members.Count().ToString();

            var dataGridViewColumn = dataGridViewMembersRep.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;

            dataGridViewMembersRep.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembersRep.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadMembershipReport(DateTime fromDateTime, DateTime toDateTime, string searchValue)
        {
            fromDateTime = fromDateTime.Date;
            toDateTime = toDateTime.Date.AddDays(1).AddSeconds(-5);

            var membershipList = from membership in db.Memberships
                                 where membership.StartDate >= fromDateTime && membership.StartDate <= toDateTime
                                 orderby membership.Id descending
                                 select new
                                 {
                                     membership.Id,
                                     Nume = membership.Members.Name,
                                     Prenume = membership.Members.Surname,
                                     Cod = membership.Members.Code,
                                     Data_inscriere = membership.Members.Created,
                                     Tip_abonament = membership.MembershipType.Type,
                                     Data_inceput = membership.StartDate,
                                     Data_incheiere = membership.EndDate,
                                     TotalAbonamente = db.Memberships.Count(s => s.IdMember == membership.Members.Id),
                                     Abonament_Activ = membership.StartDate <= DateTime.Now && membership.EndDate >= DateTime.Now
                                 };

            if (!string.IsNullOrEmpty(searchValue))
            {
                if (searchValue.Contains(" "))
                {
                    var delimiter = ' ';
                    var substrings = searchValue.Split(delimiter);
                    if (substrings.Length == 1)
                    {
                        membershipList =
                            membershipList.Where(
                                m =>
                                    m.Nume.StartsWith(substrings[0]) || m.Prenume.StartsWith(substrings[0]));
                    }
                    else if (substrings.Length == 2)
                    {
                        membershipList =
                          membershipList.Where(
                              m =>
                                  m.Nume.StartsWith(substrings[0]) || m.Prenume.StartsWith(substrings[1]) ||
                                  m.Nume.StartsWith(substrings[1]) || m.Prenume.StartsWith(substrings[0]));
                    }
                }
                else
                {
                    membershipList =
                     membershipList.Where(
                         m =>
                             m.Nume.StartsWith(searchValue) || m.Prenume.StartsWith(searchValue) ||
                             m.Cod.StartsWith(searchValue));
                }
                
            }

            dataGridViewMembershipR.DataSource = membershipList.ToList();
            lblTotalMembership.Text = membershipList.Count().ToString();
            lblActiveCount.Text = membershipList.Count(m => m.Abonament_Activ).ToString();

            dataGridViewMembershipR.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipR.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadMembersReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtMember.Text);
        }

        private void txtMember_KeyUp(object sender, KeyEventArgs e)
        {
            LoadMembersReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtMember.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMember.Clear();
            LoadMembersReport(DateTime.Now.AddYears(-1), DateTime.MaxValue.AddDays(-2), string.Empty);
        }

        private void btnGenerateMembershipR_Click(object sender, EventArgs e)
        {
            LoadMembershipReport(dateTimePickerFDMembershipR.Value, dateTimePickerTDMembershipR.Value, txtMemberMembershipR.Text);
        }

        private void btnResetMembershipR_Click(object sender, EventArgs e)
        {
            txtMemberMembershipR.Clear();
            LoadMembershipReport(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
        }

        private void txtMemberMembershipR_KeyUp(object sender, KeyEventArgs e)
        {
            LoadMembershipReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtMemberMembershipR.Text);
        }
        private void txtMemberMembershipR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Space && !txtMemberMembershipR.Text.Contains(" ")));
        }
    }
}
