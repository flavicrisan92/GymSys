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

        private ucReports()
        {
            InitializeComponent();
            InitDateFields();

            LoadAllReports();
            //AddMembers();
            //DeleteMembers();
            //AddMembership();
            //AddScans();
        }

        private void AddScans()
        {
            foreach (var memberse in db.Members.ToList())
            {
                Scans scan = new Scans
                {
                    IdMember = memberse.Id,
                    Date = RandomDay()
                };
                db.Scans.Add(scan);
                db.SaveChanges();
            }
        }

        public void LoadAllReports()
        {
            InitDateFields();
            LoadMembersReport(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
            LoadMembershipReport(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
            LoadScans(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
        }

        private void InitDateFields()
        {
            InitDatePickerNewMembers();

            InitDatePickersMembership();

            InitDatePickersScans();
        }

        private void InitDatePickersScans()
        {
            DTPScansFD.Format = DateTimePickerFormat.Custom;
            DTPScansFD.CustomFormat = "dd/MM/yyyy";
            DTPScansFD.Value = DateTime.Now.Date.AddYears(-1);

            DTPScansTD.Format = DateTimePickerFormat.Custom;
            DTPScansTD.CustomFormat = "dd/MM/yyyy";
            DTPScansTD.Value= DateTime.Now.Date;
        }

        private void InitDatePickersMembership()
        {
            dateTimePickerFDMembershipR.Format = DateTimePickerFormat.Custom;
            dateTimePickerFDMembershipR.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFDMembershipR.Value = DateTime.Now.Date.AddYears(-1);

            dateTimePickerTDMembershipR.Format = DateTimePickerFormat.Custom;
            dateTimePickerTDMembershipR.CustomFormat = "dd/MM/yyyy";
            dateTimePickerTDMembershipR.Value = DateTime.Now.Date;
        }

        private void InitDatePickerNewMembers()
        {
            dateTimePickerFromDateTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerFromDateTime.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFromDateTime.Value = DateTime.Now.Date.AddYears(-1);

            dateTimePickerToDateTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerToDateTime.CustomFormat = "dd/MM/yyyy";
            dateTimePickerToDateTime.Value = DateTime.Now.Date;
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

        private void AddMembers()
        {
            for (var i = 0; i < 250; i++)
            {
                Members member = new Members
                {
                    Name = "Test",
                    Surname = "Test1",
                    Birthdate = RandomDay(),
                    Code = "123",
                    IsActive = true,
                    Created = RandomDay()
                };
                db.Members.Add(member);
                db.SaveChanges();
            }
        }

        private void AddMembership()
        {
            foreach (var memberse in db.Members.ToList())
            {
                Memberships newMemberships = new Memberships
                {
                    IdMember = memberse.Id,
                    StartDate = DateTime.Now.AddDays(-5),

                    EndDate = DateTime.Now.AddDays(-5).AddMonths(1),
                    IsActive = true,
                    IdMembershipType = db.MembershipType.Select(s => s.Id).FirstOrDefault()
                };
                db.Memberships.Add(newMemberships);

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

        private void LoadScans(DateTime fromDateTime, DateTime toDateTime, string searchValue)
        {
            fromDateTime = fromDateTime.Date;
            toDateTime = toDateTime.Date.AddDays(1).AddSeconds(-5);

            var scans = from scan in db.Scans
                        where scan.Date >= fromDateTime && scan.Date <= toDateTime
                        orderby scan.Date descending
                        select new
                        {
                            scan.Members.Id,
                            Nume = scan.Members.Name,
                            Prenume = scan.Members.Surname,
                            Cod = scan.Members.Code,
                            Data_nastere = scan.Members.Birthdate,
                            Data_inregistrare = scan.Members.Created,
                            Data_scanare = scan.Date,
                            Utilizator_activ = scan.Members.IsActive,
                            Abonament_activ = scan.Members.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                        };
            if (!string.IsNullOrEmpty(searchValue))
            {
                if (searchValue.Contains(" "))
                {
                    var delimiter = ' ';
                    var substrings = searchValue.Split(delimiter);
                    var firstSubstring = substrings[0];
                    if (substrings.Length == 1)
                    {
                        scans =
                            scans.Where(
                                m =>
                                    m.Nume.StartsWith(firstSubstring) || m.Prenume.StartsWith(firstSubstring));
                    }
                    else if (substrings.Length == 2)
                    {
                        var secondSubstring = substrings[1];
                        if (!string.IsNullOrEmpty(secondSubstring))
                        {
                            scans =
                                scans.Where(
                                    m =>
                                        (m.Nume.StartsWith(firstSubstring) && m.Prenume.StartsWith(secondSubstring)) ||
                                        (m.Nume.StartsWith(secondSubstring) && m.Prenume.StartsWith(firstSubstring)));
                        }
                        else
                        {
                            scans =
                           scans.Where(
                               m =>
                                   m.Nume.StartsWith(firstSubstring) || m.Prenume.StartsWith(firstSubstring));
                        }
                    }
                }
                else
                {
                    scans =
                     scans.Where(
                         m =>
                             m.Nume.StartsWith(searchValue) || m.Prenume.StartsWith(searchValue) ||
                             m.Cod.StartsWith(searchValue));
                }

            }
            lblTotalScansCount.Text = scans.Count().ToString();
            dataGridViewScansR.DataSource = scans.ToList();

            var id = dataGridViewScansR.Columns["Id"];
            if (id != null) id.Visible = false;

            dataGridViewScansR.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScansR.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var scansByMonth = from p in scans
                               where p.Data_scanare >= fromDateTime && p.Data_scanare <= toDateTime
                               group p by new { month = p.Data_scanare.Month, year = p.Data_scanare.Year } into d
                               select new { An = d.Key.year, Luna = d.Key.month, Numar_scanari = d.Count() };

            dataGridViewScandGBM.DataSource = scansByMonth.ToList();

            dataGridViewScandGBM.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScandGBM.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScandGBM.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadMembersReport(DateTime fromDateTime, DateTime toDateTime, string searchValue)
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
                              Data_nastere = member.Birthdate,
                              Data_inregistrare = member.Created,
                              Ultima_scanare = db.Scans.Where(s => s.IdMember == member.Id).OrderByDescending(s => s.Id).Select(s => s.Date).FirstOrDefault(),
                              Utilizator_activ = member.IsActive,
                              Abonament_activ = member.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                          };

            if (!string.IsNullOrEmpty(searchValue))
            {
                if (searchValue.Contains(" "))
                {
                    var delimiter = ' ';
                    var substrings = searchValue.Split(delimiter);
                    var firstSubstring = substrings[0];
                    if (substrings.Length == 1)
                    {
                        members =
                            members.Where(
                                m =>
                                    m.Nume.StartsWith(firstSubstring) || m.Prenume.StartsWith(firstSubstring));
                    }
                    else if (substrings.Length == 2)
                    {
                        var secondSubstring = substrings[1];
                        if (!string.IsNullOrEmpty(secondSubstring))
                        {
                            members =
                                members.Where(
                                    m =>
                                        (m.Nume.StartsWith(firstSubstring) && m.Prenume.StartsWith(secondSubstring)) ||
                                        (m.Nume.StartsWith(secondSubstring) && m.Prenume.StartsWith(firstSubstring)));
                        }
                        else
                        {
                            members =
                           members.Where(
                               m =>
                                   m.Nume.StartsWith(firstSubstring) || m.Prenume.StartsWith(firstSubstring));
                        }
                    }
                }
                else
                {
                    members =
                     members.Where(
                         m =>
                             m.Nume.StartsWith(searchValue) || m.Prenume.StartsWith(searchValue) ||
                             m.Cod.StartsWith(searchValue));
                }

            }

            dataGridViewMembersRep.DataSource = members.ToList();

            var id = dataGridViewMembersRep.Columns["Id"];
            if (id != null) id.Visible = false;

            lblTotalCount.Text = members.Count().ToString();

            lblCountActiveMembers.Text = members.Count(m => m.Abonament_activ).ToString();

            var newMembersByMonth = from p in members
                                    where p.Data_inregistrare >= fromDateTime && p.Data_inregistrare <= toDateTime
                                    group p by new { month = p.Data_inregistrare.Month, year = p.Data_inregistrare.Year } into d
                                    select new { An = d.Key.year, Luna = d.Key.month, Membri_noi = d.Count() };

            dataGridViewCountByMonth.DataSource = newMembersByMonth.OrderByDescending(s => s.An).ThenByDescending(s => s.Luna).ToList();
            dataGridViewCountByMonth.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCountByMonth.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCountByMonth.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //

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
            dataGridViewMembersRep.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadMembershipReport(DateTime fromDateTime, DateTime toDateTime, string searchValue)
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
                                     Data_inceput_abonament = membership.StartDate,
                                     Data_incheiere_abonament = membership.EndDate,
                                     Total_abonamente = db.Memberships.Count(s => s.IdMember == membership.Members.Id && s.StartDate >= fromDateTime && s.StartDate <= toDateTime),
                                     Utilizator_activ = membership.Members.IsActive,
                                     Abonament_activ = membership.StartDate <= DateTime.Now && membership.EndDate >= DateTime.Now
                                 };

            if (!string.IsNullOrEmpty(searchValue))
            {
                if (searchValue.Contains(" "))
                {
                    var delimiter = ' ';
                    var substrings = searchValue.Split(delimiter);
                    var firstSubstring = substrings[0];
                    if (substrings.Length == 1)
                    {
                        membershipList =
                            membershipList.Where(
                                m =>
                                    m.Nume.StartsWith(firstSubstring) || m.Prenume.StartsWith(firstSubstring));
                    }
                    else if (substrings.Length == 2)
                    {
                        var secondSubstring = substrings[1];
                        if (!string.IsNullOrEmpty(secondSubstring))
                        {
                            membershipList =
                                membershipList.Where(
                                    m =>
                                        (m.Nume.StartsWith(firstSubstring) && m.Prenume.StartsWith(secondSubstring)) ||
                                        (m.Nume.StartsWith(secondSubstring) && m.Prenume.StartsWith(firstSubstring)));
                        }
                        else
                        {
                            membershipList =
                           membershipList.Where(
                               m =>
                                   m.Nume.StartsWith(firstSubstring) || m.Prenume.StartsWith(firstSubstring));
                        }
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

            var id = dataGridViewMembershipR.Columns["Id"];
            if (id != null) id.Visible = false;

            lblTotalMembership.Text = membershipList.Count().ToString();
            lblActiveCount.Text = membershipList.Count(m => m.Abonament_activ).ToString();
            lblInactiveCount.Text = (membershipList.Count() - membershipList.Count(m => m.Abonament_activ)).ToString();

            var newMembershipsByMonth = from p in membershipList
                                        where p.Data_inscriere >= fromDateTime && p.Data_inscriere <= toDateTime
                                        group p by new { month = p.Data_inceput_abonament.Month, year = p.Data_inceput_abonament.Year } into d
                                        select new { An = d.Key.year, Luna = d.Key.month, Numar_abonamente = d.Count() };

            dataGridViewMembershipGroupByMonthR.DataSource = newMembershipsByMonth.OrderByDescending(d => d.An).ThenByDescending(d => d.Luna).ToList();


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
            dataGridViewMembershipR.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadMembersReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtMember.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMember.Clear();
            InitDatePickerNewMembers();
            LoadMembersReport(DateTime.Now.AddYears(-1), DateTime.MaxValue.AddDays(-2), string.Empty);
        }

        private void btnGenerateMembershipR_Click(object sender, EventArgs e)
        {
            LoadMembershipReport(dateTimePickerFDMembershipR.Value, dateTimePickerTDMembershipR.Value, txtMemberMembershipR.Text);
        }

        private void btnResetMembershipR_Click(object sender, EventArgs e)
        {
            txtMemberMembershipR.Clear();
            InitDatePickersMembership();
            LoadMembershipReport(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
        }

        private void txtMember_KeyUp(object sender, KeyEventArgs e)
        {
            LoadMembersReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtMember.Text);
        }

        private void txtMemberMembershipR_KeyUp(object sender, KeyEventArgs e)
        {
            LoadMembershipReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtMemberMembershipR.Text);
        }

        private void txtMemberMembershipR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Space && !txtMemberMembershipR.Text.Contains(" ")));
        }

        private void txtMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Space && !txtMember.Text.Contains(" ")));
        }

        private void txtScanMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Space && !txtMember.Text.Contains(" ")));
        }

        private void txtScanMember_KeyUp(object sender, KeyEventArgs e)
        {
            LoadScans(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value, txtScanMember.Text);
        }

        private void btnScansGenerate_Click(object sender, EventArgs e)
        {
            LoadScans(DTPScansFD.Value, DTPScansTD.Value.Date.AddDays(1).AddSeconds(-5), txtScanMember.Text);
        }

        private void btnResetGenerate_Click(object sender, EventArgs e)
        {
            txtScanMember.Clear();
            InitDatePickersScans();
            LoadScans(DateTime.Now.AddYears(-1), DateTime.Now.Date.AddDays(1).AddSeconds(-5), string.Empty);
        }
    }
}
