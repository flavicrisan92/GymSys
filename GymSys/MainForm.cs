using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class MainForm : Form
    {
        private Users _user;

        public MainForm(Users user)
        {
            _user = user;
            InitializeComponent();
            LoadDashboard();
            ucDashboard.Instance.SetFocusOnScan();
            this.Text = "GYMSYS";
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucMembers.Instance))
            {
                panelMain.Controls.Add(ucMembers.Instance);
                ucMembers.Instance.Dock = DockStyle.Fill;
                ucMembers.Instance.BringToFront();
            }
            else
            {
                ucMembers.Instance.BringToFront();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!_user.IsAdmin)
            {
                btnAdministration.Visible = false;
            }
            WindowState = FormWindowState.Maximized;
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucAdministration.Instance))
            {
                panelMain.Controls.Add(ucAdministration.Instance);
                ucAdministration.Instance.Dock = DockStyle.Fill;
                ucAdministration.Instance.BringToFront();
            }
            else
            {
                ucAdministration.Instance.BringToFront();
            }
            ucAdministration.Instance.SetLoggedUser(_user);
        }

        private void LoadDashboard()
        {
            if (!panelMain.Controls.Contains(ucDashboard.Instance))
            {
                panelMain.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            else
            {
                ucDashboard.Instance.BringToFront();
            }
            ucDashboard.Instance.SetFocusOnScan();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucDashboard.Instance))
            {
                panelMain.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            else
            {
                ucDashboard.Instance.BringToFront();
            }

            ucDashboard.Instance.LoadScanList(false);
            ucDashboard.Instance.SetFocusOnScan();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucReports.Instance))
            {
                panelMain.Controls.Add(ucReports.Instance);
                ucReports.Instance.Dock = DockStyle.Fill;
                ucReports.Instance.BringToFront();
            }
            else
            {
                ucReports.Instance.BringToFront();
            }

            ucReports.Instance.LoadAllReports();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
