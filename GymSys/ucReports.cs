using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class ucReports : UserControl
    {
        LocalDBEntities db = new LocalDBEntities();
        private static ucReports _instanceMembers;

        public ucReports()
        {
            InitializeComponent();
            dateTimePickerFromDateTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerFromDateTime.CustomFormat = "dd/MM/yyyy";

            dateTimePickerToDateTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerToDateTime.CustomFormat = "dd/MM/yyyy";
        }

        public static ucReports Instance => _instanceMembers ?? (_instanceMembers = new ucReports());

        public void LoadMembersReport(DateTime fromDateTime, DateTime toDateTime)
        {
            fromDateTime = fromDateTime.Date;
            toDateTime = toDateTime.Date.AddDays(1).AddSeconds(-5);
            
            var members = from member in db.Members
                          where member.Created >= fromDateTime && member.Created <= toDateTime
                          orderby member.Created descending
                          select new
                          {
                              member.Id,
                              Nume = member.Name,
                              Prenume = member.Surname,
                              Cod = member.Code,
                              Data_Nastere = member.Birthdate,
                              Data_inregistrare = member.Created,
                              Abonament_Activ = member.Memberships.Count(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now) > 0,
                              Ultima_scanare = db.Scans.Where(s => s.IdMember == member.Id).OrderByDescending(s => s.Id).Select(s => s.Date).FirstOrDefault()
                          };
            dataGridViewMembersRep.DataSource = members.ToList();
            lblTotalCount.Text = members.Count().ToString();

            var dataGridViewColumn = dataGridViewMembersRep.Columns["Id"];
            //if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            dataGridViewMembersRep.Columns[0].Width = 25;
            dataGridViewMembersRep.Columns[1].Width = 150;
            dataGridViewMembersRep.Columns[2].Width = 150;
            dataGridViewMembersRep.Columns[3].Width = 120;
            dataGridViewMembersRep.Columns[4].Width = 150;
            dataGridViewMembersRep.Columns[5].Width = 150;
            dataGridViewMembersRep.Columns[6].Width = 150;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadMembersReport(dateTimePickerFromDateTime.Value, dateTimePickerToDateTime.Value);
        }
    }
}
