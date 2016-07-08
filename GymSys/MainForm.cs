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
        public MainForm()
        {
            InitializeComponent();
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
            WindowState = FormWindowState.Maximized;
        }
    }
}
