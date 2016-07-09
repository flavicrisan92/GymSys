using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
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
        private int _selectedRow = 0;

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

        private void LoadSubscription()
        {
            if (dataGVMembers.SelectedRows.Count == 1)
                foreach (DataGridViewRow row in dataGVMembers.SelectedRows)
                {
                    int idint;
                    string id = row.Cells[0].Value.ToString();
                    int.TryParse(id, out idint);

                    var membershipHist = from membership in db.Memberships
                                         where membership.IdMember == idint
                                         orderby membership.Id descending
                                         select new Subscription()
                                         {
                                             Id = membership.Id,
                                             Tip_abonament = membership.MembershipType.Type,
                                             Data_inceput = membership.StartDate,
                                             Data_sfarsit = membership.EndDate,
                                             Status = DateTime.Now < membership.EndDate ? "Activ" : "Expirat"
                                         };

                    dataGvMembershipHist.DataSource = membershipHist.ToList();

                    dataGvMembershipHist.Visible = true;
                    var dataGridViewColumn = dataGvMembershipHist.Columns["Id"];
                    if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
                    dataGvMembershipHist.Columns[0].Width = 135;
                    dataGvMembershipHist.Columns[1].Width = 135;
                    dataGvMembershipHist.Columns[2].Width = 135;
                    dataGvMembershipHist.Columns[3].Width = 100;
                }
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
            dataGVMembers.Columns[0].Width = 150;
            dataGVMembers.Columns[1].Width = 150;
            dataGVMembers.Columns[2].Width = 150;
            dataGVMembers.Columns[3].Width = 115;
            dataGVMembers.Columns[4].Width = 150;
            dataGVMembers.Columns[5].Width = 150;
            dataGVMembers.Columns[6].Width = 150;

          
            if (_selectedRow > 0)
            {
                dataGVMembers.ClearSelection();
                dataGVMembers.Rows[_selectedRow].Selected = true;
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            NewMemberForm newMemberForm = new NewMemberForm(null, Actions.Operations.AddMember);
            newMemberForm.Show();
        }

        private void dataGVMembers_MouseClick(object sender, MouseEventArgs e)
        {
            int position = dataGVMembers.HitTest(e.X, e.Y).RowIndex;
            _selectedRow = position;
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

        private void dataGVMembers_SelectionChanged(object sender, EventArgs e)
        {
            LoadSubscription();

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
                    NewMemberForm addSubscription = new NewMemberForm(member, Actions.Operations.AddSubscription);
                    addSubscription.Show();
                }
        }
    }

    public class Subscription   
    {
        public string Tip_abonament { get; set; }
        public DateTime Data_inceput { get; set; }
        public DateTime Data_sfarsit { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
    }
}
