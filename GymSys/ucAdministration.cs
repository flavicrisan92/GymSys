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

        public static ucAdministration Instance
        {
            get { return _instanceMembers ?? (_instanceMembers = new ucAdministration()); }
        }
        public ucAdministration()
        {
            InitializeComponent();
            LoadMembershipTypes();
            LoadUsers();
        }

        public void LoadUsers()
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
                                         DataIntroducerii = user.Created
                                     };
            dataGridViewUsers.DataSource = usersList.ToList();

            var dataGridViewUsersId = dataGridViewUsers.Columns["Id"];
            //if (dataGridViewUsersId != null) dataGridViewUsersId.Visible = false;
            dataGridViewUsers.Columns[0].Width = 350;
            dataGridViewUsers.Columns[1].Width = 350;
            dataGridViewUsers.Columns[2].Width = 250;
            dataGridViewUsers.Columns[3].Width = 250;
        }

        public void LoadMembershipTypes()
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
            dataGridViewMembershipTypes.Columns[0].Width = 350;
            dataGridViewMembershipTypes.Columns[1].Width = 350;
            dataGridViewMembershipTypes.Columns[2].Width = 250;
            dataGridViewMembershipTypes.Columns[3].Width = 250;
            dataGridViewMembershipTypes.Columns[4].Width = 550;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            FormUserOperations formUserOperation = new FormUserOperations(Actions.Operations.AddUser);
            formUserOperation.Show();
        }

        private void btnNewMembershipType_Click(object sender, EventArgs e)
        {
            FormMembershipTypeOperations formMembershipType = new FormMembershipTypeOperations(Actions.Operations.AddMembershipType);
            formMembershipType.Show();
        }
    }
}
