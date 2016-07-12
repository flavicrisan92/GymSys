using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GymSys
{
    public partial class ucDashboard : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucDashboard _instanceMembers;
        DateTime dateToday = DateTime.Now.Date;

        //private System.Timers.Timer aTimer;

        private ucDashboard()
        {
            InitializeComponent();
            lblTodayCount.Text = db.Scans.Count(d => d.Date > dateToday).ToString();
            LoadScanList();
        }
        
        public void LoadScanList()
        {
            dataGridViewScans.DataSource = db.Scans.OrderByDescending(s=>s.Id).ToList();
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
