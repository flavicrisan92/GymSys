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
    public partial class ucAdministration : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucAdministration _instanceMembers;
        private static int _membershipTypeSelectedRow;
        private static int _userSelectedRow;
        private Users _loggedUser;
        private FormUserOperations formUserOperation;
        private FormMembershipTypeOperations formMembershipType;

        public static ucAdministration Instance
        {
            get { return _instanceMembers ?? (_instanceMembers = new ucAdministration()); }
        }
        public ucAdministration()
        {
            InitializeComponent();
            LoadMembershipTypes(Actions.Operations.NotSpecified);
            LoadUsers(Actions.Operations.NotSpecified);
        }

        public void LoadUsers(Actions.Operations operation)
        {
            var usersList = from user in db.Users
                            where user.IsActive
                            orderby user.Name
                            select new
                            {
                                user.Id,
                                Nume = user.Name,
                                Prenume = user.Surname,
                                NumeUtilizator = user.Username,
                                Administrator = user.IsAdmin,
                                DataIntroducerii = user.Created
                            };
            dataGridViewUsers.DataSource = usersList.ToList();

            var dataGridViewUsersId = dataGridViewUsers.Columns["Id"];
            //if (dataGridViewUsersId != null) dataGridViewUsersId.Visible = false;
            dataGridViewUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (_userSelectedRow > 0 && operation != Actions.Operations.DeleteUser)
            {
                dataGridViewUsers.ClearSelection();
                dataGridViewUsers.Rows[_userSelectedRow].Selected = true;
            }
        }

        public void LoadMembershipTypes(Actions.Operations operation)
        {
            var membershiptypeList = from membershiptype in db.MembershipType
                                     where membershiptype.IsActive
                                     orderby membershiptype.Id descending
                                     select new
                                     {
                                         membershiptype.Id,
                                         NumeAbonament = membershiptype.Type,
                                         Pret = membershiptype.Price,
                                         DataIntroducerii = membershiptype.Created,
                                         Descriere = membershiptype.Description
                                     };
            dataGridViewMembershipTypes.DataSource = membershiptypeList.ToList();

            var dataGridViewMembershipTypesId = dataGridViewMembershipTypes.Columns["Id"];
            if (dataGridViewMembershipTypesId != null) dataGridViewMembershipTypesId.Visible = false;
            dataGridViewMembershipTypes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipTypes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipTypes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMembershipTypes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (_membershipTypeSelectedRow > 0 && operation != Actions.Operations.DeleteMemberhipType)
            {
                dataGridViewMembershipTypes.ClearSelection();
                dataGridViewMembershipTypes.Rows[_membershipTypeSelectedRow].Selected = true;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (formUserOperation == null)
            {
                formUserOperation = new FormUserOperations(null, Actions.Operations.AddUser, _loggedUser);
                formUserOperation.Show();
            }
            else
            {
                formUserOperation.Show();
            }
        }

        public void CloseFormAddNewUser()
        {
            formUserOperation = null;
        }

        public void CloserFOrmAddMembershipTytpe()
        {
            formMembershipType = null;
        }

        private void btnNewMembershipType_Click(object sender, EventArgs e)
        {
            if (formMembershipType == null)
            {

                formMembershipType = new FormMembershipTypeOperations(null, Actions.Operations.AddMembershipType);
                formMembershipType.Show();
            }
            else
            {
                formMembershipType.Show();
            }
        }

        private void dataGridViewMembershipTypes_MouseClick(object sender, MouseEventArgs e)
        {
            int position = dataGridViewMembershipTypes.HitTest(e.X, e.Y).RowIndex;
            _membershipTypeSelectedRow = position;
            dataGridViewMembershipTypes.Rows[_membershipTypeSelectedRow].Selected = true;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();

                if (position >= 0 && dataGridViewMembershipTypes.SelectedRows.Count == 1)
                {
                    myMenu.Items.Add("Editare").Name = "Editare";
                    myMenu.Items.Add("Stergere").Name = "Stergere";
                }
                myMenu.Show(dataGridViewMembershipTypes, new Point(e.X, e.Y));
                myMenu.ItemClicked += MyMenu_ItemClicked;
            }
        }

        private void MyMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "Editare":
                    foreach (DataGridViewRow row in dataGridViewMembershipTypes.SelectedRows)
                    {
                        int idint;
                        string id = row.Cells[0].Value.ToString();
                        int.TryParse(id, out idint);
                        var membershipType = db.MembershipType.FirstOrDefault(m => m.Id == idint);
                        var membershiptypeList = from membershiptype in db.MembershipType
                                                 where membershiptype.Id == idint
                                                 select new
                                                 {
                                                     type = membershiptype.Type,
                                                     price = membershiptype.Price,
                                                     description = membershiptype.Description
                                                 };
                        if (membershipType != null)
                        {
                            membershipType.Type = membershiptypeList.Select(m => m.type).FirstOrDefault();
                            membershipType.Price = membershiptypeList.Select(m => m.price).FirstOrDefault();
                            membershipType.Description = membershiptypeList.Select(m => m.description).FirstOrDefault();
                            FormMembershipTypeOperations addSubscription = new FormMembershipTypeOperations(membershipType, Actions.Operations.EditMembershipType);
                            addSubscription.Show();
                        }
                    }
                    break;
                case "Stergere":
                    ProcessDeleteMemberhipType();
                    break;
            }
        }

        private void ProcessDeleteMemberhipType()
        {
            int idmembership;
            MembershipType membershipTypeToDelete = null;
            foreach (DataGridViewRow row in dataGridViewMembershipTypes.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                int.TryParse(id, out idmembership);
                membershipTypeToDelete = db.MembershipType.FirstOrDefault(m => m.Id == idmembership);
            }
            if (membershipTypeToDelete != null)
            {
                var confirmResult =
                    MessageBox.Show(
                        "Sunteti siguri ca doriti sa stergeti tipul de abonament selectat?", "Confirm!",
                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    membershipTypeToDelete.IsActive = false;
                    db.SaveChanges();
                    Instance.LoadMembershipTypes(Actions.Operations.DeleteMemberhipType);
                }
            }
        }

        private void dataGridViewUsers_MouseClick(object sender, MouseEventArgs e)
        {
            int position = dataGridViewUsers.HitTest(e.X, e.Y).RowIndex;
            _userSelectedRow = position;
            dataGridViewUsers.Rows[_userSelectedRow].Selected = true;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenuUsers = new ContextMenuStrip();

                if (position >= 0 && dataGridViewUsers.SelectedRows.Count == 1)
                {
                    myMenuUsers.Items.Add("Editare").Name = "Editare";
                    myMenuUsers.Items.Add("Stergere").Name = "Stergere";
                }
                myMenuUsers.Show(dataGridViewUsers, new Point(e.X, e.Y));
                myMenuUsers.ItemClicked += MyMenuUsers_ItemClicked;
            }
        }

        private void MyMenuUsers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "Editare":
                    foreach (DataGridViewRow row in dataGridViewUsers.SelectedRows)
                    {
                        int idint;
                        string id = row.Cells[0].Value.ToString();
                        int.TryParse(id, out idint);
                        var user = db.Users.FirstOrDefault(m => m.Id == idint);
                        var usersList = from item in db.Users
                                        where item.Id == user.Id
                                        select new
                                        {
                                            name = item.Name,
                                            surname = item.Surname,
                                            item.Password,
                                            item.IsAdmin
                                        };
                        if (user != null)
                        {
                            user.Name = usersList.Select(m => m.name).FirstOrDefault();
                            user.Surname = usersList.Select(m => m.surname).FirstOrDefault();
                            user.Password = usersList.Select(s => s.Password).FirstOrDefault();
                            user.IsAdmin = usersList.Select(s => s.IsAdmin).FirstOrDefault();
                            FormUserOperations addSubscription = new FormUserOperations(user, Actions.Operations.EditUser, _loggedUser);
                            addSubscription.Show();
                        }
                    }
                    break;
                case "Stergere":
                    ProcessDeleteUser();
                    break;
            }
        }

        private void ProcessDeleteUser()
        {
            int iduser;
            Users userToDelete = null;
            foreach (DataGridViewRow row in dataGridViewUsers.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                int.TryParse(id, out iduser);
                userToDelete = db.Users.FirstOrDefault(m => m.Id == iduser);
            }
            if (userToDelete != null)
            {
                var confirmResult =
                    MessageBox.Show(
                        "Sunteti siguri ca doriti sa stergeti utilizatorul selectat?", "Confirm!",
                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    userToDelete.IsActive = false;
                    db.SaveChanges();
                    Instance.LoadUsers(Actions.Operations.DeleteUser);
                }
            }
        }

        public void SetLoggedUser(Users user)
        {
            _loggedUser = user;
        }
    }
}
