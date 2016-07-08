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
    public partial class ucMembers : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucMembers _instanceMembers;

        public static ucMembers Instance
        {
            get { return _instanceMembers ?? (_instanceMembers = new ucMembers()); }
        }
        public ucMembers()
        {
            InitializeComponent();
            lblUserMembership.Visible = false;
            dataGvMembershipHist.Visible = false;
            LoadMembers();
        }

        public void LoadMembers()
        {
            var members = from member in db.Members
                          where member.IsActive
                          orderby member.Created descending
                          select new
                          {
                              Id = member.Id,
                              Nume = member.Name,
                              Prenume = member.Surname,
                              Cod = member.Code,
                              Activ = member.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                              Data_Creare = member.Created,
                              Ultima_modificare = member.Modified
                          };
            dataGVMembers.DataSource = members.ToList();

            var dataGridViewColumn = dataGVMembers.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            NewMemberForm newMemberForm = new NewMemberForm();
            newMemberForm.Show();
        }

        private void dataGVMembers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int position = dataGVMembers.HitTest(e.X, e.Y).RowIndex;
                

                if (position >= 0 && dataGVMembers.SelectedRows.Count == 1)
                {
                    myMenu.Items.Add("Editare").Name = "Editare";
                    myMenu.Items.Add("Stergere").Name = "Stergere";
                }
                else if(position >= 0 && dataGVMembers.SelectedRows.Count > 1)
                {
                    myMenu.Items.Add("Stergere").Name = "Stergere";
                }
                myMenu.Show(dataGVMembers, new Point(e.X, e.Y));
                myMenu.ItemClicked += MyMenu_ItemClicked;
            }
        }

        private void MyMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "Editare":
                    foreach (DataGridViewRow row in dataGVMembers.SelectedRows)
                    {
                        string id = row.Cells[0].Value.ToString();
                    }
                    break;
                case "Stergere":
                    //Todo
                    foreach (DataGridViewRow row in dataGVMembers.SelectedRows)
                    {
                        string id = row.Cells[0].Value.ToString();
                        var memberToDelete = db.Members.FirstOrDefault(m => m.Id == int.Parse(id));
                        if (memberToDelete != null) memberToDelete.IsActive = false;
                        db.SaveChanges();
                    }
                    Instance.LoadMembers();
                    break;
            }
        }
    }
}
