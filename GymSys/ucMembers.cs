using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GymSys
{
    public partial class ucMembers : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucMembers _instanceMembers;
        private int _membersSelectedRow = 0;

        public static ucMembers Instance
        {
            get { return _instanceMembers ?? (_instanceMembers = new ucMembers()); }
        }

        private ucMembers()
        {
            InitializeComponent();
            lblUserMembership.Visible = false;
            dataGvMembershipHist.Visible = false;
            LoadMembers(Actions.Operations.NotSpecified);
        }

        private void ProcessDeleteMember()
        {
            int idmember = 0;

            Members memberToDelete = null;
            foreach (DataGridViewRow row in dataGVMembers.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                int.TryParse(id, out idmember);
                memberToDelete = db.Members.FirstOrDefault(m => m.Id == idmember);

            }
            if (memberToDelete != null)
            {
                var confirmResult =
                    MessageBox.Show(
                        "Sunteti siguri ca doriti sa stergeti utilizatorul selectat?", "Confirm!!",
                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    memberToDelete.IsActive = false;
                    db.SaveChanges();
                    Instance.LoadMembers(Actions.Operations.DeleteMember);
                }
            }
        }

        public void LoadSubscription(Actions.Operations operation)
        {
            if (dataGVMembers.SelectedRows.Count == 1)
            {
                lblUserMembership.Visible = true;
                foreach (DataGridViewRow row in dataGVMembers.SelectedRows)
                {
                    int idint;
                    string id = row.Cells[0].Value.ToString();
                    int.TryParse(id, out idint);

                    var membershipHist = from membership in db.Memberships
                                         where membership.IdMember == idint && membership.IsActive
                                         orderby membership.Id descending
                                         select new
                                         {
                                             membership.Id,
                                             TipAbonament = membership.MembershipType.Type,
                                             DataInceput = membership.StartDate,
                                             DataSfarsit = membership.EndDate,
                                             Status = DateTime.Now < membership.EndDate ? "Activ" : "Expirat"
                                         };

                    dataGvMembershipHist.DataSource = membershipHist.ToList();

                    dataGvMembershipHist.Visible = true;
                    var dataGridViewColumn = dataGvMembershipHist.Columns["Id"];
                    if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
                    dataGvMembershipHist.Columns[0].Width = 135;
                    dataGvMembershipHist.Columns[1].Width = 135;
                    dataGvMembershipHist.Columns[2].Width = 135;
                    dataGvMembershipHist.Columns[3].Width = 135;
                    dataGvMembershipHist.Columns[4].Width = 100;
                }
            }
            else
            {
                dataGvMembershipHist.Visible = false;
                lblUserMembership.Visible = false;
            }
            if (operation == Actions.Operations.DeleteMemberhip)
            {
                if (_membersSelectedRow > 0)
                {
                    dataGVMembers.ClearSelection();
                    dataGVMembers.Rows[_membersSelectedRow].Selected = true;
                }
            }
        }

        public void LoadMembers(Actions.Operations operation)
        {
            var members = from member in db.Members
                          where member.IsActive
                          orderby member.Created descending
                          select new
                          {
                              member.Id,
                              Nume = member.Name,
                              Prenume = member.Surname,
                              Cod = member.Code,
                              Activ = member.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                              Data_Nastere = member.Birthdate,
                              Data_inregistrare = member.Created
                          };
            dataGVMembers.DataSource = members.ToList();

            var dataGridViewColumn = dataGVMembers.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            dataGVMembers.Columns[0].Width = 150;
            dataGVMembers.Columns[1].Width = 150;
            dataGVMembers.Columns[2].Width = 150;
            dataGVMembers.Columns[3].Width = 120;
            dataGVMembers.Columns[4].Width = 150;
            dataGVMembers.Columns[5].Width = 150;
            dataGVMembers.Columns[6].Width = 150;

            if (operation != Actions.Operations.DeleteMember)
            {
                if (_membersSelectedRow > 0)
                {
                    dataGVMembers.ClearSelection();
                    dataGVMembers.Rows[_membersSelectedRow].Selected = true;
                }
            }

            if (!members.Any())
            {
                btnMembership.Visible = false;
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            NewMemberForm newMemberForm = new NewMemberForm(null, null, Actions.Operations.AddMember);
            newMemberForm.Show();
        }

        private void dataGVMembers_MouseClick(object sender, MouseEventArgs e)
        {
            int position = dataGVMembers.HitTest(e.X, e.Y).RowIndex;
            _membersSelectedRow = position;
            if (position >= 0)
            {
                dataGVMembers.Rows[_membersSelectedRow].Selected = true;
                btnMembership.Visible = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();

                if (position >= 0 && dataGVMembers.SelectedRows.Count == 1)
                {
                    myMenu.Items.Add("Editare").Name = "Editare";
                    myMenu.Items.Add("Stergere").Name = "Stergere";
                }
                else if (position >= 0 && dataGVMembers.SelectedRows.Count > 1)
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
                        int idint;
                        string id = row.Cells[0].Value.ToString();
                        int.TryParse(id, out idint);
                        var member = db.Members.FirstOrDefault(m => m.Id == idint);
                        NewMemberForm addSubscription = new NewMemberForm(member, null, Actions.Operations.EditMember);
                        addSubscription.Show();
                    }
                    break;
                case "Stergere":
                    ProcessDeleteMember();
                    break;
            }
        }

        private void dataGVMembers_SelectionChanged(object sender, EventArgs e)
        {
            LoadSubscription(Actions.Operations.NotSpecified);
        }

        private void ucMembers_Load(object sender, EventArgs e)
        {

        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            if (dataGVMembers.SelectedRows.Count == 1)
                foreach (DataGridViewRow row in dataGVMembers.SelectedRows)
                {
                    int idint;
                    string id = row.Cells[0].Value.ToString();
                    int.TryParse(id, out idint);
                    var member = db.Members.FirstOrDefault(m => m.Id == idint);
                    NewMemberForm addSubscription = new NewMemberForm(member, null,
                        Actions.Operations.AddSubscription);
                    addSubscription.Show();
                }
        }

        private void dataGvMembershipHist_MouseClick(object sender, MouseEventArgs e)
        {
            int position = dataGvMembershipHist.HitTest(e.X, e.Y).RowIndex;
            if (position >= 0)
            {
                dataGvMembershipHist.Rows[position].Selected = true;
                btnMembership.Visible = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip membershipMenu = new ContextMenuStrip();

                if (position >= 0 && dataGVMembers.SelectedRows.Count == 1)
                {
                    membershipMenu.Items.Add("Editare").Name = "Editare";
                    membershipMenu.Items.Add("Stergere").Name = "Stergere";
                }
                else if (position >= 0 && dataGVMembers.SelectedRows.Count > 1)
                {
                    membershipMenu.Items.Add("Stergere").Name = "Stergere";
                }
                membershipMenu.Show(dataGvMembershipHist, new Point(e.X, e.Y));
                membershipMenu.ItemClicked += MembershipMenu_ItemClicked;
            }
        }

        private void MembershipMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "Editare":
                    if (dataGvMembershipHist.SelectedRows.Count == 1)
                        foreach (DataGridViewRow row in dataGvMembershipHist.SelectedRows)
                        {
                            int idint;
                            string id = row.Cells[0].Value.ToString();
                            int.TryParse(id, out idint);
                            var membership = db.Memberships.FirstOrDefault(m => m.Id == idint);

                            var membershipUpdated = from item in db.Memberships
                                                    where item.Id == idint
                                                    select new
                                                    {
                                                        item.StartDate,
                                                        item.EndDate,
                                                        IdMembershipType = item.IdMember
                                                    };

                            if (membership != null)
                            {
                                membership.StartDate = membershipUpdated.Select(m => m.StartDate).FirstOrDefault();
                                membership.EndDate = membershipUpdated.Select(m => m.EndDate).FirstOrDefault();
                                membership.IdMembershipType =
                                    membershipUpdated.Select(m => m.IdMembershipType).FirstOrDefault();

                                NewMemberForm editSubscription = new NewMemberForm(null, membership,
                                    Actions.Operations.EditSubscription);
                                editSubscription.Show();
                            }
                        }
                    break;
                case "Stergere":
                    try
                    {
                        ProcessDeleteMembership();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ProcessDeleteMembership");
                    }
                    break;
            }
        }


        private
            void ProcessDeleteMembership()
        {

            int idmembership;
            Memberships membershipToDelete = null;
            foreach (DataGridViewRow row in dataGvMembershipHist.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                int.TryParse(id, out idmembership);
                membershipToDelete = db.Memberships.FirstOrDefault(m => m.Id == idmembership);
            }
            if (membershipToDelete != null)
            {
                var confirmResult =
                    MessageBox.Show(
                        "Sunteti siguri ca doriti sa stergeti abonamentu selectat?", "Confirm!",
                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    membershipToDelete.IsActive = false;
                    db.SaveChanges();
                    Instance.LoadSubscription(Actions.Operations.DeleteMemberhip);
                }
            }


        }
    }
}
