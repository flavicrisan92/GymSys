using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class ucDashboard : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucDashboard _instanceMembers;

        private ucDashboard()
        {
            InitializeComponent();
        }

        public static ucDashboard Instance
        {
            get { return _instanceMembers ?? (_instanceMembers = new ucDashboard()); }
        }

        public void SetFocusOnScan()
        {
            this.txtScanedCode.Focus();
        }

        private void txtScanedCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var scannedMember = db.Members.FirstOrDefault(m => m.Code == txtScanedCode.Text);
                if (scannedMember != null)
                {
                    Scans scan = new Scans
                    {
                        iduser = scannedMember.Id,
                        scandate = DateTime.Now
                    };
                    db.Scans.Add(scan);
                    db.SaveChanges();
                    MessageBox.Show(db.Scans.Count().ToString());
                }
                else
                {
                    MessageBox.Show("Membrul nu exista!");
                }
            }
        }
    }
}
