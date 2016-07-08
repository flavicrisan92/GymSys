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

        private void LoadMembers()
        {
            var members = from member in db.Members
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
    }
}
