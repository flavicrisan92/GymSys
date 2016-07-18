using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.Objects;
using System.Globalization;

namespace GymSys
{
    public partial class ucDashboard : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucDashboard _instanceMembers;
        DateTime dateToday = DateTime.Now.Date;
        private int days = 7;


        private ucDashboard()
        {
            InitializeComponent();
            LoadScanList(false);
            LoadBirhdays();
            LoadTopMembers(days);
            LoadSubscriptionToExpire();
        }

        public void LoadSubscriptionToExpire()
        {
            var datetimeToday = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
            var subscriptions = from membership in db.Memberships
                                where EntityFunctions.DiffDays(datetimeToday, membership.EndDate) <= 7 && EntityFunctions.DiffDays(datetimeToday, membership.EndDate) >-1
                                select new
                                {
                                    Nume = membership.Members.Name,
                                    Prenume = membership.Members.Surname,
                                    Inceput_abonament = membership.StartDate,
                                    Incheiere_abonament = membership.EndDate,
                                    Zile_ramase = EntityFunctions.DiffDays(datetimeToday, membership.EndDate)
                                };
            dataGridViewToExpire.DataSource = subscriptions.ToList();

            dataGridViewToExpire.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewToExpire.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewToExpire.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewToExpire.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewToExpire.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadBirhdays()
        {
            var members = from member in db.Members
                          where member.IsActive
                          select member;

            var query = from adr in members
                        where adr.Birthdate != null && adr.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0
                        let diffYears = EntityFunctions.DiffYears(adr.Birthdate, DateTime.Today)
                        let birthdayOccurred = adr.Birthdate != null && (adr.Birthdate.Value.Month < DateTime.Today.Month ||
                                                                         (adr.Birthdate.Value.Day < DateTime.Today.Day && adr.Birthdate.Value.Month == DateTime.Today.Month))
                        let nextBirthdate = EntityFunctions.AddYears(adr.Birthdate, diffYears + (birthdayOccurred ? 1 : 0))
                        let daysToBirthdate = EntityFunctions.DiffDays(DateTime.Today.Date, nextBirthdate)
                        orderby daysToBirthdate
                        select new
                        {
                            Nume = adr.Name,
                            Prenume = adr.Surname,
                            Data_nastere = adr.Birthdate,
                            Zile_ramase = daysToBirthdate
                        };
            dataGridViewBirthdays.DataSource = query.Take(15).ToList();
            dataGridViewBirthdays.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadTopMembers(int days)
        {
            var fromDate = DateTime.Now.Date.AddDays(-days);
            var topScans = from p in db.Scans
                           where p.Date >= fromDate
                           group p by new { idMember = p.IdMember, p.Members.Name, p.Members.Surname, p.Members.Code } into d
                           select new { Nume = d.Key.Name, Prenume = d.Key.Surname, Cod = d.Key.Code, Prezente = d.Count() };
            topScans = topScans.OrderByDescending(s => s.Prezente).Take(15);
            dataGridViewTopUsers.DataSource = topScans.ToList();
            dataGridViewTopUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void LoadScanList(bool updateLastScanned)
        {
            var todayDate = DateTime.Now.Date;
            var getScans = from scan in db.Scans
                           where scan.Date > todayDate
                           orderby scan.Date descending
                           select scan;
            var scans = from scan in getScans
                        select new
                        {
                            Nume = scan.Members.Name,
                            Prenume = scan.Members.Surname,
                            Cod = scan.Members.Code,
                            Data_nastere = scan.Members.Birthdate,
                            Expirare_abonament = scan.Members.Memberships.Select(s => s.EndDate).Max(), //
                            Data_scanare = db.Scans.Where(s => s.IdMember == scan.IdMember).OrderByDescending(s => s.Id).Select(s => s.Date).FirstOrDefault(),
                            Abonament_Activ = scan.Members.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                        };

            dataGridViewScans.DataSource = scans.ToList();
            lblTodayCount.Text = scans.Count().ToString();
            dataGridViewScans.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (updateLastScanned)
            {
                var maxMembership = getScans.FirstOrDefault();
                if (maxMembership != null)
                {
                    var membshp = maxMembership.Members.Memberships.OrderByDescending(s => s.EndDate).FirstOrDefault();

                    SetUpLastScanned(getScans.Select(s => s.Members).FirstOrDefault(), membshp);
                }
            }
        }
        public static ucDashboard Instance
        {
            get { return _instanceMembers ?? (_instanceMembers = new ucDashboard()); }
        }

        private void txtScanedCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateTime dateTodayMax = dateToday.AddDays(1).Date.AddSeconds(-5);
                var scannedMember = db.Members.FirstOrDefault(m => m.Code == txtScanedCode.Text);

                if (scannedMember != null)
                {

                    var membership = db.Memberships.Where(s => s.IdMember == scannedMember.Id && s.EndDate > dateTodayMax).Select(s => s).OrderByDescending(s => s.Id).FirstOrDefault();
                    if (membership != null)
                    {
                        if (db.Scans.Count(s => s.IdMember == scannedMember.Id && s.Date > dateToday) == 0)
                        {
                            Scans scan = new Scans
                            {
                                IdMember = scannedMember.Id,
                                Date = DateTime.Now
                            };
                            db.Scans.Add(scan);
                            db.SaveChanges();
                            SetUpLastScanned(scannedMember, membership);
                            LoadScanList(false);
                        }
                        else
                        {
                            SetUpLastScanned(scannedMember, membership);
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Abonamentul este expirat. Doriti sa il prelungiti?", "Abonament expirat", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            NewMemberForm addSubscription = new NewMemberForm(scannedMember, null, Actions.Operations.AddSubscription, string.Empty, txtScanedCode.Text);
                            addSubscription.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }

                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Doriti sa adaugati un membru nou?", "Membru inexistent", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        NewMemberForm addmember = new NewMemberForm(null, null, Actions.Operations.AddMember, string.Empty, txtScanedCode.Text);
                        addmember.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }

                txtScanedCode.Clear();
                LoadTopMembers(days);
            }
        }

        public void SetUpLastScanned(Members scannedMember, Memberships membership)
        {
            txtName.Text = scannedMember.Name;
            txtSurname.Text = scannedMember.Surname;
            txtCode.Text = scannedMember.Code;
            if (scannedMember.Birthdate != null) txtBirthdate.Text = scannedMember.Birthdate.Value.ToString("dd/MM/yyyy");
            txtFromDate.Text = membership.StartDate.ToString("dd/MM/yyyy");
            txtToDate.Text = membership.EndDate.ToString("dd/MM/yyyy");
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            SetFocusOnScan();
        }

        public void SetFocusOnScan()
        {
            txtScanedCode.Select();
        }

        private void dataGridViewScans_MouseClick(object sender, MouseEventArgs e)
        {
            txtScanedCode.Select();
        }

        private void dataGridViewBirthdays_Click(object sender, EventArgs e)
        {
            ucDashboard.Instance.SetFocusOnScan();
        }

        private void dataGridViewTopUsers_Click(object sender, EventArgs e)
        {
            ucDashboard.Instance.SetFocusOnScan();
        }

        private void numericUpDownTopDays_ValueChanged(object sender, EventArgs e)
        {
            int numberOfDays;
            int.TryParse(numericUpDownTopDays.Value.ToString(CultureInfo.InvariantCulture), out numberOfDays);
            LoadTopMembers(numberOfDays);
            ucDashboard.Instance.SetFocusOnScan();
        }

        private void dataGridViewToExpire_Click(object sender, EventArgs e)
        {
            SetFocusOnScan();
        }
    }
}
