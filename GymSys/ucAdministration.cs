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
        }

        private void LoadMembershipTypes()
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
                                         Descriere = ""
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
    }
}
