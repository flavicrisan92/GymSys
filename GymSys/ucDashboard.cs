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

namespace GymSys
{
    public partial class ucDashboard : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucDashboard _instanceMembers;
        DateTime dateToday = DateTime.Now.Date;
        private int days = 7;

        //private System.Timers.Timer aTimer;

        private ucDashboard()
        {
            InitializeComponent();
            lblTodayCount.Text = db.Scans.Count(d => d.Date > dateToday).ToString();
            LoadScanList();
            LoadBirhdays();
            LoadTopMembers(days);
        }


        public void LoadBirhdays()
        {
            var datetimeBd = DateTime.Now.Date.AddDays(8).AddSeconds(-5);
            var dtnow = DateTime.Now.Date;
            var members = from member in db.Members
                                      where member.IsActive
                          select member;

            //            && member.Birthdate >= dtnow && member.Birthdate.Value <= datetimeBd
            //orderby member.Birthdate descending
            //            select new
            //            {
            //                member.Id,
            //                Nume = member.Name,
            //                Prenume = member.Surname,
            //                Cod = member.Code,
            //                Data_Nastere = member.Birthdate
            //            };
            var query = from adr in members
                        where adr.Birthdate != null && adr.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0
                        let diffYears = EntityFunctions.DiffYears(adr.Birthdate, DateTime.Today)
                        let birthdayOccurred = adr.Birthdate.Value.Month < DateTime.Today.Month || 
                        (adr.Birthdate.Value.Day < DateTime.Today.Day && adr.Birthdate.Value.Month == DateTime.Today.Month)
                        let nextBirthdate = EntityFunctions.AddYears(adr.Birthdate, diffYears + (birthdayOccurred ? 1 : 0))
                        let daysToBirthdate = EntityFunctions.DiffDays(DateTime.Today, nextBirthdate)
                        orderby daysToBirthdate
                        select new
                        {
                            adr.Id,
                            Nume = adr.Name,
                            Prenume = adr.Surname,
                            Cod = adr.Code,
                            Data_Nastere = adr.Birthdate,
                            ZileRamase = daysToBirthdate
                        }; 
            dataGridViewBirthdays.DataSource = query.Take(15).ToList();
            dataGridViewBirthdays.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBirthdays.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadTopMembers(int days)
        {
            var fromDate = DateTime.Now.AddDays(-days);
            var topScans = from p in db.Scans
                               where p.Date >= fromDate
                               group p by new { idMember = p.IdMember, p.Members.Name, p.Members.Surname, p.Members.Code } into d
                               select new {IdMembru = d.Key.idMember, Nume = d.Key.Name, Prenume = d.Key.Surname, Cod = d.Key.Code, Prezente = d.Count() };
            topScans = topScans.OrderByDescending(s => s.Prezente).Take(15);
            dataGridViewTopUsers.DataSource = topScans.ToList();
            dataGridViewTopUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTopUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void LoadScanList()
        {
            var scans = from scan in db.Scans
                        orderby scan.Date descending
                        select new
                        {
                            scan.Members.Id,
                            Nume = scan.Members.Name,
                            Prenume = scan.Members.Surname,
                            Cod = scan.Members.Code,
                            Data_Nastere = scan.Members.Birthdate,
                            DataExpirareAbonament = scan.Members.Memberships.Select(s=>s.EndDate).Max(),
                            Abonament_Activ = scan.Members.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                            Data_scanare = scan.Date,
                            Data_inregistrare = scan.Members.Created,
                            Ultima_scanare = db.Scans.Where(s => s.IdMember == scan.IdMember).OrderByDescending(s => s.Id).Select(s => s.Date).FirstOrDefault()
                        };
            dataGridViewScans.DataSource = scans.ToList();

            dataGridViewScans.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewScans.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                    if (db.Memberships.Any(s => s.IdMember == scannedMember.Id && s.EndDate > dateTodayMax))
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
                            LoadScanList();
                            lblTodayCount.Text = db.Scans.Count(d => d.Date > dateToday).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Abonamentul este expirat!");
                    }
                }
                else
                {
                    MessageBox.Show("Membrul nu exista!");
                }

                txtScanedCode.Clear();
                LoadTopMembers(days);
            }
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
    }
}
